namespace Aufgabe_11
{
    internal class Grain : Goods
    {
        public new static uint PurchasePrice = 25;
        public new static uint SellingPrice = 22;

        public override string Print()
        {
            return $"{"Getreide",-8}{PurchasePrice,12}{SellingPrice,16}";
        }
    }
}