using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _1654
{
    internal class Program
    {
        static int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        static List<int> wires = new List<int>();
        static BigInteger totalLen = 0;
        static BigInteger tmp = 0;

        static void Main(string[] args)
        {
            for (int i = 0; i < inputs[0]; i++)
            {
                wires.Add(int.Parse(Console.ReadLine()));
            }

            //totalLen = wires.Sum();

            foreach (int w in wires)
                totalLen += w;
            wires.Sort();

            Console.WriteLine(GetMaxLength());
        }

        static BigInteger GetMaxLength()
        {
            BigInteger length = ((BigInteger)wires[0] + (BigInteger)wires[wires.Count-1]) / 2;
            BigInteger beforeLen = length;
            BigInteger min = 1;
            BigInteger max = totalLen;

            while (true)
            {
                if (CanFillNum(length)) //true : 길게도 체크 해야함
                    length = (length + max) / 2;
                else //false : 무조건 더 짧게 해야함
                    length = (length + min) / 2;

                if (beforeLen < length)
                    min = beforeLen;
                else
                    max = beforeLen;

                if (beforeLen == length)
                    return length;

                beforeLen = length;
            }
        }

        static bool CanFillNum(BigInteger length)
        {
            tmp = 0;

            //조기 검사
            if(totalLen / length < inputs[1])
                return false;
            else
            {
                foreach (int w in wires)
                    tmp += w / length;

                return tmp >= inputs[1];
            }
        }
    }
}