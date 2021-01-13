using System;

namespace Aufgabe_10
{
    class Ui
    {
        public static void PrintSpieler(Spieler s)
        {
            Console.WriteLine(s.ToString()+"\n");
        }

        public static void PrintGetreiede(Spieler s)
        {
            string test = "";

            test += $"{"Vorrat",18}";
            test += $"{"KaufPreis",12}";
            test += $"{"Verkaufspreis",16}";
            test += $"{"Guthaben",11}";
            test += "\n";
            test += $"{"Getreide",0}";
            test += $"{s.AnzGetreide,10}";
            test += $"{Getreide.KaufPreis,12}";
            test += $"{Getreide.VerkaufPreis,16}";
            test += $"{s.Guthaben,11}";

            test += "\n";
            Console.WriteLine(test);

        }
        public static void PrintLand(Spieler s)
        {
            string test = "";

            test += $"{"Anzahl",18}";
            test += $"{"KaufPreis",12}";
            test += $"{"Verkaufspreis",16}";
            test += $"{"Guthaben",11}";
            test += "\n";
            test += $"{"Getreide",0}";
            test += $"{s.AnzLaendereien,10}";
            test += $"{Land.KaufPreis,12}";
            test += $"{Land.VerkaufPreis,16}";
            test += $"{s.Guthaben,11}";
            test += "\n";
            Console.WriteLine(test);

        }

        public static void PrintMainMenue()
        {
            Console.WriteLine("1. Land verwalten");
            Console.WriteLine("2. Markt besuchen");
            Console.WriteLine("3. Runde beenden");
        }

        public static void PrintLandVerwaltungsMenue()
        {
            Console.WriteLine("1. Land kaufen");
            Console.WriteLine("2. Land verkaufen");
            Console.WriteLine("3. Zurück");
        }
        public static void PrintGetreideVerwaltungsMenue()
        {
            Console.WriteLine("1. Getreide kaufen");
            Console.WriteLine("2. Getreide verkaufen");
            Console.WriteLine("3. Zurück");
        }

        public static void PrintAnzPromt()
        {
            Console.WriteLine("Anzahl ? ");
        }

        public static uint GetFunctionNr()
        {
            return Convert.ToUInt16(Console.ReadLine());
        }
        public static uint GetAnz()
        {
            return Convert.ToUInt16(Console.ReadLine());
        }

        public static void PrintError(String str)
        {
            Console.WriteLine(str);
        }
    }
}
