using System;
using Xunit;
using System.Collections.Generic; 

namespace CarGarage.Tests
{
    public class GarageTests
    {
        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            // Arrange 
            var carGarage = new Garage();
            // Act
            var bmw = new Car();
            var bentley = new Car();
            carGarage.CarsInGarage.Add(bmw);
            carGarage.CarsInGarage.Add(bentley);

            //Assert
            Assert.Equal(bmw, carGarage.CarsInGarage[0]);
            Assert.Equal(bentley, carGarage.CarsInGarage[1]);

        }
        [Fact]

        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method           
            //Arrange
            var carGarage = new Garage();

            // Act
            //var bmw = new Car();
            //var bentley = new Car();

            var bmw = new Car();
            var bentley = new Car();
            carGarage.CarsInGarage.Add(bmw);
            carGarage.CarsInGarage.Add(bentley);
            carGarage.CarsInGarage.Remove(bentley);
            // Assert
            Assert.Equal(bmw, carGarage.CarsInGarage[0] );
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            // Tests FuelAllCars() method
            // Arrange
            var carGarage = new Garage();
            var bmw = new Car();
            var bentley = new Car();
           
            // Act
            carGarage.CarsInGarage.Add(bmw);
            carGarage.CarsInGarage.Add(bentley);
            
            carGarage.FuelAllCars();

            // Assert
            Assert.Equal(120, bmw.GasLevel);
            Assert.Equal(120, bentley.GasLevel);
        }

        [Fact]
        public void shouldTestDriveOneCar()
        {
            // Use the Program class to let you select a single car
            // Program class should then let you choose what you want to do with that car
            // You do not need to test user input in the Program class
        }

        [Fact]
        public void youShouldNameThisTest()
        {
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats
        }
    }
}
