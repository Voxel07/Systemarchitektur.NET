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
                    Beenden();
                    break;
                default:
                    Ui.PrintError("Ungültige Eingabe");
                    MainMenue(p);
                    break;
            }
        }

        

        public static void ChooseLandFunction(Player p, uint func)
        {
            Land l = new Land(); //Das muss anders gehen 

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

        //public static void ChooseGetreideFunction(Player p, uint func)
        //{
        //    Grain g = new Grain();//Das muss anders gehen 
        //    switch (func)
        //    {
        //        case 1:
        //            Ui.PrintCntPromt();
        //            p.BuyGrain(Ui.GetCnt());
        //            GetreideVerwalten(p);
        //            break;
        //        case 2:
        //            Ui.PrintCntPromt();
        //            p.SellGrain(Ui.GetCnt());
        //            GetreideVerwalten(p);
        //            break;
        //        case 3:
        //            MainMenue(p);
        //            break;
        //        default:
        //            Ui.PrintError("Ungültige Eingabe");
        //            GetreideVerwalten(p);
        //            break;
        //    }
        //}

        public static void LandAdministration(Player p)
        {
            Ui.PrintLand(p);
            Ui.PrintLandAdministration();
            Game.ChooseLandFunction(p, Ui.GetFunctionNr());
        }

        public static void VisitMarket(Player p)
        {
            Ui.PrintMarketAdministration();
            Market.ChoseMarketFunction(p, Ui.GetFunctionNr());
        }

        public static void Beenden()
        {
            Environment.Exit(0);
        }
    }
}
