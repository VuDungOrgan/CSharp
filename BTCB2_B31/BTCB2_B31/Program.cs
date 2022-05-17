using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2_B31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bang Cuu Chuong: ");
            for(int i = 1; i <= 10; i++){
                for (int j = 2; j <= 9; j++)
                {
                    Console.Write("{0} x {1} = {2}    ---    ",j,i,j*i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
