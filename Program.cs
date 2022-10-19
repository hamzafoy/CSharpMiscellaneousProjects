/*
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
using CSharpMiscellaneousProjects_PrintingQuotes;
using CSharpMiscellaneousProjects_MadLibber;
using CSharpMiscellaneousProjects_Arithmancy;

namespace CSharpMiscellaneousProjects
{
    public static class Remote
    {
        private static string[] prompts =
        {
            "Type A to receive a greeting",
            "Type B to submit a word for its letters to be counted",
            "Type C to access the menu for reading and storing quotes",
            "Type D to access the Mad Lib Generator",
            "Type Q to exit the program\n"
        };
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
                var splitname = name.ToCharArray();
                if (name != "")
                {
                    splitname[0] = Char.ToUpper(splitname[0]);
                }
                string fixedname = String.Join("", splitname);
                Username = name != "" ? fixedname : "Guest";
            }
            if(Language == null)
            {
                Console.WriteLine("\nSelect your language:");
                Console.WriteLine("ENG for English, ARB for Arabic, SOM for Somali\n");
                var lang = Console.ReadLine().ToUpper();
                Language = lang != "" ? lang : "ENG";
            }
            Console.WriteLine("\n");
            foreach (string x in prompts)
            {
                Console.WriteLine(x);
            }
            var userinput = Console.ReadLine().ToUpper();
            selection = userinput != "" ? (char)Convert.ChangeType(userinput, typeof(char)) : '!';
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
                case 'C':
                    QuotesHandler.DatabaseRemote.CreateDatabase();
                    Console.Write("Type A to read list of saved quotes or Type B to add a quote: ");
                    QuotesHandler.Remote.GetUserSelection();
                    break;
                case 'D':
                    MadLibMachine.DevelopMadLib();
                    break;
                case 'E':
                    ArithmeticOperations.Remote.GetUserSelection();
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