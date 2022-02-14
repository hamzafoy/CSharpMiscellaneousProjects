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

namespace CSharpMiscellaneousProjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //MoneyMaker.FindCoinCountWithinTotal();
            double testApproximation = ArchitecturalCalculation.ApproximateArea(rLength: 150, rWidth: 75, cRadius: 25, tBase: 100, tHeight: 200);
            Console.WriteLine($"The approximate area of your house is: {Decimal.Round((decimal)testApproximation, 2)} meters");
            Console.WriteLine(GameConsole.scissor1);
            Console.WriteLine(GameConsole.scissor2);
            Console.WriteLine(GameConsole.scissor3);
        }
    }
}