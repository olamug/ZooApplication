using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsConsoleApp.Model
{
    class Food
    {
        public string Name { get; set; }
        public int EnergyValueInKcal { get; set; }
        public string OriginOfIndgredients { get; set; }
        public Guid ID { get; set; }
    }
}
