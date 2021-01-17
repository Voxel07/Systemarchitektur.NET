using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_11
{
    class Grain : Goods
    {
        public static new uint PurchasePrice = 25;
        public static new uint SellingPrice = 22;

        public override string Print()
        {
            return $"{"Getreide",-8}{PurchasePrice,12}{SellingPrice,16}";
        }
    }
}
