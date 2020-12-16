
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuetypeAndReferenceType
{
    class ReferenceType
    {
        public string  Name {get; set; }
        public int Age { get; set; }
        public ReferenceType(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name},Age: {Age}";     
        }
    }
}
