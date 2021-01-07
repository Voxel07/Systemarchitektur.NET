using System;

namespace Aufgabe_9
{
    class Program
    {
        public static uint guthaben = 100;
        public static uint land = 0;

        static void Main(string[] args)
        {

            printMainMenue();
            ChooseMainFunction(getAnz());
        }

       static void Landverwalten()
        {
            printVerwaltungsMenue();
            ChooseFunction(getAnz());
        }

        //Kostet 50
        static void LandKaufen()
        {
            //Prüfen ob genug Geld da ist
            Console.WriteLine("Wie vile Ländereien möchten Sie kaufen");
            uint anz = getAnz();
            if (Program.guthaben >= 50* anz)
            {
                Program.land++;
                Program.guthaben -= 50*anz;
            }
        }

        //Bringt 45
        static void LadVerkaufen()
        {
            //Prüfen ob länderreihen verfügbar sind
            Console.WriteLine("Wie viele Ländereien möchten Sie verkaufen");
            uint anz = getAnz();
            if (land >= anz)
            {
                land++;
                guthaben -= 45*anz;
            }
        }

        static void UserInteraktion()
        {
            Console.WriteLine("");
        }

        static uint getAnz()
        {
            Console.WriteLine("");
            return Convert.ToUInt16(Console.ReadLine());
        }

        static void printMainMenue()
        {
            Console.WriteLine("1. Land verwalten");
            Console.WriteLine("2. Runde beenden");
        }
        static void printVerwaltungsMenue()
        {
            Console.WriteLine("1. Land kaufen");
            Console.WriteLine("2. Land verkaufen");
            Console.WriteLine("3. Zurück");
        }
        static void Beenden()
        {
            Environment.Exit(0);
        }

        static void ChooseFunction(uint func)
        {
            switch (func)
            {
                case 1:
                    LandKaufen();
                    break;
                case 2:
                    LadVerkaufen();
                    break;
                case 3:
                    printMainMenue();
                    ChooseMainFunction(getAnz());


                    break; 
                default:
                    break;
            }
        }
        static void ChooseMainFunction(uint func)
        {
            switch (func)
            {
                case 1:
                    Landverwalten();
                    break;
                case 2:
                    Beenden();
                    break; 
                default:
                    break;
            }
        }
    }

    class Spiel
    {



    };

    class Spieler
    {

        private

        int guthaben;
        uint anzLand;

        public

        int getGuthaben()
        {
            return guthaben;
        }
    };
}
    
    
    
   

