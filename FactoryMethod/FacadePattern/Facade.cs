using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Facade
    {
        private Assembler _assembler;
        private Compiler _compiler;
        private TextEditor _textEditor;
        public Facade(Assembler assembler, Compiler compiler, TextEditor textEditor)
        {
            _assembler = assembler;
            _compiler = compiler;
            _textEditor = textEditor;
        }

        public Facade(Assembler assembler, Compiler compiler)
        {
            _assembler = assembler;
            _compiler = compiler;
            
        }

        public void CompileAndSave(string code)
        {
            _compiler.Compile(code);
            _assembler.SaveDlls(code);
        }
    }
}
