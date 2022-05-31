using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyKhachSan
{
    class RoomC : Room
    {
        public RoomC() : base()
        {
            GiaPhong = 100;
            LoaiPhong = "C";
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
