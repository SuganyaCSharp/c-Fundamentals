using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class AlternatePrint : ColorPrinter
    {
        public override ConsoleColor ChooseColor(int n)
        {
            return n % 2 == 0 ? ConsoleColor.DarkCyan : ConsoleColor.Blue;
        }
    }
}
