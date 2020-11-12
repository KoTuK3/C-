using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks01
{
    class AppSettingHelper
    {
        ConsoleColor BackgroundColor { get; set; }
        ConsoleColor ForegroundColor { get; set; }
        int BufferHeight { get; set; }
        int BufferWidth { get; set; }
        string Title { get; set; }
        public void Write()
        {
            using (var writer = new BinaryWriter(File.Open("Settings", FileMode.Create)))
            {
                writer.Write((byte)Console.BackgroundColor);
                writer.Write((byte)Console.ForegroundColor);
                writer.Write(Console.BufferHeight);
                writer.Write(Console.BufferWidth);
                writer.Write(Console.Title);
            }
        }

        public void Read()
        {
            using (var reader = new BinaryReader(File.Open("Settings", FileMode.Open)))
            {
                BackgroundColor = (ConsoleColor)reader.ReadByte();
                ForegroundColor = (ConsoleColor)reader.ReadByte();
                BufferHeight = reader.ReadInt32();
                BufferWidth = reader.ReadInt32();
                Title = reader.ReadString();

                Console.BackgroundColor = BackgroundColor;
                Console.ForegroundColor = ForegroundColor;
                Console.BufferHeight = BufferHeight;
                Console.BufferWidth = BufferWidth;
                Console.Title = Title;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Console.BackgroundColor: {BackgroundColor}");
            Console.WriteLine($"Console.ForegroundColor: {ForegroundColor}");
            Console.WriteLine($"Console.BufferHeight: {BufferHeight}");
            Console.WriteLine($"Console.BufferWidth: {BufferWidth}");
            Console.WriteLine($"Console.Title: {Title}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var aps = new AppSettingHelper();
            aps.Read();
            aps.Print();


        }
    }
}
