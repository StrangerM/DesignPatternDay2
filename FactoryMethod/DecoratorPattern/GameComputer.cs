using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class GameComputer : BaseComputer
    {
        public GameComputer() : base("Computer for game")
        {

        }
        public override void Show()
        {
            Console.WriteLine($"Name is {Name}");
        }
    }
}
