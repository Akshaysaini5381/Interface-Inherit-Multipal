using System;

namespace Interface_Inherit_Multipal
{
    interface F1
    {
        public abstract void M1();
    }
    interface F2:F1
    {
        void M2();
    }
    interface F3:F1,F2
    {
        public void M3();
    }

    class my:F1
    {
        public void M1()
        {
            Console.WriteLine("akshay :");
        }
    }
    class Program:F3
    {
        public void M1()
        {
            Console.WriteLine("Hello :");
        }
        public void M2()
        {
            Console.WriteLine("Hii :");
        }
        public void M3()
        {
            Console.WriteLine("Hello Sir :");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.M1();
            obj.M2();
            obj.M3();
            my obj1 = new my();
            obj1.M1();
        }
    }
}
