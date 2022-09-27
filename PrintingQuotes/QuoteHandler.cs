using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CSharpMiscellaneousProjects_PrintingQuotes
{
    
    public class QuotesHandler
    {
        public static class Remote
        {
            private static char selection = 'X';
            public static char Selection
            {
                get { return selection; }
                set { selection = Char.ToUpper(value); }
            }

            public static void GetUserSelection()
            {
                var userinput = (char)Convert.ChangeType(Console.ReadLine(), typeof(char));
                ActOnSelection(userinput);
            }

            public static void ActOnSelection(char selection)
            {
                switch (selection)
                {
                    case 'A':
                        Console.WriteLine("Running Test A");
                        break;
                    case 'B':
                        Console.WriteLine("Running Test B");
                        break;
                    default:
                        Console.WriteLine("Terminal Default");
                        break;
                }
            }

            public static void QuoteReader()
            {

            }

        }
    }
}
