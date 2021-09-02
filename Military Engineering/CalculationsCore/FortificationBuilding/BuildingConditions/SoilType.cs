﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsCore.FortificationBuilding.BuildingConditions
{
    public class SoilType
    {
        public static SoilType Weak { get; } = new SoilType(1.25, "Weak");
        public static SoilType Medium { get; } = new SoilType(1, "Medium");
        public static SoilType Solid { get; } = new SoilType(0.6, "Solid");
        public static SoilType Rocky { get; } = new SoilType(0.2, "Rocky");
        public static SoilType FrozenShallow { get; } = new SoilType(0.3, "FrozenShallow");
        public static SoilType FrozenDeep { get; } = new SoilType(0.15, "FrozenDeep");
        public string Name { get; private set; }
        public double Value { get; private set; }

        private SoilType(double val, string name)
        {
            Value = val;
            Name = name;
        }
        public static IEnumerable<SoilType> GetSoilConditions()
        {
            return new[] { Weak, Medium, Solid, Rocky, FrozenShallow, FrozenDeep };
        }
    }
}
