using System;

namespace Aufgabe_12
{
    internal class Ui
    {
        public static void PrintPlayer(Player p)
        {
            Console.WriteLine(p + "\n");
            string goodsStr = $"{"Vorrat",16} {"Preis",8}\n";
            goodsStr += $"{"Getreide",-8}{p.CountGrain,8}{Grain.PurchasePrice,6}{"/",1}{Grain.SellingPrice,2}\n";
            goodsStr += $"{"Öl",-8}{p.CountOil,8}{Crystal.PurchasePrice,6}{"/",1}{Crystal.SellingPrice,2}\n";
            goodsStr += $"{"Metall",-8}{p.CountMetal,8}{Oil.PurchasePrice,6}{"/",1}{Oil.SellingPrice,2}\n";
            goodsStr += $"{"Kristall",-8}{p.CountCrystal,8}{Metal.PurchasePrice,6}{"/",1}{Metal.SellingPrice,2}\n";
            Console.WriteLine(goodsStr);
        }

        public static void PrintGood(Player p, Goods g)
        {
            string goodsStr = $"{"Vorrat",16} {"Preis",8}{"Geld",8}\n";
            switch (g)
            {
                case Grain _:
                    goodsStr += $"{"Getreide",-8}{p.CountGrain,8}";
                    goodsStr += $"{Grain.PurchasePrice,6}{"/",1}{Grain.SellingPrice,2}";
                    break;
                case Metal _:
                    goodsStr += $"{"Metall",-8}{p.CountMetal,8}";
                    goodsStr += $"{Metal.PurchasePrice,6}{"/",1}{Metal.SellingPrice,2}";
                    break;
                case Crystal _:
                    goodsStr += $"{"Kristall",-8}{p.CountCrystal,8}";
                    goodsStr += $"{Crystal.PurchasePrice,6}{"/",1}{Crystal.SellingPrice,2}";
                    break;
                case Oil _:
                    goodsStr += $"{"Öl",-8}{p.CountOil,8}";
                    goodsStr += $"{Oil.PurchasePrice,6}{"/",1}{Oil.SellingPrice,2}";
                    break;
                default:
                    Console.WriteLine("passt nicht");
                    break;
            }
            //goodsStr += $"{g.PurchasePrice,6}{"/",1}{g.SellingPrice,2}"; //Kp warum das nicht mehr geht
            goodsStr += $"{p.Credit,8}"; 
            goodsStr += "\n";
            Console.WriteLine(goodsStr);
        }

        public static void PrintLand(Player p)
        {
            Console.WriteLine($"{"KaufPreis",20}{"Verkaufspreis",16}{"Vorrat",10}{"Guthaben",11}\n" +
                              $"{"Land",-8}{Land.PurchasePrice,12}{Land.SellingPrice,16}{p.CountLands,10}{p.Credit,11}\n");
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
            Console.WriteLine("Mit was möchtest du Handeln ?");
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


        public static void PrintCountPromt()
        {
            Console.Write("\nAnzahl: ");
        }

        public static uint GetFunctionNr()
        {
            return Convert.ToUInt16(Console.ReadLine());
        }

        public static uint GetCount()
        {
            return Convert.ToUInt16(Console.ReadLine());
        }

        public static void PrintError(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n"+str+"\n");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}