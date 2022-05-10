using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLySV
{
    class Student
    {
        private string sID;
        private string ten;
        private string khoa;
        private double diemtb;

        public Student(string sID, string ten, string khoa, double diemtb)
        {
            this.sID = sID;
            this.ten = ten;
            this.khoa = khoa;
            this.diemtb = diemtb;
        }

        public Student()
        {
            sID = "";
            ten = "";
            khoa = "";
            diemtb = 0D;
        }

        ~Student()
        {
            sID = "";
            ten = "";
            khoa = "";
            diemtb = 0D;
        }

        public string SID { get => sID; set => sID = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public double Diemtb { get => diemtb; set => diemtb = value; }

        public void nhap()
        {
            Console.Write("Nhap vao maSV: ");
            sID = Console.ReadLine();
            Console.Write("Nhap vao tenSV: ");
            ten = Console.ReadLine();
            Console.Write("Nhap vao Khoa: ");
            khoa = Console.ReadLine();
            Console.Write("Nhap vao diem TB: ");
            diemtb = Convert.ToDouble(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ma SV: "+sID);
            Console.WriteLine("Ten SV: "+ten);
            Console.WriteLine("Khoa :"+khoa);
            Console.WriteLine("Diem TB: "+diemtb);
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            int soSV;
            Console.Write("Nhap vao so sv: ");
            soSV = Convert.ToInt32(Console.ReadLine());
            Student[] list_SV = new Student[soSV];

            //Nhap dssv
            for (int i = 0; i< soSV; i++)
            {
                list_SV[i] = new Student();
                list_SV[i].nhap();
            }

            //Xuat dssv
            for (int i = 0; i < soSV; i++)
            {
                list_SV[i].xuat();
            }

            Console.ReadKey();

        }
    }
}
