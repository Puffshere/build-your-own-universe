using System;
using System.Collections.Generic;
using System.Text;

namespace build_your_own_universe
{
    public class Person
    {
        public Person(string y, string p)
        {
            Y = y;
            P = p;
        }

        public string Y { get; set; }

        public string P { get; set; }

        public string GetFullName()
        {
            String combindedString = string.Join(" ", Y, P);
            return combindedString;
        }
    }
}

