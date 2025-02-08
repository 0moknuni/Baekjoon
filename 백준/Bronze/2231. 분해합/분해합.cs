using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int sum = 0, result = 0;
            int digitCount;
            StringBuilder sb = new StringBuilder();

            for (int testNum = 0; testNum <= inputNum; testNum++)    //테스트 수 증가
            {
                sb.Append(testNum);
                for (int i = 0; i <= sb.Length -1; i++)    //각 자릿수 더하기
                    sum += int.Parse(sb[i].ToString());

                sum += testNum; //본인 값 더하기

                if (sum == inputNum)
                {//결과값 저장
                    result = testNum;
                    break;  //최소값 구할 시 바로 종료
                }

                sum = 0;    //초기화
                sb.Clear();
            }

            Console.WriteLine(result);
        }
    }
}
