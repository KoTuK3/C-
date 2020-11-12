using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestLibrary;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load("TestLibrary");
            var types = asm.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine(type.Name);

                var methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static)
                    .Where(method => !method.IsSpecialName)
                    .ToArray();

                if (methods.Length > 0)
                {
                    Console.WriteLine("\n  Methods:");
                    foreach (var method in methods)
                    {
                        string res = "";
                        res += method.IsPrivate ? "private " : "public ";
                        if (method.IsStatic)
                        {
                            res += "static ";
                        }
                        res += method.IsVirtual ? "virtual " : "";

                        res += method.ReturnType.Name + " ";

                        res += method.Name + "(";
                        var parameters = method.GetParameters();
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            res += parameters[i].ParameterType.Name + " " + parameters[i].Name;
                            if (i != parameters.Length - 1)
                                res += ", ";
                        }
                        res += ")";

                        Console.WriteLine($"  {res}");
                    }
                }

                var properties = type.GetProperties();
                if (properties.Length > 0)
                {
                    Console.WriteLine("\n  Properties:");
                    foreach (var property in properties)
                    {
                        Console.WriteLine($"  {property.PropertyType.Name} {property.Name}");
                    }
                }

                var constructors = type.GetConstructors();
                if (constructors.Length > 0)
                {
                    Console.WriteLine("\n  Constructors:");
                    foreach (var constructor in constructors)
                    {
                        string res = "";
                        res += constructor.IsPrivate ? "private " : "public ";
                        res += constructor.IsStatic ? "static " : "";
                        res += constructor.IsVirtual ? "virtual " : "";
                        res += constructor.DeclaringType.Name + "(";
                        var parameters = constructor.GetParameters();
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            res += parameters[i].ParameterType.Name + " " + parameters[i].Name;
                            if (i != parameters.Length - 1)
                                res += ", ";
                        }
                        res += ")";

                        Console.WriteLine($"  {res}");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
