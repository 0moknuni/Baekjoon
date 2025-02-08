using System;
using System.Collections.Generic;

namespace _2675
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());

            List<int> repeat = new List<int>(); //각 테스트별 값을 담을 변수
            List<string> words = new List<string>();

            for (int i = 0; i < testCase; i++)   //testcase만큼 반복
            {
                string[] input; //[0] = reapeat, [1] = word
                input = Console.ReadLine().Split(" ");  //테스트 케이스 값 입력, 초기화
                repeat.Add(int.Parse(input[0]));
                words.Add(input[1]);
            }

            for (int i = 0; i < testCase; i++)   //출력
            {
                foreach(char alpha in words[i])
                    for(int j = 0; j< repeat[i]; j++)
                        Console.Write(alpha);

                Console.WriteLine();
            }
        }
    }
}
