using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB_63
{
    class Program
    {
        static bool check6(int n)
        {
            if (Math.Abs(n%10) == 6)
            {
                return true;
            }
            else
            {
                return false;
            }

   
        }

        static bool check4_6(int n)
        {
            int a = n / 10;
            int b = n % 10;
            int s = Math.Abs(a) * 2 + Math.Abs(b);
            if ((s % 4 == 0) && (check6(n) == true))
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }

        static bool checkLe(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int n,dem=0;
            int[] a = new int[200];
            do
            {
                Console.Write("nhap n>0 : ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = ran.Next(-100, 100);
                
                Console.Write(a[i] + " ");

                if (check4_6(a[i]) == true)
                {
                    dem++;
                }

                if (checkLe(a[i]) == true)
                {
                    a[i] = a[i] * 2;
                }

            }
            Console.Write("\nSo phan tu chia het cho 4 & tan cung = 6 la: {0} ",dem);
            Console.Write("\nNhan doi cac phan tu le: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
