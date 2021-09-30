using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindings
{
    class Car
    {
        private string _carModel;
        private int _carPrice;
        private string _carColor;

        public string Model
        {
            get => _carModel;
            set => _carModel = value;
        }

        public int Price
        {
            get => _carPrice;
            set => _carPrice = value;
        }

        public string Color
        {
            get => _carColor;
            set => _carColor = value;
        }

        public Car()
        {

        }
        public Car(string model, int price, string color)
        {
            _carModel = model;
            _carPrice = price;
            _carColor = color;
        }

        public void HalfPrice()
        {
            _carPrice /= 2;
        }
    }
}
