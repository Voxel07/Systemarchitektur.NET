using System;

namespace Aufgabe_11
{
    class Ui
    {
        public static void PrintPlayer(Player p)
        {
            Console.WriteLine(p + "\n");
        }

        #region PrintMaterials
        public static void PrintGrain(Player p, Goods g)
        {
            switch (g)
            {
                case Grain: Console.WriteLine("grain");
                    break;
                default: Console.WriteLine("default");
                    break;
            }
            string grainStr = g.Print();
          
            //grainStr += $"{"KaufPreis",20}";
            //grainStr += $"{"Verkaufspreis",16}";
            //grainStr += $"{"Vorrat",10}";
            //grainStr += $"{"Guthaben",11}";
            //grainStr += "\n";
            //grainStr += $"{"Getreide",0}";
          
            //grainStr += $"{Grain.PurchasePrice,12}";
            //grainStr += $"{Grain.SellingPrice,16}";
            grainStr += $"{p.CntGrain,10}";
            grainStr += $"{p.Credit,11}";
            grainStr += "\n";
            Console.WriteLine(grainStr);
        }

        public static void PrintLand(Player p)
        {
            string landStr = "";
            landStr += $"{"Cntahl",18}";
            landStr += $"{"KaufPreis",12}";
            landStr += $"{"Verkaufspreis",16}";
            landStr += $"{"Guthaben",11}";
            landStr += "\n";
            landStr += $"{"Land",0}";
            landStr += $"{p.CntLands,14}";
            landStr += $"{Land.PurchasePrice,12}";
            landStr += $"{Land.SellingPrice,16}";
            landStr += $"{p.Credit,11}";
            landStr += "\n";
            Console.WriteLine(landStr);

        }

        public static void PrintOil(Player p)
        {
            string oilStr = "";
            oilStr += $"{"Cntahl",18}";
            oilStr += $"{"KaufPreis",12}";
            oilStr += $"{"Verkaufspreis",16}";
            oilStr += $"{"Guthaben",11}";
            oilStr += "\n";
            oilStr += $"{"Öl",0}";
            oilStr += $"{p.CntLands,16}";
            oilStr += $"{Land.PurchasePrice,12}";
            oilStr += $"{Land.SellingPrice,16}";
            oilStr += $"{p.Credit,11}";
            oilStr += "\n";
            Console.WriteLine(oilStr);
        }

        public static void PrintCrystal(Player p)
        {
            string cystalStr = "";
            cystalStr += $"{"Cntahl",18}";
            cystalStr += $"{"KaufPreis",12}";
            cystalStr += $"{"Verkaufspreis",16}";
            cystalStr += $"{"Guthaben",11}";
            cystalStr += "\n";
            cystalStr += $"{"Kristall",0}";
            cystalStr += $"{p.CntLands,10}";
            cystalStr += $"{Land.PurchasePrice,12}";
            cystalStr += $"{Land.SellingPrice,16}";
            cystalStr += $"{p.Credit,11}";
            cystalStr += "\n";
            Console.WriteLine(cystalStr);
        }

        public static void PrintMetal(Player p)
        {
            string metalStr = "";
            metalStr += $"{"Cntahl",18}";
            metalStr += $"{"KaufPreis",12}";
            metalStr += $"{"Verkaufspreis",16}";
            metalStr += $"{"Guthaben",11}";
            metalStr += "\n";
            metalStr += $"{"Metall",0}";
            metalStr += $"{p.CntLands,12}";
            metalStr += $"{Land.PurchasePrice,12}";
            metalStr += $"{Land.SellingPrice,16}";
            metalStr += $"{p.Credit,11}";
            metalStr += "\n";
            Console.WriteLine(metalStr);
        }


        #endregion


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

        public static void PrintMarketAdministration()
        {
            Console.WriteLine("1. Getreide");
            Console.WriteLine("2. Kristall");
            Console.WriteLine("3. Öl");
            Console.WriteLine("4. Metall");
            Console.WriteLine("5. Zurück");
        }

        public static void PrintGrainAdministration()
        {
            Console.WriteLine("1. Getreide kaufen");
            Console.WriteLine("2. Getreide verkaufen");
            Console.WriteLine("3. Zurück");
        }
        public static void PrintOilAdministration()
        {
            Console.WriteLine("1. Öl kaufen");
            Console.WriteLine("2. Öl verkaufen");
            Console.WriteLine("3. Zurück");
        }
        public static void PrintCrystalAdministration()
        {
            Console.WriteLine("1. Kristall kaufen");
            Console.WriteLine("2. Kristall verkaufen");
            Console.WriteLine("3. Zurück");
        }
        public static void PrintMetalAdministration()
        {
            Console.WriteLine("1. Metall kaufen");
            Console.WriteLine("2. Metall verkaufen");
            Console.WriteLine("3. Zurück");
        }

        public static void PrintCntPromt()
        {
            Console.WriteLine("Cntahl ? ");
        }

        public static uint GetFunctionNr()
        {
            return Convert.ToUInt16(Console.ReadLine());
        }
        public static uint GetCnt()
        {
            return Convert.ToUInt16(Console.ReadLine());
        }

        public static void PrintError(String str)
        {
            Console.WriteLine(str);
        }
    }
}
