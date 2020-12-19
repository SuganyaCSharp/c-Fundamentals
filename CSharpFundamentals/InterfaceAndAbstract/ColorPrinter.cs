using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    abstract class ColorPrinter : IPrinter
    {
        public void Print(string str, int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                Console.ForegroundColor = ChooseColor(i);

                Console.WriteLine(str);
            }
        }
        public abstract ConsoleColor ChooseColor(int n);
        
    }
}
