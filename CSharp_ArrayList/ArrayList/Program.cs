using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace ArrayListTrongCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Khởi tạo ArrayList

            ArrayList MyArray = new ArrayList(); // khởi tạo 1 ArrayList rỗng

            ArrayList MyArray2 = new ArrayList(5); // khởi tạo 1 ArrayList và chỉ định Capacity ban đầu là 5

            /*
             * Khởi tạo 1 ArrayList có kích thước bằng với MyArray2.
             * Sao chép toàn độ phần tử trong MyArray2 vào MyArray3.
             */
            ArrayList MyArray3 = new ArrayList(MyArray2);

            //Hoặc có thể sử dụng
            ArrayList MyArr3 = (ArrayList) MyArray2.Clone();


            #endregion

            #region Sắp xếp 1 danh sách object trong ArrayList
            
            // Tạo 1 danh sách kiểu ArrayList rỗng
            ArrayList arrPersons = new ArrayList();

            // Thêm 3 Person vào danh sách
            arrPersons.Add(new Person("Nguyen Van A", 18));
            arrPersons.Add(new Person("Nguyen Van B", 25));
            arrPersons.Add(new Person("Nguyen Van C", 20));

            // In thử danh sách Person ban đầu ra.
            Console.WriteLine("Danh sach Person ban dau: ");

     
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }

            /* 
             * Thực hiện sắp xếp danh sách Person theo tiêu chí đã được định nghĩa 
             * trong phương thức Compare của lớp SortPerson (tuổi tăng dần).
             */

            //Test Clone()
            Console.WriteLine("Danh sach Person clone Ban Dau : ");
            ArrayList cloneArrPerson = (ArrayList)arrPersons.Clone();
            foreach (Person item in cloneArrPerson)
            {
                Console.WriteLine(item.ToString());
            }

            // LUU Y QUAN TRONG: Khi Thêm hoặc Xóa trongArrayList nên dùng for thay vì foreach;
            // Có thể dùng Foreach theo 2 cách bên dưới nhưng ít hiệu quả:
            
            //Xóa = For:
            for(int i=0;i < cloneArrPerson.Count; i++)
            {
                Person ArrayListUnit = cloneArrPerson[i] as Person;
                if (ArrayListUnit.Age==25)
                {
                    cloneArrPerson.RemoveAt(i);
                    // some other codes
                }
            }
            
            //Xóa = foreach:
                //C1:
            foreach (Person item in new ArrayList(cloneArrPerson))
            {
                if(item.Age == 25)
                {
                    cloneArrPerson.Remove(item);
                }
            }
            //C2:
            foreach (Person item in cloneArrPerson)
            {
                if (item.Age == 25)
                {
                    cloneArrPerson.RemoveRange(1,2);
                    break;
                }
            }

            //Console.WriteLine("Danh sach Person clone sau khi xoa : ");
            //foreach (Person item in cloneArrPerson)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            ////Sort
            arrPersons.Sort(new SortPersons());

            // In danh sách Person đã được sắp xếp ra màn hình.
            Console.WriteLine();
            Console.WriteLine("Danh sach Person da duoc sap xep theo tuoi tang dan: ");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion

            Console.ReadLine();
        }
    }

    public class SortPersons : IComparer
    {
        public int Compare(object x, object y)
        {
            // Ép kiểu 2 object truyền vào về Person.
            Person p1 = x as Person;
            Person p2 = y as Person;

            /*
             * Vì có thể 2 object truyền vào không phải Person khi đó ta không thể so sánh được.
             * Trường hợp này tốt nhất ta nên ném ra lỗi để lập trình viên sửa chữa.
             * Chi tiết về exception sẽ được trình bày ở những bài học sau.
             */
            if (p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                /*
                 * Khi dữ liệu đã ok thì ta thực hiện so sánh và trả về các giá trị 1 0 -1 tương ứng
                 * lớn hơn, bằng, bé hơn.
                 */
                if (p1.Age < p2.Age)
                {
                    return 1;
                }
                else if (p1.Age == p2.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
