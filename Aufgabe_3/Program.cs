using System;
using Xunit;

namespace Aufgabe_3
{
    class Program
    {
        public static void Main()
        {
            string userInput;
            while (true)
            {
                Console.Write("Geben Sie eine Römische Zahl ein: ");
                userInput = Console.ReadLine();
                if (RZ.IsValidNumber(userInput))
                {
                    Console.WriteLine();
                    Console.WriteLine("{0} -> {1}", userInput, RZ.ConvertRomeToInt(userInput));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ungültige Eingabe");
                }
            }
        }
    }
    public static class RZ
    {
        public static int[] ConvertStringToIntArray(string userInput)
        {
            int[] convertedString = new int[userInput.Length];
            for (int i = 0; i < userInput.Length; i++)
            {
                convertedString[i] = (userInput[i]) switch
                {
                    'I' => 1,
                    'V' => 5,
                    'X' => 10,
                    'L' => 50,
                    'C' => 100,
                    'D' => 500,
                    'M' => 1000,
                    _ => 0,
                };
            }
            return convertedString;
        }

        //Validates the userInput String.
        //checke´s, if there are non romen numerals
        //Then if it´s an valid  number
        //Calculation of the value was moved out for modularity. 
        //If an Invalid char is found execution is abborted and false is returned
        /*Rules*/
        //Rule 1: I,X,C,M max 3 Times
        //Rule 2: V,L,D max 1 Time
        //Rule 3: no V,L,D to decrement
        //Rule 4: decrement only with one numeral smaler
        public static bool IsValidNumber(string userInput)
        {
            int[] eingabe = ConvertStringToIntArray(userInput);
            bool valid = false;
            short cntMultible = 1;
            int last = 0;
            int i = 0;
            //int value = 0;

            while (i < eingabe.Length)
            {
                //Enforces the rules for I,X,C,M
                if (eingabe[i] == 1 || eingabe[i] == 10 || eingabe[i] == 100 || eingabe[i] == 1000)
                {
                    valid = true;
                    //ignors first run
                    if (i != 0)
                    {
                        //Checkes Rule 1
                        if (eingabe[i] == last)
                        {
                            cntMultible++;
                            if (cntMultible > 3)
                            {
                                valid = false;
                                break;
                            }
                            //value += eingabe[i];
                            last = eingabe[i];
                            i++;
                        }
                        //When new is bigger then last
                        //Checkes Rule 3 & 4
                        else if (eingabe[i] > last && last != 5 && last != 50 && last != 500 && last * 10 == eingabe[i])
                        {
                            if (cntMultible > 1)
                            {
                                valid = false;
                                break;
                            }
                            else
                            {
                                //value += eingabe[i] - last;
                                last = eingabe[i];
                                i += 1;
                            }
                            cntMultible = 1;
                        }
                        //When new is smaller then last
                        else if (eingabe[i] < last)
                        {
                            //value += eingabe[i];
                            last = eingabe[i];
                            i += 1;
                            cntMultible = 1;
                        }
                        else
                        {
                            valid = false;
                            break;
                        }
                    }
                    //happens only for the first value 
                    else
                    {
                        //value += eingabe[i];
                        last = eingabe[i];
                        i++;
                    }
                }
                //Enforces the rules for V,L,D
                else if (eingabe[i] == 5 || eingabe[i] == 50 || eingabe[i] == 500)
                {
                    valid = true;
                    //ignors first run
                    if (i != 0)
                    {
                        //Checkes Rule 1
                        if (eingabe[i] == last)
                        {
                            cntMultible++;
                            if (cntMultible > 1)
                            {
                                valid = false;
                                break;
                            }
                            //value += eingabe[i];
                            last = eingabe[i];
                            i++;
                        }
                        //When new is bigger then last
                        else if (eingabe[i] > last)
                        {
                            if (cntMultible > 1)
                            {
                                valid = false;
                                break;
                            }
                            else
                            {
                                //value += eingabe[i] - last;
                                last = eingabe[i];
                                i += 1;
                            }
                            cntMultible = 1;
                        }
                        //When new is smaller then last
                        else if (eingabe[i] < last)
                        {
                            last = eingabe[i];
                            i += 1;
                            //value += eingabe[i];
                            cntMultible = 1;
                        }
                        else
                        {
                            valid = false;
                            break;
                        }
                    }
                    //happens only for the first value 
                    else
                    {
                        //value += eingabe[i];
                        last = eingabe[i];
                        i++;
                    }
                }
                else
                {
                    valid = false;
                }
                // check after each loop if String is still valid.
                if (!valid) break;
            }
            return valid;
        }
        //Simply converts Rome to int. 
        //Does not check if the given string is Valid.
        //Use IsValidNumber() to Validate the string
        public static int ConvertRomeToInt(string userInput)
        {
            int value = 0;

            while (userInput.StartsWith("M"))
            {
                value += 1000; userInput = userInput.Substring(1);
            }
            if (userInput.StartsWith("CM"))
            {
                value += 900; userInput = userInput.Substring(2);
            }

            while (userInput.StartsWith("D"))
            {
                value += 500; userInput = userInput.Substring(1);
            }
            if (userInput.StartsWith("CD"))
            {
                value += 400; userInput = userInput.Substring(2);
            }

            while (userInput.StartsWith("C"))
            {
                value += 100; userInput = userInput.Substring(1);
            }
            if (userInput.StartsWith("XC"))
            {
                value += 90; userInput = userInput.Substring(2);
            }

            while (userInput.StartsWith("L"))
            {
                value += 50; userInput = userInput.Substring(1);
            }
            if (userInput.StartsWith("XL"))
            {
                value += 40; userInput = userInput.Substring(2);
            }

            while (userInput.StartsWith("X"))
            {
                value += 10; userInput = userInput.Substring(1);
            }
            if (userInput.StartsWith("IX"))
            {
                value += 9; userInput = userInput.Substring(2);
            }

            while (userInput.StartsWith("V"))
            {
                value += 5; userInput = userInput.Substring(1);
            }
            if (userInput.StartsWith("IV"))
            {
                value += 4; userInput = userInput.Substring(2);
            }

            while (userInput.StartsWith("I"))
            {
                value += 1; userInput = userInput.Substring(1);
            }
            return value;
        }
    }
}
