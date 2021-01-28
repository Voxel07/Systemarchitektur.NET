namespace Aufgabe_11
{
    internal class Market
    {
        public static Goods ChoseMarketGoods(Player p, uint func)
        {
            Goods x = new Goods();
            switch (func)
            {
                case 1:
                    Grain g = new Grain();
                    Ui.PrintGoods(p, g);
                    return g;
                case 2:
                    Crystal c = new Crystal();
                    Ui.PrintGoods(p, c);
                    return c;
                case 3:
                    Oil o = new Oil();
                    Ui.PrintGoods(p,o);
                    return o;
                case 4:
                    Metal m = new Metal();
                    Ui.PrintGoods(p,m);
                    return m;
                case 5:
                    Game.MainMenue(p);
                    return x;
                default:
                    Ui.PrintError("Ungültige Eingabe");
                    return x;
            }
        }

        public static uint getGoodPurchasePrice(Goods g)
        {
            if (g is Grain) return Grain.PurchasePrice;
            if (g is Metal) return Metal.PurchasePrice; 
            if (g is Crystal) return Crystal.PurchasePrice;
            if (g is Oil) return Oil.PurchasePrice;
            return 0;
        }

        public static uint getGoodSellingPrice(Goods g)
        {
            if (g is Grain) return Grain.SellingPrice;
            if (g is Metal) return Metal.SellingPrice;
            if (g is Crystal) return Crystal.SellingPrice;
            if (g is Oil) return Oil.SellingPrice;
            return 0;
        }
    }
}
