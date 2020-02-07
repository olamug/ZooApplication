using AnimalsConsoleApp.Interface;
using AnimalsConsoleApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsConsoleApp.Model
{
    public class Giraffe : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Gender { get; set; }
        public bool IsVaccinated { get; set; }
        public EBehaviour Behaviour { get; set; }
        public Guid ID { get; set; }
    }
}
