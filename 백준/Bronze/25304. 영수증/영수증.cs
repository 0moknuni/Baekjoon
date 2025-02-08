using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25304
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalPrice = int.Parse(Console.ReadLine());
            int sumPrice = 0;
            int i = int.Parse(Console.ReadLine());

            for (; i > 0; i--)
            {
                //purchaseInfo[0] = 가격, purchaseInfo[1] = 수량
                int[] purchaseInfo = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                sumPrice += purchaseInfo[0] * purchaseInfo[1];
            }

            if(sumPrice == finalPrice)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}