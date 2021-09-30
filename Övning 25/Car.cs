using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_25
{
    class Car
    {
        //Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, pris och färg.
        private string _carModel;
        private int _carPrice;
        private string _carColor;

        //Skapa publika properties för att hämta eller ändra värdet på varje field.
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

        //Skriv en konstruktor till bilklassen som inte tar några parametrar.
        public Car()
        {

        }
        //Skriv en till konstruktor som tar en parameter för varje property som klassen har. 
        public Car(string model, int price, string color)
        {
            _carModel = model;
            _carPrice = price;
            _carColor = color;
        }

        public void HalfPrice()
        {
            Price /= 2;
        }
    }
}
