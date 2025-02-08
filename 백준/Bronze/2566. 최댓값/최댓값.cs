using System;

namespace _2566
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] inputArr = new int[9,9];
            int[] tmpArr = new int[9];
            int max = -1;
            int[] maxIndex = new int[2];

            for (int i = 0; i < 9; i++)    //Input
            {
                tmpArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < 9; j++)
                {
                    inputArr[i, j] = tmpArr[j];
                }
            }

            for (int i = 0; i < 9; i++)    //FindMax
            {
                for (int j = 0; j < 9; j++)
                {
                    if (inputArr[i, j] > max)
                    {
                        max = inputArr[i, j];
                        maxIndex[0] = i; maxIndex[1] = j;
                    }
                }
            }

            //Output
            //출력은 인덱스 위치 + 1
            Console.WriteLine(max); 
            Console.WriteLine((maxIndex[0]+1) + " " + (maxIndex[1]+1));
        }
    }
}
