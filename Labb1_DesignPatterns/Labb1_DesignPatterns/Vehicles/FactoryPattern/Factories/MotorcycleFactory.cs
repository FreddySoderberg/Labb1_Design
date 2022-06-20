using Labb1_DesignPatterns.Vehicles.FactoryPattern.Factories.Interface;
using Labb1_DesignPatterns.Vehicles.Models;
using Labb1_DesignPatterns.Vehicles.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_DesignPatterns.Vehicles.FactoryPattern.Factories
{
    public class MotorcycleFactory : VehicleFactory
    {
        protected override IVehicle MakeVehicle()
        {
            IVehicle vehicle = new Motorcycle();
            return vehicle;
        }
    }
}
