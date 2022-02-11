using System;

namespace CSharpMiscellaneousProjects_MoneyMaker
{
    class MoneyMaker
    {
        public static string FindCoinCountWithinTotal()
        {
            int quarter = 25, dime = 10, nickel = 5;
            Console.WriteLine("Interested in learning how many of each coin\nyou need to reach a certain amount?\nLook no further!");
            Console.WriteLine("Please give an amount to convert: ");
            string userAnswer = Console.ReadLine();
            double answerAsADouble = Math.Floor(Convert.ToDouble(userAnswer));
            Console.WriteLine($"{answerAsADouble} cents is equal to...");
            double quarters = Math.Floor(answerAsADouble / quarter);
            double remainingAmount = answerAsADouble % quarter;
            double dimes = Math.Floor(remainingAmount / dime);
            remainingAmount %= dime;
            double nickels = Math.Floor(remainingAmount / nickel);
            remainingAmount %= nickel;
            string returnedValue = $"Quarters: {quarters}\nDimes: {dimes}\nNickels: {nickels}\nPennies: {remainingAmount}";
            return returnedValue;
        }
    }
}