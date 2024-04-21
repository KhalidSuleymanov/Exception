using System;
using System.Collections.Generic;
using System.Text;

namespace StudentNoValue
{
    internal class Drink : Student
    {

        public readonly double AlcoholPercent;
        public Drink(double alcoholPercent)
        {
            _price = 5;

            if (alcoholPercent >= 0 && alcoholPercent <= 100)
            {
                AlcoholPercent = alcoholPercent;
            }
               
        }
        public override double Price
        {
            set
            {
                if (value >= 5)
                    _price = value;
            }
            get
            {
                return _price;
            }
        }
    }
}
