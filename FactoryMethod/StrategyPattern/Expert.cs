using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Expert
    {
        public string Name { get; private set; }
        public IWork Work { private get; set; }
        public Expert(string name, IWork work)
        {
            Name = name;
            Work = work;
        }

        public void DoSomeWork()
        {
            Work.DoSomeWork();
        }
    }
}
