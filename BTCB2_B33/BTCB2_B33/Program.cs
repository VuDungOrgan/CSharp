using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2_B33
{
    class Program
    {
        static void Main(string[] args)
        {
            int demcs;
            double tong;
            Console.WriteLine("So ArmsTrong co 3,4 Chu so: ");
            for (int i = 100; i<= 9999; i++)
            {
                tong = 0;
                if (i <= 999)
                {
                    demcs = 3;
                }
                else
                {
                    demcs = 4;
                }
                int t = i;
                while (t != 0)
                {
                    int x = t % 10;
                    tong += Math.Pow(x, demcs);
                    t = t / 10;
                }
                if (tong == i)
                {
                    Console.Write(i+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
