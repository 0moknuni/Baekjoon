using System;
using System.Text;

namespace _25314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalByte = int.Parse(Console.ReadLine());

            StringBuilder print = new StringBuilder();
            print.Append("int");

            for (int i = 0; i < totalByte / 4; i++)
                print.Insert(0, "long ");

            Console.WriteLine(print);
        }
    }
}