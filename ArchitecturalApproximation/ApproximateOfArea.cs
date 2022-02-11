using System;


namespace CSharpMiscellaneousProjects.ArchitecturalApproximation
{
    class Program
    {
        public static void Main(string[] args)
        {
            double testApproximation = ApproximateArea(rLength: 150, rWidth: 75, cRadius: 25, tBase: 100, tHeight: 200);
            Console.Write($"The approximate area of your house is: {Decimal.Round((decimal)testApproximation,2)} meters");
        }
        public static double ApproximateArea(double rLength, double rWidth, double cRadius, double tBase, double tHeight)
        {
            return ((rLength * rWidth) + (Math.PI * Math.Pow(cRadius, 2)) + (0.5 * tBase * tHeight));
        }
    }
}
