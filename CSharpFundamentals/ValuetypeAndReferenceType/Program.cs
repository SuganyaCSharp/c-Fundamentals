using System;

namespace ValuetypeAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            RefTest2();
            //RefTest();
            //ValueTest();
            //OutUseCase();
        }
        private static void OutUseCase()
        {
            int q;
            FindRemAndQuo(123, 7, out int rem, out q);
            Console.WriteLine(rem);
            Console.WriteLine(q);
        }
        private static void FindRemAndQuo(int a, int b, out int rem, out int q)
        {
            rem = a % b;
            q = a / b;
        }
        private static void ValueTest()
        {
            int X = 10;
            changeValue(X);
            Console.WriteLine(X);
            changeValueRef(ref X);
            Console.WriteLine(X);
            changeValueOut(out X);
            Console.WriteLine(X);
        }
        private static void RefTest2()
        {
            var refernce = new ReferenceType("sugu", 22);
            Console.WriteLine(refernce.ToString());
            PropertyChange(refernce);
            Console.WriteLine(refernce.ToString());
        }
        private static void RefTest()
        {
            ReferenceType referencetype = new ReferenceType("sugu", 22);
            Console.WriteLine(referencetype.ToString());
            GetReference(referencetype);
            Console.WriteLine(referencetype.ToString());
            GetReferenceRef(ref referencetype);
            Console.WriteLine(referencetype.ToString());
            GetReferenceOut(out referencetype);
            Console.WriteLine(referencetype.ToString());
        }
        static void PropertyChange(ReferenceType referenceType)
        {
            referenceType.Name = "sagu";
            referenceType.Age = 55
;        }
        static void GetReference(ReferenceType referenceType)
        {
            referenceType = new ReferenceType("venkat",23);
        }
        static void GetReferenceRef(ref ReferenceType referenceType)
        {
            referenceType = new ReferenceType("venkat", 23);
        }
        static void GetReferenceOut(out ReferenceType referenceType)
        {
            referenceType = new ReferenceType("venkat", 23);
        }

        static void changeValue(int x)
        {
            x = 20;
        }
        static void changeValueRef(ref int x)
        {
            x = 20;
        }
        static void changeValueOut(out int x)
        {
            x = 20;
        }
    }
}
