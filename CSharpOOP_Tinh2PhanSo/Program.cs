using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_Tinh2PhanSo
{
    class PhanSo
    {
        private int tuso;
        private int mauso;

        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }

        ~PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }

        public int Tuso {
            get => tuso;
            set => tuso = value;
        }
        public int Mauso {
            get => mauso;
            set
            {
                if (value != 0)
                    mauso = value;
            }
                
        }        

        public void Cong2PS(PhanSo ps3, PhanSo ps1, PhanSo ps2)
        {
            ps3.tuso = ps1.tuso * ps2.mauso + ps1.mauso * ps2.tuso;
            ps3.mauso = ps1.mauso * ps2.mauso;
        }

        public void Tru2PS(PhanSo obj3,PhanSo obj1, PhanSo obj2)
        {
            obj3.tuso = obj1.tuso * obj2.mauso - obj1.mauso * obj2.tuso;
            obj3.mauso = obj1.mauso * obj2.mauso;

        }
        public void Nhan2PS(PhanSo obj3,PhanSo obj1, PhanSo obj2)
        {
            obj3.tuso = obj1.tuso * obj2.tuso;
            obj3.mauso = obj1.mauso * obj2.mauso;
    
        }

        public void Chia2PS(PhanSo obj3,PhanSo obj1, PhanSo obj2)
        {
            obj3.tuso = obj1.tuso * obj2.mauso;
            obj3.mauso = obj1.mauso * obj2.tuso;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();

            ps1.Tuso = 3;
            ps1.Mauso = 5;
            ps2.Tuso = 2;
            ps2.Mauso = 5;
            ps3.Cong2PS(ps3,ps1,ps2);

            Console.WriteLine("Tong cua: {0}/{1} + {2}/{3} = {4}/{5}",ps1.Tuso,ps1.Mauso,ps2.Tuso,ps2.Mauso,ps3.Tuso,ps3.Mauso);
            
            

            Console.ReadKey();

        }
    }
}
