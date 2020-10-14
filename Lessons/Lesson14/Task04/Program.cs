using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Task04_Library;

namespace Task04
{

    [Serializable]
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
    class Program
    {
        static void Print<T>(IEnumerable<T> arr, string name = "Array")
        {
            Console.Write($"{name}: ");
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var personList = new List<Person>() {
                new Person() { Name = "Name1", Surname = "Surname1" },
                new Person() { Name = "Name2", Surname = "Surname2" },
                new Person() { Name = "Name3", Surname = "Surname3" },
            };
            var strList = new List<string>()
            {
                "str1", "str2", "str3"
            };

            Convertor.BinarySerialization(personList, "person.txt");
            Convertor.XmlSerialization(personList, "person.xml");
            Convertor.JsonSerialization(personList, "person.json");

            Convertor.BinarySerialization(strList, "strList.txt");
            Convertor.XmlSerialization(strList, "strList.xml");
            Convertor.JsonSerialization(strList, "strList.json");

            var pList1 = Convertor.BinaryDeserialization<List<Person>>("person.txt");
            var pList2 = Convertor.XmlDeserialization<List<Person>>("person.xml");
            var pList3 = Convertor.JsonDeserialization<List<Person>>("person.json");

            Print(pList1, "pList1");
            Print(pList2, "pList2");
            Print(pList3, "pList3");

            var sList1 = Convertor.BinaryDeserialization<List<string>>("strList.txt");
            var sList2 = Convertor.XmlDeserialization<List<string>>("strList.xml");
            var sList3 = Convertor.JsonDeserialization<List<string>>("strList.json");

            Print(sList1, "sList1");
            Print(sList2, "sList2");
            Print(sList3, "sList3");



        }
    }
}
