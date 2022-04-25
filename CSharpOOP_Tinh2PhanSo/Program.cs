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
            set => mauso = value;
        }

        public void nhap()
        {
            
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
