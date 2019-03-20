using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassExample
{
    public class Car
    {
        private float gasLevel;
        public float GasLevel
        {
            get
            {
                return gasLevel;
            }
            set
            {
                if (value < 0 || value > 13)
                {
                    throw new FormatException();
                }
                else
                {
                    gasLevel = value;
                }
            }
        }

        public void AddGas(float gasIntake)
        {
            GasLevel += gasIntake;
        }
        public float FillUp()
        {
            float gasDifference = 13 - GasLevel;
            GasLevel = 13;

            return gasDifference;
        }
        public Car()
        {
            Random rand = new Random();
            GasLevel = rand.Next(0, 14);
        }
    }
}
