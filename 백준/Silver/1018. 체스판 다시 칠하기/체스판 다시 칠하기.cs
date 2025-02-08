using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1018
{
    internal class Program
    {

        const int CHESS_BOARD_SiZE = 8;
        static void Main(string[] args)
        {
            int[] inputNum = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            char[,] nomalBoard = new char[inputNum[0], inputNum[1]];
            char[,] chessBoard = new char[CHESS_BOARD_SiZE, CHESS_BOARD_SiZE];

            for (int i = 0; i < inputNum[0]; i++)   //nomalBoard 입력받기
            {
                var tmpArr = Console.ReadLine();
                int tmpCount = 0;
                foreach (var item in tmpArr)
                {
                    nomalBoard[i, tmpCount] = item;
                    tmpCount++;
                }
            }

            MakeChessBoard(chessBoard);

            Console.WriteLine(GetNumOfWillPaint(nomalBoard, chessBoard));
        }

        static void MakeChessBoard(char[,] arr)
        {
            string[] chessBoard = new string[]  //원하는 체스판
            { "WBWBWBWB",
              "BWBWBWBW",
              "WBWBWBWB",
              "BWBWBWBW",
              "WBWBWBWB",
              "BWBWBWBW",
              "WBWBWBWB",
              "BWBWBWBW" };

            for (int i = 0; i < chessBoard.Length; i++)
            {
                for (int j = 0; j < chessBoard.Length; j++)
                {
                    arr[i, j] = chessBoard[i][j];
                }
            }
        } 

        static int GetNumOfWillPaint(char[,] nomalBoard, char[,] chessBoard)
        {
            int sameCount = 0;
            int diffCount = 0;
            int min = 999999, tmp = 999999;
            for (int i = 0; i <= nomalBoard.GetLength(0) - CHESS_BOARD_SiZE; i++)
            {
                for (int j = 0; j <= nomalBoard.GetLength(1) - CHESS_BOARD_SiZE; j++)
                {
                    for (int k = 0; k < CHESS_BOARD_SiZE; k++)
                    {
                        for (int l = 0; l < CHESS_BOARD_SiZE; l++)
                        {
                            if (nomalBoard[i + k, j + l] == chessBoard[k, l])
                                sameCount++;
                            if (nomalBoard[i + k, j + l] != chessBoard[k, l])
                                diffCount++;
                        }
                    }

                    //최소값 넣기
                    tmp = (sameCount < diffCount) ? sameCount : diffCount;
                    if(min > tmp)
                        min = tmp;

                    //초기화
                    sameCount = 0;
                    diffCount = 0;
                }
            }

            return min;
        }
    }
}
