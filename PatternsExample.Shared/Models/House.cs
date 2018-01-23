using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Shared.Models
{
    public interface IHouse
    {
        double Width { get; set; }
        double Heigth { get; set; }
        bool IsOptimalParams { get; }
    }
    public class House : IHouse
    {
        public double Width { get; set; } = 0;
        public double Heigth { get; set; } = 0;
        public bool IsOptimalParams => Width > 5 && Heigth > 3;
    }
}
