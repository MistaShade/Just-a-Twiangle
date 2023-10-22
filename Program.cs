using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, x, y, start, end;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            start = num; 

            for (y = 1; y <= num; y++)
            {
                for (x = 1; x <= (num * 2); x++)
                {
                    if (x >= start)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                start--;
                Console.WriteLine();
            }
            Console.ReadKey();
        }


    }
}

