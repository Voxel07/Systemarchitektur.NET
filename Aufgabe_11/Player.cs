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

        //Neu 
        public void Buy (Goods g, uint anz)
        {
            uint price = Market.getGoodPurchasePrice(g);
            if (anz * price <= Credit)
            {
                Credit -= anz * price;
                IncCnt(g,anz);
            }
            else
            {
                Ui.PrintError("Du hast nicht genügend Geld");
            }
        }
        public void Sell(Goods g, uint anz)
        {
            uint price = Market.getGoodSellingPrice(g);
            uint cnt = GetCnt(g);
            if (anz <= cnt)
            {
                Credit += anz * price;
                DecCnt(g, anz);
            }
            else
            {
                Ui.PrintError("Du kannst nich mehr verkaufen als du besitzt");
            }
        }

        public void BuyLand(uint anz)
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
        }

        public void SellLand(uint anz)
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
        }

        public uint GetCnt(Goods g)
        {
            if (g is Grain) return CntGrain;
            if (g is Metal) return CntMetal;
            if (g is Crystal) return CntCrystal;
            if (g is Oil) return CntOil;
            return 0;
        }

        public void IncCnt(Goods g, uint anz)
        {
            if (g is Grain) CntGrain += anz;
            if (g is Metal) CntMetal += anz; 
            if (g is Crystal) CntCrystal += anz; 
            if (g is Oil) CntOil += anz; 
        }
        public void DecCnt(Goods g, uint anz)
        {
            if (g is Grain) CntGrain -= anz;
            if (g is Metal) CntMetal -= anz;
            if (g is Crystal) CntCrystal -= anz;
            if (g is Oil) CntOil -= anz;
        }


        public override string ToString()
        {
            return "Guthaben: " + Credit + " | Ländereien: " + CntLands + " | Getreide: " + CntGrain 
                   + " | Kristall: " + CntCrystal + " | Metall: " + CntMetal + " | Öl: " + CntOil;
        }
    }
}

