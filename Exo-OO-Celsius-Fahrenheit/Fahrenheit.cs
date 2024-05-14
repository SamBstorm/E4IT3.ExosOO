using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_OO_Celsius_Fahrenheit
{
    internal class Fahrenheit
    {
        public double Temperature { get; set; }
        public static explicit operator Celsius(Fahrenheit f)
        {
            Celsius c = new Celsius();
            c.Temperature = (f.Temperature - 32) *  5 / 9;
            return c;
        }
    }
}
