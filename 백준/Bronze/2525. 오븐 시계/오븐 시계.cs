using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2525
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startTime = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int elapsedTime = int.Parse(Console.ReadLine());

            int[] endTime = PlusMinToTime(startTime[1], elapsedTime);   //분->시:분
            endTime[0] = PlusHour(startTime[0], endTime[0]);

            Console.WriteLine(endTime[0] + " " + endTime[1]);
        }


        static int[] RoundMinToTime(int inputMin)
        {
            int[] time; //Time[0] = H, Time[1] = M
            time = new int[2];

            time[0] = inputMin / 60;
            time[1] = inputMin % 60;

            return time;
        }

        static int[] PlusMinToTime(int min1, int min2)
        {
            int[] time;
            time = new int[2];

            int sum = min1 + min2;

            return RoundMinToTime(sum);
        }

        static int PlusHour(int h1, int h2)
        {
            int tmp = h1 + h2;

            return tmp % 24;
        }
    }
}
