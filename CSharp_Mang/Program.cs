using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Mang
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Nhap vao A[{0}]: ",i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
