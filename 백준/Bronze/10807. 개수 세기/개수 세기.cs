using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10807
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region input
            int inputNum = int.Parse(Console.ReadLine());
            int[] inputArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int findNum = int.Parse(Console.ReadLine());
            #endregion

            int[] indexLoc = Array.FindAll(inputArr, n => n == findNum);
            Console.WriteLine(indexLoc.Length);
        }
    }
}