using System;

namespace _2941
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine() + " ";    //CountCroatiaAlpha 마지막 인덱스 계산을 위해 + " "

            Console.WriteLine(CountCroatiaAlpha(input));
        }

        static int CountCroatiaAlpha(string input)
        {
            int CroCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'c':
                    case 's':
                    case 'z':
                        if (CheckNextIsCroatiaOperator(input[i + 1]))
                            i++;
                        CroCount++;
                        break;

                    case 'l':
                    case 'n':
                        if(CheckNextIsCroatiaJ(input[i + 1]))
                            i++;
                        CroCount++;
                        break;

                    case 'd':
                        if (input[i + 1] == '-')
                            i++;
                        else if (input[i + 1] == 'z')
                            if (input[i + 2] == '=')
                                i += 2;

                        CroCount++;
                        break;

                    default:    //이 외의 인덱스 
                        if(input[i] != ' ')
                            CroCount++;
                        break;
                }
            }

            return CroCount;
        }

        static bool CheckNextIsCroatiaOperator(char Alpha)
        {
            if (Alpha == '-' || Alpha == '=')
                return true;
            else
                return false;
        }
        static bool CheckNextIsCroatiaJ(char Alpha)
        {
            if (Alpha == 'j')
                return true;
            else
                return false;
        }
    }
}
