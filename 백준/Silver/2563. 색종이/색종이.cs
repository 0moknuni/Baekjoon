using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2563
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] canvas = new int[100, 100];


            int count = int.Parse(Console.ReadLine());
            int[] input= new int[2];

            for (; count > 0; count--)
            {
                input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Cover(canvas, input);
            }

            Console.WriteLine(CalAllArea(canvas));
        }

        static void Cover(int[,] canvas, int[] input)
        {
            for (int x = input[0]; x < input[0] + 10; x++)
            {
                for (int y = input[1]; y < input[1] + 10; y++)
                {
                    canvas[x, y]++;
                }
            }
        }

        static int CalAllArea(int[,] canvas)
        {
            int allArea = 0;

            foreach (var area in canvas)
            {
                if (area > 0)
                    allArea++;
            }

            return allArea;
        }
    }
}