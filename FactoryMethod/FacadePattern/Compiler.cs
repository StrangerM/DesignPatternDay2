using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Compiler
    {
        public void Validator(string code)
        {
            Console.WriteLine($"Validate {code}");
        }

        public void Compile(string code)
        {
            Console.WriteLine($"Compile {code}");     
        }
    }
}
