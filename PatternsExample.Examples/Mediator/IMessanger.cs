using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Mediator
{
    public interface IMessanger
    {
        void RegisterObserver(string type, ColleguageBase colleguage, Guid code);

        void UnRegisterObserver(string type, Guid code);

        void SendMessage(string type, object message, Guid code);
    }
}
