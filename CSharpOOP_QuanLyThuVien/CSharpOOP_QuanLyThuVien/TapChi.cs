using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyThuVien
{
    class TapChi : TaiLieu
    {
        private string ngaythangPH;
        private int soBan;

        public TapChi(string id, string tenXB, int soPH, string ngaythangPH, int soBan) : base (id,tenXB,soPH)
        {
            this.ngaythangPH = ngaythangPH;
            this.soBan = soBan;
        }

        public TapChi() : base()
        {
            ngaythangPH = "";
            soBan = 0;
        }

        public string NgaythangPH { get => ngaythangPH; set => ngaythangPH = value; }
        public int SoBan { get => soBan; set => soBan = value; }

        public override String ToString()
        {
            return "Journal{" +
                    "issueNumber=" + SoBan +
                    ", monthIssue=" + ngaythangPH +
                    ", id='" + Id + '\'' +
                    ", nxb='" + TenXB + '\'' +
                    ", number='" + SoPH + '\'' +
                    '}';
        }
    }
}
