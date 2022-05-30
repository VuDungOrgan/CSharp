using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyThuVien
{
    class TaiLieu
    {
        private string id;
        private string tenXB;
        private int soPH;

        public string Id { get => id; set => id = value; }
        public string TenXB { get => tenXB; set => tenXB = value; }
        public int SoPH { get => soPH; set => soPH = value; }

        public TaiLieu(string id, string tenXB, int soPH)
        {
            this.id = id;
            this.tenXB = tenXB;
            this.soPH = soPH;
        }

        public TaiLieu()
        {
            id = "";
            tenXB = "";
            soPH = 0;
        }

    }
}
