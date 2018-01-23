using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Shared.Models
{
    public abstract class Sensor : IObserver<Temperature>
    {
        private IDisposable disposable;
        public Sensor(IObservable<Temperature> thermometer)
        {
            if (thermometer != null)
                disposable = thermometer.Subscribe(this);
        }
        public virtual void OnCompleted()
        {
            this.disposable.Dispose();
        }

        public virtual void OnError(Exception error) { }

        public virtual void OnNext(Temperature value)
        {
            Console.WriteLine($"Температура {value.C}C");
        }
    }
}
