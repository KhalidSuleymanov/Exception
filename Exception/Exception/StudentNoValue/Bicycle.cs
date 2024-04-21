using System;
using System.Collections.Generic;
using System.Text;

namespace StudentNoValue
{
    internal class Bicycle : Vehicle
    {
        public override void Drive(int km)
        {
            Mileage += km;
        }
    }
}
