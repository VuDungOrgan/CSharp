using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_basic1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_109;
            Console.Write("nhap n bat ky: ");
            n_109 = Convert.ToInt32(Console.ReadLine());
            if (n_109 >= 0)
            {
                Console.WriteLine("Đây là số nguyên dương");
            }
            else
            {
                Console.WriteLine("Đây là số nguyên âm");
            }
            Console.ReadKey();
        }
    }
}
