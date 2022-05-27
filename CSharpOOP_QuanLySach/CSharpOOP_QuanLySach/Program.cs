using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_QuanLySach
{
    interface IBook
    {
        string this [int index]
        {
            get;
            set;
        }
        string Title
        {
            get;
            set;
        }

        string Author
        {
            get;
            set;
        }

        string Publisher
        {
            get;
            set;
        }

        string ISBN
        {
            get;
            set;
        }

        int Year
        {
            get;
            set;
        }

        void show();
        void input();

    }


    class Book : IBook
    {
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;

        private ArrayList chapter = new ArrayList();

        public string this[int index] {
            get
            {
                if (index >= 0 && index < chapter.Count)
                {
                    return (string)chapter[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

            set
            {
                if (index >= 0 && index < chapter.Count)
                {
                    chapter[index] = value;
                }
                else if (index == chapter.Count)
                {
                    chapter.Add(value);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

        }

        public string Title { get { return title; } set { title = value; }  }
        public string Author { get { return author; } set { author = value; } }
        public string Publisher { get { return publisher; } set { publisher = value; } }
        public string ISBN { get { return isbn; } set { isbn = value; } }
        public int Year { get { return year; } set { year = value; } }

        public void input()
        {
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Author: ");
            author = Console.ReadLine();
            Console.Write("Publisher: ");
            publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Year: ");
            year  =  Convert.ToInt32(Console.ReadLine());
            string str;
            Console.WriteLine("Nhap cac chuong (nhap rong de dung lai): ");
            int i = 0;
            do
            {
                i++;
                Console.Write("Chuong {0}: ",i);
                str = Console.ReadLine();
                if (str.Length > 0)
                {
                    chapter.Add(str);
                }
            } while (str.Length > 0);

        }

        public void show()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Title: "+title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Danh sach cac chuong: ");
            for (int i = 0; i < chapter.Count; i++)
            {
                Console.WriteLine("\t {0}: {1}",i+1,chapter[i]);
            }
            Console.WriteLine("-----------------------------------");
        }
    }


    class BookList
    {
        private ArrayList list = new ArrayList();

        public void addBook()
        {
            Book b = new Book();
            b.input();
            list.Add(b);
        }

        public void showBook()
        {
            Console.WriteLine("\n   DANH SACH :");
            list.Sort(new SortYear());
            foreach (Book item in list)
            {
                item.show();
            }
        }

        public void InputToList() {
            int n = 0;
            Console.Write("Nhap vao so sach can nhap: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                addBook();
            }
        }
    }

    public class SortYear : IComparer
    {
        public int Compare(object x, object y)
        {
            Book b1 = x as Book;
            Book b2 = y as Book;
            if (b1 == null || b2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if(b1.Year > b2.Year)
                {
                    return 1;
                }else if(b1.Year == b2.Year)
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

    class Program
    {
        static void Main(string[] args)
        {
            BookList blist = new BookList();
            blist.InputToList();
            blist.showBook();
            Console.ReadKey();
        }
    }
}
