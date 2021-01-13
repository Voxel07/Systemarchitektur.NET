namespace Aufgabe_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Spieler s = new Spieler();

            Getreide.KaufPreis = 20;
            while (true)
            {
                Spiel.Hauptmenue(s);
            }
        }
    }
}
