using System;

namespace Aufgabe_12
{
    internal class Player
    {
        public Player()
        {
            Credit = 100;
            CountLands = 0;
            CountGrain = 20;
            CountOil = 10;
            CountMetal = 5;
            CountCrystal = 0;
            CountSiedler = 20;
        }

        //Variablen
        public uint Credit { get; private set; }
        public uint CountLands { get;  set; }
        public uint CountGrain { get; private set; }
        public uint CountOil { get; private set; }
        public uint CountMetal { get; private set; }
        public uint CountCrystal { get; private set; }
        public uint CountSiedler { get; private set; }

        public uint GetCount(Goods g)
        {
            return g switch
            {
                Grain _ => CountGrain,
                Metal _ => CountMetal,
                Crystal _ => CountCrystal,
                Oil _ => CountOil,
                _ => 0
            };
        }

        public void IncCount(Goods g, uint count)
        {
            switch (g)
            {
                case Grain _:
                    CountGrain += count;
                    break;
                case Metal _:
                    CountMetal += count;
                    break;
                case Crystal _:
                    CountCrystal += count;
                    break;
                case Oil _:
                    CountOil += count;
                    break;
            }
        }

        public void DecCount(Goods g, uint count)
        {
            switch (g)
            {
                case Grain _:
                    CountGrain -= count;
                    break;
                case Metal _:
                    CountMetal -= count;
                    break;
                case Crystal _:
                    CountCrystal -= count;
                    break;
                case Oil _:
                    CountOil -= count;
                    break;
            }
        }

        public void IncCredit(uint amount)
        {
            Credit += amount;
        }

        public void DecCredit(uint amount)
        {
            Credit -= amount;
        }


        public override string ToString()
        {
            return "Siedler: "+CountSiedler+" | "+"Geld: " + Credit + " | Land: " 
                   + CountLands+" (Preis: "+Land.PurchasePrice+"/"+Land.SellingPrice+")";
        }
    }
}