using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Abstract_Factory
{
    public abstract class HouseType
    {
        public abstract GlassType GlassType();
        public abstract BalconyType BalconyType();
    }

    public class Cottage : HouseType
    {
        public override BalconyType BalconyType()
        {
            return new Terrace();
        }

        public override GlassType GlassType()
        {
            return new Wood();
        }
    }

    public class Apartment : HouseType
    {
        public override BalconyType BalconyType()
        {
            return new Loggia();
        }

        public override GlassType GlassType()
        {
            return new Plastic();
        }
    }
}
