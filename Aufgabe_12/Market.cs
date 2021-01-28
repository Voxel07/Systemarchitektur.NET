namespace Aufgabe_12
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
                    Ui.PrintGood(p, g);
                    return g;
                case 2:
                    Crystal c = new Crystal();
                    Ui.PrintGood(p, c);
                    return c;
                case 3:
                    Oil o = new Oil();
                    Ui.PrintGood(p,o);
                    return o;
                case 4:
                    Metal m = new Metal();
                    Ui.PrintGood(p,m);
                    return m;
                case 5:
                    Game.MainMenue(p);
                    return x;
                default:
                    Ui.PrintError("Ungültige Eingabe");
                    return x;
            }
        }

        public static uint GetGoodPurchasePrice(Goods g)
        {
            return g switch
            {
                Grain _ => Grain.PurchasePrice,
                Metal _ => Metal.PurchasePrice,
                Crystal _ => Crystal.PurchasePrice,
                Oil _ => Oil.PurchasePrice,
                _ => 0
            };
        }

        public static uint GetGoodSellingPrice(Goods g)
        {
            return g switch
            {
                Grain _ => Grain.SellingPrice,
                Metal _ => Metal.SellingPrice,
                Crystal _ => Crystal.SellingPrice,
                Oil _ => Oil.SellingPrice,
                _ => 0
            };
        }

        public static bool Buy(Goods g, Player p, uint count)
        {
            uint price = GetGoodPurchasePrice(g);
            uint amount = count * price;

            if (amount > p.Credit) return false;
            p.DecCredit(amount);
            return true;
        }

        public static bool Sell(Goods g, Player p, uint count)
        {
            uint value = GetGoodSellingPrice(g);
            uint goodsCount = p.GetCount(g);
            uint amount = count * value;

            if (count > goodsCount) return false;
            p.IncCredit(amount);
            return true;
        }
    }
}
