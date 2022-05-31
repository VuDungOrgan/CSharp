using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyKhachSan
{
    class Room
    {
        private int giaPhong;
        private string loaiPhong;

        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }

        public Room(int giaPhong, string loaiPhong)
        {
            this.giaPhong = giaPhong;
            this.loaiPhong = loaiPhong;
        }

        public Room()
        {
            giaPhong = 0;
            loaiPhong = "";
        }
    }
}
