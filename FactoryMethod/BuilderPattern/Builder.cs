using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class Builder
    {
        private float _egineCapacity;
        private int _diskDiameter;
        private bool _isHasHeater;
        private Product product;
        public Builder()
        {
            product = new Product();
        }
        public void BasicCar()
        {
            product.Add(string.Format("Choose {3} with egine Capacity: {0}, with disk diameter {1} and with heater {2}", _egineCapacity = 1.5f, _diskDiameter = 15, _isHasHeater = false, this.GetType().Name));
        }

        public void PremiumCar()
        {
            product.Add(string.Format("Choose {3} with egine Capacity: {0}, with disk diameter {1} and with heater {2}", _egineCapacity = 1.81f, _diskDiameter = 1, _isHasHeater = false, this.GetType().Name));
        }

        public void SuperMegaCar()
        {
            product.Add(string.Format("Choose {3} with egine Capacity: {0}, with disk diameter {1} and with heater {2}", _egineCapacity = 1.81f, _diskDiameter = 16, _isHasHeater = true, this.GetType().Name));
        }

        public Product GetCar()
        {
            return product;
        }
    } 
}
