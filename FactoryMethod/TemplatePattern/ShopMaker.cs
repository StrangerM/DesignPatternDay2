using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class ShopMaker
    {
        public void DoShop()
        {
            GoOut();
            GoToShop();
            ChooseItem();
            PayForItem();

            if (this.GetType() == typeof(BuyFurniture))
            {
                OrderDeliverService();
            }

            SendToHome();
        }

        public abstract void GoOut();
        public abstract void GoToShop();
        public abstract void ChooseItem();
        public abstract void PayForItem();

        public void OrderDeliverService()
        {
            Console.WriteLine("Ordered deliver service");
        }
        public abstract void SendToHome();
    }
}
