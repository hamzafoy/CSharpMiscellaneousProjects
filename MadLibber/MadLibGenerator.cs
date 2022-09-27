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
    * PSEUDOCODE WHITEBOARD
    *   MadLibMachine
    *       Initialize madlibStory to contain a List of strings
    *       
    *       Display "Enter a noun in 1st prompt, verb in 2nd, adverb in 3rd, & an adjective in the 4th"
    *       Prompt for noun
    *       Prompt for verb
    *       Prompt for adverb
    *       Prompt for adjective
    *       
    *       Add noun to madlibStory List<string>
    *       Add verb to madlibStory List<string>
    *       Add adverb to madlibStory List<string>
    *       Add adjective to madlibStory List<string>
    *       
    *       Combine madlibStory List<string> into a single string.
    *       
    *       Display madlibStory in console.
    */
    public class MadLibMachine
    {
        private static List<string> madlibStory = new()
        {
            "A "
        };

        public static List<string> MadlibStory
        {
            get { return madlibStory; }
            set { madlibStory = value; }
        }

        public static void DevelopMadLib()
        {
            Console.WriteLine("Enter a noun in 1st prompt, verb in 2nd, adverb in 3rd, & an adjective in the 4th");
            string[] arrayOfInputs = { Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
            MadlibStory.Add($"{arrayOfInputs[3]} ");
            MadlibStory.Add($"{arrayOfInputs[0]} ");
            MadlibStory.Add($"{arrayOfInputs[1]}s ");
            MadlibStory.Add($"{arrayOfInputs[2]}.\n");
            Console.WriteLine("\nThe story goes. . .");
            Console.WriteLine(String.Join("", MadlibStory));
        }
    }
}
