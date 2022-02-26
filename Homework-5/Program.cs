using System;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. a ededi b ededine tam bolunurse tam bolunur eks halda bolunmur

            int a = 20;

            int b = 10;

            int c = a % b;
            if (c == 0)
            {
                Console.WriteLine("tam bolunur");
            }
            else
            {
                Console.WriteLine("Bolunmur");
            }

        }
    }
}
