using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Abstract_Factory
{
    public abstract class GlassType
    {
        public abstract void Type();
    }

    public class Plastic : GlassType
    {
        public override void Type()
        {
            Console.WriteLine("Тип остекления: Пластиковое остекление");
        }
    }

    public class Wood : GlassType
    {
        public override void Type()
        {
            Console.WriteLine("Тип остекления: Деревянное остекление");
        }
    }
}
