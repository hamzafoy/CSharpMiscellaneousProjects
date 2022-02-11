using System;


namespace CSharpMiscellaneousProjects_ArchitecturalApproximation
{
    class ArchitecturalCalculation
    {
        public static double ApproximateArea(double rLength, double rWidth, double cRadius, double tBase, double tHeight)
        {
            return ((rLength * rWidth) + (Math.PI * Math.Pow(cRadius, 2)) + (0.5 * tBase * tHeight));
        }
    }
}
