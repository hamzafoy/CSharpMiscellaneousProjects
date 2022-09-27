using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_MadLibber
{
    /*
    * Create a simple mad-lib program that prompts for a noun, verb, adverb, &
    * an adjective & injects those into blank spaces in a pre-generated story.
    *
    * INPUTS: Noun, Verb, Adverb, Adjective
    * PROCESSES: Injection of input into blank spaces in story
    * OUTPUTS: Fully formed story complete with filled in noun, verb, adverb, adjective
    * 
    * TEST DRIVEN DEV -
    *   Inputs: toy, run, slowly, beautiful
    *   Expected Result: A beautiful toy runs slowly.
    *   Actual Result: A beautiful toy runs slowly.
    * 
    */
    public class MadLibMachine
    {
        private static List<string> madlib = new()
        {
            "A "
        };

        public static List<string> Madlib
        {
            get { return madlib; }
            set { madlib = value; }
        }

        public static void DevelopMadLib()
        {
            Console.WriteLine("Enter a noun in 1st prompt, verb in 2nd, adverb in 3rd, & an adjective in the 4th");
            string[] arrayOfInputs = { Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
            Madlib.Add($"{arrayOfInputs[3]} ");
            Madlib.Add($"{arrayOfInputs[0]} ");
            Madlib.Add($"{arrayOfInputs[1]}s ");
            Madlib.Add($"{arrayOfInputs[2]}.\n");
            Console.WriteLine("\nThe story goes. . .");
            Console.WriteLine(String.Join("", Madlib));
        }
    }
}
