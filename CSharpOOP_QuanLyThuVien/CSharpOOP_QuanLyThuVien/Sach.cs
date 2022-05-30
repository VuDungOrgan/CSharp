using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyThuVien
{
    class Sach : TaiLieu
    {
        private string tenTG;
        private int soTrang;

        public string TenTG { get => tenTG; set => tenTG = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }

        public Sach(string id, string tenXB, int soPH, string tenTG, int soTrang) : base(id, tenXB, soPH)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
        }
        public Sach() : base()
        {
            tenTG = "";
            soTrang = 0;
        }
        
        public void nhap()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Nhap vao thong tin Sach: ");
            Console.Write("ID: ");
            Id = Console.ReadLine();
            Console.Write("ten NXB: ");
            TenXB = Console.ReadLine();
            Console.Write("so PH: ");
            SoPH = Convert.ToInt32(Console.ReadLine());
            Console.Write("tenTG: ");
            TenTG = Console.ReadLine();
            Console.Write("so Trang: ");
            soTrang = Convert.ToInt32(Console.ReadLine());
        }

        public override String ToString()
        {
            return "Book{" +
                    "author='" + tenTG + '\'' +
                    ", numerPage=" + soTrang +
                    ", id='" + Id + '\'' +
                    ", nxb='" + TenXB + '\'' +
                    ", number='" + SoPH + '\'' +
                    '}';
        }
    }
}
