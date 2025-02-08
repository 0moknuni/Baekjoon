using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10871
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0, max = 0; //수열의 크기와 최댓값
            List<int> sequence = new List<int>();   //수열
            
            string[] InforArr = Console.ReadLine().Split(); //수열 정보를 입력받음
            string[] numArr = Console.ReadLine().Split(); //수열의 수 입력받음
           
            count = int.Parse(InforArr[0]);     //수열 초기화
            max = int.Parse(InforArr[1]);
            foreach (string item in numArr)
            {
                sequence.Add(int.Parse(item));
            }
            
            foreach (int i in sequence) //max미만 값 출력
                if(i < max)
                    Console.Write(i + " ");
        }
    }
}
