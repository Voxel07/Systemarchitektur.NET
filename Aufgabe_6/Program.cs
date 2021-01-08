using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aufgabe_6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie den Text ein der \"Verschlüsselt werden soll\": ");
            var userInput = Console.ReadLine();
            Console.WriteLine("Nach dem hash: {0}",
                HashTheString(TransformToUpperCase(ReplaceSpecialChars(userInput))));
        }

        private static string ReplaceSpecialChars(string replace)
        {
            var map = new Dictionary<char, string>() {
                { 'ä', "AE" },
                { 'ö', "OE" },
                { 'ü', "UE" },
                { 'Ä', "AE" },
                { 'Ö', "OE" },
                { 'Ü', "UE" },
                { 'ß', "SS" }
            };

            return replace.Aggregate(
                 new StringBuilder(),
                 (normalizedString, foundChar) => map.TryGetValue(foundChar, out var replacementChar) ? normalizedString.Append(replacementChar) : normalizedString.Append(foundChar)
             ).ToString();
        }

        private static string TransformToUpperCase(string transform)
        {
            var upperCaseString = new StringBuilder();
            //StringBuilder upperCaseString = new StringBuilder(transform.Length); -> wäre das eeffizienter ?

            foreach (var t in transform)
                if (t >= 'a' && t <= 'z')
                    upperCaseString.Append(Convert.ToChar(t - 32));
                else
                    upperCaseString.Append(t);

            return upperCaseString.ToString();
        }

        private static string HashTheString(string hashed)
        {
            var hashedString = new StringBuilder();

            foreach (var t in hashed)
                if (t >= 'A' && t <= 'Z')
                    hashedString.Append(t <= 77 ? Convert.ToChar(t + 13) : Convert.ToChar(t - 13));

                else
                    hashedString.Append(t);

            return hashedString.ToString();
        }
    }
}