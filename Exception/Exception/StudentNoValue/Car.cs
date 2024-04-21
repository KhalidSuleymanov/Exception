using System;
using System.Collections.Generic;
using System.Text;

namespace StudentNoValue
{
    internal class Car : Vehicle
    {
        double CurrentFuel;
        double FuelFor1Km;

        public override void Drive(int km)
        {
            double needFuel = FuelFor1Km * km;

            if (CurrentFuel > needFuel)
            {
                CurrentFuel -= needFuel;
                Mileage += km;
            }
        }
    }
}
