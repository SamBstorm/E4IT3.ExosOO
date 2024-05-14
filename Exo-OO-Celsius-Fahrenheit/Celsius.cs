using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_OO_Celsius_Fahrenheit
{
    internal class Celsius
    {
        public double Temperature { get; set; }

        public static implicit operator Fahrenheit(Celsius c)
        {
            Fahrenheit f = new Fahrenheit();
            f.Temperature = (c.Temperature * 9 / 5) + 32;
            return f;
        }
    }
}
