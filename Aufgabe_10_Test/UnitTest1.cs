using System;
using Xunit;

namespace Aufgabe_10_Test
{
    internal class Spiel
    {
        public static void Hauptmenue(Spieler s)
        {
            Ui.PrintSpieler(s);
            Ui.PrintHauptMenue();
            ChooseMainFunction(s, Ui.GetFunctionNr());
        }
        public static void ChooseMainFunction(Spieler s, uint func)
        {
            switch (func)
            {
                case 1:
                    s.LandVerwalten(s);
                    break;
                case 2:
                    s.GetreideVerwalten(s);
                    break;
                case 3:
                    Beenden();
                    break;
                default:
                    Ui.PrintError("Ungültige Eingabe");
                    Hauptmenue(s);
                    break;
            }
        }

        public static void ChooseLandFunction(Spieler s, uint func)
        {
            Land l = new Land(); //Das muss anders gehen 

            switch (func)
            {
                case 1:
                    Ui.PrintAnzPromt();
                    s.LandKaufen(Ui.GetAnz());
                    break;
                case 2:
                    Ui.PrintAnzPromt();
                    s.LandVerkaufen(Ui.GetAnz());
                    break;
                case 3:
                    Hauptmenue(s);
                    break;
                default:
                    Ui.PrintError("Ungültige Eingabe");
                    s.LandVerwalten(s);
                    break;
            }
        }

        public static void ChooseGetreideFunction(Spieler s, uint func)
        {
            Getreide g = new Getreide();//Das muss anders gehen 
            switch (func)
            {
                case 1:
                    Ui.PrintAnzPromt();
                    s.GetreideKaufen(Ui.GetAnz());
                    break;
                case 2:
                    Ui.PrintAnzPromt();
                    s.GetreideVerkaufen(Ui.GetAnz());
                    break;
                case 3:
                    Hauptmenue(s);
                    break;
                default:
                    Ui.PrintError("Ungültige Eingabe");
                    s.GetreideVerwalten(s);
                    break;
            }
        }

        public static void Beenden()
        {
            Environment.Exit(0);
        }
    }
    internal class Land
    {
        //Variablen
        public static uint KaufPreis = 50;
        public static uint VerkaufPreis = 45;
        //Methoden
    }
    internal class Getreide
    {
        //Variablen
        public static uint KaufPreis = 25;
        public static uint VerkaufPreis = 22;
        //Methoden
    }
    class Ui
    {
        public static void PrintSpieler(Spieler s)
        {
            Console.WriteLine(s + "\n");
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

        public static void PrintHauptMenue()
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
    internal class Spieler
    {
        //Variablen
        public uint Guthaben { get; private set; }
        public uint AnzLaendereien { get; private set; }
        public uint AnzGetreide { get; private set; }

        //Construktoren
        public Spieler()
        {
            Guthaben = 100;
            AnzGetreide = 20;
            AnzLaendereien = 0;
        }

        //Methoden

        //Verwaltung
        public void LandVerwalten(Spieler s)
        {
            Ui.PrintLand(s);
            Ui.PrintLandVerwaltungsMenue();
            Spiel.ChooseLandFunction(s, Ui.GetFunctionNr());
        }

        public void GetreideVerwalten(Spieler s)
        {
            Ui.PrintGetreiede(s);
            Ui.PrintGetreideVerwaltungsMenue();
            Spiel.ChooseGetreideFunction(s, Ui.GetFunctionNr());
        }

        //Kaufen
        public void LandKaufen(uint anz)
        {
            if (anz * Land.KaufPreis <= Guthaben)
            {
                Guthaben -= anz * Land.KaufPreis;
                AnzLaendereien += anz;
            }
            else
            {
                Ui.PrintError("Du hast nicht genügend Geld");
            }

            LandVerwalten(this);
            //Spiel.Hauptmenue(this);
        }

        public void GetreideKaufen(uint anz)
        {
            if (anz * Getreide.KaufPreis <= Guthaben)
            {
                Guthaben -= anz * Getreide.KaufPreis;
                AnzGetreide += anz;
            }
            else
            {
                Ui.PrintError("Du hast nicht genügend Geld");
            }

            GetreideVerwalten(this);
            //Spiel.Hauptmenue(this);
        }

        //Verkaufen
        public void LandVerkaufen(uint anz)
        {
            if (anz <= AnzLaendereien)
            {
                Guthaben += anz * Land.VerkaufPreis;
                AnzLaendereien -= anz;
            }
            else
            {
                Ui.PrintError("Du kannst nich mehr verkaufen als du besitzt");
            }

            LandVerwalten(this);
            // Spiel.Hauptmenue(this);
        }

        public void GetreideVerkaufen(uint anz)
        {
            if (anz <= AnzGetreide)
            {
                Guthaben += anz * Getreide.VerkaufPreis;
                AnzGetreide -= anz;
            }
            else
            {
                Ui.PrintError("Du kannst nich mehr verkaufen als du besitzt");
            }

            GetreideVerwalten(this);
            //Spiel.Hauptmenue(this);
        }

        public override string ToString()
        {
            return "Guthaben: " + Guthaben + " | Ländereien: " + AnzLaendereien + " | Getreide: " + AnzGetreide;
        }
    }
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 3 ,3)]
        public void LandKaufenTest(uint anz, uint val, uint val2)
        {
            Spieler s = new Spieler();
            s.GetreideKaufen(anz);
            Assert.Equal(val, s.AnzGetreide);
            Assert.Equal(val2, s.Guthaben);
        }
    }
}
