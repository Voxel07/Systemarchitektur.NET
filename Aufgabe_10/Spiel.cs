using System;

namespace Aufgabe_10
{
    internal class Spiel
    {
        public static void Hauptmenue(Spieler s)
        {
            Ui.PrintSpieler(s);
            Ui.PrintMainMenue();
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
}
