using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FahrenheitToCelsiusConverter
{
    public class FarToCelConverter : TempConverter
    {

        public override double Convert(double value)
        {
            return (value - 32) * 0.5556 ;
        }

    }
}
