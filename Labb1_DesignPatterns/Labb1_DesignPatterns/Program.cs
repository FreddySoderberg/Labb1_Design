using Labb1_DesignPatterns.Vehicles.FactoryPattern.Factories;
using Labb1_DesignPatterns.Vehicles.Models.Interface;
using Labb1_DesignPatterns.Vehicles.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_DesignPatterns
{
    class Program
    {
        //I've chosen Factory, Strategy and Singleton

        public static List<IVehicle> vehicleList = new List<IVehicle>();

        static void Main(string[] args)
        {
            bool run = true;

            Console.WriteLine("Welcome to the vehicle factory! Please select an option below: ");
            while (run)
            {
                Console.WriteLine("1. To create a Car");
                Console.WriteLine("2. To create a Motorcycle");
                Console.WriteLine("3. To create a Boat");
                Console.WriteLine("4. See all vehicles in order created");
                Console.WriteLine("q. To create a Boat");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    IVehicle vehicle = new CarFactory().CreateVehicle(); //Factory
                    vehicleList.Add(vehicle);
                    Console.WriteLine("Car created!");
                }
                else if (input == "2")
                {
                    Console.Clear();
                    IVehicle vehicle = new MotorcycleFactory().CreateVehicle(); //Factory
                    vehicleList.Add(vehicle);
                    Console.WriteLine("Motorcycle created!");
                }
                else if (input == "3")
                {
                    Console.Clear();
                    IVehicle vehicle = new BoatFactory().CreateVehicle(); //Factory
                    vehicleList.Add(vehicle);
                    Console.WriteLine("Boat created!");
                }
                else if (input == "4")
                {
                    Console.Clear();
                    if (vehicleList != null)
                    {
                        foreach (var vehicle in vehicleList)
                        {
                            var objName = vehicle.GetType();
                            Console.WriteLine("Type: " + objName.Name + ", Color: " + vehicle.GetColorOfVehicle().ToString() + ", Number of wheels: " + vehicle.GetNumberOfWheels().ToString());
                        }
                    }
                }
                else if (input == "q")
                {
                    Environment.Exit(1);
                }
                else
                {
                    //Singleton error message
                    Console.Clear();
                    SingletonErrorLog errorMessage = SingletonErrorLog.GetInstance;
                    errorMessage.WrongInputMessage();
                }
            }
        }
    }
}
