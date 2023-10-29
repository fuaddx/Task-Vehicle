using Microsoft.VisualBasic.FileIO;
using System.IO;
using Task_Vehicle.Models;

namespace Task_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle[] vehicle = new Vehicle[100];
            int Count = 0;
            char select;
            do
            {
                Console.WriteLine("1 - Create new car");
                Console.WriteLine("2 - Create new bicycle");
                Console.WriteLine("3 - Create new plane");
                Console.WriteLine("4 - Show All Vehicles");
                Console.WriteLine("5 - Delete Vehicle for Index");
                Console.WriteLine("0 - Quit");

                select = Convert.ToChar(Console.ReadLine());

                switch (select)
                {
                    case '1':
                        Console.WriteLine("Name :");
                        string name = Console.ReadLine();
                        Console.WriteLine("Door Count:");
                        byte doorcount = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Id code:");
                        int wincode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("HorsePower:");
                        int horsepower = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Tank size:");
                        float tanksize = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Curremt oil:");
                        double currentoil = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Fuel Type: ");
                        string fueltype = Console.ReadLine();
                        Console.WriteLine("Wheel Thickness :");
                        double wheelthick = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Transmission: ");
                        string transmission = Console.ReadLine();
                        Console.WriteLine("Drive Time:");
                        int drivetime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Drive path :");
                        int drivepath = Convert.ToInt32(Console.ReadLine());
                        vehicle[Count] = new Car(name,doorcount, wincode, horsepower, tanksize,
                        currentoil,fueltype, wheelthick,transmission,drivetime, drivepath);
                        Count++;

                        

                        Console.WriteLine("\nNew car created : \n");
                        Console.WriteLine($"Name: {name}\nDoor Count: {doorcount}\nId Code: {wincode}\n" +
                         $"Drive Time: {drivetime}km/h\nDrive Path: {drivepath}meter\n" +
                         $"Horse Power: {horsepower}hp\nTank size: {tanksize}litre\nCurrent oil: {currentoil}litre\n" +
                         $"Fuel Type: {fueltype}\nWheel Thick: {wheelthick}meter\nTransmissionKind: {transmission}\n");

                        if (vehicle[Count - 1] is Car car)
                        {
                            Console.WriteLine($"Remaining Oil Amount of Car: {car.RemainOilAmount()} litre");
                            Console.WriteLine($"Avarage Speed of Car: {car.AverageSpeed()} km/h");
                        }

                        break;

                    case '2':
                        Console.WriteLine("Name :");
                        string bycyle = Console.ReadLine();
                        Console.WriteLine("Pedalkind :");
                        string pedalkind = Console.ReadLine();
                        Console.WriteLine("WheelThick :");
                        double wheelthickk = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Drive Time :");
                        int drivetimee = Convert.ToInt32(Console.ReadLine);
                        Console.WriteLine("Drive Path :");
                        int drivebycpath = Convert.ToInt32(Console.ReadLine());
                        
                        vehicle[Count] = new Bicycle(bycyle, pedalkind, wheelthickk, drivetimee, drivebycpath);
                        Count++;

                        Console.WriteLine("\nNew Biycyle created : \n");
                        Console.WriteLine($"Name: {bycyle}\nWheel Thick: {wheelthickk}meter\nDrive Time: {drivetimee}km/h\nDrive Path: {drivebycpath}meter\n");

                        if (vehicle[Count - 1] is Bicycle bicycle)
                        {
                            Console.WriteLine($"Avarage Speed of Car: {bicycle.AverageSpeed()}km/h");
                        }

                        break;

                    case '3':

                        Console.WriteLine("Plane Horse Power :");
                        int Planehorsepower = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Plane Tank Size :");
                        float Planetanksize = Convert.ToSingle(Console.ReadLine);
                        Console.WriteLine("Plane Current oil :");
                        double Planecurrentoil = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Plane Fuel Type :");
                        string Planefueltype = Console.ReadLine();
                        Console.WriteLine("Plane WheelThick :");
                        int Planewheel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Plane WheelThick :");
                        int winglength = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Plane Drive Time: ");
                        int Planedrivetime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Plane Drive Path:");
                        int Planedrivepath =Convert.ToInt32(Console.ReadLine());

                        vehicle[Count] = new Plane(Planehorsepower, Planetanksize,
                        Planecurrentoil, Planefueltype, Planewheel, winglength, Planedrivetime, Planedrivepath);
                        Count++;

                        Console.WriteLine("\nNew Plane created : \n");
                        Console.WriteLine($"Plane Fuel Type : {Planehorsepower}hp\nPlane Tank Size: {Planetanksize}\n" +
                         $"Drive Time: {Planedrivetime}km/h\nDrive Path: {Planedrivepath}meter\n" +
                         $"Tank size: {Planetanksize}litre\nCurrent oil: {Planecurrentoil}litre\n" +
                         $"Fuel Type: {Planefueltype}\nWheel Thick: {Planewheel}meter\n");

                        if (vehicle[Count - 1] is Plane plane)
                        {
                            Console.WriteLine($"Avarage Speed of Car: {plane.AverageSpeed()}km/h");
                        }

                        break;

                    case '4':

                            
                        if (Count == 0)
                        {
                            Console.WriteLine("No vehicles to display.");
                        }
                        else
                        {
                            Console.WriteLine("List of Vehicles:");

                            foreach (Vehicle vehicles in vehicle)
                            {
                                if (vehicles is Car tem)
                                {
                                    Console.WriteLine($"Name: {tem.Name}\nDoor Count: {tem.DoorCount}\nId Code: {tem.WinCode}\n" +
                                    $"Drive Time: {tem.DriveTime}km/h\nDrive Path: {tem.DrivePath}meter\n" +
                                    $"Horse Power: {tem.HorsePower}hp\nTank size: {tem.TankSize}litre\nCurrent oil: {tem.CurrentOil}litre\n" +
                                    $"Fuel Type: {tem.FuelType}\nWheel Thick: {tem.WheelThickness}meter\nTransmissionKind: {tem.TransmissionKind}\n");
                                }
                                else if (vehicles is Bicycle tem1)
                                {
                                    Console.WriteLine($"Name: {tem1.Name}\nWheel Thick: {tem1.WheelThickness}meter\nDrive Time: {tem1.DriveTime}km/h\nDrive Path: {tem1.DrivePath}meter\n");
                                }
                                else if (vehicles is Plane tem2)
                                {
                                    Console.WriteLine($"Plane Fuel Type : {tem2.HorsePower}hp\n" +
                                   $"Drive Time: {tem2.DriveTime}km/h\nDrive Path: {tem2.DrivePath}meter\n" +
                                   $"Tank size: {tem2.TankSize}litre\nCurrent oil: {tem2.CurrentOil}litre\n" +
                                   $"Fuel Type: {tem2.FuelType}\nWheel Thick: {tem2.WheelThickness}meter\n");
                                }
                            }

                        }

                        break;

                    case '5':

                        if (Count == 0)
                        {
                            Console.WriteLine("No vehicles to delete.");
                        }
                        else
                        {
                            Console.WriteLine("Write index:");
                            int index = Convert.ToInt32(Console.ReadLine());

                            if (index >= 0 && index < Count)
                            {
                                for (int i = index; i < Count - 1; i++)
                                {
                                    for(int j = i + 1; j < Count; j++)
                                    {
                                        if(vehicle[i] == vehicle[j])
                                        {
                                            j--;
                                        }
                                    }
                                    
                                }
                                Count--;
                                Console.WriteLine("Deleted");
                            }
                            else
                            {
                                Console.WriteLine("Wrong index, please try again");
                            }  
                        }
                        break;

                    default:
                        Console.WriteLine("Try Again");
                    break;
                }

            } while (select != '0');
            
        }
    }
}