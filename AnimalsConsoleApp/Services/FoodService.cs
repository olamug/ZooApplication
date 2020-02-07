using AnimalsConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalsConsoleApp.Services
{
    class FoodService
    {
        public Food CreateNewFood()
        {
            var newFood = new Food();
            newFood.ID = Guid.NewGuid();
            Console.WriteLine("Enter following parameters of food:");
            Console.Write("Producent/Name: ");
            newFood.Name = Console.ReadLine();
            Console.Write("Energy value in kcal per 100 g: ");
            newFood.EnergyValueInKcal = Int32.Parse(Console.ReadLine());
            Console.Write("Origin of indgredients, eg. plant-origin, raw meat etc.: ");
            newFood.OriginOfIndgredients = Console.ReadLine();

            return newFood;
        }
        public void CreatingListOfFood()
        {
            var listOfFood = new List<Food>();
            var addAnotherFoodAnswer = "y";
            do
            {
                var newFood = CreateNewFood();
                var logInit = new LogService();
                var ItemType = newFood.GetType();
                logInit.AddLogDataToLogFile(ItemType, newFood.ID);
                listOfFood.Add(newFood);
                Console.WriteLine("Food: " + newFood.Name + " with ID " + newFood.ID + " has been added.");
                Console.WriteLine("Do you want to add another food type to register? \ny - yes \nn - no");
                addAnotherFoodAnswer = Console.ReadLine();
            } while (addAnotherFoodAnswer == "y");
            Console.WriteLine("List of added eatables: ");
            foreach (var item in listOfFood)
            {
                Console.WriteLine(item.Name + " " + " ID: " + item.ID);
            }
        }
    }
}
