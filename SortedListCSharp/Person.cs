using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedListCSharp
{
    public class Person
    {
        public Person()
        {
 
        }
        
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private string name;
        private int age;
        private string p;
        private int p_2;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
          get { return name; }
          set { name = value; }
        }

        public override string ToString()
        {
            return Name + " - " + Age;
        }
    }
}
