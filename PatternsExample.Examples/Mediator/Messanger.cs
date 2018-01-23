using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsExample.Shared.Models;

namespace PatternsExample.Examples.Mediator
{
    public class Messanger : IMessanger
    {
        private IList<ColleguageItem> observers;

        public Messanger()
        {
            observers = new List<ColleguageItem>();
        }

        private bool Exists(string type, Guid code) => observers.Any(o => o.Code == code && o.Type == type);

        public void RegisterObserver(string type, ColleguageBase colleguage, Guid code)
        {
            if (type != null)
            {
                if (Exists(type, code))
                    UnRegisterObserver(type, code);

                observers.Add(new ColleguageItem { Type = type.ToString(), Colleguage = colleguage, Code = code });
            }
        }

        public void SendMessage(string type, object message, Guid code)
        {
            if (type != null && observers.Any())
            {
                if (!Exists(type, code))
                    return;

                observers.FirstOrDefault(o => o.Code == code && o.Type == type)?
                         .Colleguage
                         .Notify(message);
            }
        }

        public void UnRegisterObserver(string type, Guid code)
        {
            if (type != null)
            {
                if (!Exists(type, code))
                    return;

                observers.Remove(observers.First(o => o.Code == code && o.Type == type));
            }
        }
    }

    public class ColleguageItem
    {
        public string Type { get; set; }

        public Guid Code { get; set; }

        public ColleguageBase Colleguage { get; set; }
    }
}
