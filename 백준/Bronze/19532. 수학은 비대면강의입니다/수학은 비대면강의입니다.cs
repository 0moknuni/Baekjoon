using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19532
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a, b, c, d, e, f = 0, 1, 2, 3, 4, 5
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool solution1 = false, solution2 = false;
            for (int x = -999; x <= 999; x++)
            {
                for (int y = -999; y <= 999; y++)
                {
                    solution1 = inputArr[0] * x + inputArr[1] * y == inputArr[2];
                    solution2 = inputArr[3] * x + inputArr[4] * y == inputArr[5];

                    if (solution1 && solution2)
                    {
                        Console.WriteLine(x + " " + y);
                        return;
                    }

                    solution1 = false;  solution2 = false;
                }
            }
        }
    }
}