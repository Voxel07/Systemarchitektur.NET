using System;

namespace Aufgabe_9
{
    internal class Program
    {
        public static uint guthaben = 100;
        public static uint land;

        private static void Main(string[] args)
        {
            MainMenue();
        }

        #region SpielFunktionen
        private static void MainMenue()
        {
            PrintMainMenue();
            ChooseMainFunction(GetProgrammNr());
        }

        private static void Beenden()
        {
			//ausgelagert für zukünftige Erweiterungen
            Environment.Exit(0);
        }
        #endregion


        #region Spielerfunktionen
        private static void Landverwalten()
        {
            Console.WriteLine("Guthaben: {0} | Ländereien {1}", guthaben, land);
            PrintVerwaltungsMenue();
            ChooseFunction(GetProgrammNr());
        }

        private static void LandKaufen()
        {
            Console.WriteLine("Wie viele Ländereien möchten Sie kaufen");
            var anz = GetAnz();
            if (guthaben >= 50 * anz)
            {
                land += anz;
                guthaben -= 50 * anz;
            }
            else
            {
                Console.WriteLine("Nicht genung Guthaben um {0} Ländereien zu kaufen", anz);
            }

            Landverwalten();
        }

        private static void LandVerkaufen()
        {
            Console.WriteLine("Wie viele Ländereien möchten Sie verkaufen");
            var anz = GetAnz();
            if (land >= anz)
            {
                land -= anz;
                guthaben += 45 * anz;
            }
            else
            {
                Console.WriteLine("Sie können {0} Ländereien verkaufen", land);
            }

            Landverwalten();
        }
        #endregion

        #region UserInteragtionen
        private static uint GetAnz()
        {
			//ausgelagert für zukünftige Erweiterungen / Limitierungen
            Console.WriteLine("");
            return Convert.ToUInt16(Console.ReadLine());
        }

        private static uint GetProgrammNr()
        {
			//ausgelagert für zukünftige Erweiterungen / Limitierungen
            Console.WriteLine("");
            return Convert.ToUInt16(Console.ReadLine());
        }
        #endregion

        #region PrintFunktionen
        private static void PrintMainMenue()
        {
            Console.WriteLine("1. Land verwalten");
            Console.WriteLine("2. Runde beenden");
        }

        private static void PrintVerwaltungsMenue()
        {
            Console.WriteLine("1. Land kaufen");
            Console.WriteLine("2. Land verkaufen");
            Console.WriteLine("3. Zurück");
        }
        #endregion

        #region Menünavigation
        private static void ChooseFunction(uint func)
        {
            switch (func)
            {
                case 1:
                    LandKaufen();
                    break;
                case 2:
                    LandVerkaufen();
                    break;
                case 3:
                    MainMenue();
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe");
                    Landverwalten();
                    break;
            }
        }

        private static void ChooseMainFunction(uint func)
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
                    Console.WriteLine("Ungültige Eingabe");
                    MainMenue();
                    break;
            }
        }
        #endregion

    }
}