using System;
using System.Collections.Generic;

namespace _4673
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcD(int x)
            {
                if(x >= 10)
                {
                    return x % 10 + funcD(x / 10);
                }
                else //x < 10
                {
                    return x;
                }
            }   //d함수

            List<int> allNumberList = new List<int>();
            List<int> dNumberList = new List<int>();

            for(int i = 1; i <= 10000; i++)  //각 리스트 초기화
                allNumberList.Add(i);
            for(int i = 1; i <= 10000; i++)
                dNumberList.Add(i + funcD(i));

            dNumberList.Sort(); //정렬

            for(int i = 1; i<=10000; i++)   //셀프넘버 분류, 출력
            {
                if(!dNumberList.Contains(i))    
                    Console.WriteLine(i);
            }
        }
    }
}
