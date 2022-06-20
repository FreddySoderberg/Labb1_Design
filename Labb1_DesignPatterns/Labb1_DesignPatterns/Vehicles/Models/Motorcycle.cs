using Labb1_DesignPatterns.Vehicles.Models.Interface;
using Labb1_DesignPatterns.Vehicles.Singleton;
using Labb1_DesignPatterns.Vehicles.StrategyPattern;
using Labb1_DesignPatterns.Vehicles.StrategyPattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_DesignPatterns.Vehicles.Models
{
    class Motorcycle : IVehicle
    {
        public string Color { get; set; }

        public Motorcycle()
        {
            Color = menu(); // Menu to Strategy
        }

        public string GetColorOfVehicle()
        {
            return Color;
        }

        public int GetNumberOfWheels()
        {
            return 2;
        }

        public static string menu()
        {
            bool run = true;

            Console.WriteLine("Which color would you like your Car to be?");
            Console.WriteLine("1. Black");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Red");
            try
            {
                while (run)
                {
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.Clear();
                        ColorContext color = new ColorContext(new BlackStrategy()); //Strategy, called from constructor
                        var setColor = color.CreateColor();
                        return setColor;
                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        ColorContext color = new ColorContext(new BlueStrategy()); //Strategy, called from constructor
                        var setColor = color.CreateColor();
                        return setColor;
                    }
                    else if (input == "3")
                    {
                        Console.Clear();
                        ColorContext color = new ColorContext(new RedStrategy()); //Strategy, called from constructor
                        var setColor = color.CreateColor();
                        return setColor;
                    }
                    else
                    {
                        SingletonErrorLog errorMessage = SingletonErrorLog.GetInstance;
                        errorMessage.WrongInputMessage();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
    }
}
