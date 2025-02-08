using System;
using System.Collections.Generic;

namespace _2775
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            var howManyLiveThisRoom = new List<int>();

            for(int i = 0; i<testcase; i++)  //각 테스트 케이스 실행
            {
                int floorNumber = int.Parse(Console.ReadLine());
                int roomNumber = int.Parse(Console.ReadLine());
                float sum = 1;

                for (int j = 0; j <= floorNumber; j++)  //몇 명 사는지 구하기
                    sum *= (float)(roomNumber + j) / (j+1);    //n/1 -> n/1 * n+1/2 -> n/1 * n+1/2 * n+2/3 -> pre * 분자분모 각각+1

                howManyLiveThisRoom.Add((int)sum);
            }

            for(int i = 0; i<howManyLiveThisRoom.Count; i++)    //출력
                Console.WriteLine(howManyLiveThisRoom[i]);
        }
    }
}