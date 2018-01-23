using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Mediator
{
    public class Book : ColleguageBase
    {
        public Book(IMessanger messanger, string name)
        {
            Code = Guid.NewGuid();
            Name = name;
            messanger.RegisterObserver(nameof(Book), this, Code);
        }

        public Guid Code { get; private set; }

        public string Name { get; private set; }

        public int Count { get; private set; } = 0;

        public override void Notify(object message)
        {
            if (message != null && message is int)
                Count = (int)message;
        }

    }
}
