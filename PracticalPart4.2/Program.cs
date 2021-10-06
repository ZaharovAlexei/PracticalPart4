using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalPart4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            // количество отрицательных чисел - n
            // количество положительных чисел - p
            int n = 0;
            int p = 0;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                {
                    n++;
                        }
                else
                {
                    if (a>0)
                    {
                        p++;
                    }
                    else
                    {
                        Console.WriteLine("Ввод последовательности завершена");
                    }
                }
            }
            while (a != 0);
            Console.WriteLine("Количество отрицательных чисел = {0}",n);
            Console.WriteLine("Количество положительных чисел = {0}",p);
            if (p>n)
            {
                Console.WriteLine("Количество положительных чисел больше");
            }
            else
            {
                if (p<n)
                {
                    Console.WriteLine("Количество отрицательных чисел больше");
                }
                else
                {
                    Console.WriteLine("Количество отрицательных и положительных чисел одинаково");
                }
            }
            Console.ReadKey();
        }
    }
}
