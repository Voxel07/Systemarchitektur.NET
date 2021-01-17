using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_11
{
    class Oil : Goods
    {
        public static uint PurchasePrice = 50;
        public static uint SellingPrice = 45;

        public override string Print()
        {
            return $"{"Öl",-8}{PurchasePrice,12}{SellingPrice,16}";
        }
    }
}
