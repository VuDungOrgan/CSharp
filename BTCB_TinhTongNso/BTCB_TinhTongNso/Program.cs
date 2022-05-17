using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB_TinhTongNso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[50];
            int n;

            int sum = 0;
            Console.Write("Nhap vao n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}] = ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum += a[i];
            }

            Console.Write("Tong la: "+sum);
            Console.ReadKey();
        }
    }
}
