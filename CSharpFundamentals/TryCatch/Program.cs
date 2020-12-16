using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void Caller1()
        {
            throwexception(20);
        }
        static void Caller2()
        {
            try
            {
                throwexception(20);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Caller3()
        {
            try
            {
                throwexception(20);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void throwexception(int x)
        {
            if (x <= 10)
            {
                Console.WriteLine(x);
            }
            else
            {
                throw new Exception("number is not valid");
            }
        }
        static void thrownullexception(int x)
        {
            if (x <= 10)
            {
                Console.WriteLine(x);
            }
            else
            {
                throw new NullReferenceException("number is not valid");
            }
        }

    }
}
