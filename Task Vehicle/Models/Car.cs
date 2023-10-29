using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Vehicle.Models
{
    internal class Car : Vehicle, IEngine, IWheel, ITransmission
    {
        //Field
        private string _name;
        private byte _doorcount;
        private int _wincode;
        private int _horsepower;
        private float _tanksize;
        private double _currentoil;
        private string _fueltype;
        private double _wheel;
        private string _transmission;

        //Property
        public string Name { get =>_name; set 

            {
                if (value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                    return;
                }

            }
        }
        public byte DoorCount { get => _doorcount; 
            set
                {
                if (value > 0)
                {
                    _doorcount = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                    
                }
                }
        }
        public int WinCode { get => _wincode; set
            {
                if (value > 0)
                {
                    _wincode = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }
        public int HorsePower { get => _horsepower; set
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
        public float TankSize { get => _tanksize; set
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
        public double CurrentOil { get => _currentoil; set
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
        public string FuelType { get => _fueltype; set
            {
                if (value== "Benzin" || value == "Dizel"|| value == "Hybrid")
                {
                    _fueltype = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
        }
        public double WheelThickness { get=> _wheel; set
            {
                if (value>0&& value<3)
                {
                    _wheel = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            } }

        public string TransmissionKind { get=> _transmission; set 
            {
                if (value == "Manual"|| value== "Auto")
                {
                    _transmission = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        //Constructor
        public Car(string name,byte doorcount,int wincode,int horsepower,float tanksize,
        double currentoil,string fueltype,double wheelthick,string transmission,int drivetime, int drivepath) 
        :base(drivetime, drivepath)
        {
            Name = name;
            DoorCount = doorcount;
            WinCode = wincode;
            HorsePower = horsepower;
            TankSize = tanksize;
            CurrentOil = currentoil;
            FuelType = fueltype;
            WheelThickness = wheelthick;
            TransmissionKind = transmission;
        }
        //Override
        public override double AverageSpeed()
        {
            return DrivePath/DriveTime;
        }

        public double RemainOilAmount()
        {
            return TankSize - CurrentOil;
        }
    }
}
