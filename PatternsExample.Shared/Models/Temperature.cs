using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Shared.Models
{
    public class Temperature
    {
        public Temperature(double temperature = 0)
        {
            this.C = temperature;
        }
        public double C { get; private set; }

        public double F => 1.8 * C + 32;

        public double K => C + 273;
    }
}
