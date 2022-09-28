using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_HelloInManyLanguages
{
    /*
    * Create a program that returns a greeting in the appropriate language
    * chosen by the user at the initialization of the program and with the
    * user's name concatenated.
    *
    * INPUTS: Abbreviation of Language, Username
    * PROCESSES: Searching and returning the correct greeting, injecting username into the greeting
    * OUTPUTS: Correct language's greeting with username appropriately placed
    * 
    * TEST DRIVEN DEV -
    *   Inputs: Hamza, ARB
    *   Expected Result: Marhaba Hamza, kayfa haluk.
    *   Actual Result: Marhaba Hamza, kayfa haluk.
    *   
    * PSEUDOCODE WHITEBOARD
    *   HelloMarhabaSalam.GreetMe(languageAbbreviation, name)
    *       Execute Method GreetMe with provided parameters
    *       
    *       Search Dictionary of greetings with the languageAbbreviation
    *       Insert name into the resulting array of greeting
    *       Join together the string array to generate a full greeting string
    *       
    *       Display greeting in console.
    */
    public class HelloMarhabaSalam
    {

        private static Dictionary<string, List<string>> greetingDictionary = new()
        {
            { "ARB", new List<string> { "Marhaba ", ", ", "kayfa ", "haluk." } },
            { "ENG", new List<string> { "Hello ", ", ", "how ", "are ", "you." } },
            { "SOM", new List<string> { "Salam ", ", ", "iska ", "warran." } }
        };

        private static Dictionary<string, int> wordCountedInDict = new()
        {
            { "ARB", greetingDictionary["ARB"].Count },
            { "ENG", greetingDictionary["ENG"].Count },
            { "SOM", greetingDictionary["SOM"].Count }
        };

        public static Dictionary<string, int> wordCount
        {
            get { return wordCountedInDict; }
            set { wordCountedInDict = value; }
        }

        public static Dictionary<string, List<string>> greeting
        {
            get { return greetingDictionary; }
            set { greetingDictionary = value; }
        }

        public static string GreetMe(string languageAbbreviation, string name = null)
        {
            switch (languageAbbreviation != null)
            {
                case true:
                    if (name != null && wordCount[languageAbbreviation] == greetingDictionary[languageAbbreviation].Count)
                    {
                        greetingDictionary[languageAbbreviation].Insert(1, name);
                        return String.Join("", greetingDictionary[languageAbbreviation]);
                    } else
                    {
                        return String.Join("", greetingDictionary[languageAbbreviation]);
                    }
                default:
                    return $"Dunno what language you speak mate!";
            }
        }
    }
}
