using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class BuyFood : ShopMaker
    {
        public override void ChooseItem()
        {
            Console.WriteLine("Take some foods");
        }

        public override void GoOut()
        {
            Console.WriteLine("Go out from work");
        }

        public override void GoToShop()
        {
            Console.WriteLine("Go to market");
        }

        public override void PayForItem()
        {
            Console.WriteLine("Pay by credir card");
        }

        public override void SendToHome()
        {
            Console.WriteLine("Go to home with foods");
        }
    }
}
