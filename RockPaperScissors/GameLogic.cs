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
        
        public static void PrintPick()
        {
            foreach (string item in scissor)
            {
                Console.WriteLine(item);
            }
        }
    }

}
