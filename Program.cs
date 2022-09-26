﻿/*
 * 
 * This repository is composed of multiple subdirectories storing miscellaneous, smaller codebases
 * that have been developed as I become more familiar with the C# language.
 * 
 */

using System;
using System.Text;
using CSharpMiscellaneousProjects_ArchitecturalApproximation;
using CSharpMiscellaneousProjects_MoneyMaker;
using CSharpMiscellaneousProjects_RockPaperScissors;
using CSharpMiscellaneousProjects_FileHandler;
using CSharpMiscellaneousProjects_DotNetExamples;
using CSharpMiscellaneousProjects_HelloInManyLanguages;
using CSharpMiscellaneousProjects_NumberOfCharacters;

namespace CSharpMiscellaneousProjects
{
    public static class Remote
    {
        private static string username;

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }

        private static string language;

        public static string Language
        {
            get { return language; }
            set { language = value; }
        }

        private static char selection = 'X';
        public static char Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        public static void GetUserSelection()
        {
            if(Username == null)
            {
                Console.Write("What is your name? ");
                var name = Console.ReadLine();
                Username = name != "" ? name : "Guest";
            }
            if(Language == null)
            {
                Console.WriteLine("Select your language:");
                Console.WriteLine("ENG for English, ARB for Arabic, SOM for Somali");
                var lang = Console.ReadLine();
                Language = lang != "" ? lang : "ENG";
            }
            Console.WriteLine("Submit A to receive a greeting. Submit B to submit a word to count its letters. Submit Q to exit program.");
            var userinput = Console.ReadLine();
            selection = userinput != "" ? (char)Convert.ChangeType(userinput, typeof(char)) : '!';
            //Console.WriteLine(selection);
            ActOnSelection(Selection);
        }

        public static void ActOnSelection(char selection)
        {
            switch (selection)
            {
                case 'A':
                    Console.WriteLine($"{HelloMarhabaSalam.GreetMe(Remote.Language, Remote.Username)}\n");
                    break;
                case 'B':
                    Console.Write("Type a word to count its letters: ");
                    Console.WriteLine($"{CharacterCounter.CharacterCount(Console.ReadLine())}");
                    break;
                case 'Q':
                    Console.WriteLine("Program closing. . ,");
                    break;
                case '!':
                    Console.WriteLine("You must input a single letter, not leave this blank!\n");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            while(Remote.Selection != 'Q')
            {
                Remote.GetUserSelection();
            }
        }
    }
}