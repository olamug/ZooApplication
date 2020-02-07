using AnimalsConsoleApp.Enum;
using AnimalsConsoleApp.Interface;
using AnimalsConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsConsoleApp.Services
{
    class WorkerServices
    {
        public void CreatingListOfWorkers()
        {
            var listOfWorkers = new List<Worker>();
            var addAnotherWorkerAnswer = "y";
            do
            {
                var newWorker = CreateNewWorker();
                var logInit = new LogService();
                var ItemType = newWorker.GetType();
                logInit.AddLogDataToLogFile(ItemType, newWorker.ID);
                listOfWorkers.Add(newWorker);
                Console.WriteLine("Worker: " + newWorker.SecondName + " with ID " + newWorker.ID + " has been added.");
                Console.WriteLine("Do you want to add another worker to register? \ny - yes \nn - no");
                addAnotherWorkerAnswer = Console.ReadLine();
            } while (addAnotherWorkerAnswer == "y");
            Console.WriteLine("List of added workers: ");
            foreach (var item in listOfWorkers)
            {
                Console.WriteLine(item.Name + " " + item.SecondName + " ID: " + item.ID);
            }
        }

        public Worker CreateNewWorker()
        {
            var newWorker = new Worker();
            newWorker.ID = Guid.NewGuid();
            Console.WriteLine("Enter new worker's personal data");
            Console.Write("Name: ");
            newWorker.Name = Console.ReadLine();
            Console.Write("Second name: ");
            newWorker.SecondName = Console.ReadLine();
            Console.WriteLine("Choose section of the zoo a worker is assigned to by providing one of the following numbers:");
            foreach (var enumValue in ESection.GetValues(typeof(ESection)))
            {
                Console.WriteLine((int)enumValue + " - " + enumValue.ToString().ToLower());
            }
            newWorker.AnimalSection = (ESection)Int32.Parse(Console.ReadLine()); // sekcja w której będzie pracował w zoo
            //newWorker.Animals = new List<IAnimal>(); // lista przyporządkowanych zwierząt

            return newWorker;
        }
    }
}
