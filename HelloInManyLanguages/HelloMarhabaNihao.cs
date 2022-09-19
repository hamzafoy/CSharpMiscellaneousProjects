using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_HelloInManyLanguages
{
    public class HelloMarhabaSalam
    {
        public static Dictionary<string, string> greetingDictionary = new Dictionary<string, string>()
        {
            {"ARB", "Marhaban Kayfa haluk?"},
            {"ENG", "Hello how are you?"},
            {"SOM", "Salam iska warran?"}
        };
        public static string GreetMe(string name, string languageAbbreviation)
        {
            switch (languageAbbreviation)
            {
                case "ARB":
                    return greetingDictionary["ARB"];
                case "ENG":
                    return greetingDictionary["ENG"];
                case "SOM":
                    return greetingDictionary["SOM"];
                default:
                    return $"Dunno what language you speak mate!";
            }
        }
    }
}
