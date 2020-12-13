using System;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            string userInput;
            bool validNumber;
            int zahl;
            do
            {
                //User promt
                Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 100 ein:");

                //get user input
                userInput = Console.ReadLine();
                //check if a number was entered
                validNumber = int.TryParse(userInput, out zahl);
                //procede if it was a number
                if (validNumber)
                {
                    if (zahl > 0 && zahl <= 100)
                    {
                        if (zahl % 3 == 0 && zahl % 5 == 0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else if (zahl % 3 == 0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else if (zahl % 5 == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(zahl);
                        }
                    }
                    //user feedback, that the Number hast to be between 1 and 100
                    else
                    {
                        Console.WriteLine("Nur Zahlen zwischen 1 und 100");
                    }
                }
                //user feedback that it has to be an int number
                else
                {
                    Console.WriteLine("Nur Int zahlen möglich {0} ist kein Int", userInput);
                }
                // runs forever, because no exit statement was given
            } while (true);
        }
    }
}