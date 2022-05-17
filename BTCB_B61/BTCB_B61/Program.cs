using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB_B61
{
    class Program
    {
        static void deletePoint(int []a,int n, int p)
        {
            for (int i = p; i < n-1; i++)
            {
                a[i] = a[i+1]; // 1 2 3 4 
            }
        }
        static void Main(string[] args)
        {
            int n, sum ;
            sum = 0;
            int[] a = new int[100];
            do
            {
                Console.Write("Nhap vao n [1-99] : ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (0 > n || n > 99);
            Random ran = new Random();
            for (int i = 0; i< n;i++)
            {
                a[i] = ran.Next(-100, 100);
                if (a[i] > 0 )
                {
                    sum += a[i]; 
                }
                Console.Write(a[i]+" ");
            }
            Console.Write("\n Tong Cac So Nguyen Duong: "+sum);
            int p;
            do
            {
                Console.Write("\nNhap vao p [0,9] : ");
                p = Convert.ToInt32(Console.ReadLine());
            } while (0 > n || n > 9);
            Console.Write("Danh sach sau khi xoa vi tri {0} :",p);
            deletePoint(a,n,p);
            n--;
            for (int i=0 ; i<n;i++) {
                Console.Write(a[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
