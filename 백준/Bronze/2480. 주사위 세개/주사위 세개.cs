using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2480
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;    
            string[] num;
            int result = 0;

            num = Console.ReadLine().Split();

            x = int.Parse(num[0]);
            y = int.Parse(num[1]);
            z = int.Parse(num[2]);

            if (x == y && y == z)   //3개 동일
                result = 10000 + x * 1000;
            else if (x == y || y == z || x == z)    //2개 동일
            {
                if (x == y)
                    result = 1000 + x * 100;
                else if (y == z)
                    result = 1000 + y * 100;
                else  //x == z
                    result = 1000 + z * 100;
            }
            else
            {
                int max = 0;
                max = (x > y ?x :y) > z ?(x > y ? x : y) :z;
                result = max * 100;
            }
            
            Console.WriteLine(result);
        }
    }
}