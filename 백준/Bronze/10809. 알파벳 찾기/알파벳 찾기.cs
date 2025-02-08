using System;

namespace _10809
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            int count = 0;
            int[] alphabet = new int[26];   //a~z 배열 생성, 기본값 -1로 초기화
            for (int i = 0; i < alphabet.Length; i++)   //alphabet[]의 인덱스  0~25 == a~z
                alphabet[i] = -1;

            word = Console.ReadLine();
            
            foreach(char alpha in word) //알파벳 첫 등장위치로 초기화
            {                                     
                if (alphabet[alpha - 'a'] == -1) //해당 소문자 아스키코드(97~123) - 'a'(97) == alphabet[]의 해당 a~z 위치, //첫 등장 위치만 저장
                    alphabet[alpha - 'a'] = count;
                count++;
            }

            foreach(int item in alphabet)   //알파벳 위치 출력
                Console.Write(item + " ");
        }
    }
}