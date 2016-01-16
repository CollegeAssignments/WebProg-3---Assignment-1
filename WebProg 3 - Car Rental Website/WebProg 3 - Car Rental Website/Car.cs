using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProg_3___Car_Rental_Website
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Gearbox { get; set; }
        public string Fuel { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public int Suitcases { get; set; }
        public int Bags { get; set; }
        public decimal Price { get; set; }

        public Car(string _brand, string _model, string _gearbox, string _fuel, int _doors, int _seats, int _suitcases, int _bags, decimal _price)
        {
            Brand = _brand;
            Model = _model;
            Gearbox = _gearbox;
            Fuel = _fuel;
            Doors = _doors;
            Seats = _seats;
            Suitcases = _suitcases;
            Bags = _bags;
            Price = _price;
        }
    }
}