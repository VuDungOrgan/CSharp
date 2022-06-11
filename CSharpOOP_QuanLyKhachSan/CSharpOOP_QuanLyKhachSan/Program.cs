using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLyKhachSan
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            while (true)
            {
                Console.WriteLine("\n1. Thue phong");
                Console.WriteLine("2. Xoa Khach (theo CMND)");
                Console.WriteLine("3. Tinh tien (theo CMND)");
                Console.WriteLine("4. In DS Khach thue ");
                Console.WriteLine("5. Thong Ke ");
                Console.WriteLine("6. Phong dat nhieu nhat - it nhat nam ");
                Console.WriteLine("7. Tinh tien thue ");
                Console.WriteLine("8. Thoat !");
                Console.WriteLine("Moi ban chon: ");
                int chon;
                chon = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (chon)
                {
                    case 1:
                        {
                            Console.WriteLine("======= Them khach thue Phong =======");
                            Console.Write("Ho ten: ");
                            string hoten = Console.ReadLine();
                            Console.Write("Tuoi: ");
                            int tuoi = Convert.ToInt32(Console.ReadLine());
                            Console.Write("CMND: ");
                            string cmnd = Console.ReadLine();
                            Console.Write("So ngay thue: ");
                            int songaythue = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Chon Phong: ");
                            Console.WriteLine("\t 1.Loai A ");
                            Console.WriteLine("\t 2.Loai B ");
                            Console.WriteLine("\t 3.Loai C ");
                            string loaiphong = Console.ReadLine();
                            Room room;
                            if (loaiphong.Equals("1"))
                            {
                                room = new RoomA();
                            }
                            else if (loaiphong.Equals("2"))
                            {
                                room = new RoomB();
                            }
                            else if (loaiphong.Equals("3"))
                            {
                                room = new RoomC();
                            }
                            else
                            {
                                continue;
                            }
                            Console.WriteLine("Ngay bat dau thue: ");
                            Console.Write("\t 1.Ngay: ");
                            int ngay = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\t 2.Thang: ");
                            int thang = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\t 3.Nam:  ");
                            int nam = Convert.ToInt32(Console.ReadLine());
                            DateTime ngaythue = new DateTime(nam,thang, ngay);
                            Person person = new Person(hoten,cmnd,tuoi,songaythue,ngaythue,room);
                            hotel.addPerson(person);

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("====== Xoa khach thue phong ========");
                            Console.Write("Nhap vao CMND cua khach can xoa: ");
                            string cmnd = Console.ReadLine();
                            hotel.deletePeron(cmnd);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("====== Tinh Tien ========");
                            Console.Write("Nhap vao CMND cua khach: ");
                            string cmnd = Console.ReadLine(); 
                            hotel.calPrice(cmnd);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("====== DANH SACH ========");
                            Console.WriteLine("Luu y: Ngay thue phong duoc in theo thang-ngay-nam");
                            hotel.showInfo();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("====== Thong Ke  ========");
                            Console.WriteLine("1. Thong ke thang");
                            Console.WriteLine("2. Thong ke nam");
                            Console.Write("Moi chon: ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            switch (c)
                            {
                                case 1:
                                    {
                                        Console.Write("Nhap thang");
                                        int thang = Convert.ToInt32(Console.ReadLine());
                                        hotel.thongKeThueTheoThang(thang);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Nhap nam");
                                        int nam = Convert.ToInt32(Console.ReadLine());
                                        hotel.thongKeThueTheoNam(nam);
                                        break;
                                    }
                                default: {
                                        Console.WriteLine("LOI !");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("====== Phong Thue Nhieu - It Nhat  ========");
                            Console.Write("Nhap Nam: ");
                            int namc = Convert.ToInt32(Console.ReadLine());
                            hotel.phongDatNhieuNhat(namc);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("====== Tinh Tong Tien  ========");
                            Console.WriteLine("1. Tong Tien thang");
                            Console.WriteLine("2. Tong Tien nam");
                            Console.Write("Moi chon: ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            switch (c)
                            {
                                case 1:
                                    {
                                        Console.Write("Nhap thang");
                                        int thang = Convert.ToInt32(Console.ReadLine());
                                        hotel.thongKeThueTheoThang(thang);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Nhap nam");
                                        int nam = Convert.ToInt32(Console.ReadLine());
                                        hotel.thongKeThueTheoNam(nam);
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("LOI !");
                                        break;
                                    }
                            }
                            break;
                        }

                    default:
                        {
                            return;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}
