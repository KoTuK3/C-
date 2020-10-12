using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task04_Library
{
    public class Convertor
    {
        static private BinaryFormatter binaryFormatter = new BinaryFormatter();
        static public void BinarySerialization<T>(ICollection<T> collection, string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fs, collection);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static public TOut BinaryDeserialization<TOut>(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    return (TOut)binaryFormatter.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return default;
        }
        
        static public void XmlSerialization<T>(ICollection<T> collection, string path)
        {
            try
            {
                XmlSerializer xmlFormatter = new XmlSerializer(collection.GetType());
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    xmlFormatter.Serialize(fs, collection);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static public TOut XmlDeserialization<TOut>(string path)
        {
            try
            {
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(TOut));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    return (TOut)xmlFormatter.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return default;
        }

        static public void JsonSerialization<T>(ICollection<T> collection, string path)
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(collection.GetType());
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, collection);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public TOut JsonDeserialization<TOut>(string path)
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TOut));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    return (TOut)jsonFormatter.ReadObject(fs);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return default;
        }

    }
}
