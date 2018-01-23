using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.DI
{
    public interface IReader<T>
    {
        T Create(string fileName);
    }
}
