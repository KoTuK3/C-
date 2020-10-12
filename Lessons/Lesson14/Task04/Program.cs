using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task04_Library;

namespace Task04
{
    class Person
    {
        public string name;
        public string surname;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Person>();
            var strList = new List<string>();

            Convertor.BinarySerialization(personList, "person.txt");
            Convertor.XmlSerialization(personList, "person.xml");
            Convertor.JsonSerialization(personList, "person.json");

            Convertor.BinarySerialization(strList, "strList.txt");
            Convertor.XmlSerialization(strList, "strList.xml");
            Convertor.JsonSerialization(strList, "strList.json");

            Convertor.BinaryDeserialization<List<Person>>("person.txt");
            Convertor.BinaryDeserialization<List<Person>>("person.xml");
            Convertor.BinaryDeserialization<List<Person>>("person.json");

            Convertor.BinaryDeserialization<List<string>>("strList.txt");
            Convertor.BinaryDeserialization<List<string>>("strList.xml");
            Convertor.BinaryDeserialization<List<string>>("strList.json");

        }
    }
}
