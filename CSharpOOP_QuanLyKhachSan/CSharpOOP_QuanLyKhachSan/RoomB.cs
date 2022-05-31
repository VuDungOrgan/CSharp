using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyKhachSan
{
    class RoomB : Room
    {
        public RoomB() : base()
        {
            GiaPhong = 300;
            LoaiPhong = "B";
        }
        public override String ToString()
        {
            return "RoomA{" +
                    "category='" + LoaiPhong + '\'' +
                    ", price=" + GiaPhong +
                    '}';
        }
    }
}
