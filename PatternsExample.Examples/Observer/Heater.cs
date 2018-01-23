using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Observer
{
    public class Heater : Sensor
    {
        public Heater(IObservable<Temperature> thermometer) : base(thermometer) { }

        public override void OnNext(Temperature value)
        {
            var message = $"Обогреватель включен: {value.K <= 273}";
            Console.WriteLine(message);
        }
    }
}
