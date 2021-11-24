using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class FolderComponent : IComponent
    {
        public List<IComponent> Components { get; private set; }
 
        public string Name{ get; set; }

        public FolderComponent(List<IComponent> components, string name )
        {
            Components = components;
            Name = name;
        }

        public FolderComponent(string name)
        {
            Components = new List<IComponent>();
            Name = name;
        }

        public void AddComponent(IComponent component)
        {
            Components.Add(component);
        }

        public bool IsComposite()
        {
            return true;
        }

        public string Operation()
        {
            int i = 0;
            string result = "Folder(";

            foreach (IComponent component in this.Components)
            {
                result += component.Operation();
                if (i != this.Components.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }
    }
}

