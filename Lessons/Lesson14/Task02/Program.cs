using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        class Vocabulary
        {
            public string Name { get; set; }
            public Dictionary<string, List<string>> dic { get; private set; } = new Dictionary<string, List<string>>();
            public Vocabulary(string name = "")
            {
                Name = name;
            }
            public void AddWord(string word, string translation)
            {
                if (dic.ContainsKey(word))
                {
                    dic[word].Add(translation);
                } else
                {
                    dic.Add(word, new List<string>() { translation });
                }
            }

            public void ChangeWord(string word, string newWord)
            {
                if (dic.ContainsKey(word))
                {
                    var value = dic[word];
                    dic.Remove(word);
                    dic.Add(newWord, value);
                }
            }

            public void ChangeWordTranslation(string word, string translation, string newTranslation)
            {
                if (dic.ContainsKey(word) && dic[word].Contains(translation))
                {
                    int index = dic[word].FindIndex(n => n == translation);
                    dic[word][index] = newTranslation;
                }
            }

            public void ChangeWordTranslations(string word, List<string> newTranslations)
            {
                if (dic.ContainsKey(word))
                {
                    dic[word] = newTranslations;
                }
            }

            public void DeleteWord(string word)
            {
                if (dic.ContainsKey(word))
                {
                    dic.Remove(word);
                }
            }

            public void DeleteTranslation(string word, string translation)
            {
                if (dic.ContainsKey(word) && dic[word].Contains(translation) && dic[word].Count > 1)
                {
                    dic[word].Remove(translation);
                }
            }

            public void FindTranslation(string word)
            {
                if (dic.ContainsKey(word))
                {
                    Console.WriteLine($"{word,-20} | {ToStringTranslation(dic[word])}");
                }
            }

            public void Print()
            {
                int i = 1;
                foreach (var item in dic)
                    Console.WriteLine($"{i++, -6} | {item.Key, -20} | {ToStringTranslation(item.Value)}");
            }

            public void SaveToFile(string name = "")
            {
                string json = JsonConvert.SerializeObject(dic, Formatting.Indented);
                string fileName = Name;

                if (name != "" && name != null)
                    fileName = name;

                using (StreamWriter file = File.CreateText($"{fileName}.json"))
                {
                    file.WriteLine(json);
                }
            }

            public void ReadFromFile(string fileName)
            {
                Name = fileName;
                if (File.Exists($"{fileName}.json"))
                {
                    string json = File.ReadAllText($"{fileName}.json");
                    dic = JsonConvert.DeserializeObject< Dictionary <string, List<string> >> (json);
                } 
                else
                {
                    Console.WriteLine("File not found.");
                }
                
            }

            private string ToStringTranslation(List<string> translations)
            {
                string res = "";
                for (int i = 0; i < translations.Count; i++)
                {
                    res += translations[i];
                    if (i != translations.Count - 1)
                        res += ", ";
                }
                return res;
            }
        }
        static void VocabularyMenu()
        {
            Vocabulary vocabulary = new Vocabulary("enRu");

            var menu1 = new Menu();
            //1
            menu1.Add(new MenuItem("Create vocabulary", () => vocabulary = new Vocabulary("enRu")));
            //2
            menu1.Add(new MenuItem("Add word", () => {

                Console.Write("Enter word: ");
                string word = Console.ReadLine();

                int size = 0;
                do
                {
                    Console.Write("Enter num of translation words: ");
                } while (!int.TryParse(Console.ReadLine(), out size) || size < 1);

                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter translation: ");
                    string translation = Console.ReadLine();

                    vocabulary.AddWord(word, translation);
                }

            }));
            //3
            menu1.Add(new MenuItem("Change word", () => {
                Console.Write("Enter word: ");
                string word = Console.ReadLine();

                Console.Write("Enter new word: ");
                string newWord = Console.ReadLine();

                vocabulary.ChangeWord(word, newWord);
            }));
            //4
            menu1.Add(new MenuItem("Change translation", () => {
                Console.Write("Enter word: ");
                string word = Console.ReadLine();

                Console.Write("Enter translation: ");
                string translation = Console.ReadLine();

                Console.Write("Enter new translation: ");
                string newTranslation = Console.ReadLine();

                vocabulary.ChangeWordTranslation(word, translation, newTranslation);
            }));
            //5
            menu1.Add(new MenuItem("Delete word", () => {
                Console.Write("Enter word: ");
                string word = Console.ReadLine();

                vocabulary.DeleteWord(word);
            }));
            //6
            menu1.Add(new MenuItem("Delete translation", () => {
                Console.Write("Enter word: ");
                string word = Console.ReadLine();

                Console.Write("Enter translation: ");
                string translation = Console.ReadLine();

                vocabulary.DeleteTranslation(word, translation);
            }));
            //7
            menu1.Add(new MenuItem("Find word", () => {
                Console.Write("Enter word: ");
                string word = Console.ReadLine();

                vocabulary.FindTranslation(word);
                Console.ReadKey();
            }));
            //8
            menu1.Add(new MenuItem("Save vocabulary to file", () => vocabulary.SaveToFile() ));
            //9
            menu1.Add(new MenuItem("Read vocabulary from file", () => vocabulary.ReadFromFile(vocabulary.Name) ));

            //10
            menu1.Add(new MenuItem("Print vocabulary", () => {
                vocabulary.Print();
                Console.ReadKey();
            } ));

            //11
            menu1.Add(new MenuItem("Back", () => menu1.Exit()));

            menu1.Start();
        }
        static void Main(string[] args)
        {
            Vocabulary ruEn = new Vocabulary("ruEn");

            var menu = new Menu();

            menu.Add(new MenuItem("enRu vocabulary", VocabularyMenu));

            menu.Add(new MenuItem("ruEn vocabulary", VocabularyMenu));

            menu.Add(new MenuItem("Exit", () => menu.Exit() ));

            menu.Start();

        }
    }
}
