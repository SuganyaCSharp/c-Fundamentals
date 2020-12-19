using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class YellowPrint : ColorPrinter
    {
        public override ConsoleColor ChooseColor(int n)
        {
            return ConsoleColor.DarkYellow;
        }
    }
}
