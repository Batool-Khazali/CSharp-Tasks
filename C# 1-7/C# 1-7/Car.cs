using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__1_7
{
    internal class Car
    {
        private string maker;
        private int year;
        private string type;
        private double price;
        private string model;
        private int palletNumber;
        private string color;

        public string Maker { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public int PalletNumber { get; set; }
        public string Color { get; set; }


        public Car()
        {
            Maker = "Ford";
            Year = 2019;
            Type = "SUV";
            Price = 30000;
            Model = "Explorer";
            PalletNumber = 123456;
            Color = "Black";
        }
        public Car(string carMaker, int carYear, string carType, double carPrice, string carModel, int carPalletNumber, string carColor)
        {
            Maker = carMaker;
            Year = carYear;
            Type = carType;
            Price = carPrice;
            Model = carModel;
            PalletNumber = carPalletNumber;
            Color = carColor;
        }

        public void startEngine()
        {
            Console.WriteLine("the engine has started"); ;
        }
        public void stopEngine()
        {
            Console.WriteLine("the engine has stopped");
        }

        public string printCarSale ()
        {
            return $"A {Year} {Maker} {Model} {Type} in {Color}, priced at {Price}, with pallet number {PalletNumber}, is available for sale.";
        }

    }
}
