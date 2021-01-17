using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_11
{
    class Crystal : Goods
    {
        public static uint PurchasePrice = 75;
        public static uint SellingPrice = 67;

        public override string Print()
        {
            return $"{"Kristall",-8}{PurchasePrice,12}{SellingPrice,16}";
        }
    }
}
