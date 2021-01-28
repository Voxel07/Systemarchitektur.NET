namespace Aufgabe_12
{
    internal class Land
    {
        public static uint PurchasePrice = 50;
        public static uint SellingPrice = 45;

        public static bool Buy(Player p, uint count)
        {
            if (count * PurchasePrice > p.Credit) return false;
            p.DecCredit(count * PurchasePrice);
            p.CountLands += count;
            return true;
        }

        public static bool Sell(Player p, uint count)
        {
            if (count > p.CountLands) return false;
            p.IncCredit(count* SellingPrice);
            p.CountLands -= count;
            return true;
        }
    }
}