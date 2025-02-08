using System;

namespace _2869
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //a = 0, b = 1, v = 2
            if (input[2] - input[0] == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                int beforeLastDay = (input[2] - input[0]) / (input[0] - input[1]);
                if ((input[2] - input[0]) % (input[0] - input[1]) != 0)
                    beforeLastDay++;

                Console.WriteLine(beforeLastDay == 0 ? 2 : beforeLastDay + 1);
            }
        }
    }
}