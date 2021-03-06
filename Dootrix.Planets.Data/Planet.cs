﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dootrix.Planets.Data
{
    public class Planet
    {
        public int PlanetId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal AstronomicalUnits { get; set; }
        public decimal Mass { get; set; }
        public decimal Radius { get; set; }
        public int PlanetaryOrder { get; set; }
        public string ImageUri { get; set; }
        public List<ExtraInformation> ExtraInformation { get; set; }
    }
}
