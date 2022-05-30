using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyThuVien
{
    class QuanLyTaiLieu
    {
        List<TaiLieu> dsTaiLieu ;

        public QuanLyTaiLieu()
        {
            dsTaiLieu = new List<TaiLieu>(0);
        }

        public void themTL(TaiLieu taiLieu)
        {
            dsTaiLieu.Add(taiLieu);
        }

        public void xoaTL(string id)
        {

            if (dsTaiLieu != null && dsTaiLieu.Any(x => x.Id == id))
            {
                TaiLieu obj = dsTaiLieu.Find(x => (x.Id == id));
                dsTaiLieu.Remove(obj);
                Console.WriteLine("Xoa thanh cong !");
            }
            else
            {
                Console.WriteLine("Xoa that bai !");
            }
            
        }

        public void timTLtheoSach()
        {
            foreach(var item in dsTaiLieu.OfType<Sach>())
            {
                Console.WriteLine("--------------------------------");
                Console.Write(item.ToString());
            }
        }

        public void timTLtheoBao()
        {
            foreach (var item in dsTaiLieu.OfType<Bao>())
            {
                Console.WriteLine("--------------------------------");
                Console.Write(item.ToString());
            }
        }

        public void timTLtheoTapChi()
        {
            foreach (var item in dsTaiLieu.OfType<TapChi>())
            {
                Console.WriteLine("--------------------------------");
                Console.Write(item.ToString());
            }
        }
        public void inTaiLieu()
        {
            foreach(var item in dsTaiLieu)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(item.ToString());
            }
        }
    }
}
