using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB_TinhLai
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, tienGoc;
            float lai;
            double tienThu;
            Console.Write("Nhap vao so tien goc: ");
            tienGoc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so lai: ");
            lai = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao so nam: ");
            n = Convert.ToInt32(Console.ReadLine());
            tienThu = tienGoc * Math.Pow((1 + lai/100),n);
            Console.Write("\nSo tien thu dc la: "+tienThu);
            Console.ReadKey();
        }
    }
}
