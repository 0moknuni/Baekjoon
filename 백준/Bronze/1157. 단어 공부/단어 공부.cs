using System;

namespace _1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] alphabetCount = new int[26]; //a~z == index[0~25], 기본으로 int배열 0으로 초기화됨
            string word = Console.ReadLine();
            int maxFrequency = 0;
            int maxIndex = -1;
            int count = 0;

            word = word.ToUpper();  //대문자로 통일

            foreach (char alpha in word)    //등장빈도별 1추가
                alphabetCount[alpha - 'A']++;

            for(int i = 0; i < alphabetCount.Length; i++)   //최대 빈도 값, 인덱스 찾기
            {
                if(maxFrequency < alphabetCount[i])
                {
                    maxFrequency = alphabetCount[i];
                    maxIndex = i;
                }
            }

            foreach (int item in alphabetCount) //최대 빈도 알파벳이 몇 개인지 검사
                if (alphabetCount[maxIndex] == item)
                    count++;

            if(count == 1)  //출력
                Console.WriteLine((char)(maxIndex + 'A'));
            else
                Console.WriteLine("?");
        }
    }
}