using System;
using System.IO;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT12_Task01
{
    class Cmd
    {
        public string CurrentPath { get; private set; }

        public Cmd()
        {
            CurrentPath = Path.GetDirectoryName(Path.GetFullPath("HT12_Task01.exe"));

            Directory.SetCurrentDirectory(CurrentPath);
        }

        public void EnterCommand()
        {
            do
            {
                Console.Write($"{CurrentPath}>");
                string str = Console.ReadLine();
                string[] commandAndArgs = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                CommandsdHandler(commandAndArgs);
            } while (true);
        }

        public void CommandsdHandler(string[] commandAndArgs)
        {
            if (commandAndArgs.Length > 0)
            {
                string command = commandAndArgs[0];
                string newPath = CurrentPath;
                switch (command)
                {
                    case "md":

                        newPath = Path.Combine(CurrentPath, commandAndArgs[1]);
                        if (!Directory.Exists(newPath))
                        {
                            Directory.CreateDirectory(newPath);
                        }
                        break;

                    case "rd":
                        newPath = Path.Combine(CurrentPath, commandAndArgs[1]);
                        if (Directory.Exists(newPath))
                        {
                            Directory.Delete(newPath, true);
                        }
                        break;

                    case "cd":
                        newPath = Path.Combine(CurrentPath, commandAndArgs[1]);
                        if (Directory.Exists(newPath))
                        {
                            Directory.SetCurrentDirectory(newPath);
                            CurrentPath = Directory.GetCurrentDirectory();
                        }
                        break;

                    case "dir":
                        string[] dirs;
                        string[] files;

                        if (commandAndArgs.Length > 1)
                            dirs = Directory.GetDirectories(CurrentPath, commandAndArgs[1]);
                        else
                            dirs = Directory.GetDirectories(CurrentPath);

                        if (commandAndArgs.Length > 1)
                            files = Directory.GetFiles(CurrentPath, commandAndArgs[1]);
                        else
                            files = Directory.GetFiles(CurrentPath);

                        foreach (var item in dirs)
                        {
                            Console.WriteLine($"{new DirectoryInfo(item).Name}\\");
                        }

                        foreach (var item in files)
                        {
                            Console.WriteLine(Path.GetFileName(item));
                        }
                        break;

                    case "create":
                        if (commandAndArgs.Length > 1)
                        {
                            string name = commandAndArgs[1];

                            FileInfo file = new FileInfo(name);

                            using (StreamWriter sw = File.CreateText(name))
                            {
                                sw.WriteLine(Console.ReadLine());
                            }
                        }
                        break;

                    case "type":
                        //if (commandAndArgs.Length > 1)
                        //{
                        //    string name = commandAndArgs[1];

                        //    using (FileStream reader = File.OpenRead(name))
                        //    {
                        //        read
                        //    }
                        //}
                        break;

                    case "copy":

                        break;

                    case "del":

                        break;

                    default:
                        Console.WriteLine("Command not found");
                        break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cmd cmd = new Cmd();
            cmd.EnterCommand();
        }
    }
}
