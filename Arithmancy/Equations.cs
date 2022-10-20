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
            public static int Addition(int firstvalue, int secondvalue)
            {
                return firstvalue + secondvalue;
            }

            public static int Subtraction(int firstvalue, int secondvalue)
            {
                return firstvalue - secondvalue;
            }

            public static int Multiplication(int firstvalue, int secondvalue)
            {
                return firstvalue * secondvalue;
            }

            public static int Division(int firstvalue, int secondvalue)
            {
                return firstvalue / secondvalue;
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

            private static int firstvalue;

            public static int FirstValue
            {
                get { return firstvalue; }
                set { firstvalue = value; }
            }

            private static int secondvalue;

            public static int SecondValue
            {
                get { return secondvalue; }
                set { secondvalue = value; }
            }

            public static void GetUserSelection()
            {
                Console.WriteLine("Enter two numbers to execute basic math on them");
                int firstinput = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));
                int secondinput = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));
                ActOnSelection(firstinput, secondinput);
            }

            public static void ActOnSelection(int first, int second)
            {
                string[] mathoutputs =
                {
                    $"{first} + {second} = {(int)first + (int)second}",
                    $"{first} - {second} = {(int)first - (int)second}",
                    $"{first} times {second} = {(int)first * (int)second}",
                    $"{first} divided by {second} = {(int)first / (int)second}"
                };
                foreach (string x in mathoutputs)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
