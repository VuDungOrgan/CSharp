using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyVienKhoaHoc
{
    abstract class ConNguoi {
        private string hoten;
        private string namsinh;
        private string bangcap;

        public string Hoten { get => hoten; set => hoten = value; }
        public string Namsinh { get => namsinh; set => namsinh = value; }
        public string Bangcap { get => bangcap; set => bangcap = value; }

        protected ConNguoi(string hoten, string namsinh, string bangcap)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.bangcap = bangcap;
        }

        protected ConNguoi()
        {
            this.hoten = "";
            this.namsinh = "";
            this.bangcap = "";
        }

        public virtual void nhap()
        {
            Console.Write("Nhap vao hoten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap vao namsinh: ");
            namsinh = Console.ReadLine();
            Console.Write("Nhap vao bangcap: ");
            bangcap = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("hoten: " + hoten);
            Console.WriteLine("namsinh: " + namsinh);
            Console.WriteLine("bangcap: " + bangcap);
        }
    }

    internal class NhaQuanLy : ConNguoi
    {
        private string chucvu;
        private int soNgaycong;
        private int bacluong;
        private int luongthang = 0;

        public string Chucvu { get => chucvu; set => chucvu = value; }
        public int SoNgaycong { get => soNgaycong; set => soNgaycong = value; }
        public int Bacluong { get => bacluong; set => bacluong = value; }
        public int Luongthang { get => luongthang; set => luongthang = value; }


        public NhaQuanLy(string hoten, string namsinh, string bangcap, string chucvu, int soNgaycong, int bacluong):base(hoten,namsinh,bangcap)
        {
            this.chucvu = chucvu;
            this.soNgaycong = soNgaycong;
            this.bacluong = bacluong;
        }

        public NhaQuanLy():base()
        {
            chucvu = "";
            soNgaycong = 0;
            bacluong = 0;
            luongthang = 0;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap vao chucvu: ");
            chucvu = Console.ReadLine();
            Console.Write("Nhap vao songaycong: ");
            soNgaycong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao bacluong: ");
            bacluong = Convert.ToInt32(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("chucvu: "+chucvu);
            Console.WriteLine("songaycong: "+soNgaycong);
            Console.WriteLine("bacluong: "+bacluong);
            Console.WriteLine("Luong thang: "+luongthang);
        }

    }

    class NhaKhoaHoc : NhaQuanLy
    {
        private int soBaibao;

        public NhaKhoaHoc(string hoten, string namsinh, string bangcap, string chucvu, int soNgaycong, int bacluong,int soBaibao):base(hoten,namsinh,bangcap,chucvu,soNgaycong,bacluong)
        {
            this.soBaibao = soBaibao;
        }

        public NhaKhoaHoc() : base()
        {
            soBaibao = 0;
        }

        public int SoBaibao { get => soBaibao; set => soBaibao = value; }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap vao so bai bao: ");
            soBaibao = Convert.ToInt32(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.Write("so bai bao: "+soBaibao);
        }
    }

    class NhanVienPhongThiNghiem : ConNguoi
    {
        private int luongtrongthang;

        public int Luongtrongthang { get => luongtrongthang; set => luongtrongthang = value; }

        public NhanVienPhongThiNghiem(string hoten, string namsinh, string bangcap, int luongtrongthang):base(hoten, namsinh, bangcap)
        {
            this.luongtrongthang = luongtrongthang;
        }

        public NhanVienPhongThiNghiem():base()
        {
            luongtrongthang = 0;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("nhap luong trong thang: ");
            luongtrongthang = Convert.ToInt32(Console.ReadLine());
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Luong trong thang: "+luongtrongthang);
        }
    }

    class Program
    {
 
        static void Main(string[] args)
        {
            ArrayList arr_QL = new ArrayList();
            ArrayList arr_NhaKH = new ArrayList();
            ArrayList arr_PTN = new ArrayList();
            int luongQL = 0, luongKH = 0, luongPTN = 0;

            int n = 0;
            do
            {
                Console.WriteLine("\nChon doi tuong de nhap: ");
                Console.WriteLine("1.Nha quan ly ");
                Console.WriteLine("2.Nha khoa hoc ");
                Console.WriteLine("3.NV phong TN ");
                Console.WriteLine("0. de thoat !");
                Console.Write("\nMoi ban chon: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("Nhap thong tin nha quan ly");
                            NhaQuanLy ql = new NhaQuanLy();
                            ql.nhap();
                            ql.Luongthang = ql.SoNgaycong * ql.Bacluong;
                            luongQL += ql.Luongthang;
                            arr_QL.Add(ql);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nhap thong tin nha khoa hoc");
                            NhaKhoaHoc kh = new NhaKhoaHoc();
                            kh.nhap();
                            kh.Luongthang = kh.SoNgaycong * kh.Bacluong;
                            luongKH += kh.Luongthang;
                            arr_NhaKH.Add(kh);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Nhap thong tin NV phong TN");
                            NhanVienPhongThiNghiem tn = new NhanVienPhongThiNghiem();
                            tn.nhap();
                            luongPTN += tn.Luongtrongthang;
                            arr_PTN.Add(tn);
                            break;
                        }
                    default: { Console.WriteLine("Ket thuc nhap! ");  break; }
                       
                }


            } while (n != 0);

            Console.WriteLine("\nDANH SACH NHA QUAN LY: ");
            foreach (NhaQuanLy nql in arr_QL)
            {
                nql.xuat();
            }

            Console.WriteLine("\nDANH SACH NHA KHOA HOC: ");
            foreach (NhaKhoaHoc nql in arr_NhaKH)
            {
                nql.xuat();
            }

            Console.WriteLine("\nDANH SACH PHONG TN ");
            foreach (NhanVienPhongThiNghiem nql in arr_PTN)
            {
                nql.xuat();
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\n Luong cua Quan ly: " + luongQL);
            Console.WriteLine("\n Luong cua Nha KH: " + luongKH);
            Console.WriteLine("\n Luong cua PTN: " + luongPTN);

            Console.ReadKey();
        }
    }
}
