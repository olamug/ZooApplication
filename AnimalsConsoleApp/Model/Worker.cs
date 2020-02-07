using AnimalsConsoleApp.Enum;
using AnimalsConsoleApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsConsoleApp.Model
{
    class Worker
    {
        public Worker()
        {

        }
        public Worker(string name, string secondName)
        {
            Name = name;
            SecondName = secondName;
        }

        public string Name { get; set; }
        public string SecondName { get; set; }
        public ESection AnimalSection { get; set; } 
        public Guid ID { get; set; }
        //public List<IAnimal> Animals { get; set; }
    }
}
