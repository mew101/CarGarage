using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> CarsInGarage { get; set; }

        public Garage()
        {

            CarsInGarage = new List<Car>();
        }

        public void AddCar()
        {
            CarsInGarage.Add(new Car());
        }

        public void RemoveCar()
        {
            CarsInGarage.Remove(new Car());
        }

        public void FuelAllCars()
        {
            
        }
    } 

}
