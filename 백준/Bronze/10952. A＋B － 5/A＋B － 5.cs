using System;
using System.Collections.Generic;
using System.Linq;

namespace _10952
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sumList = new List<int>();
            int[] inputArr = new int[2] {-1, -1};

            while (inputArr[0] != 0 && inputArr[1] != 0)    //입력
            {
                inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                sumList.Add(inputArr[0] + inputArr[1]);
            }

            sumList.RemoveAt(sumList.Count()-1);    //종료 키워드 0, 0의 합 제거

            foreach (int num in sumList)    //출력
                Console.WriteLine(num);
        }
    }
}