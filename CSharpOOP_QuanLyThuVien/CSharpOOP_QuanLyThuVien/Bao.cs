using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyThuVien
{
    class Bao:TaiLieu 
    {
        string ngayPH;

        public string NgayPH { get => ngayPH; set => ngayPH = value; }

        public Bao(string id, string tenXB, int soPH, string ngayPH) : base (id,tenXB,soPH)
        {
            this.ngayPH = ngayPH;
        }

        public Bao() : base()
        {
            ngayPH = "";
        }

        public override String ToString()
        {
            return "Newspaper{" +
                    "dayIssue=" + ngayPH +
                    ", id='" + Id + '\'' +
                    ", nxb='" + TenXB + '\'' +
                    ", number='" + SoPH + '\'' +
                    '}';
        }
    }
}
