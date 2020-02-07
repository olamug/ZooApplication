using AnimalsConsoleApp.Enum;
using AnimalsConsoleApp.Interface;
using System;

namespace AnimalsConsoleApp.Model
{
    public class Lion : IAnimal
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
