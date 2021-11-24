using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public interface IComponent
    {
        public string Name { get; set; }
        void AddComponent(IComponent component);

        bool IsComposite();

        public string Operation();
    }
}
