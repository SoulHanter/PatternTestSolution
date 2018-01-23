using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Abstract_Factory
{
    public abstract class BalconyType
    {
        public abstract void Type();
    }

    public class Terrace : BalconyType
    {
        public override void Type()
        {
            Console.WriteLine("Тип балкона: Терраса");
        }
    }

    public class Loggia : BalconyType
    {
        public override void Type()
        {
            Console.WriteLine("Тип балкона: Лоджия");
        }
    }
}
