using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Shared.Models
{
    public interface IShed
    {
        double Width { get; set; }
        double Heigth { get; set; }
    }
    public class Shed : IShed
    {
        public double Width { get; set; } = 0;
        public double Heigth { get; set; } = 0;
    }
}
