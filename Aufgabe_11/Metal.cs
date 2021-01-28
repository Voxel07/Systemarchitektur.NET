namespace Aufgabe_11
{
    internal class Metal : Goods
    {
        public new static uint PurchasePrice = 60;
        public new static uint SellingPrice = 54;

        public override string Print()
        {
            return $"{"Metall",-8}{PurchasePrice,12}{SellingPrice,16}";
        }
    }
}