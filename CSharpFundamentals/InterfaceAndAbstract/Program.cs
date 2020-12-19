using System;

namespace Interface
{
    class Program
    {
        static IPrinter printer = new AlternatePrint();
        static void Main(string[] args)
        {
            printer.Print("this is duck",4);
        }
    }
}
