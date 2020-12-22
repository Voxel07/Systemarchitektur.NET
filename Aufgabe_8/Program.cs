using System;
using System.Collections.Generic;
using System.IO;

namespace Aufgabe_8
{
    internal class Program
    {
        private const string Path =
            @"C:\Users\Matze\OneDrive - bwedu\Programmieren\Systemarchitekturen mit .Net\Systemarchitekturen\Aufgabe_8\bookings.csv";

        private static readonly List<ListItem> Items = new List<ListItem>();

        private static void Main(string[] args)
        {
            if (args.Length <= 0) return;
            switch (args[0])
            {
                case "add":
                    AddEntry(args[1], args[2], args[3]);

                    break;
                case "list":
                    ParseList(args.Length > 1 ? args[1] : DateTime.Now.Month.ToString(),
                        args.Length > 2 ? args[2] : DateTime.Now.Year.ToString());
                    break;

                default:
                    Console.WriteLine("WRONG FORMAT");
                    break;
            }
        }

        private static bool GetUserFeedback()
        {
            Console.WriteLine("Correct entry ? = (y/n)");
            var choice = false;
            ConsoleKeyInfo keyinfo;

            do
            {
                keyinfo = Console.ReadKey();
            } while (keyinfo.Key != ConsoleKey.Y && keyinfo.Key != ConsoleKey.N && keyinfo.Key != ConsoleKey.Backspace);

            choice = keyinfo.Key switch
            {
                ConsoleKey.Y => true,
                ConsoleKey.N => false,
                ConsoleKey.Backspace => false,
                _ => choice
            };

            return choice;
        }

        public static void AddEntry(string date, string purpose, string value)
        {
            if (!GetUserFeedback()) return;


            if (!File.Exists(Path))
            {
                using var sw = File.CreateText(Path);
                sw.WriteLine("{0};{1};{2}", date, purpose, value);
                Console.WriteLine("Entry was saved");
            }
            else
            {
                using var sw = File.AppendText(Path);
                sw.WriteLine("{0};{1};{2}", date, purpose, value);
                Console.WriteLine("Entry was saved");
            }
        }

        public static void ParseList(string month, string year)
        {
            using (var sr = File.OpenText(Path))
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    var values = s.Split(';');
                    if (Convert.ToDateTime(values[0]).Year == Convert.ToInt16(year))
                        if (Convert.ToDateTime(values[0]).Month == Convert.ToInt16(month))
                            Items.Add(new ListItem(values[0], values[1], values[2]));
                }
            }

            Items.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            foreach (var elm in Items) Console.WriteLine($"{elm.Date:dd.MM.yy} {elm.Name} {elm.Value}");
        }

        private readonly struct ListItem
        {
            public ListItem(string date, string name, string value)
            {
                DateTime.TryParse(date, out Date);
                Name = name;
                double.TryParse(value, out Value);
            }

            public readonly DateTime Date;
            public readonly string Name;
            public readonly double Value;
        }
    }
}