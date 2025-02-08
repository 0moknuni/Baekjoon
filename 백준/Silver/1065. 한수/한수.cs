using System;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkAritSeque(int n)   //n이하의 한수 갯수 검사 함수
            {
                if (1 <= n && n < 100)    //일, 십의 자리 수는 모두 등차이니 한수임
                    return n;
                else if (100 <= n && n < 1000)  
                {
                    int count = 0;
                    for (int i = 100; i <= n; i++)
                        if ((i / 100 + i % 10) / 2f == (i / 10 % 10))    //a+c/2 == b 등차수열 식
                            count++;

                    return 99 + count;  //1~100까지의 한수 == 99
                }
                else if (n == 1000)
                    return checkAritSeque(999);
                else //그 외의 오류
                    return -1;
            }

            int result = checkAritSeque(int.Parse(Console.ReadLine()));  //검사할 수 입력
            Console.WriteLine(result);
        }
    }
}