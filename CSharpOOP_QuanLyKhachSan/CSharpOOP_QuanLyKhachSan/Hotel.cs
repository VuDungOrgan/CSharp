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

        public void thongKeThueTheoThang(int thang)
        {
            int demSoNguoiThue = 0;
            int tongSotien = 0;
            int thueRoomA = 0;
            int thueRoomB = 0;
            int thueRoomC = 0;
            foreach (var item in dsNguoiThue)
            {
                if (item != null && item.Ngaythue.Month == thang)
                {
                    demSoNguoiThue++;
                    tongSotien += item.LoaiPhong.GiaPhong * item.SoNgaythue;
                    if(item.LoaiPhong.GiaPhong == 500)
                    {
                        thueRoomA++;
                    }else if (item.LoaiPhong.GiaPhong == 300)
                    {
                        thueRoomB++;
                    }
                    else
                    {
                        thueRoomC++;
                    }
                }
            }

            Console.WriteLine("So nguoi thue trong thang: "+demSoNguoiThue);
            Console.WriteLine("So tong so tien : "+tongSotien);
            Console.WriteLine("phong A {0} nguoi thue ",thueRoomA);
            Console.WriteLine("phong B {0} nguoi thue ", thueRoomB);
            Console.WriteLine("phong C {0} nguoi thue ", thueRoomC);


        }

        public void thongKeThueTheoNam(int thang)
        {
            int demSoNguoiThue = 0;
            int tongSotien = 0;
            int thueRoomA = 0;
            int thueRoomB = 0;
            int thueRoomC = 0;
            foreach (var item in dsNguoiThue)
            {
                if (item != null && item.Ngaythue.Year == thang)
                {
                    demSoNguoiThue++;
                    tongSotien += item.LoaiPhong.GiaPhong * item.SoNgaythue;
                    if (item.LoaiPhong.GiaPhong == 500)
                    {
                        thueRoomA++;
                    }
                    else if (item.LoaiPhong.GiaPhong == 300)
                    {
                        thueRoomB++;
                    }
                    else
                    {
                        thueRoomC++;
                    }
                }
            }

            Console.WriteLine("So nguoi thue trong nam: " + demSoNguoiThue);
            Console.WriteLine("So tong so tien : "+ tongSotien);
            Console.WriteLine("phong A {0} nguoi thue ", thueRoomA);
            Console.WriteLine("phong B {0} nguoi thue ", thueRoomB);
            Console.WriteLine("phong C {0} nguoi thue ", thueRoomC);


        }

        public void phongDatNhieuNhat(int nam)
        {
            int thueRoomA = 0;
            int thueRoomB = 0;
            int thueRoomC = 0;
            foreach (var item in dsNguoiThue)
            {
                if (item != null && item.Ngaythue.Year == nam)
                {
                    if (item.LoaiPhong.GiaPhong == 500)
                    {
                        thueRoomA++;
                    }
                    else if (item.LoaiPhong.GiaPhong == 300)
                    {
                        thueRoomB++;
                    }
                    else
                    {
                        thueRoomC++;
                    }
                }               
            }

            int max = Math.Max(thueRoomA, Math.Max(thueRoomB, thueRoomC));
            int min = Math.Min(thueRoomA, Math.Min(thueRoomB, thueRoomC));
            
            if (max == thueRoomA)
            {
                Console.WriteLine("Phong duoc thue nhieu nhat la : {0} - So lan thue: {1}", "A", max);
            }
            else if (max == thueRoomB)
            {
                Console.WriteLine("Phong duoc thue nhieu nhat la : {0} - So lan thue: {1}", "B", max);
            }
            else
            {
                Console.WriteLine("Phong duoc thue nhieu nhat la : {0} - So lan thue: {1}", "C", max);
            }

            if (min == thueRoomA)
            {
                Console.WriteLine("Phong duoc thue it nhat la : {0} - So lan thue: {1}", "A", min);
            }
            else if (min == thueRoomB)
            {
                Console.WriteLine("Phong duoc thue it nhat la : {0} - So lan thue: {1}", "B", min);
            }
            else
            {
                Console.WriteLine("Phong duoc thue it nhat la : {0} - So lan thue: {1}", "C", min);
            }
        }


    }
}
