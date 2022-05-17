using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB_58
{
    class Program
    {
        static bool checkSNT(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
              
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao n >= 2: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 2);

            for (int i = 2; i<=n; i++)
            {
                if (checkSNT(i) == true)
                {
                    Console.Write(i+" ");
                }
            }

            Console.ReadKey();
        }
    }
}
