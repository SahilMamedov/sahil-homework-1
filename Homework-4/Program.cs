using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //       a ededi  1 - reqemlidirse cavabda  1 - reqemli
            //                2 - reqemlidirse cavabda  2 - reqemli.....
            //                5 - reqemlidrise cavabda  5 - reqemli cap edin

            int a = 6999999;

            if (a > 0 && a < 10)
            {
                Console.WriteLine("1 reqemlidir");

            }
            else if (a > 9 && a < 100)
            {
                Console.WriteLine("2 reqemlidir");
            }
            else if (a > 99 && a < 1000)
            {
                Console.WriteLine("3 reqemlidir");
            }
            else if (a > 999 && a < 10000)
            {
                Console.WriteLine("4 reqemlidir");
            }
            else if (a > 9999 && a < 100000)
            {
                Console.WriteLine("5 reqemlidir");
            }
            else
            {
                Console.WriteLine("1, 2, 3, 4, 5, reqemli yazi :) .");
            }





        }
    }
}
