using System;

namespace _2609
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int _GCD;   //the Greatest Common Diviser

            Console.WriteLine(_GCD = GCD(nums[0], nums[1]));
            Console.WriteLine(nums[0] * nums[1] / _GCD);    // == LCM(nums[0], nums[1])
        }

        static private int GCD(int a, int b)
        {
            int tmp;
            while (b > 0)
            {
                tmp = a;
                a = b;
                b = tmp % b;
            }

            return a;
        }

        static private int LCM(int a, int b)
        {
            return (a*b) / GCD(a, b);
        }
    }
}
