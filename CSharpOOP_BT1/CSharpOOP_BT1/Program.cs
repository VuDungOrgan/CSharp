using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_BT1
{
    class Person
    {
        protected int Age;
        public void setAge(int age)
        {
            Age = age;
        }
        public void welcome()
        {
            Console.WriteLine("Xin Chao Vu Dung");
        }
    }

    class Student : Person
    {

        public void printAge()
        {
            Console.WriteLine("Tuoi cua ban la: "+Age);
        }

        public void gotoClass()
        {
            Console.WriteLine("Dung dang den truong");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.setAge(20);
            student.welcome();
            student.printAge();
            student.gotoClass();
            Console.ReadKey();
        }
    }
}
