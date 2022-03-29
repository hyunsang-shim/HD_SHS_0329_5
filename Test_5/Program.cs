using System;

namespace Test_5
{
    class Program
    {
        // 5. for와 while을 혼합하여 아래 별을 출력하세요
        // ㅁㅁㅁ별
        // ㅁㅁ별별
        // ㅁ별별별
        // 별별별별

        static void Main(string[] args)
        {
            //solution 1
            Console.WriteLine("solution 1");
            int lines = 4;
            while (lines > 0)
            {
                for (int i = 0; i < lines - 1; i++)
                {
                    Console.Write(" ");
                }

                for (int j = 4 - lines + 1; j > 0; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");

                lines--;
            }

            // 구분선
            Console.WriteLine("------------------");

            // solution 2
            Console.WriteLine("solution 2");
            for (int i = 0; i < 4; i++)
            {
                int spaces = 3 - i;
                int stars2 = 1 + i;
                
                while (spaces > 0)
                {
                    Console.Write(" ");
                    spaces--;
                }

                while (stars2 > 0)
                {
                    Console.Write("*");
                    stars2--;
                }

                Console.Write("\n");
            }
        }
    }
}
