using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyBanVeMayBay
{
    class Vemaybay
    {
        private string tenchuyen;
        private string ngaybay;
        private int giave;

        public int getGiave { get => giave; set => giave = value; }

        public Vemaybay(string tenchuyen, string ngaybay, int giave)
        {
            this.tenchuyen = tenchuyen;
            this.ngaybay = ngaybay;
            this.giave = giave;
        }

        public Vemaybay()
        {
            tenchuyen = "";
            ngaybay = "";
            giave = 0;
        }
        ~Vemaybay()
        {
            tenchuyen = "";
            ngaybay = "";
            giave = 0;
        }
        public void nhapVe()
        {
            Console.Write("\nNhap vao Ten CB: ");
            tenchuyen = Console.ReadLine();
            Console.Write("Nhap vao Ngay Bay: ");
            ngaybay = Console.ReadLine();
            Console.Write("Nhap vao Gia ve: ");
            giave = Convert.ToInt32(Console.ReadLine());
        }

        public void xuatVe()
        {
            Console.WriteLine("Ten CB: "+tenchuyen);
            Console.WriteLine("Ngay Bay: "+ngaybay);
            Console.WriteLine("Gia ve: {0}\n",giave);
        }


    }

    class Nguoi
    {
        private string ten;
        private string gioitinh;
        private int tuoi;

        public Nguoi(string ten, string gioitinh, int tuoi)
        {
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.tuoi = tuoi;
        }

        public Nguoi()
        {
            ten = "";
            gioitinh = "";
            tuoi = 0;
        }
        ~Nguoi()
        {
            ten = "";
            gioitinh = "";
            tuoi = 0;
        }
        public void nhap()
        {
            Console.Write("Nhap vao Ten Khach Hang: ");
            ten = Console.ReadLine();
            Console.Write("Nhap vao Gioi Tinh: ");
            gioitinh = Console.ReadLine();
            Console.Write("Nhap vao Tuoi: ");
            tuoi = Convert.ToInt32(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("Ten: " + ten);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Gioi: " + gioitinh);
        }

    }

    class HanhKhach : Nguoi
    {
        Vemaybay []Vemaybay;
        int soluong;
        int tongtien;

        public HanhKhach()
        {
            soluong = 0;
            Vemaybay = new Vemaybay[soluong];
            tongtien = 0;
        }
        ~HanhKhach()
        {
            soluong = 0;
            Vemaybay = new Vemaybay[soluong];
            tongtien = 0;
        }

        public int Tongtien { get => tongtien; set => tongtien = value; }

        public void nhapKhach()
        {
            nhap();
            Console.Write("Nhap vao so luong ve hanh khach da mua: ");
            soluong = Convert.ToInt32(Console.ReadLine());
            Vemaybay = new Vemaybay[soluong];
            for (int i = 0; i < soluong; i++) 
            {
                Vemaybay[i] = new Vemaybay();
                Vemaybay[i].nhapVe();
                tongtien += Vemaybay[i].getGiave;
            }
        }

        public void xuatKhach()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("THONG TIN KHACH HANG: ");
            xuat();
            Console.WriteLine("THONG TIN CHUYEN BAY: ");
            for (int i = 0; i < soluong; i++)
            {
                Vemaybay[i].xuatVe();
            }
            Console.Write("Tong Tien: {0}\n",tongtien);
            
        }

        public static bool operator < (HanhKhach obj1, HanhKhach obj2)
        {
            if (obj1.tongtien<obj2.tongtien) return true;
             else return false;
        }
        public static bool operator >(HanhKhach obj1, HanhKhach obj2)
        {
            if (obj1.tongtien > obj2.tongtien) return true;
            else return false;
        }
    }

    class Program
    {
        public static void swap(ref HanhKhach a, ref HanhKhach b)
        {
            HanhKhach temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void Bubblesort(HanhKhach[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        swap(ref arr[j], ref arr[j + 1]);
        }

        static void Main(string[] args)
        {
            int soLuongHK;
            Console.Write("Nhap vao so luong Hanh khach: ");
            soLuongHK = Convert.ToInt32(Console.ReadLine());
            HanhKhach[] HK = new HanhKhach[soLuongHK];
            for (int i=0 ; i < soLuongHK; i++)
            {
                Console.Write("Nhap vao hanh khach thu {0}:\n", i + 1);
                HK[i] = new HanhKhach();
                HK[i].nhapKhach();
            }
            Bubblesort(HK, soLuongHK);
            for (int i = 0; i < soLuongHK; i++)
            {
                HK[i].xuatKhach();
                Console.WriteLine("--------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
