using Labb1_DesignPatterns.Vehicles.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_DesignPatterns.Vehicles.FactoryPattern.Factories.Interface
{
    public abstract class VehicleFactory
    {
        protected abstract IVehicle MakeVehicle();
        public IVehicle CreateVehicle()
        {
            return MakeVehicle();
        }
    }
}
