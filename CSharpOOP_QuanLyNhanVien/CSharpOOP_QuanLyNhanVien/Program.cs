using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyNhanVien
{
    class CanBo
    {
        private string hoten;
        private string gioitinh;
        private string diachi;
        private int tuoi;

        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public CanBo(string hoten, string gioitinh, string diachi, int tuoi)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.tuoi = tuoi;
        }

        public CanBo()
        {
            hoten = "";
            gioitinh = "";
            diachi = "";
            tuoi = 0;
        }

    }

    class CongNhan : CanBo
    {
        int bac;

        public CongNhan(string hoten, string gioitinh, string diachi, int tuoi, int bac) : base(hoten,gioitinh,diachi,tuoi)
        {
            this.bac = bac;
        }

        public CongNhan() : base()
        {
            bac = 0;
        }

        public int Bac { get => bac; set => bac = value; }

        public override string ToString()
        {
            return "Worker{" +
                "level='" + bac + '\'' +
                ", name='" + Hoten + '\'' +
                ", age=" + Tuoi +
                ", gender='" + Gioitinh + '\'' +
                ", address='" + Diachi + '\'' +
                '}';
        }
    }

    class KySu : CanBo
    {
        private string nganhdaotao;

        public KySu(string hoten, string gioitinh, string diachi, int tuoi, string nganhdaotao) : base(hoten, gioitinh, diachi, tuoi)
        {
            this.nganhdaotao = nganhdaotao;
        }

        public KySu() : base ()
        {
            nganhdaotao = "";
        }

        public string Nganhdaotao { get => nganhdaotao; set => nganhdaotao = value; }

        public override string ToString()
        {
            return "Engineer{" +
                "branch='" + nganhdaotao + '\'' +
                ", name='" + Hoten + '\'' +
                ", age=" + Tuoi +
                ", gender='" + Gioitinh + '\'' +
                ", address='" + Diachi + '\'' +
                '}';
        }


    }

    class NhanVien : CanBo
    {
        private string congviec;

        public string Congviec { get => congviec; set => congviec = value; }

        public NhanVien(string hoten, string gioitinh, string diachi, int tuoi, string congviec) : base(hoten, gioitinh, diachi, tuoi)
        {
            this.congviec = congviec;
        }

        public NhanVien() : base ()
        {
            congviec = "";
        }

        public override string ToString()
        {
            return "Staff{" +
                "branch='" + congviec + '\'' +
                ", name='" + Hoten + '\'' +
                ", age=" + Tuoi +
                ", gender='" + Gioitinh + '\'' +
                ", address='" + Diachi + '\'' +
                '}';
        }


    }

    class QuanLyCanBo
    {
        private List<CanBo> dsCanBo;

        public QuanLyCanBo()
        {
            dsCanBo = new List<CanBo>(0);
        }

        public void ThemCanBo(CanBo canBo)
        {
            dsCanBo.Add(canBo);
        }

        public void InDS()
        {
            foreach (var item in dsCanBo)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(item.ToString());
            }
        }

        public void TimKiemTenCB(string tenCB)
        {
            if (dsCanBo != null && dsCanBo.Any(x => x.Hoten == tenCB))
            {
                CanBo obj = dsCanBo.Find(x => (x.Hoten == tenCB));
                Console.WriteLine("Thong tin can bo co ten {0} :",tenCB);
                Console.WriteLine(obj.ToString());

            }
            else
            {
                Console.WriteLine("Khong co can bo ten: "+tenCB);
            }
        }
    }


    class Program
    {
        public static void themCB(ref string hoten, ref int tuoi, ref string gioitinh, ref string diachi)
        {
            Console.Write("Nhap vao hoten:  ");
            hoten = Console.ReadLine();
            Console.Write("Nhap vao tuoi: ");
            tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao gioitinh: ");
            gioitinh = Console.ReadLine();
            Console.Write("Nhap vao diachi: ");
            diachi = Console.ReadLine();

        }
        static void Main(string[] args)
        {
            QuanLyCanBo quanLyCanBo = new QuanLyCanBo();
            string hoten = "";
            string gioitinh = "";
            string diachi = "";
            int tuoi = 0;
            while (true)
            {
                
                Console.WriteLine("\n1. Them Can Bo.");
                Console.WriteLine("2. In Danh Sach Can Bo.");
                Console.WriteLine("3. Tim Kiem Can Bo (Theo ten).");
                Console.WriteLine("4. Thoat !");

                Console.WriteLine("Vui long chon:  ");
                int chon;
                chon = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (chon)
                {
                    case 1:
                        {
                            Console.WriteLine("Chon them can bo: ");
                            Console.WriteLine("\t 1. Cong Nhan");
                            Console.WriteLine("\t 2. Ky Su");
                            Console.WriteLine("\t 3. Nhan Vien");
                            Console.WriteLine("\t 4. Quay lai");
                            int c;
                            c = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (c)
                            {
                                case 1:
                                    {
                                        themCB(ref hoten, ref tuoi, ref gioitinh, ref diachi);
                                        int bac;
                                        Console.Write("Nhap vao bac:  ");
                                        bac = Convert.ToInt32(Console.ReadLine());
                                        CanBo congnhan = new CongNhan(hoten,gioitinh,diachi,tuoi,bac);
                                        quanLyCanBo.ThemCanBo(congnhan);
                                        Console.WriteLine("Them Thanh Cong ! ");
                                        break;  
                                    }
                                case 2:
                                    {
                                        themCB(ref hoten, ref tuoi, ref gioitinh, ref diachi);
                                        string bac;
                                        Console.Write("Nhap nganh dao tao:  ");
                                        bac = Console.ReadLine();
                                        CanBo kysu = new KySu(hoten, gioitinh, diachi, tuoi, bac);
                                        quanLyCanBo.ThemCanBo(kysu);
                                        Console.WriteLine("Them Thanh Cong ! ");
                                        break;
                                    }
                                case 3:
                                    {
                                        themCB(ref hoten, ref tuoi, ref gioitinh, ref diachi);
                                        string bac;
                                        Console.Write("Nhap cong viec  ");
                                        bac = Console.ReadLine();
                                        CanBo nhanvien = new NhanVien(hoten, gioitinh, diachi, tuoi, bac);
                                        quanLyCanBo.ThemCanBo(nhanvien);
                                        Console.WriteLine("Them Thanh Cong ! ");
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                            break;  
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("In Danh Sach Can Bo:");
                            quanLyCanBo.InDS();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("Nhap vao ten can bo can tim: ");
                            string tencb;
                            tencb = Console.ReadLine();
                            quanLyCanBo.TimKiemTenCB(tencb);
                            break;
                        }
                    default: { Console.WriteLine("Ket Thuc !");
                            return;
                        }
                }
                
            }
            Console.ReadKey();


        }
    }
}
