using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Examples.Adapter
{
    public class BuildingCompany
    {
        public void Building(IHouse house)
        {
            var message = house.IsOptimalParams ?
                $"Построено здание площадью: {house.Heigth * house.Width} кв.м  и периметром: {(house.Heigth  + house.Width) * 2} м" :
                "Условия для строительсва не соблюдены";
            Console.WriteLine(message);
        }
            
    }
}
