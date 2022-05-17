using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_basic3
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
            if ((a_109 + b_109 > c_109) && (a_109 + c_109 > b_109) && (b_109 + c_109 > a_109))
            {
                Console.Write("la 3 canh tam giac");
            }
            else
            {
                Console.Write("khong phai 3 canh tam giac");
            }
            Console.ReadKey();
        }
    }
}
