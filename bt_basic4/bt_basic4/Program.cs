using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_basic4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a_109, b_109, c_109;
            Console.Write("a = ");
            a_109 = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b_109 = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c_109 = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(a_109,2) == Math.Pow(b_109, 2) + Math.Pow(c_109, 2) || Math.Pow(b_109, 2) == Math.Pow(a_109, 2) + Math.Pow(c_109, 2) || Math.Pow(c_109, 2) == Math.Pow(a_109, 2) + Math.Pow(b_109, 2))
            {
                Console.Write("La tam giac vuong");
            }
            else
            {
                Console.Write("Khong phai tam giac vuong");
            }

            Console.ReadKey();
        }
    }
}
