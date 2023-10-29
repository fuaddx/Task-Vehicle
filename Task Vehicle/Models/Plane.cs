using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Vehicle.Models
{
    internal class Plane : Vehicle,IEngine
    {
        //field
        private int _horsepower;
        private float _tanksize;
        private double _currentoil;
        private string _fueltype;
        public int _winglength;
        private double _wheel;

        //properties
        public int HorsePower
        {
            get => _horsepower; set
            {
                if (value > 0)
                {
                    _horsepower = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }
        public float TankSize
        {
            get => _tanksize; set
            {
                if (value > 0)
                {
                    _tanksize = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }
        public double CurrentOil
        {
            get => _currentoil; set
            {
                if (value > 0)
                {
                    _currentoil = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }
        public string FuelType
        {
            get => _fueltype; set
            {
                if (value == "Benzin" || value == "Dizel" || value == "Hybrid")
                {
                    _fueltype = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }
        public double WheelThickness
        {
            get => _wheel; set
            {
                if (value > 0 && value < 3)
                {
                    _wheel = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }
        public int WingLength { get => _winglength; set 
            {
                if (value > 0 && value < 3)
                {
                    _wheel = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }

        //constructor
        public Plane(int horsepower, float tanksize,
        double currentoil, string fueltypeint ,double wheel,int winglength, int drivetime, int drivepath) :base(drivetime, drivepath)
        { 
              HorsePower = horsepower;
              TankSize = tanksize;
              CurrentOil = currentoil;
              FuelType = fueltypeint;
              WheelThickness = wheel;
              WingLength = winglength;
        }

        //override
        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public double RemainOilAmount()
        {
            return TankSize - CurrentOil;
        }
    }
}
