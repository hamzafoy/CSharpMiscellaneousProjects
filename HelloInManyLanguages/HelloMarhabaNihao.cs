using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_HelloInManyLanguages
{
    public class HelloMarhabaSalam
    {
        private static Dictionary<string, List<string>> greetingDictionary = new()
        {
            { "ARB", new List<string> { "Marhaba ", ", ", "kayfa ", "haluk." } },
            { "ENG", new List<string> { "Hello ", ", ", "how ", "are ", "you." } },
            { "SOM", new List<string> { "Salam ", ", ", "iska ", "warran." } }
        };

        public static Dictionary<string, List<string>> greeting
        {
            get { return greetingDictionary; }
            set { greetingDictionary = value; }
        }

        public static string GreetMe(string name, string languageAbbreviation)
        {
            switch (languageAbbreviation)
            {
                case "ARB":
                    greetingDictionary[languageAbbreviation].Insert(1, name);
                    return String.Join("", greetingDictionary["ARB"]);
                case "ENG":
                    greetingDictionary[languageAbbreviation].Insert(1, name);
                    return String.Join("", greetingDictionary["ENG"]);
                case "SOM":
                    greetingDictionary[languageAbbreviation].Insert(1, name);
                    return String.Join("", greetingDictionary["SOM"]);
                default:
                    return $"Dunno what language you speak mate!";
            }
        }
    }
}
