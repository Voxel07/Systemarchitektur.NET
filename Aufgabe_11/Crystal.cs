namespace Aufgabe_11
{
    internal class Crystal : Goods
    {
        public new static uint PurchasePrice = 75;
        public new static uint SellingPrice = 67;

        public override string Print()
        {
            return $"{"Kristall",-8}{PurchasePrice,12}{SellingPrice,16}";
        }
    }
}