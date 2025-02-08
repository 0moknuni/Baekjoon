using System;

namespace _2292
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindRoom(int.Parse(Console.ReadLine())));
        }

        static int FindRoom(int num)
        {
            int i = 0;
            int roomNum = 1;
            do
            {
                roomNum += 6 * i;
                i++;
            } while (roomNum < num);
            
            return i;
        }
    }
}