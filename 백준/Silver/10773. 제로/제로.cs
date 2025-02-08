using System;
using System.Collections.Generic;
using System.Linq;

namespace _10773
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int roop = int.Parse(Console.ReadLine());
            int tmp;

            for (int i = 0; i < roop; i++)
            {
                tmp = int.Parse(Console.ReadLine());
                if(tmp == 0)
                    stack.Pop();
                else
                    stack.Push(tmp);
            }

            Console.WriteLine(stack.Sum());
        }
    }
}