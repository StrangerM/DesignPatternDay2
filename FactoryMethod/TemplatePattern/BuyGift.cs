using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class BuyGift : ShopMaker
    {
        public override void ChooseItem()
        {
            Console.WriteLine("Choose a gift");
        }

        public override void GoOut()
        {
            Console.WriteLine("Go out from home");
        }

        public override void GoToShop()
        {
            Console.WriteLine("Go to mall");
        }

        public override void PayForItem()
        {
            Console.WriteLine("Pay for gift");
        }

        public override void SendToHome()
        {
            Console.WriteLine("Go to home with a gift");
        }
    }
}
