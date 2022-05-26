using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyVienKhoaHoc
{

    class NhaQuanLy
    {
        private string hoten;
        private string namsinh;
        private string bangcap;
        private string chucvu;
        private int soNgaycong;
        private int bacluong;

        public NhaQuanLy(string hoten, string namsinh, string bangcap, string chucvu, int soNgaycong, int bacluong)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.bangcap = bangcap;
            this.chucvu = chucvu;
            this.soNgaycong = soNgaycong;
            this.bacluong = bacluong;
        }

        public NhaQuanLy()
        {
            hoten = "";
            namsinh = "";
            bangcap = "";
            chucvu = "";
            soNgaycong = 0;
            bacluong = 0;
        }

        ~NhaQuanLy()
        {
            hoten = "";
            namsinh = "";
            bangcap = "";
            chucvu = "";
            soNgaycong = 0;
            bacluong = 0;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public string Namsinh { get => namsinh; set => namsinh = value; }
        public string Bangcap { get => bangcap; set => bangcap = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public int SoNgaycong { get => soNgaycong; set => soNgaycong = value; }
        public int Bacluong { get => bacluong; set => bacluong = value; }

        public virtual void nhap()
        {
            Console.Write("Nhap vao hoten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap vao namsinh: ");
            namsinh = Console.ReadLine();
            Console.Write("Nhap vao bangcap: ");
            bangcap = Console.ReadLine();
            Console.Write("Nhap vao chucvu: ");
            chucvu = Console.ReadLine();
            Console.Write("Nhap vao songaycong: ");
            Console.Write("Nhap vao bacluong: ");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
