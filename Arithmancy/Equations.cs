using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMiscellaneousProjects_Arithmancy
{
    public class ArithmeticOperations
    {
        public static class Calculations
        {
            public static double[] RectangularRoomArea(int firstvalue, int secondvalue)
            {
                return new[]
                {
                    firstvalue * secondvalue, //measure in feet
                    (firstvalue + secondvalue) * 0.09290304, //measure in meters
                };
            }
        }
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

            public static void GetUserSelectionForBasicMath()
            {
                Console.WriteLine("Enter two numbers to execute basic math on them");
                int firstinput = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));
                int secondinput = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));
                ActOnSelection(firstinput, secondinput, 'a');
            }

            public static void GetUserSelectionForRectangularArea()
            {
                Console.WriteLine("Enter length & width of a rectangular to figure area");
                int length = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));
                int width = (int)Convert.ChangeType(Console.ReadLine(), typeof(int));
                ActOnSelection(length, width, 'b');
            }

            public static void ActOnSelection(int first, int second, char option)
            {
                switch (option)
                {
                    case 'a':
                        string[] mathoutputs =
                        {
                            $"{first} + {second} = {Arithmetics.Addition((int)first,(int)second)}",
                            $"{first} - {second} = {Arithmetics.Subtraction((int)first,(int)second)}",
                            $"{first} times {second} = {Arithmetics.Multiplication((int)first,(int)second)}",
                            $"{first} divided by {second} = {Arithmetics.Division((int)first,(int)second)}"
                        };
                        foreach (string x in mathoutputs)
                        {
                            Console.WriteLine(x);
                        };
                        break;
                    case 'b':
                        string[] areaoutputs =
                        {
                            $"You entered dimensions of {first} ft by {second} ft.",
                            $"The area is {Calculations.RectangularRoomArea(first,second)[0]} sq ft.",
                            $"Or {Calculations.RectangularRoomArea(first,second)[1]} sq meters."
                        };
                        foreach (string x in areaoutputs)
                        {
                            Console.WriteLine(x);
                        }
                        break;
                }
                
            }
        }
    }
}
