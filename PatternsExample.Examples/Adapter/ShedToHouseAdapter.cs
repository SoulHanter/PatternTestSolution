using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Adapter
{
    public class ShedToHouseAdapter: IHouse
    {
        public ShedToHouseAdapter(IShed shed)
        {
            Width = shed.Width;
            Heigth = shed.Heigth;
        }

        public double Width { get; set; } = 0;
        public double Heigth { get; set; } = 0;
        public bool IsOptimalParams => Width >= 2 && Heigth >= 2;
    }
}
