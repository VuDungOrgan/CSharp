using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB_60
{
    class Program
    {
        static void suffle(int []a, int[] t, int n)
        {
            int d = n / 2;
            for(int i = 0; i < d; i++)
            {
                t[2*i] = a[i];
                t[2* i + 1] = a[d+i];
            }
            
        }

       static bool isEqual(int []a,int []b,int n)
        {
            for (int i = 0; i< n; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int[] b = new int[100];
            int[] t = new int[100];
            int n = 0;
            do
            {
                Console.Write("Nhap vao n (n Chan) = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n % 2 != 0);

            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = ran.Next(-100,100);
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            suffle(a,t,n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(t[i] + " ");
            }
            int count=0;
            do
            {
                b = new int[100];
                suffle(t, b, n);
                count++;
                t = b;

            } while (isEqual(a, b, n) != true);
            Console.WriteLine();
            Console.Write("Can Suffle {0} lan: ",count);
            Console.ReadKey();
        }
    }
}
