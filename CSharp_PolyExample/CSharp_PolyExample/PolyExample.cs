using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PolyExample
{

    class HinhHoc
    {
        public virtual void nhanBiet()
        {
            Console.WriteLine("Hinh la tap hop cac duong thang tao thanh 1 khong gian khep kin");
        }
    }

    class HinhTron : HinhHoc{
        public override void nhanBiet()
        {
            Console.Write("\n Đây là hình tròn: \n");
            Console.WriteLine("Hình tròn là các điểm nằm trên đường tròn và nằm trong đường tròn đó.");
        }
    }

    class HinhVuong : HinhHoc
    {
        public override void nhanBiet()
        {
            Console.Write("\n Đây là hình vuông: \n");
            Console.WriteLine("hình vuông là hình tứ giác đều, tức có 4 cạnh bằng nhau và 4 góc bằng nhau");
        }
    }

    class HinhTamGiac : HinhHoc
    {
        public override void nhanBiet()
        {
            Console.Write("\n Đây là hình Tam Giac: \n");
            Console.WriteLine("Tam giác là đa giác có số cạnh ít nhất (3 cạnh), có ba đỉnh là ba điểm không thẳng hàng và ba cạnh là ba đoạn thẳng nối các đỉnh với nhau.");
        }
    }

    class HinhBinhHanh : HinhHoc
    {
        public override void nhanBiet()
        {
            Console.Write("\n Đây là hình Binh Hanh: \n");
            Console.WriteLine("Hình bình hành là một hình tứ giác được tạo thành khi hai cặp đường thẳng song song cắt nhau");
        }
    }



    class PolyExample
    {
        static void Main(string[] args)
        {
            HinhHoc htron = new HinhTron();
            HinhHoc hvuong = new HinhVuong();
            HinhHoc htamgiac = new HinhTamGiac();
            HinhHoc hBinhhanh = new HinhBinhHanh();
            htron.nhanBiet();
            hvuong.nhanBiet();
            htamgiac.nhanBiet();
            hBinhhanh.nhanBiet();
            Console.ReadKey();
        }
    }
}
