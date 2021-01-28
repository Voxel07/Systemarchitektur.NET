namespace Aufgabe_11
{
    internal class Oil : Goods
    {
        public new static uint PurchasePrice = 50;
        public new static uint SellingPrice = 45;

        public override string Print()
        {
            return $"{"Öl",-8}{PurchasePrice,12}{SellingPrice,16}";
        }
    }
}