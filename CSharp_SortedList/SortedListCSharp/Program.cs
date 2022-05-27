using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SortedListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion

            SortedList MySL = new SortedList(); // khởi tạo 1 SortedList rỗng

            SortedList MySL2 = new SortedList(5); // khởi tạo 1 SortedList và chỉ định Capacity ban đầu là 5

            /*
             * Khởi tạo 1 SortedList có kích thước bằng với MySL2.
             * Sao chép toàn độ phần tử trong MySL2 vào MySL3.
             */
            SortedList MySL3 = new SortedList(MySL2);

            /*
             * Mình định nghĩa 1 lớp PersonComparer có thực thi 1 interface IComparer
             * Sau đó override lại phương thức Compare.
             * Sử dụng lớp trên để truyển vào constructor của SortedList.
             */
            SortedList MySL4 = new SortedList(new PersonComparer());

            /*
             * Tạo 1 SortedList mới và sao chép các phần tử từ MySL3 đồng thời sắp xếp các phần tử lại
             * theo cách sắp xếp được định nghĩa trong lớp PersonComparer.
             */
            SortedList MySL5 = new SortedList(MySL3, new PersonComparer());

            #endregion

            #region Ví dụ sử dụng SortedList
            
            // tạo 1 SortedList và truyền vào cách sắp xếp các Key trong SortedList này.
            SortedList MySL6 = new SortedList(new PersonComparer());
            
            MySL6.Add(new Person("HowKteam", 20), 10);
            MySL6.Add(new Person("Kteam", 2), 15);

            foreach (DictionaryEntry item in MySL6)
            {
                Console.WriteLine(" Key: " + item.Key + "\tValue: " + item.Value);
            }

            #endregion

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Định nghĩa 1 lớp thực thi interface IComparer.
    /// override phương thức Comparer và định nghĩa cách sắp xếp trong đó.
    /// Chi tiết bạn có thể xem lại bài ArrayList trong C#.
    /// </summary>
    class PersonComparer : IComparer
    {

        public int Compare(object x, object y)
        {
            Person a = x as Person;
            Person b = y as Person;

            if (a == null || b == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (a.Age > b.Age)
                {
                    return 1;
                }
                else if (a.Age == b.Age)
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
