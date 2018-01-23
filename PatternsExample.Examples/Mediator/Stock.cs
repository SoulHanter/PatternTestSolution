using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Mediator
{
    public class Stock : ColleguageBase
    {
        private readonly string key = nameof(Book);
        private readonly IMessanger _messanger;
        public Stock(IMessanger messanger) 
        {
            _messanger = messanger;
        }

        public void Trace(Guid code, int count)
        {
            _messanger.SendMessage(key, count, code);
        }
    }
}
