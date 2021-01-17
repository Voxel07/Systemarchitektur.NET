using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_11
{
    class Goods
    {
        public uint PurchasePrice;
        public uint SellingPrice;

        public  virtual string Print()
        {
            return "default";
        }
    }
}
