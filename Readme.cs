/*
 * 
 * This repository is composed of multiple subdirectories storing miscellaneous, smaller codebases
 * that have been developed as I become more familiar with the C# language.
 * 
 */

using System;
using CSharpMiscellaneousProjects_ArchitecturalApproximation;

namespace CSharpMiscellaneousProjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double testApproximation = ArchitecturalCalculation.ApproximateArea(rLength: 150, rWidth: 75, cRadius: 25, tBase: 100, tHeight: 200);
            Console.Write($"The approximate area of your house is: {Decimal.Round((decimal)testApproximation, 2)} meters");
        }
    }
}