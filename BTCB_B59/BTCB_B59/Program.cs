using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB_B59
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string []can = {"Canh", "Tan", "Nham", "Quy", "Giap","At", "Binh", "Dinh", "Mau", "Ky"};
            string []chi = {"Than", "Dau", "Tuat", "Hoi", "Ti", "Suu","Dan", "Meo", "Thin", "Ty", "Ngo", "Mui"};
            Console.Write("Nhap n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nam {0} - {1} {2}",n,can[n%10],chi[n%12]);
            Console.WriteLine();
            Console.Write("Nam {0} - {1} {2}", n + 60, can[n % 10], chi[n % 12]);
            Console.ReadKey();
         }
     }
 }

