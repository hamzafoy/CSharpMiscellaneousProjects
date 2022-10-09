using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_Arithmancy
{
    public class ArithmeticOperations
    {
        public static class Arithmetics
        {
            public static void Addition(int firstvalue, int secondvalue)
            {
                Console.WriteLine($"{firstvalue} + {secondvalue} equals {firstvalue + secondvalue}");
            }
        }
        public static class Remote
        {
            private static char selection = 'X';
            public static char Selection
            {
                get { return selection; }
                set { selection = Char.ToUpper(value); }
            }


        }
    }
}
