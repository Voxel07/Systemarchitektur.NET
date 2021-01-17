using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_11
{
    class Player
    {
        //Variablen
        public uint Credit { get; private set; }
        public uint CntLands { get; private set; }
        public uint CntGrain { get; private set; }
        public uint CntOil { get; private set; }
        public uint CntMetal { get; private set; }
        public uint CntCrystal { get; private set; }

        //Construktoren
        public Player()
        {
            Credit = 100;
            CntLands = 0;
            CntGrain = 20;
            CntOil = 10;
            CntMetal = 5;
            CntCrystal = 0;
        }

        //Methoden

        //Verwaltung
        //public void LandVerwalten(Player s)
        //{
        //    Ui.PrintLand(s);
        //    Ui.PrintLandAdministration();
        //    Game.ChooseLandFunction(s, Ui.GetFunctionNr());
        //}

        //public void GetreideVerwalten(Player s)
        //{
        //    Ui.PrintGetreiede(s);
        //    Ui.PrintGrainAdministration();
        //    Game.ChooseGetreideFunction(s, Ui.GetFunctionNr());
        //}

        //Kaufen
        public void SellLand(uint anz)
        {
            if (anz * Land.PurchasePrice <= Credit)
            {
                Credit -= anz * Land.PurchasePrice;
                CntLands += anz;
            }
            else
            {
                Ui.PrintError("Du hast nicht genügend Geld");
            }

            //LandVerwalten(this);
        }

        public void SellGrain(uint anz)
        {
            if (anz * Grain.PurchasePrice <= Credit)
            {
                Credit -= anz * Grain.PurchasePrice;
                CntGrain += anz;
            }
            else
            {
                Ui.PrintError("Du hast nicht genügend Geld");
            }

            //GetreideVerwalten(this);
        }

        //Verkaufen
        public void BuyLand(uint anz)
        {
            if (anz <= CntLands)
            {
                Credit += anz * Land.SellingPrice;
                CntLands -= anz;
            }
            else
            {
                Ui.PrintError("Du kannst nich mehr verkaufen als du besitzt");
            }

            //LandVerwalten(this);
        }

        public void BuyGrain(uint anz)
        {
            if (anz <= CntGrain)
            {
                Credit += anz * Grain.SellingPrice;
                CntGrain -= anz;
            }
            else
            {
                Ui.PrintError("Du kannst nich mehr verkaufen als du besitzt");
            }

            //GetreideVerwalten(this);
        }

        public override string ToString()
        {
            return "Guthaben: " + Credit + " | Ländereien: " + CntLands + " | Getreide: " + CntGrain;
        }
    }
}

