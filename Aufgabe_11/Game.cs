using System;
namespace Aufgabe_11
{
    class Game
    {
        public static void MainMenue(Player p)
        {
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
                    Ui.PrintCntPromt();
                    p.BuyLand(Ui.GetCnt());
                    LandAdministration(p);
                    break;
                case 2:
                    Ui.PrintCntPromt();
                    p.SellLand(Ui.GetCnt());
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

        public static void ChooseBuySell(Player p,Goods g, uint func)
        {
            switch (func)
            { 
                case 1: Ui.PrintCntPromt(); 
                    p.Buy(g, Ui.GetCnt());
                    break;
                case 2: Ui.PrintCntPromt();
                    p.Sell(g,Ui.GetCnt());
                    break;
                case 3: VisitMarket(p);
                    break;
                default: Ui.PrintError("Ungültige Eingabe");
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
          
            Ui.PrintMarketAdministration();
            Goods g = Market.ChoseMarketFunction(p, Ui.GetFunctionNr());
            Ui.PrintBuySellOption();
            ChooseBuySell(p, g, Ui.GetCnt());

        }

        public static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
