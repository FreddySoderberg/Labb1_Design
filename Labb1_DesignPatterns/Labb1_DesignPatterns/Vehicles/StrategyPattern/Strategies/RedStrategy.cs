using Labb1_DesignPatterns.Vehicles.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_DesignPatterns.Vehicles.StrategyPattern.Strategies
{
    class RedStrategy : IColor
    {
        public string PickedColor()
        {
            return "Red";
        }
    }
}
