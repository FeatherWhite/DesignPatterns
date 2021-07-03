using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance(0);
            Console.WriteLine(singleton1.GetHashCode());
            Singleton singleton2 = Singleton.GetInstance(1);
            Console.WriteLine(singleton2.GetHashCode());
            Singleton singleton3 = Singleton.GetInstance(2);
            Console.WriteLine(singleton3.GetHashCode()); 
            Singleton singleton4 = Singleton.GetInstance(0);
            Console.WriteLine(singleton4.GetHashCode());
            Singleton singleton5 = Singleton.GetInstance(1);
            Console.WriteLine(singleton5.GetHashCode());
            Singleton singleton6 = Singleton.GetInstance(2);
            Console.WriteLine(singleton6.GetHashCode());
            Console.ReadLine();
        }
    }
}
