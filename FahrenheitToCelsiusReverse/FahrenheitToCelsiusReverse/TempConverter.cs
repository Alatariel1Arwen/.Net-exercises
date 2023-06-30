using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelsiusConverter
{
    public abstract class TempConverter
    {
        public abstract double Convert(double value);
    }
}
