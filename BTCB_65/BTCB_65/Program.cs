using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB_65
{
    class Program
    {
        static double tbc(int[] a, int n)
        {
            int demSL = 0;
            double tbc, sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0 && a[i] % 2 != 0)
                {
                    sum += a[i];
                    demSL++;
                }
            }

            tbc = sum / demSL;
            return tbc;
        }

        static void deleteValue(int []a, ref int n , int pos)
        {
            for (int i = pos; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }
            // Giam so luong phan tu sau khi xoa.
            --n;
        }

        static void deleteArr(int[] a, ref int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        deleteValue(a,ref n,j);
                    }
                }
            }
        }

        static void nhapN(out int n)
        {
            do
            {
                Console.Write("nhap n [1-99] : ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 && n > 99);
        }
        static void xuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        

        static void Main(string[] args)
        {
            int x, n, dem = 0;
            int[] a = new int[200];

            nhapN(out n);

            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\n TBC So Nguyen Am Le: "+tbc(a,n));

            deleteArr(a,ref n);
            Console.Write("\nMang sau khi xoa trung: ");
            xuatMang(a,n);
            Console.ReadKey();

        }
    }
}
