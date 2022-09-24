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

namespace CSharpMiscellaneousProjects
{
    public static class Remote
    {
        private static char selection = 'X';
        public static char Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        public static void GetSelection()
        {
            Console.WriteLine("Submit A to change your name and be greeted. Submit B to submit a word to count its letters.");
            selection = (char)Convert.ChangeType(Console.ReadLine(), typeof(char));
            Console.WriteLine(selection);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Remote.GetSelection();
            Console.WriteLine("What is your name?");
            Console.WriteLine("Type ENG for English, ARB for Arabic, SOM for Somali");
            Console.WriteLine(HelloMarhabaSalam.GreetMe(Console.ReadLine(), Console.ReadLine()));
            Console.WriteLine("Type a word to count its letters.");
            Console.WriteLine(CharacterCounter.CharacterCount(Console.ReadLine()));
            //SerializeToJSON.readTextVersion();
        }
    }
}