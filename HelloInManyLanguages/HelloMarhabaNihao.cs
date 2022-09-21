using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_HelloInManyLanguages
{
    public class HelloMarhabaSalam
    {
        public static Dictionary<string, List<string>> greetingDictionary = new Dictionary<string, List<string>>()
        {
            {"ARB", new List<string>{"Marhaba", "kayfa", "haluk"} },
            {"ENG", new List<string>{"Hello", "how", "are", "you"} },
            {"SOM", new List<string>{"Salam", "iska", "warran"} }
        };
        public static string GreetMe(string name, string languageAbbreviation)
        {
            switch (languageAbbreviation)
            {
                case "ARB":
                    greetingDictionary["ARB"].Insert(1, name);
                    return String.Join(" ", greetingDictionary["ARB"]);
                case "ENG":
                    greetingDictionary["ENG"].Insert(1, name);
                    return String.Join(" ", greetingDictionary["ENG"]);
                case "SOM":
                    greetingDictionary["SOM"].Insert(1, name);
                    return String.Join(" ", greetingDictionary["SOM"]);
                default:
                    return $"Dunno what language you speak mate!";
            }
        }
    }
}
