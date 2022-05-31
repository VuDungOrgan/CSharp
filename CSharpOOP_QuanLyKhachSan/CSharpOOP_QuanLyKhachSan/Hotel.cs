using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyKhachSan
{
    class Hotel
    {
        List<Person> dsNguoiThue;

        public Hotel()
        {
            dsNguoiThue = new List<Person>();
        }

        public void addPerson(Person person)
        {
            dsNguoiThue.Add(person);
        }

        public void showInfo()
        {
            Console.WriteLine("DANH SACH NGUOI THUE: ");
            foreach (var item in dsNguoiThue)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(item.ToString());
            }
        }

        public void deletePeron(string cmnd)
        {
            if(dsNguoiThue != null && dsNguoiThue.Any(x => x.Cmnd == cmnd))
            {
                Person personObj = dsNguoiThue.Find(x => (x.Cmnd == cmnd));
                dsNguoiThue.Remove(personObj);
                Console.WriteLine("Xoa thanh cong !");
            }
            else
            {
                Console.WriteLine("Xoa that bai !");
            }
        }

        public void calPrice(string cmnd)
        {
            if (dsNguoiThue != null && dsNguoiThue.Any(x => x.Cmnd == cmnd))
            {
                Person personObj = dsNguoiThue.Find(x => (x.Cmnd == cmnd));
                int tongtienTT = 0;

                tongtienTT = personObj.LoaiPhong.GiaPhong * personObj.SoNgaythue;

                Console.WriteLine("\nTong so tien ma \"{0}\" phai thanh toan la {1} ",personObj.Hoten,tongtienTT);

                
            }
            else
            {
                Console.WriteLine("\nTinh toan ko thanh cong !");
            }
        }
    }
}
