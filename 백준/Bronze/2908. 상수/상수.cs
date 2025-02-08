using System;

namespace _2908
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNum = Console.ReadLine().Split(" ");  //케이스 입력받기
            int[] reverseNum = new int[2];

            for(int i = 0; i < inputNum.Length; i++)    //케이스 수만큼 reverse
            {
                string dummy = ""; //reverse한 수를 저장해둘 변수
                for(int j = inputNum[i].Length - 1; j >= 0; j--)    //숫자 자리수만큼 역 반복
                {
                    dummy += (inputNum[i])[j];  //string[]->string->char형태 순으로 쪼개어 저장
                }
                reverseNum[i] = int.Parse(dummy);    //더미 값 복사
            }

            Console.WriteLine(reverseNum[0] > reverseNum[1] ?reverseNum[0] :reverseNum[1]); //최대 값 출력
        }
    }
}
