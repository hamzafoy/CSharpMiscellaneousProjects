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
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.WriteLine("Type ENG for English, ARB for Arabic, SOM for Somali");
            Console.WriteLine(HelloMarhabaSalam.GreetMe(Console.ReadLine(), Console.ReadLine()));
            Console.WriteLine("Type a word to count its letters.");
            Console.WriteLine(CharacterCounter.CharacterCount(Console.ReadLine()));
            //SerializeToJSON.readTextVersion();
        }
    }
}