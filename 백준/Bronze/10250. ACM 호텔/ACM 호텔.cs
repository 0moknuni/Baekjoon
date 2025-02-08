using System;
using System.Collections.Generic;

namespace _10250
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<int[]> input = new List<int[]>(); //input<int[]> -> int[h, w, n]
            int numOfRoom, floorOfRoom;

            for(int i = 0; i <testCase; i++)    //testCase만큼 반복          
                input.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); //케이스별 입력

            for (int i = 0; i < testCase; i++)  //출력
            {            
                floorOfRoom = input[i][2] % input[i][0]; //손님 % 층
                floorOfRoom = floorOfRoom == 0 ? input[i][0] : floorOfRoom; //꼭대기층(0)일 시 0대신 h로 초기화

                if (input[i][0] < input[i][2])
                {
                    numOfRoom = input[i][2] / input[i][0];
                    numOfRoom = input[i][2] % input[i][0] == 0 ?numOfRoom :++numOfRoom;
                }
                else
                    numOfRoom = 1;

                Console.WriteLine(floorOfRoom + (numOfRoom <= 9 ? "0" + numOfRoom : "" + numOfRoom)); //층, 호수(호수가 1자리이면 앞에 0 출력)
            }
        }
    }
}