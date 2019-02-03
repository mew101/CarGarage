using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public int Speed { get; private set; }
        public int GasLevel { get; private set; }
        public bool CarStarted { get; private set; }
        

        public Car()
        {
            Speed = 0;
            GasLevel = 100;
            CarStarted = false;
            
        }

        public void Accelerate()
        {
           Speed += 10;
           GasLevel -= 10;
            if(Speed >= 150)
            {
                Speed = 150;
            }
        }

        public void AddFuel()
        {
            GasLevel = 100;
        }
        public void Decelerate()
        {
            Speed -= 10;
            GasLevel -= 1;
            if(Speed < 0)
            {
                Speed = 0;
            }
        }
            public void ToggleEngine()
           {
            CarStarted = !CarStarted;
            }       
        }
        


}
