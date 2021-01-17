namespace Aufgabe_10
{
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
        }
       
        public override string ToString()
        {
            return "Guthaben: "+Guthaben+" | Ländereien: "+AnzLaendereien+" | Getreide: "+AnzGetreide;
        }
    }
}