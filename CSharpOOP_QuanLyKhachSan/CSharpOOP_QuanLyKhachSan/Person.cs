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
        private DateTime ngaythue;
        private Room loaiPhong;

        public Person(string hoten, string cmnd, int tuoi, int soNgaythue, DateTime ngaythue, Room loaiPhong)
        {
            this.hoten = hoten;
            this.cmnd = cmnd;
            this.tuoi = tuoi;
            this.soNgaythue = soNgaythue;
            this.ngaythue = ngaythue;
            this.loaiPhong = loaiPhong;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public int SoNgaythue { get => soNgaythue; set => soNgaythue = value; }
        public DateTime Ngaythue { get => ngaythue; set => ngaythue = value; }
        internal Room LoaiPhong { get => loaiPhong; set => loaiPhong = value; }

        public override string ToString()
        {
            return "Person{" +
                "name='" + hoten + '\'' +
                ", age=" + tuoi +
                ", passport='" + cmnd +"', ngay thue=' "+ngaythue+"',"+  loaiPhong.ToString() +
                '}';
        }

    }
}
