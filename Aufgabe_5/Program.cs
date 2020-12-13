﻿using System;

namespace Aufgabe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string url = GetUrlFromUser();
                if (IsValidURL(url))
                {
                    Console.WriteLine("Protokoll: {0}", GetProtokoll(url));
                    Console.WriteLine("Domäne: {0}", GetDomain(url));
                    Console.WriteLine("Pfad: {0}", GetPath(url));
                }
                else
                {
                    Console.WriteLine("Bitte einen gültigen Url eingeben !");
                }
            }
        }
        public static string GetUrlFromUser()
        {
            Console.Write("Bitte gegeb Sie ihre URL ein: ");
            return Console.ReadLine();
        }
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
                //skippes protocol and domain
                if (userInput[i] == '/')
                {
                    slaschCnt++;
                }
                //gets the path 
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
            //Domain only
            string patternOnlyDomain = @"^(https:\/\/www\.|http:\/\/www\.|https:\/\/|http:\/\/)[a-zA-Z0-9\-!_$]+\.[a-zA-Z]{2,5}$";
            //domain and Folders
            string patternWithPath = @"^(https:\/\/www\.|http:\/\/www\.|https:\/\/|http:\/\/)[a-zA-Z0-9\-!_$]+\.[a-zA-Z]{2,5}\/[a-zA-Z0-9]";
            return (System.Text.RegularExpressions.Regex.IsMatch(userInput, patternOnlyDomain) || System.Text.RegularExpressions.Regex.IsMatch(userInput, patternWithPath));
        }
    }
}
