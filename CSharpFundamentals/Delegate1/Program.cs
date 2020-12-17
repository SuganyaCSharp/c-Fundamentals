using System;

namespace Delegate1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action m1 = Method1;
            m1();
            Action<int> m2 = Method2;
            m2(5);
            Action<int, int> m3 = Method3;
            m3(3, 3);
            Func<int> m4 = Method4;
            m4();
            Func<int, int> m5 = Method5;
            m5(4);
            Func<int, int, int> m6 = Method6;
            m6(4, 4);
            Func<int, string, int> m7 = Method7;
            m7(2, "sugu");
            Predicate<int> m9 = Method9;
            Console.WriteLine(m9(11));
            Func<int, string, string> m11 = Method11;
            Console.WriteLine(m11(5, "venakt"));
        }
        static int Addnum(int num1, int num2)
        {
            return (num1 + num2);
        }
        static int Multinum(int num1, int num2)
        {
            return (num1 * num2);
        }
        static void Method1()
        {
            Console.WriteLine("method1");
        }
        static void Method2(int a)
        {
            Console.WriteLine("method2");
        }
        static void Method3(int a, int b)
        {
            Console.WriteLine("method3");
        }
        static int Method4()
        {
            Console.WriteLine("method4");
            return 5;
        }
        static int Method5(int a)
        {
            Console.WriteLine("method5");
            return a * a;
        }
        static int Method6(int a, int b)
        {
            Console.WriteLine("method6");
            return a + b;
        }
        static int Method7(int a, string b)
        {
            Console.WriteLine("method7");
            return a + b.Length;
        }
        static bool Method8()
        {
            Console.WriteLine("method8");
            return true;
        }
        static bool Method9(int a)
        {
            Console.WriteLine("method9");
            return a % 2 == 0;
        }
        static bool Method10(int a, int b)
        {
            Console.WriteLine("method10");
            return a - b == 5;
        }
        static string Method11(int a, string str)
        {
            return str;
        }

    }
}
