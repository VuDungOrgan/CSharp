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

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
