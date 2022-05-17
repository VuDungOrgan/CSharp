using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuocTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            long     km,tongtien;
            tongtien = 0;
            Console.Write("Nhap vao so KM: ");
            km = Convert.ToInt32(Console.ReadLine());
            if (km == 1)
            {
                tongtien = 13000;
            }else if (km > 1 && km <= 30)
            {
                tongtien = 13000 + (km - 1) * 12000;
            }else if (km > 30)
            {
                tongtien = km * 11000;
            }
            if (tongtien != 0)
            {
                Console.Write("Tong Tien La: "+tongtien);
            }
            else
            {
                Console.Write("Khong Hop Le ! ");
            }
            Console.ReadKey();
        }
    }
}
