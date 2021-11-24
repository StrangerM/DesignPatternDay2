using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade(new Assembler(), new Compiler());
            facade.CompileAndSave("Some code");
        }
    }
}
