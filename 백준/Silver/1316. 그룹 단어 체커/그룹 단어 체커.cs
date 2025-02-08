using System;
using System.Collections.Generic;

namespace _1316
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = 0;
            List<string> input = new List<string>();
            int groupWord = 0;

            testCase = int.Parse(Console.ReadLine());   //testCase와 단어 입력받기
            for (int j = 0; j < testCase; j++)
                input.Add(Console.ReadLine());

            foreach(var word in input)  //단어 추출
            {
                int count = 0;
                foreach (var alpha in word)
                {
                    if (count != word.Length - 1)    //알파벳이 끝자리가 아니면
                    {
                        if (word.IndexOf(alpha, count + 1) != -1)  //단어내에 알파벳이 더 있을 시
                        {
                            if (word.IndexOf(alpha, count + 1) - word.IndexOf(alpha, count) != 1) //그룹문자가 아닐시
                                break;  //바로 다음 단어 검사
                        }
                        count++;
                    }
                    else if (count == word.Length - 1)
                        groupWord++;
                }
            }
            Console.WriteLine(groupWord);
        }
    }
}
