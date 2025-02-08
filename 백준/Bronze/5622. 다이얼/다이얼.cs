using System;

namespace _5622
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int time = 0;

            foreach(char alpha in input)    //각 문자별 소요시간 계산
            {
                if ('A' <= alpha && alpha <= 'C')
                    time += 3;
                else if ('D' <= alpha && alpha <= 'F')
                    time += 4;
                else if ('G' <= alpha && alpha <= 'I')
                    time += 5;
                else if ('J' <= alpha && alpha <= 'L')
                    time += 6;
                else if ('M' <= alpha && alpha <= 'O')
                    time += 7;
                else if ('P' <= alpha && alpha <= 'S')
                    time += 8;
                else if ('T' <= alpha && alpha <= 'V')
                    time += 9;
                else if ('W' <= alpha && alpha <= 'Z')
                    time += 10;
                else
                    Console.WriteLine("input Error");
            }

            Console.WriteLine(time);
        }
    }
}
