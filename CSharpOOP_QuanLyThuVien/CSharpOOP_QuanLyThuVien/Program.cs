using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyThuVien
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyTaiLieu quanLyTaiLieu = new QuanLyTaiLieu();
            TaiLieu taiLieu1 = new Sach("1", "hanoi", 1, "vudung", 2);
            TaiLieu taiLieu2 = new Bao("2","danang",2,"3");
            TaiLieu taiLieu3 = new TapChi("1", "hanoi", 1, "vudung", 2);
            //Sach taiLieu = new Sach();
            //taiLieu.nhap();
            quanLyTaiLieu.themTL(taiLieu1);
            quanLyTaiLieu.themTL(taiLieu2);
            quanLyTaiLieu.themTL(taiLieu3);
            quanLyTaiLieu.inTaiLieu();
            quanLyTaiLieu.timTLtheoSach();
            quanLyTaiLieu.timTLtheoTapChi();
            Console.ReadKey();
        }
    }
}
