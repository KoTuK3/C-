using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Swapi
    {
        static private string root = "https://swapi.dev/api/";
        static private string people = $"{root}people/";

        static public List<string> GetAllPeople()
        {
            List<string> res = new List<string>();
            using (WebClient wc = new WebClient())
            {
                var path = $"{people}?page=1";
                
                while (path != "")
                {
                    string json = wc.DownloadString(path);
                    var jObj = JObject.Parse(json);

                    var people = jObj.GetValue("results").ToString();
                    res.Add(people);

                    path = jObj.GetValue("next").ToString();
                }
            }
            return res;
        }

        static public string GetPersonByNumber(int number)
        {
            if (number > 0 && number <= 82)
            {
                using (WebClient wc = new WebClient())
                {
                    return wc.DownloadString($"{people}{number}/");
                }
            }
            return "";
        }

        static public Person SerializeJsonToPerson(string json)
        {
            return JsonConvert.DeserializeObject<Person>(json);
        }

        static public List<Person> SerializeJsonToPeople(List<string> jsonArr)
        {
            List<Person> res = new List<Person>();
            foreach (var item in jsonArr)
            {
                var people = JsonConvert.DeserializeObject<List<Person>>(item);
                res.AddRange(people);
            }
            return res;
        }

        static public Person GetPersonFromConsole()
        {
            int number;
            do
            {
                Console.Write("Enter person number from 1 to 82: ");
            } while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 82);
            return SerializeJsonToPerson(GetPersonByNumber(number));
        }

        static public List<Person> GetPeople()
        {
            return SerializeJsonToPeople(GetAllPeople());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = Swapi.GetPersonFromConsole();
            Console.WriteLine($"Person: {person}");


            Console.WriteLine("\nPeople\n");

            var people = Swapi.GetPeople();

            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{i + 1, 3}. {people[i]}");
            }
        }
    }
}
