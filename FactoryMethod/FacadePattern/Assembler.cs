using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class  Assembler
    {
        public void FormDlls(string dll)
        {
            Console.WriteLine($"Form {dll}");
        }

        public void SaveDlls(string dll)
        {
            Console.WriteLine($"Saved {dll}");
        }
    }
}
