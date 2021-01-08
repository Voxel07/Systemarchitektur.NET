using System;

namespace Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int treeHeight;
            bool setStar = false;
            if (args.Length != 0)
            {
                treeHeight = Convert.ToInt32(args[0]);
                if (args.Length > 1)
                {
                    setStar = Convert.ToBoolean(args[1]);
                    Console.WriteLine("Tannenbaum.exe gestartet mit {0} {1}", args[0], args[1]);
                }
                else
                {
                    Console.WriteLine("Tannenbaum.exe gestartet mit {0}", args[0]);
                }
                DrawTree(treeHeight, setStar);
            }
        }

        private static void DrawTree(int treeHeight, bool star)
        {
            int treeWidth = 1;
            if (star)
            {
                Console.WriteLine("*".PadLeft(treeHeight + 1));
            }
            for (int i = 0; i < treeHeight; i++)
            {
                for (int j = 0; j < (treeHeight - i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < treeWidth; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
                treeWidth += 2;
            }
            Console.WriteLine("I".PadLeft(treeHeight + 1));
        }
    }
}
