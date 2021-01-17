using System;

namespace Aufgabe_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();

            while (true)
            {
                Game.MainMenue(p);
            }
        }
    }
}
