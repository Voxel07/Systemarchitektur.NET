namespace Aufgabe_11
{
    internal class Goods
    {
        public uint PurchasePrice;
        public uint SellingPrice;

        public virtual string Print()
        {
            return "default";
        }
    }
}