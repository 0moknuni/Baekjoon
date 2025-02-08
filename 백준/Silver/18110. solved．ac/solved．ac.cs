using System;
using System.Collections.Generic;
using System.Linq;

namespace _18110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfInput = int.Parse(Console.ReadLine());
            
            if (numOfInput == 0)  //난이도 입력이 없을 시
            {
                int result = 0;
                Console.WriteLine(result);
                return;
            }

            //난이도 입력이 있을 시
            List<int> input = new List<int>();
            for (int i = 0; i < numOfInput; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }

            input.Sort();   //정렬


            //절사평균
            int howManySideTrim = (int)Math.Round(numOfInput * 0.15, MidpointRounding.AwayFromZero);
            input.RemoveRange(0, howManySideTrim);
            input.RemoveRange(input.Count - howManySideTrim, howManySideTrim);

            //출력
            Console.WriteLine(Math.Round(input.Average(), MidpointRounding.AwayFromZero));
        }
    }
}