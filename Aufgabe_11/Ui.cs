using System;

namespace Aufgabe_11
{
    internal class Ui
    {
        public static void PrintPlayer(Player p)
        {
            Console.WriteLine(p + "\n");
        }

        public static void PrintGoods(Player p, Goods g)
        {
            string goodsStr = $"{"KaufPreis",20} {"Verkaufspreis",16} {"Vorrat",10}{"Guthaben",11}\n";
            goodsStr += g.Print(); //Kauf & Verkaufspreis 

            if (g is Grain) goodsStr += $"{p.CntGrain,12}";
            else if (g is Metal) goodsStr += $"{p.CntMetal,12}";
            else if (g is Crystal) goodsStr += $"{p.CntCrystal,12}";
            else if (g is Oil) goodsStr += $"{p.CntOil,12}";
            else Console.WriteLine("passt nicht ");

            goodsStr += $"{p.Credit,11}";
            goodsStr += "\n";
            Console.WriteLine(goodsStr);
        }

        public static void PrintLand(Player p)
        {
            Console.WriteLine($"{"KaufPreis",20}{"Verkaufspreis",16}{"Vorrat",10}{"Guthaben",11}\n" +
                              $"{"Land",-8}{Land.PurchasePrice,12}{Land.SellingPrice,16}{p.CntLands,10}{p.Credit,11}\n");
        }

        public static void PrintMainMenue()
        {
            Console.WriteLine("1. Land verwalten");
            Console.WriteLine("2. Markt besuchen");
            Console.WriteLine("3. Runde beenden");
        }

        public static void PrintLandAdministration()
        {
            Console.WriteLine("1. Land kaufen");
            Console.WriteLine("2. Land verkaufen");
            Console.WriteLine("3. Zurück");
        }

        public static void PrintGoods()
        {
            Console.WriteLine("\nMit was möchtest du Handeln ?");
            Console.WriteLine("1. Getreide");
            Console.WriteLine("2. Kristall");
            Console.WriteLine("3. Öl");
            Console.WriteLine("4. Metall");
            Console.WriteLine("5. Zurück");
        }

        public static void PrintBuySellOption()
        {
            Console.WriteLine("1. Kaufen");
            Console.WriteLine("2. Verkaufen");
            Console.WriteLine("3. Zurück");
        }


        public static void PrintCntPromt()
        {
            Console.Write("\nAnzahl: ");
        }

        public static uint GetFunctionNr()
        {
            return Convert.ToUInt16(Console.ReadLine());
        }

        public static uint GetCnt()
        {
            return Convert.ToUInt16(Console.ReadLine());
        }

        public static void PrintError(string str)
        {
            Console.WriteLine(str);
        }
    }
}