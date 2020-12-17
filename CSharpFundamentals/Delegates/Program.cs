using System;

namespace Delegates
{
    class Program
    {
        delegate void testDel(string str);
        static void Main(string[] args)
        {
            // deltegate can be used to hold function as a variable
            //Demo();
            // deltegate can have mulitple functions
            //Demo1();
            // deletegate can be passed to other function
            Demo3();
        }

        static void Demo()
        {
            testDel a = Func1;
            a("test");
        }
        static void Demo1()
        {
            testDel a = Func1;
            a += Func2;
            a("test");
        }
        static void Demo3()
        {
            Method(Func1);
            testDel a = Func1;
            a+= Func2;
            Method(a);
        }
        static void Method(testDel a)
        {
            Console.WriteLine("it is my method");
            a("jdljlfj");
        }
        static void Func1(string a)
        {
            Console.WriteLine("Func 1 "+a );
        }
        static void Func2(string str)
        {
            Console.WriteLine("Func 2: "+str);
        }
    }
}
