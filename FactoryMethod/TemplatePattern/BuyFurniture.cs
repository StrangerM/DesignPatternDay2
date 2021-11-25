using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class BuyFurniture : ShopMaker
    {
        public override void ChooseItem()
        {
            Console.WriteLine("Choose an item");
        }

        public override void GoOut()
        {
            Console.WriteLine("Go out from home");
        }

        public override void GoToShop()
        {
            Console.WriteLine("Go to shop"); 
        }

        public override void PayForItem()
        {
            Console.WriteLine("Issue check");
        }

        public override void SendToHome()
        {
            Console.WriteLine("Go to home with furniture");
        }
    }
}
