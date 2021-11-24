using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class TextEditor
    {
        public void Save(string code)
        {
            Console.WriteLine($"Save {code}");
        }
    }
}
