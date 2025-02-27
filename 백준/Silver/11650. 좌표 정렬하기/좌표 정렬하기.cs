using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _11650
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            var reader = new StreamReader(Console.OpenStandardInput());
            int count = int.Parse(reader.ReadLine());
            List<List<int>> xy = new List<List<int>>();

            for (int i = 0; i < count; i++)
            {
                var nm = Array.ConvertAll(reader.ReadLine().Split(), int.Parse);
                xy.Add(nm.ToList()); 
            }

            //calculate
            var result = xy.OrderBy(x => x[0]).ThenBy(x => x[1]).ToList();

            var sb = new StringBuilder();
            foreach (var item in result)
            {
                sb.AppendLine($"{item[0]} {item[1]}");
            }
            Console.Write(sb.ToString());
        }
    }
}