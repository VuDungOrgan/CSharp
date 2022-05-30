using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyDanCu
{
    class Nguoi
    {
        private string hoten;
        private string nghenghiep;
        private string cmnd;
        private int tuoi;

        public Nguoi(string hoten, string nghenghiep, string cmnd, int tuoi)
        {
            this.hoten = hoten;
            this.nghenghiep = nghenghiep;
            this.cmnd = cmnd;
            this.tuoi = tuoi;
        }

        public Nguoi()
        {
            hoten = "";
            nghenghiep = "";
            cmnd = "";
            tuoi = 0;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public string Nghenghiep { get => nghenghiep; set => nghenghiep = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public void nhapNguoi()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Nhap vao thong tin: ");
            Console.Write("Nhap vao hoten : ");
            hoten = Console.ReadLine();
            Console.Write("Nhap vao tuoi : ");
            tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao nghenghiep : ");
            nghenghiep = Console.ReadLine();
            Console.Write("Nhap vao cmnd : ");
            cmnd = Console.ReadLine();
            Console.WriteLine("-------------------------");
        }

        public void inNguoi()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Ho ten: "+hoten);
            Console.WriteLine("Tuoi: "+tuoi);
            Console.WriteLine("nghe nghiep: "+nghenghiep);
            Console.WriteLine("cmnd: "+cmnd);
            Console.WriteLine("-------------------------");
        }

    }

    class Hogiadinh
    {
        private string diachi;
        private List<Nguoi> dsNguoi = new List<Nguoi>();
        private int soTV;

        public string Diachi { get => diachi; set => diachi = value; }
        internal List<Nguoi> DsNguoi { get => dsNguoi; set => dsNguoi = value; }
        public int SoTV { get => soTV; set => soTV = value; }

        public Hogiadinh(string diachi, List<Nguoi> dsNguoi, int soTV)
        {
            this.diachi = diachi;
            this.dsNguoi = dsNguoi;
            this.soTV = soTV;
        }
        public Hogiadinh()
        {
            diachi = "";
            dsNguoi = new List<Nguoi>(0);
            soTV = 0;
        }
        public void nhapHoGD()
        {
            
            Console.Write("Nhap vao dia chi: ");
            diachi = Console.ReadLine();
            Console.Write("Nhap so luong TV: ");
            soTV = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            do
            {
                Console.WriteLine("Nhap vao nguoi thu {0}: ",i+1);
                Nguoi nguoi = new Nguoi();
                nguoi.nhapNguoi();
                //Nguoi obj = dsNguoi.Find(x => (x.Hoten == nguoi.Hoten));
                if (dsNguoi != null && dsNguoi.Any(x => x.Cmnd == nguoi.Cmnd))
                {
                    Console.WriteLine("Nhap vao nguoi thu {0} da trung CMND vui long nhap lai ! ",i+1);
                }
                else
                {
                    dsNguoi.Add(nguoi);
                    i++;
                }
            } while (i < soTV);
            Console.WriteLine("--------------------");
        }
        
        public void inHoGD()
        {
            Console.WriteLine("Dia chi "+diachi);
            Console.WriteLine("Danh sach TV: ");
            foreach (var item in dsNguoi)
            {
                item.inNguoi();
            }
        }

    }

    class KhuPho
    {
        private List<Hogiadinh> dsHGD = new List<Hogiadinh>();
        private ArrayList dsCMND = new ArrayList(0);
        private int soHGD;
        private string tenKhuPho;
     

        public KhuPho()
        {
            dsHGD = new List<Hogiadinh>(0);
            soHGD = 0;
            tenKhuPho = "";
        }

        public KhuPho(List<Hogiadinh> dsHGD, int soHGD, string tenKhuPho)
        {
            this.dsHGD = dsHGD;
            this.soHGD = soHGD;
            this.tenKhuPho = tenKhuPho;
        }

        public int SoHGD { get => soHGD; set => soHGD = value; }
        public string TenKhuPho { get => tenKhuPho; set => tenKhuPho = value; }
        internal List<Hogiadinh> DsHGD { get => dsHGD; set => dsHGD = value; }

        public void nhapKhuPho()
        {
            Console.Write("Nhap vao ten khu pho: ");
            tenKhuPho = Console.ReadLine();
            Console.Write("Nhap vao so ho dan: ");
            soHGD = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < soHGD; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Nhap vao ho gia dinh thu {0}: ", i+1);
                Hogiadinh hogiadinh = new Hogiadinh();
                hogiadinh.nhapHoGD();
                foreach (var item in hogiadinh.DsNguoi)
                {
                    if (dsCMND.Contains(item.Cmnd) && dsCMND != null)
                    {
                        Console.WriteLine("Nguoi ten '{0}' da trung CMND vui long nhap lai ! ", item.Hoten);
                        i--;
                        break;
                    }
                    else
                    if (item == hogiadinh.DsNguoi.Last())
                    {
                        foreach(var ds in hogiadinh.DsNguoi)
                        {
                            dsCMND.Add(ds.Cmnd);
                        }
                        dsHGD.Add(hogiadinh);
                    }
                }
              
            }
        }

        public void inKhuPho()
        {
            Console.WriteLine("Khu pho {0} : ",tenKhuPho);
            Console.WriteLine("So Ho GD {0} :",soHGD);
            foreach (var item in dsHGD)
            {
                item.inHoGD();
            }
        }

    }


    class Program
    {
        
        static void Main(string[] args)
        {
            KhuPho khuPho = new KhuPho();
            khuPho.nhapKhuPho();
            khuPho.inKhuPho();
            Console.ReadKey();
        }
    }
}
