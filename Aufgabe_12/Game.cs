using System;

namespace Aufgabe_12
{
    internal class Game
    {
        public static void MainMenue(Player p)
        {
            Console.Clear();
            Ui.PrintPlayer(p);
            Ui.PrintMainMenue();
            ChooseMainFunction(p, Ui.GetFunctionNr());
        }

        public static void ChooseMainFunction(Player p, uint func)
        {
            switch (func)
            {
                case 1:
                    LandAdministration(p);
                    break;
                case 2:
                    VisitMarket(p);
                    break;
                case 3:
                    Exit();
                    break;
                default:
                    Ui.PrintError("Ungültige Eingabe");
                    MainMenue(p);
                    break;
            }
        }

        public static void ChooseLandFunction(Player p, uint func)
        {
            switch (func)
            {
                case 1:
                    Ui.PrintCountPromt();
                    if (!Land.Buy(p, Ui.GetCount()))
                        Ui.PrintError("Nicht genügend Geld");
                    LandAdministration(p);
                    break;
                case 2:
                    Ui.PrintCountPromt();
                    if (!Land.Sell(p, Ui.GetCount()))
                        Ui.PrintError("Mehr verkaufen als haben ist nicht");
                    LandAdministration(p);
                    break;
                case 3:
                    MainMenue(p);
                    break;
                default:
                    Ui.PrintError("Ungültige Eingabe");
                    LandAdministration(p);
                    break;
            }
        }

        public static void ChooseBuySell(Player p, Goods g, uint func)
        {
            uint anz;
            switch (func)
            {
                case 1:
                    Ui.PrintCountPromt();
                    anz = Ui.GetCount();
                    if (Market.Buy(g, p, anz))
                        p.IncCount(g, anz);
                    else
                        Ui.PrintError("Nicht genügend Geld");
                    break;
                case 2:
                    Ui.PrintCountPromt();
                    anz = Ui.GetCount();
                    if (Market.Sell(g, p, anz))
                        p.DecCount(g, anz);
                    else
                        Ui.PrintError("Mehr verkaufen als haben ist nicht");
                    break;
                case 3:
                    VisitMarket(p);
                    break;
                default:
                    Ui.PrintError("Ungültige Eingabe");
                    VisitMarket(p);
                    break;
            }
        }

        public static void LandAdministration(Player p)
        {
            Ui.PrintLand(p);
            Ui.PrintLandAdministration();
            ChooseLandFunction(p, Ui.GetFunctionNr());
        }

        public static void VisitMarket(Player p)
        {
            Ui.PrintPlayer(p);
            Ui.PrintGoods();
            Goods g = Market.ChoseMarketGoods(p, Ui.GetFunctionNr());
            Ui.PrintBuySellOption();
            ChooseBuySell(p, g, Ui.GetFunctionNr());
            VisitMarket(p);
        }

        public static void Exit()
        {
            Environment.Exit(0);
        }
    }
}