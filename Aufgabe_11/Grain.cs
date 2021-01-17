using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_11
{
    class Grain : Goods
    {
        public static uint PurchasePrice = 25;
        public static uint SellingPrice = 22;

        public override string Print()
        {
            string grainStr = "";

            grainStr += $"{"KaufPreis",20}";
            grainStr += $"{"Verkaufspreis",16}";
            grainStr += $"{"Vorrat",10}";
            grainStr += $"{"Guthaben",11}";
            grainStr += "\n";
            grainStr += $"{"Getreide",0}";
            grainStr += $"{PurchasePrice,12}";
            grainStr += $"{SellingPrice,16}";

            return grainStr;
        }
    }
}
