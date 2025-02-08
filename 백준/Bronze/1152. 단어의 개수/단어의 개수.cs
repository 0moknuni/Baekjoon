using System;

namespace _1152
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if(input != " ")
                Console.WriteLine(input.Trim().Split(" ").Length);         
            else
                Console.WriteLine("0");
        }
    }
}
