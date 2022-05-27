using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP_Animal
{
    interface IAnimal
    {
        void eat();
        void makeSound();
    }
    class Cat : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("Con meeo dang an");
        }

        public void makeSound()
        {
            Console.WriteLine("Con meeo keu meo meo");   
        }
        public void run()
        {
            Console.WriteLine("Con meo dang chay...");
        }
    }
    class Bird : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("Con chim dang an");
        }

        public void makeSound()
        {
            Console.WriteLine("Con chim keu cuc cu");
        }
        public void fly()
        {
            Console.WriteLine("Con chim dang bay...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bird conChim = new Bird();
            conChim.fly();

            Cat conMeo = new Cat();
            conMeo.run();

            Console.ReadKey();
        }
    }
}
