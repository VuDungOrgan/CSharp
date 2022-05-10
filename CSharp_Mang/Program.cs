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
            int[] arr_109 = new int[10];
            for (int i_109 = 0; i_109 < 10; i_109++)
            {
                Console.Write("Nhap vao A[{0}]: ",i_109+1);
                arr_109[i_109] = Convert.ToInt32(Console.ReadLine());
            }
            int max_109 = arr_109[0];
            int min_109 = arr_109[0];
            for (int i = 1; i < 10; i++)
            {
                if (arr_109[i]>max_109)
                {
                    max_109 = arr_109[i];
                }

                if (arr_109[i] < min_109)
                {
                    min_109 = arr_109[i];
                }
            }


            Console.WriteLine("So lon nhat la: " + max_109);
            Console.WriteLine("So lon be la: " + min_109);


            int[] ptXH = new int[100];
            for(int i = 0; i < 10; i++)
            {
                ptXH[i]=0;
                for(int j = i; j < 10; j++)
                {
                    if (arr_109[i] == arr_109[j])
                    {
                        ptXH[i]++;
                    }
                }
            }
            int maxXH = ptXH[0];
            for (int i = 1; i < 10; i++)
            {
                if (ptXH[i] > maxXH)
                {
                    maxXH= i;
                }

            }
            Console.Write("Phan tu xuat hien nhieu nhat la: "+arr_109[maxXH-1]);

            Console.ReadKey();
        }
    }
}
