using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2798
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //index=0 => 반복횟수, index=1 => 합
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            int sum = 0, result = 0;
            for (int i = 0; i < input[0]-2; i++)
            {
                for (int j = i+1; j < input[0]-1; j++)
                {
                    for (int k = j+1; k < input[0]; k++)
                    {
                        sum = numbers[i] + numbers[j] + numbers[k];


                        if (result < sum && sum <= input[1])
                            result = sum;

                        sum = 0;    //reset
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
