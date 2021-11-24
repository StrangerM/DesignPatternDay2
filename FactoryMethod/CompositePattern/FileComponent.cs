using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class FileComponent : IComponent
    {
        public string Name { get; set; }
        public FileComponent(string name)
        {
            Name = name;
        }
        public void AddComponent(IComponent component)
        {
            Console.WriteLine("Can not add component");
        }

        public bool IsComposite() 
        {
            return false;
        }

        public string Operation()
        {
            return "file";
        }
    }
}
