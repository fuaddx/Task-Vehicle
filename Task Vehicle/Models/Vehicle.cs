using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Vehicle.Models
{
    internal abstract class Vehicle
    {
        public int DriveTime;
        public int DrivePath;

        public Vehicle(int drivetime,int drivepath)
        { 
            DriveTime = drivetime;
            DrivePath = drivepath;
        }
        public abstract double AverageSpeed();

    }
}
