using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyFurniture furniture = new BuyFurniture();
            BuyFood food = new BuyFood();

            furniture.DoShop();
            food.DoShop();
        }
    }
}
