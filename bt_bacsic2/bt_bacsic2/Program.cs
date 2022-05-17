using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_bacsic2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_109;
            Console.Write("Nhap mot so bat ky: ");
            n_109 = Convert.ToInt32(Console.ReadLine());

            if (n_109 == 0)
            {
                Console.Write("So khong");
            }
            else if (n_109 == 1)
            {
                Console.Write("So mot");
            }
            else if (n_109 == 2)
            {
                Console.Write("So hai");
            }
            else if (n_109 == 3)
            {
                Console.Write("So ba");
            }
            else if (n_109 == 4)
            {
                Console.Write("So bon");
            }
            else if (n_109 == 5)
            {
                Console.Write("So nam");
            }
            else if (n_109 == 6)
            {
                Console.Write("So sau");
            }
            else if (n_109 == 7)
            {
                Console.Write("So bay");
            }
            else if (n_109 == 8)
            {
                Console.Write("So tam");
            }
            else if (n_109 == 9)
            {
                Console.Write("So chin");
            }
            else
            {
                Console.Write("Chi nhap so tu 0 - 9");
            }
            Console.ReadKey();
        }
    }
}
