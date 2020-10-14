using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Task02;

namespace Task03
{
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"{Name} {DateOfBirth}";
        }
    }


    class Quiz
    {
        public Dictionary<string, int> ResultsTable { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public string Author { get; set; }
        public string Header { get; set; }

        public Quiz(string header)
        {
            Header = header;
        }

        public void PrintResultTable()
        {
            foreach (var item in ResultsTable)
            {
                Console.WriteLine($"{item.Key,20} - {item.Value,5}");
            }
        }

        public void StartQuiz(string name)
        {
            int counter = 0;
            foreach (var item in Questions)
            {
                Console.WriteLine(item);
                if (item.GetAnswer())
                    counter += 1;
            }
            Console.WriteLine($"Correct answers: {counter}");
            if (ResultsTable.ContainsKey(name))
            {
                if (ResultsTable[name] < counter)
                    ResultsTable[name] = counter;
            }
        }

        public void CreateQuiz(string name)
        {
            int size = 20;
            Author = name;

            for (int i = 0; i < size; i++)
            {
                var question = new Question();
                question.CreateQuestion();
                Questions.Add(question);
            }
        }
    }

    class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
        
        public int CorrectAnswer { get; set; }

        public override string ToString()
        {
            string res = Text + "\n";
            for (int i = 0; i < Answers.Count; i++)
            {
                res += $"{i + 1,2}. {Answers[i]} \n";
            }
            return res;
        }

        public bool GetAnswer()
        {
            int answer;
            do
            {
                Console.Write("Enter num of right answer: ");
            } while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > Answers.Count);
            return answer == CorrectAnswer;
        }

        public void CreateQuestion()
        {
            Console.Write("Enter question: ");
            Text = Console.ReadLine();
            int size;
            do
            {
                Console.Write("Enter num of answers: ");
            } while (!int.TryParse(Console.ReadLine(), out size) || size < 1);

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter answer[{i+1}]: ");
                Answers.Add(Console.ReadLine());
            }
        }
    }

    class DB
    {
        public List<User> db;
        public List<Quiz> quizDb;
        public DB()
        {
            if (File.Exists("db.json"))
            {
                try
                {
                    using (StreamReader sr = new StreamReader("db.json"))
                    {
                        string json = sr.ReadToEnd();
                        db = JsonConvert.DeserializeObject<List<User>>(json);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                db = new List<User>();
            }

            if (File.Exists("quizDb.json"))
            {
                try
                {
                    using (StreamReader sr = new StreamReader("quizDb.json"))
                    {
                        string json = sr.ReadToEnd();
                        quizDb = JsonConvert.DeserializeObject<List<Quiz>>(json);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                quizDb = new List<Quiz>();
            }
        }

        ~DB()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("db.json"))
                {
                    string json = JsonConvert.SerializeObject(db);
                    sw.WriteLine(json);
                }
                
                using (StreamWriter sw = new StreamWriter("quizDb.json"))
                {
                    string json = JsonConvert.SerializeObject(quizDb);
                    sw.WriteLine(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Print()
        {
            foreach (var item in db)
                Console.Write($"{item} ");
        }

        public bool UserExist(string username)
        {
            foreach (var item in db)
                if (item.Name == username)
                    return true;
            return false;
        }

        public bool CheckPass(string name, string pass)
        {
            foreach (var item in db)
                if (item.Name == name && item.Password == pass)
                    return true;
            return false;
        }

        public void AddUser()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (!UserExist(name))
            {
                Console.Write("Enter pass: ");
                string pass = Console.ReadLine();
                DateTime dateOfBirth;
                do
                {
                    Console.Write("Enter date of birth(01/01/2001): ");
                } while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth));

                db.Add(new User() { Name = name, Password = pass, DateOfBirth = dateOfBirth });
            }
            else
            {
                Console.WriteLine("User with such name is already exists");
            }
        }

        public bool Login()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (UserExist(name))
            {
                Console.Write("Enter pass: ");
                string pass = Console.ReadLine();
                return CheckPass(name, pass);
            }
            else
            {
                Console.WriteLine("No user found with this name");
            }
            return false;
        }

        public User GetUser(string name)
        {
            foreach (var item in db)
                if (item.Name == name)
                    return item;
            return null;
        } 

        public void ChangePass(string name)
        {
            if (UserExist(name))
            {
                Console.Write("Enter old pass: ");
                string pass = Console.ReadLine();
                if (CheckPass(name, pass))
                {
                    Console.Write("Enter new pass: ");
                    string newPass = Console.ReadLine();

                    GetUser(name).Password = newPass;
                }
            }
            else
            {
                Console.WriteLine("No user found with this name");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB();

            var menu = new Menu();

            menu.Add(new MenuItem("Login", () => {
                if (db.Login())
                {
                    Console.Write("Enter name: ");
                    User user = db.GetUser(Console.ReadLine());

                    var menu1 = new Menu();
                    menu1.Add(new MenuItem("Start quiz", () => {
                        for (int i = 0; i < db.quizDb.Count; i++)
                        {
                            Console.WriteLine($"{i+1, 4}. {db.quizDb[i].Header}");
                        }
                        int index;
                        do
                        {
                            Console.Write("Enter quiz number: ");
                        } while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > db.quizDb.Count);
                        db.quizDb[index].StartQuiz(user.Name);
                    } ));

                    menu1.Add(new MenuItem("Create new quiz", () => {
                        Console.Write("Enter header: ");
                        var quiz = new Quiz(Console.ReadLine());

                        quiz.CreateQuiz(user.Name);
                    } ));

                    menu1.Add(new MenuItem("Show history", () => {
                        var hist = db.quizDb.Where(x => x.ResultsTable.ContainsKey(user.Name));
                        int counter = 1;
                        foreach (var item in hist)
                        {
                            Console.WriteLine($"{counter++, 4}. {item.Header}");
                        }
                        Console.ReadLine();
                    } ));

                    menu1.Add(new MenuItem("Change pass", () => db.ChangePass(user.Name) ));

                    menu1.Add(new MenuItem("Back", () => menu1.Exit() ));

                    menu1.Start();
                }
                Console.ReadLine();
            }));


            menu.Add(new MenuItem("Register", () => {
                db.AddUser();
            }));


            menu.Add(new MenuItem("Exit", () => menu.Exit() ));
            menu.Start();
        }
    }
}
