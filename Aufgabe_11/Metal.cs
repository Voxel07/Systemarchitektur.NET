using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_11
{
    class Metal : Goods
    {
        public static uint PurchasePrice = 60;
        public static uint SellingPrice = 54;

        public override string Print()
        {
            return $"{"Metall",-8}{PurchasePrice,12}{SellingPrice,16}";
        }
    }
}
