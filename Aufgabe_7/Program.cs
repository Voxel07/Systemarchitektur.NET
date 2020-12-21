using System;
using System.IO;

namespace Aufgabe_7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                SeperateArgs(args, out var func, out var date, out var purpose, out var value);

                switch (func)
                {
                    case "add":
                        Add(date, purpose, value);
                        break;
                    //case "print": PrintInvoice();
                    //    break;
                    default:
                        Console.WriteLine("wrong format");
                        break;
                }
            }
            else
            {
                Console.WriteLine("wrong format");
            }
        }

        private static void SeperateArgs(string[] arg, out string func, out string date, out string purpose,
            out double value)
        {
            func = arg[0];
            date = arg[1];
            purpose = arg[2];
            value = Convert.ToDouble(arg[3]);

            Console.WriteLine("Your input: {0}, {1}, {2}, {3}", func, date, purpose, value);
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

        private static void Add(string date, string purpose, double value)
        {
            if (!GetUserFeedback()) return;
            const string path = @"C:\Users\Matze\OneDrive - bwedu\Programmieren\Systemarchitekturen mit .Net\Systemarchitekturen\Aufgabe_7\bookings.csv";

            if (!File.Exists(path))
            {
                using var sw = File.CreateText(path);
                sw.WriteLine("{0};{1};{2};{3}", date, purpose, value);
            }

            using (var sw = File.AppendText(path))
            {
                sw.WriteLine("{0};{1};{2}", date, purpose, value);
                Console.WriteLine("Entry was saved");
            }
        }
    }
}