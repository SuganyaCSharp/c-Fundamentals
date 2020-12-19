using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class FilePrinter : IPrinter
    {
        public void Print(string str, int Count)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Suganya\Print.txt"))
            {
                for (int i = 0; i < Count; i++)
                {
                    file.WriteLine(str);
                }
            }
        }
    }
}
