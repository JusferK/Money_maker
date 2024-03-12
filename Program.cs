using System;

namespace moneymaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value you would like to convert: ");
            String totalToString = Console.ReadLine();
            Console.WriteLine($"{totalToString} cents is equal to...");
            double total = Convert.ToDouble(totalToString);
            total = Math.Floor(total);

            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(total / goldValue);
            double remainingAmount = total % goldValue;
            double silverCoins = Math.Floor(remainingAmount / silverValue);
            remainingAmount %= silverValue;
            double bronzeCoins = remainingAmount - (remainingAmount - 1);

            Console.WriteLine($"Gold coins {goldCoins} \nsilver coins {silverCoins} \nBronze coins: {bronzeCoins}");
        }
    }
}