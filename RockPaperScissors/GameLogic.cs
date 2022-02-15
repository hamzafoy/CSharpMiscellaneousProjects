using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_RockPaperScissors
{
    public class GameConsole
    {
        public static List<string> scissor = new List<string>()
        {
            "O O",
            " X ",
            "/ \\"
        };

        public static List<string> paper = new List<string>()
        {
            "___",
            "| |",
            "---"
        };

        public static List<string> rock = new List<string>()
        {
            " n ",
            "< >",
            " u "
        };

        public static List<KeyValuePair<string, string>> gameMenu = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("R", "rock"),
            new KeyValuePair<string, string>("S", "scissor"),
            new KeyValuePair<string, string>("P", "paper"),
            new KeyValuePair<string, string>("Q", "quit")
        };
        
        public static void RunConsole()
        {
            foreach(KeyValuePair<string, string> option in gameMenu)
            {
                Console.WriteLine($"{option.Key} {option.Value}");
            }
        }
    }

}
