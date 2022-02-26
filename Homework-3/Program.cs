using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //          3.   a ve b ededinin cemi 2 - reqemlidirse "cem ikireqemli ededdir"
            //                cem 3 reqemlidirse "cem ucreqemlidir" eks halda "nezere alinmayıb" cap edilsin


            int a = 90;

            int b = 34;

            int c = a + b;

            if (c < 100 && c > 9)
            {
                Console.WriteLine("cem 2 reqemli ededdir");
            }
            else if (c < 1000 && c > 99)
            {
                Console.WriteLine("cem 3 reqemli ededdir");
            }
            else
            {
                Console.WriteLine("Nezere Alinmiyib");
            }




        }
    }
}
