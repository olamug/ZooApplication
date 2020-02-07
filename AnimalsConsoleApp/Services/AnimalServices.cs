using System;
using System.Collections.Generic;
using AnimalsConsoleApp.Enum;
using AnimalsConsoleApp.Interface;
using AnimalsConsoleApp.Model;

namespace AnimalsConsoleApp.Services
{
    class AnimalServices
    {
        public void CreatingListOfAnimals()
        {
            //utworzenie listy i dodawanie do niej nowych zwierząt
            var listOfAnimalsInZoo = new List<IAnimal>();
            var addAnotherAnimalAnswer = "y";
            do
            {
                var newAnimalOnList = CreateNewAnimal();
                var logInit = new LogService();
                var ItemType = newAnimalOnList.GetType();
                logInit.AddLogDataToLogFile(ItemType, newAnimalOnList.ID);
                listOfAnimalsInZoo.Add(newAnimalOnList);
                //LogService.AddLogDataToLogFile(newAnimalOnList);
                Console.WriteLine("Do you want to add another animal to the list? \ny - yes \nn - no");
                addAnotherAnimalAnswer = Console.ReadLine();
            } while (addAnotherAnimalAnswer == "y");

            //wyświetlenie dodanych zwierząt w sesji
            Console.WriteLine("The list of added animals:");
            foreach (var animal in listOfAnimalsInZoo)
            {
                Console.WriteLine(animal.Name + " - " + animal.Behaviour);
            }
            //Console.WriteLine("Press m to return to Menu. Press any other key to exit.");
            //var returnToMenu = Console.ReadLine();
            //if (returnToMenu == "m")
            //{
            //    Console.Clear();
            //    // ? znowu wywołać menuDisplay ?
            //}
        }
        static public IAnimal CreateNewAnimal()
        {
            IAnimal result;
            //zapytanie użytkownika o rodzaj zwierzęcia jakie chce wybrać
            var questionAnimal = "Select an animal to add to register: ";
            var eAnimalValue = EAnimal.GetValues(typeof(EAnimal));
            Console.WriteLine(questionAnimal);
            foreach (var enumValue in EAnimal.GetValues(typeof(EAnimal)))
            {
                Console.WriteLine((int)enumValue + " - " + enumValue);
            }
            var answerUsersTypeOfAnimal = Int32.Parse(Console.ReadLine());
            if (answerUsersTypeOfAnimal == (int)EAnimal.Elephant)
                result = new Elephant();
            else if (answerUsersTypeOfAnimal == (int)EAnimal.Lion)
            {
                result = new Lion();
            }
            else if (answerUsersTypeOfAnimal == (int)EAnimal.Giraffe)
            {
                result = new Giraffe();
            }
            else if (answerUsersTypeOfAnimal == (int)EAnimal.Parrot)
            {
                result = new Parrot();
            }
            else
            {
                result = new Seal();
            }
            //dodanie propertisów do utworzonego nowego zwierzęcia
            var newResult = AddingPropertiesToNewAnimal(result);
            return newResult;
        }

        public static IAnimal AddingPropertiesToNewAnimal(IAnimal newAnimal)
        {
            newAnimal.ID = Guid.NewGuid();
            Console.Write("Name: ");
            newAnimal.Name = Console.ReadLine();
            Console.Write("Age: ");
            newAnimal.Age = Int32.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            newAnimal.Weight = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Gender: \nm - male \nf - female");
            newAnimal.Gender = Console.ReadLine();
            Console.WriteLine("Is the animal Vaccinated? \ntrue/false");
            newAnimal.IsVaccinated = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Choose usual behaviour of the animal: ");
            foreach (var enumValue in EBehaviour.GetValues(typeof(EBehaviour)))
            {
                Console.WriteLine((int)enumValue + " - " + enumValue.ToString().ToLower());
            }
            newAnimal.Behaviour = (EBehaviour)Int32.Parse(Console.ReadLine());
            return newAnimal;
        }
    }
}
