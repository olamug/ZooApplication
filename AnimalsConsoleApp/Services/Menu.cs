using AnimalsConsoleApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsConsoleApp.Services
{
    public class Menu
    {
        public void DisplayOption()
        {
            Console.WriteLine("* * * MENU * * * \n\nChoose:");
            foreach (var enumValueMenu in EMenu.GetValues(typeof(EMenu)))
            {
                Console.WriteLine((int)enumValueMenu + " to run " + enumValueMenu.ToString());
            }
            Console.WriteLine();
            var userChooseMenu = (EMenu)Int32.Parse(Console.ReadLine());
            GetOption(userChooseMenu);
        }

        public void GetOption(EMenu userChoose)
        {
            switch (userChoose)
            {
                case EMenu.NewWorker:
                    Console.WriteLine("you have choosen NewWorker");
                    var newWorker = new WorkerServices();
                    newWorker.CreatingListOfWorkers();
                    break;
                case EMenu.NewAnimal:
                    var animalInstance = new AnimalServices();
                    animalInstance.CreatingListOfAnimals();
                    break;
                //case EMenu.AssignAnimalToWorker:
                //    break;
                case EMenu.AddFood:
                    var newFoodAdded = new FoodService();
                    newFoodAdded.CreatingListOfFood();
                    break;
                //case EMenu.GenerateFoodRaport:
                //    break;
                default:
                    Console.WriteLine("The command is unknown. Try again.");
                    break;
            }
        }

    }
}
