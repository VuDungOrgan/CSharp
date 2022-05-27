using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_PtrinhBac2
{
    class PTrinhBac2 {
        private int a;
        private int b;
        private int c;

        public PTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

     
        public PTrinhBac2()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }
        double delta = 0;
        public void del(double del,int a, int b, int c)
        {
            delta = b * b - 4 * a * c;
        }
        public void giaiptB2()
        {
            del(delta, a, b, c);
            if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(delta)) / 2 * a));
                Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(delta)) / 2 * a));

            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b / 2 * a);
            }
            else if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
          
    }


    class Program
    {
        static void Main(string[] args)
        {
            PTrinhBac2 pt1 = new PTrinhBac2(1, -3, 2);
            pt1.giaiptB2();
            Console.ReadKey();
        }
    }
}
