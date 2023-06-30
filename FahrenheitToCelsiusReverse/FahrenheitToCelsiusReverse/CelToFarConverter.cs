using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelsiusConverter
{
    internal class CelToFarConverter : TempConverter
    {

        public override double Convert(double value)
        {
            return (value *1.8) + 32;

        }
    }
}
