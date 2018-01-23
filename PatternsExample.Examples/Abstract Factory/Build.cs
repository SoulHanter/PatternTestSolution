using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Abstract_Factory
{
    public class Build
    {
        private GlassType _glassType;
        private BalconyType _balconyType;

        public Build(HouseType house)
        {
            _glassType = house.GlassType();
            _balconyType = house.BalconyType();
        }

        public void GetGlassType()
        {
            _glassType.Type();
        }

        public void GetBalconyType()
        {
            _balconyType.Type();
        }
    }
}
