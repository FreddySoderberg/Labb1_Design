﻿using Labb1_DesignPatterns.Vehicles.StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_DesignPatterns.Vehicles.StrategyPattern
{
    class ColorContext
    {
        private IColor Color;

        public ColorContext(IColor color)
        {
            Color = color;
        }

        public void SetStrategy(IColor color)
        {
            Color = color;
        }

        public string CreateColor()
        {
            return Color.PickedColor();
        }
    }
}
