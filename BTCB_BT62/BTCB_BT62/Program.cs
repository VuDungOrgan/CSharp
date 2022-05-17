using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB_BT62
{
    class Program
    {
        static int ucln(int a, int b)
        {
            if (b == 0) return a;
            if (a % b == 0) return b;
            return ucln(b, a % b);
        }
        static void delete_MatchValue(int []a,ref int n)
        {
            for (int i = 0; i < n - 1; i++)  // 1 2 1 1
            {
                for (int j = i + 1; j < n; j++)
                {
                    if(a[i] == a[j])
                    {
                        for(int t = j; t < n; t++)
                        {
                            a[t] = a[t + 1];
                        }
                        j--;
                        n--;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]+ " ");
            }
        }

        static void Main(string[] args)
        {
            int n;
            int s1=0, s2 = 0;
            int[] a = new int[100];
            do
            {
                Console.Write("nhap n>0 : ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = ran.Next(10,20);
                if (a[i] % 2 == 0 && i % 2 != 0)
                {
                    s1 += a[i];
                }
                if (a[i] % 2 != 0 && i % 2 == 0)
                {
                    s2 += a[i];
                }
                Console.Write(a[i] + " ");
            }
            Console.Write("\n Tong so chan o vi tri le: "+s1);
            Console.Write("\n Tong so le o vi tri chan: " + s2);
            if (s1 == s2)
            {
                Console.Write("\n Bang nhau");
            }
            else
            {
                Console.Write("\n Khac nhau");
            }
            delete_MatchValue(a,ref n);
            Console.Write("\nSo NT Cung Nhau:\n ");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ucln(a[i], a[j]) == 1)
                    {
                        Console.WriteLine("({0},{1})", a[i], a[j]);
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
