using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_Vehicle.Models
{
    internal class Bicycle : Vehicle,IWheel
    {
        //fields
        public string _name;
        public string _pedalkind;
        public double _wheel;

        //properties
        public string Name
        {
            get => _name; set

            {
                if (value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }

            }
        }
        public string PedalKind { get=> _pedalkind; set 
            {
                if (value.Length > 2)
                {
                    _pedalkind = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        public double WheelThickness
        {
            get => _wheel; set
            {
                if (value > 0)
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
        public Bicycle(string bycyle, string pedalkind, double wheelthickk,int drivetime, int drivepath) : base(drivetime, drivepath)
        {
            Name= bycyle;
            PedalKind = pedalkind;
            WheelThickness = wheelthickk;
        }

        //override
        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
