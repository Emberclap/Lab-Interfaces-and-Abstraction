using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string car, int battery)
        {
            Model = model;
            Car = car;
            Battery = battery;
        }

        public string Model { get; set; }
        public string Car { get; set; }
        public int Battery { get; set; }

        public void Start()
        {
            Console.WriteLine("Engine start"); ;
        }

        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }

        public override string ToString()
        {
            return $"{this.Car} Tesla {this.Model} with {this.Battery} Batteries";
        }
    }
}
