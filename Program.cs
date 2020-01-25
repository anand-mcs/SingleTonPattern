using System;

namespace SingleTonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTon obj1 = SingleTon.GetInstance;
            obj1.Display("Object 1");
            SingleTon obj2 = SingleTon.GetInstance;
            obj2.Display("Object 2");
            Console.WriteLine("Hello World!");
        }
    }
}
