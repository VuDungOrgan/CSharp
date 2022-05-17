using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2_B21
{
    class Program
    {
        static void Main(string[] args)
        {
            double dc, d1, d2, d3, sum;
            char kv, dt;
            Console.Write("Nhap diem chuan: ");
            dc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem 3 mon thi: ");
            Console.Write("Mon 1: ");
            d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mon 2:");
            d2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mon 3: ");
            d3 = Convert.ToDouble(Console.ReadLine());
            if (d1 * d2 * d3 != 0)
            {
                Console.Write("Nhap vao khu vuc (A,B,C,X): ");
                kv = Convert.ToChar(Console.ReadLine());
                Console.Write("Nhap vao doi tuong(1,2,3,0): ");
                dt = Convert.ToChar(Console.ReadLine());
                sum = d1 + d2 + d3;
                switch (kv)
                {
                    case 'A':
                        {
                            sum += 2;
                            break;
                        }
                    case 'B':
                        {
                            sum += 1;
                            break;
                        }
                    case 'C':
                        {
                            sum += 0.5;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                switch (dt)
                {
                    case '1':
                        {
                            sum += 2.5;
                            break;
                        }
                    case '2':
                        {
                            sum += 1.5;
                            break;
                        }
                    case '3':
                        {
                            sum += 1;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                if (sum >= dc)
                {
                    Console.WriteLine("Dau - " + sum);
                }
                else
                {
                    Console.WriteLine("Rot - " + sum);
                }
            }
            else
            {
                Console.WriteLine("Rot - " + (d1 + d2 + d3));
            }
            Console.ReadKey();
        }
    }
}
