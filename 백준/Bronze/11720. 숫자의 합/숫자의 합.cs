using System;

namespace _11720
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string numbers = "";
            int sum = 0;

            count = int.Parse(Console.ReadLine()); 
            numbers = Console.ReadLine();

            foreach(char number in numbers) //string == char[]
            {
                sum += int.Parse(number.ToString());    //int.Parse()는 string을 매개변수로 받음 -> .tostring()필요
            }

            Console.WriteLine(sum);
        }
    }
}