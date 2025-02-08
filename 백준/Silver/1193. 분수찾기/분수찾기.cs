using System;

namespace _1193
{
    class Program
    {
        static void Main(string[] args)
        {
            int raw = 1;
            int input = int.Parse(Console.ReadLine());

            (int col, int colMax) = FindColAndMax(input);

            if (col % 2 == 0)  //even - 각 층 최댓값 좌하단->우상단
                for (; input < colMax;) { colMax--; col--; raw++; }
            else //odd - 각 층 최댓값 우상단->좌하단
            {
                for (; input < colMax;) { colMax--; col--; raw++; }

                int tmp = col;  //우상단 시작이였으니 행, 렬 값 교환
                col = raw;
                raw = tmp;
            }

            Console.WriteLine(col + "/" + raw);
        }

        static (int, int) FindColAndMax(int input)    //Tuple() 사용으로 2개 반환 //메모리는 클래스가 덜 사용할 듯 합니다!
        {
            int sum, n = 0;

            do
            {
                n++;
                sum = n * (n + 1) / 2;
            } while (!(sum - n < input && input <= sum));

            return (n, sum);
        }
    }
}