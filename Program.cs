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
using CSharpMiscellaneousProjects_HelloInManyLanguages;
using CSharpMiscellaneousProjects_FileHandler;
using CSharpMiscellaneousProjects_DotNetExamples;

namespace CSharpMiscellaneousProjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            Console.WriteLine("Type ENG for English, ARB for Arabic, SOM for Somali");
            //string lang = Console.ReadLine();
            Console.WriteLine(HelloMarhabaSalam.GreetMe(Console.ReadLine(), Console.ReadLine()));
            //SerializeToJSON.readTextVersion();
        }
    }
}