using System;
using Xunit;

namespace Aufgabe_3
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                string url = Url.GetUrlFromUser();
                if (Url.IsValidURL(url))
                {
                    Console.WriteLine("Protokoll: {0}", Url.GetProtokoll(url));
                    Console.WriteLine("Domäne: {0}", Url.GetDomain(url));
                    Console.WriteLine("Pfad: {0}", Url.GetPath(url));
                }
                else
                {
                    Console.WriteLine("Bitte einen gültigen Url eingeben !");
                }
            }
        }
    }
    public class Test
    {
        [Theory]
        [InlineData("http:google.de", "http")]
        [InlineData("https:google.de", "https")]
        [InlineData("http://it-designers.de/karriere/", "http")]
        [InlineData("http://www.google.de", "http")]
        public void CheckProtokoll(string input, string expected)
        {
            Assert.Equal(expected, Url.GetProtokoll(input));
        }
        [Theory]
        [InlineData("http://it-designers.de/karriere/", "it-designers.de")]
        [InlineData("http://www.google.de", "www.google.de")]
        public void CheckHost(string input, string expected)
        {
            Assert.Equal(expected, Url.GetDomain(input));
        }
        [Theory]
        [InlineData("http://it-designers.de/karriere/", "/karriere/")]
        [InlineData("http://it-designers.de/karriere/job1", "/karriere/job1")]
        [InlineData("http://www.google.de", "")]
        public void CheckPath(string input, string expected)
        {
            Assert.Equal(expected, Url.GetPath(input));
        }
        [Theory]
        [InlineData("http://it-designers.de/karriere/", true)]
        [InlineData("http://it-designers.de/karriere/job1", true)]
        [InlineData("http://it-designers.de/karriere/job1/desciption", true)]
        [InlineData("http://www.google.de", true)]
        [InlineData("www.google.de", false)]
        [InlineData("asd", false)]
        public void CheckValidation(string input, bool expected)
        {
            Assert.Equal(expected, Url.IsValidURL(input));
        }
    };

    public static class Url
    {
        public static string GetUrlFromUser()
        {
            Console.Write("Bitte gegeb Sie ihre URL ein: ");
            return Console.ReadLine();
        }
        //Starts at the beginning an runs untill a : is hit
        public static string GetProtokoll(string userInput)
        {
            string protokoll = "";
            int i = 0;

            while (userInput[i] != ':')
            {
                protokoll += userInput[i];
                i++;
            }
            return protokoll;
        }
        public static string GetDomain(string userInput)
        {
            string domain = "";
            int i = 0;
            //skippes the protocol.
            while (userInput[i] != '/')
            {
                i++;
                if (userInput[i + 1] == '/')
                {
                    i += 3; break;
                }
            }
            //gets the domain
            while (userInput[i] != '/')
            {
                domain += userInput[i];
                i++;
                if (i == userInput.Length) break;
            }
            return domain;
        }
        public static string GetPath(string userInput)
        {
            string path = "";
            int i = 0;
            int slaschCnt = 0;

            while (i < userInput.Length)
            {
                //skippes the protocol and domain
                if (userInput[i] == '/')
                {
                    slaschCnt++;
                }

                if (slaschCnt >= 3)
                {
                    path += userInput[i];
                }
                i++;
            }
            return path;
        }
        public static bool IsValidURL(string userInput)
        {
            string patternOnlyDomain = @"^(https:\/\/www\.|http:\/\/www\.|https:\/\/|http:\/\/)[a-zA-Z0-9\-!_$]+\.[a-zA-Z]{2,5}$";
            string patternWithPath = @"^(https:\/\/www\.|http:\/\/www\.|https:\/\/|http:\/\/)[a-zA-Z0-9\-!_$]+\.[a-zA-Z]{2,5}\/[a-zA-Z0-9]";
            return (System.Text.RegularExpressions.Regex.IsMatch(userInput, patternOnlyDomain) || System.Text.RegularExpressions.Regex.IsMatch(userInput, patternWithPath));
        }
    }
}
