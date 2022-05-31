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
            Room roomA = new RoomA();
            Room roomB = new RoomB();
            Room roomC = new RoomC();

            Person person1 = new Person("vudung", "123", 20, 10,roomA);
            Person person2 = new Person("vannang", "234", 20, 5, roomB);
            Person person3 = new Person("vantrung", "345", 20, 3, roomC);

            hotel.addPerson(person1);
            hotel.addPerson(person2);
            hotel.addPerson(person3);

            Console.WriteLine("DS truoc khi xoa: ");
            hotel.showInfo();

            Console.WriteLine("\nDS sau khi xoa: ");
            hotel.deletePeron("234");
            hotel.showInfo();

            hotel.calPrice("345");

            Console.ReadKey();
        }
    }
}
