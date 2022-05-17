using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2_B13
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, m, y, top, dayofweek;
             Console.Write("Nhap vao ngay = ");
            d =  Convert.ToInt32(Console.ReadLine());
             Console.Write("Nhap vao thang = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao nam = ");
            y = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (d < 1 || d > 31)
                {
                     Console.WriteLine("Ngay ko hop le");
                    break;
                }
                if (m < 1 || m > 12)
                {
                     Console.WriteLine("Thang ko hop le");
                    break;
                }
                if (y < 1582)
                {
                     Console.WriteLine("Nam ko hop le");
                    break;
                }
                switch (m)
                {
                    case 4:
                        {
                            top = 30;
                            break;
                        }
                    case 6:
                        {
                            top = 30;
                            break;
                        }
                    case 9:
                        {
                            top = 30;
                            break;
                        }
                    case 11:
                        {
                            top = 30;
                            break;
                        }
                    case 2:
                        {
                            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                            {
                                top = 29;
                                break;
                            }
                            else
                            {
                                top = 28;
                                break;
                            }

                        }
                    default:
                        {
                            top = 31;
                            break;
                        }
                }
                Console.WriteLine("Hop le.");
                y -= (14 - m) / 12;
                m += 12 * ((14 - m) / 12) - 2;
                dayofweek = (d + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;
                if (dayofweek == 0)
                {
                     Console.WriteLine("Chu nhat");
                    break;
                }
                else
                {
                    dayofweek++;
                     Console.WriteLine("Thu " + dayofweek);
                    break;
                }
            }
            Console.ReadKey();
        }
        
    }
}
