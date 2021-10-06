using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int n2 = 0;            
            Console.WriteLine("Введите целое число N>0");
            n = Convert.ToInt32(Console.ReadLine());
            for (int k = 1; k < n+1; k++)
                {
                n2 += 2 * k - 1;
                Console.WriteLine("{0}, {1}", k, n2);
                }
            Console.ReadKey();
        }
    }
}
