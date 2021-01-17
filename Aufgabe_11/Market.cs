using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe_11
{
    class Market
    {
        public static void ChoseMarketFunction(Player p, uint func)
        {
            Grain g = new Grain();
            switch (func)
            {
                case 1:
                    Ui.PrintGrain(p, g);
                    break;
                case 2:
                    Ui.PrintCrystal(p);
                    break;
                case 3:
                    Ui.PrintOil(p);
                    break;
                case 4:
                    Ui.PrintMetal(p);
                    break;
                case 5:
                   Game.MainMenue(p);
                    break;
                default:
                    Ui.PrintError("Ungültige Eingabe");
                    break;
            }

        }
    }
}
