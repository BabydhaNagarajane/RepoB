using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowTwoConsoleApp
{
    public static class ClassAdd
    {
        public static int Add()
        {
            int a = 10, b = 20, c = 0;
            c = a + b;
            return c;
        }

        public static void Diamond()
        {
            int number, i, k, count = 1;
            Console.Write("Enter number of rows\n");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
