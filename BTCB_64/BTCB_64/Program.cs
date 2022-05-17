using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB_64
{
    class Program
    {
        static bool checkPow2(int x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }

        static void deleteValue(int []a,ref int n,int value)
        {
            for (int i = 0; i < n; i++)
            {
                if(a[i] == value)
                {
                    for (int j = i; j < n-1; j++)
                    {
                            a[j] = a[j + 1];
                    }
                    i--;  
                  --n;
                }
            }

        }

        static void xuatMang(int []a,int n)
        {
            for (int i = 0; i< n; i++)
            {
                Console.Write(a[i]+" ");
            }
        }

        static void Main(string[] args)
        {
            int x,n, dem = 0;
            int[] a = new int[200];
            do
            {
                Console.Write("nhap n [1-99] : ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 && n > 99);

            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
                if(a[i] > 0)
                {
                    if (a[i] == 1)
                    {
                        dem++;
                    }else if (checkPow2(a[i]))
                    {
                        dem++;
                    }
                }
               
            }

            Console.Write("\n Co {0} so la luy thua cua 2.\n",dem);

            Console.Write("NHAP VAO GIA TRI CAN XOA: ");
            x = Convert.ToInt32(Console.ReadLine());

            deleteValue(a,ref n,x);

            Console.Write("\nMang sau khi xoa: ");
            xuatMang(a,n);
            Console.ReadKey();
        }
    }
}
