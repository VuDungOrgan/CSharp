using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2_B22
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, t, so;
            Console.Write("nhap vao so: ");
            so = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cac uoc so:");
            d = 0;
            t = 0;
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    d++;
                    t += i;
                    Console.Write(" " + i);

                }

            }
            Console.WriteLine("\nSo uoc: " + d);
            Console.WriteLine("Tong cac uoc: " + t);
            Console.ReadKey();
        }
    }
}
