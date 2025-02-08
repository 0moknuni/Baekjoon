using System;

namespace _1712
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[3];
            int fixedCost;
            int variableCost;
            int price;

            input = Console.ReadLine().Split();
            fixedCost = int.Parse(input[0]);    variableCost = int.Parse(input[1]);
            price = int.Parse(input[2]);

            Console.WriteLine(CalBreakEvenPoint(fixedCost, variableCost, price)); 
        }

        static int CalBreakEvenPoint(int fixedCost, int variableCost, int price)
        {
            return (price - variableCost > 0) ? fixedCost / (price - variableCost) + 1 : -1;
        }
    }
}
