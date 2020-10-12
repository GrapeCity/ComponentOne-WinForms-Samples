using CustomFilters.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CustomFilters.ViewModel
{
    public class CarView
    {
        public string Brand => Car.Brand;
        public string Model => Car.Model;
        public double Liter => Car.Liter;
        public string TransmissAutomatic => Car.TransmissAutomatic;
        public string Category => Car.Category;
        public string Description => Car.Description;
        public byte[] Picture => Car.Picture;
        public double Price => Car.Price;
        public int Count => Stores.Sum(x => x.Count);

        public Car Car { get; }
        public List<CountInStore> Stores { get; }
        
        public CarView(Car car, List<CountInStore> stores)
        {
            Car = car;
            Stores = stores;            
        }
    }
}
