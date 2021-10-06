using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalPart4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            int k = 0;
            if (a<c)
            {
                Console.WriteLine("Количество квадратов равно {0}",k);
            }
            else
            {
                if (b<c)
                {
                    Console.WriteLine("Количество квадратов равно {0}", k);
                }
                else
                {
                    while (a>=c)
                    {
                        n++;
                        a = a - c;
                    }
                    while (b >= c)
                    {
                        k += n;
                        b = b - c;
                    }
                    Console.WriteLine("Количество квадратов равно {0}", k);
                }                
            }            
            Console.ReadKey();
        }
    }
}
