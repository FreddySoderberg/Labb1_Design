using Labb1_DesignPatterns.Vehicles.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_DesignPatterns.Vehicles.StrategyPattern.Strategies
{
    class BlackStrategy : IColor
    {
        public string PickedColor()
        {
            return "Black";
        }
    }
}
