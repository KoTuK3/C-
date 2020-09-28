using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    struct User
    {
        public string name;
        public string surname;

        public override string ToString()
        {
            return $"{name} {surname}";
        }
    }

    class Student
    {
        public string name;
        public string surname;

        public override string ToString()
        {
            return $"{name} {surname}";
        }
    }

    class Program
    {

        static public object Find(object[] arr, Func<object, bool> func)
        {
            foreach (var item in arr)
                if (func(item))
                    return item;
            return null;
        }
        static void Main(string[] args)
        {
            object[] arr = new object[] { 1, 2, 4, 6, 1, 5, 67, -1, 3 };
            Console.WriteLine(Find(arr, x => (int)x == 5));
            Console.WriteLine(Find(arr, x => (int)x < 0));
            Console.WriteLine(Find(arr, x => (int)x % 2 == 0));

            object[] users = new object[]
            {
                new User {name = "name1", surname = "surname1"},
                new User {name = "name2", surname = "surname2"},
                new User {name = "name3", surname = "surname3"},
                new User {name = "name4", surname = "surname4"},
            };

            Console.WriteLine(Find(users, x => ((User)x).name == "name1"));
            Console.WriteLine(Find(users, x => ((User)x).surname == "surname3"));
            Console.WriteLine(Find(users, x => ((User)x).name == "name4"));

            object[] students = new object[]
            {
                new Student {name = "student1", surname = "surname1"},
                new Student {name = "student2", surname = "surname2"},
                new Student {name = "student3", surname = "surname3"},
                new Student {name = "student4", surname = "surname4"},
            };

            Console.WriteLine(Find(students, x => ((Student)x).name == "student1"));
            Console.WriteLine(Find(students, x => ((Student)x).surname == "surname3"));
            Console.WriteLine(Find(students, x => ((Student)x).name == "student4"));

        }
    }
}
