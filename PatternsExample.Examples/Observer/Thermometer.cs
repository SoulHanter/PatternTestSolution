using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Observer
{
    public class Thermometer : IObservable<Temperature>
    {
        private List<IObserver<Temperature>> _sensors;
        public Thermometer()
        {
            _sensors = new List<IObserver<Temperature>>();
        }

        public IDisposable Subscribe(IObserver<Temperature> observer)
        {
            if (!_sensors.Any(x => x == observer))
                _sensors.Add(observer);
            return new Unsubscriber(_sensors, observer);
        }

        private class Unsubscriber: IDisposable
        {
            private List<IObserver<Temperature>> _observers;
            private IObserver<Temperature> _observer;

            public Unsubscriber(List<IObserver<Temperature>> observers, IObserver<Temperature> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void UpTemp(Temperature temp)
        {
            foreach (var senser in _sensors)
            {
                senser.OnNext(temp);
            }
        }

       
    }
}
