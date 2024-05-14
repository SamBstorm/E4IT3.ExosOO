using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_OO_Celsius_Fahrenheit
{
    internal struct Celsius
    {
        public double temperature;

        public Fahrenheit ToFahrenheit()
        {
            Fahrenheit f;
            f.temperature = (temperature * 9 / 5) + 32;
            return f;
        }
    }
}
