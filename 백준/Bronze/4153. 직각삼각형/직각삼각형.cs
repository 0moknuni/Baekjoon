using System;

namespace _4153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputCase = new int[3];

            while (true)
            {
                //입력 및 정렬
                inputCase = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Array.Sort(inputCase);

                //반복 판단
                if (inputCase[0] == 0)
                    break;

                //결과 출력
                if (Math.Pow(inputCase[2], 2) == Math.Pow(inputCase[0], 2) + Math.Pow(inputCase[1], 2))
                    Console.WriteLine("right");
                else
                    Console.WriteLine("wrong");

            }

            return;
        }
    }
}