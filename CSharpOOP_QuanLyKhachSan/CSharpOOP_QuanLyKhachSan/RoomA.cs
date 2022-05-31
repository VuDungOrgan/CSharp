using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyKhachSan
{
    class RoomA : Room
    {
        public RoomA() : base()
        {
            GiaPhong = 500;
            LoaiPhong = "A";
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
