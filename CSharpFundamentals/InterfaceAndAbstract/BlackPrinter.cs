using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class BlackPrinter : IPrinter
    {
        public void Print(string str, int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(str);
            }
        }
    }
}
