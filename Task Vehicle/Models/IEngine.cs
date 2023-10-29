using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Vehicle.Models
{
    internal interface IEngine 
    {
        public int HorsePower { get; set; }
        public float TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }

        public double RemainOilAmount();
    }
}
