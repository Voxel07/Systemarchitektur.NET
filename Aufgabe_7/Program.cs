using System;
using System.IO;

namespace Aufgabe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string function;
            string date;
            string purpose;
            double value = 4.20;

            if (args.Length > 0)
            {
                seperateArgs(args, out string func, out date, out purpose, out value);
                Console.WriteLine("Eintag Speichern = (j/n)");

                switch (func)
                {
                    case "add":add( date,purpose,value);
                        break;
                    case "print": PrintInvoice();
                        break;
                    default:Console.WriteLine("Ungültige eingabe");
                        break;
                }
               
            }
            else
            {
                Console.WriteLine("ungültige eingabe");
            }

            


        }

        static void seperateArgs(String [] arg,out string func, out string date, out string purpose, out double value)
        {
            
                func = arg[0];
                date = arg[1];
                purpose = arg[2];
                value = Convert.ToDouble(arg[3]);
                
                Console.WriteLine("Eigegebene Werte: {0},{1},{2},{3}",func, date, purpose, value);
        }
        static bool getUserFeedback()
        {
            string feedback = Console.ReadLine();
            bool choice = false;

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
               // Console.WriteLine(keyinfo.Key + " was pressed");
            }
            while (keyinfo.Key != ConsoleKey.J|| keyinfo.Key != ConsoleKey.N || keyinfo.Key == ConsoleKey.Backspace);

            switch (keyinfo.Key)
            {
                case "J": choice = true;
                    break;
                case "N": choice = false;
                    break;

            }
          
        }

        static void add(string date, string purpose, double value)
        {
            string path = @"C:\Users\Matze\OneDrive - bwedu\Programmieren\Systemarchitekturen mit .Net\Systemarchitekturen\Aufgabe_7\invoice.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("{0};{1};{2};{3}", date, purpose, value);
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("{0};{1};{2}", date, purpose, value);
            }
        }

        static void PrintInvoice()
        {
            string path = @"C:\Users\Matze\OneDrive - bwedu\Programmieren\Systemarchitekturen mit .Net\Systemarchitekturen\Aufgabe_7\invoice.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                Console.WriteLine("Invoice vom:{0}: ",System.DateTime.Today);
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
