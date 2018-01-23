using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Observer
{
    public class Fan : Sensor
    {
        public Fan(IObservable<Temperature> thermometer) : base(thermometer) { }

        public override void OnNext(Temperature value)
        {
            base.OnNext(value);
            var message = $"Вентилятор включен: {value.F > 70}";
            Console.WriteLine(message);
        }

    }
}
