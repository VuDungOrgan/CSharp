using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyKhachSan
{
    class Person
    {
        private string hoten;
        private string cmnd;
        private int tuoi;
        private int soNgaythue;
        private Room loaiPhong;

        public string Hoten { get => hoten; set => hoten = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public int SoNgaythue { get => soNgaythue; set => soNgaythue = value; }
        internal Room LoaiPhong { get => loaiPhong; set => loaiPhong = value; }

        public Person(string hoten, string cmnd, int tuoi, int soNgaythue, Room loaiPhong)
        {
            this.hoten = hoten;
            this.cmnd = cmnd;
            this.tuoi = tuoi;
            this.soNgaythue = soNgaythue;
            this.loaiPhong = loaiPhong;
        }
        public override string ToString()
        {
            return "Person{" +
                "name='" + hoten + '\'' +
                ", age=" + tuoi +
                ", passport='" + cmnd +"', " + loaiPhong.ToString() +
                '}';
        }

    }
}
