using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyVanDongVien
{

    class VanDongVien
    {
        private string hoten;
        private string monthidau;
        private int tuoi;
        private double cannang;
        private double chieucao;

        public VanDongVien()
        {
            hoten = "";
            monthidau = "";
            tuoi = 0;
            cannang = 0;
            chieucao = 0;
        }

        public VanDongVien(string hoten, string monthidau, int tuoi, double cannang, double chieucao)
        {
            this.hoten = hoten;
            this.monthidau = monthidau;
            this.tuoi = tuoi;
            this.cannang = cannang;
            this.chieucao = chieucao;
        }

        ~VanDongVien()
        {
            hoten = "";
            monthidau = "";
            tuoi = 0;
            cannang = 0;
            chieucao = 0;
        }
        
        public void Nhap()
        {
            Console.Write("Nhap vao ho ten vdv: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap vao mon thi dau: ");
            monthidau = Console.ReadLine();
            Console.Write("Nhap vao tuoi vdv: ");
            tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao can nang vdv: ");
            cannang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao chieu cao vdv: ");
            chieucao = Convert.ToDouble(Console.ReadLine());
        }

        public void HienThi()
        {
            Console.WriteLine("Ho va ten: {0} ", hoten);
            Console.WriteLine("Tuoi: {0} ", tuoi);
            Console.WriteLine("Chieu Cao: {0} ", chieucao);
            Console.WriteLine("Can Nang: {0} ", cannang);
            Console.WriteLine("Mon thi dau: {0} \n", monthidau);
        }

        public static bool operator >(VanDongVien vdv1, VanDongVien vdv2)
        {
            if(vdv1.chieucao > vdv2.chieucao)
            {
                return true;
            }else if (vdv1.chieucao < vdv2.chieucao)
            {
                return false;
            }else if (vdv1.cannang > vdv2.cannang)
            {
                return true; 
            }
            else
            {
                return false;
            }
                
        }

        public static bool operator <(VanDongVien vdv1, VanDongVien vdv2)
        {
            if (vdv1.chieucao > vdv2.chieucao)
            {
                return true;
            }
            else if (vdv1.chieucao < vdv2.chieucao)
            {
                return false;
            }
            else if (vdv1.cannang > vdv2.cannang)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

    class Program
    {

        public static void swap(ref VanDongVien a,ref VanDongVien b)
        {
            VanDongVien temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void Bubblesort(VanDongVien[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        swap(ref arr[j], ref arr[j + 1]);
        }

        static void Main(string[] args)
        {
            int soSV;
            Console.Write("Nhap vao so luong vdv: ");
            soSV = Convert.ToInt32(Console.ReadLine());
            VanDongVien[] list_vdv = new VanDongVien[soSV];

            for (int i = 0; i < soSV; i++)
            {
                Console.Write("Nhap vao van dong vien thu {0}:\n",i+2);
                list_vdv[i] = new VanDongVien();
                list_vdv[i].Nhap();
            }

            VanDongVien vd1 = new VanDongVien("Dung 1", "Bong",18,55,1.75);

            Console.WriteLine("\nHIEN THI DANH SACH VDV: ");

            vd1.HienThi();
            for (int i = 0; i < soSV; i++)
            {
                list_vdv[i].HienThi();
            }

            Bubblesort(list_vdv, soSV);

            for (int i = 0; i < soSV; i++)
            {
                list_vdv[i].HienThi();
            }
            Console.ReadKey();


        }
    }
}
