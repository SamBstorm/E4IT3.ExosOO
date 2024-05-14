using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_OO_Celsius_Fahrenheit
{
    internal struct Fahrenheit
    {
        public double temperature;
        public Celsius ToCelsius()
        {
            Celsius c;
            c.temperature = (temperature - 32) *  5 / 9;
            return c;
        }
    }
}
