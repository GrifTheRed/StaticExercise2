using System;

namespace CarLotSimulator
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Done

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Dot notation
            var lot = new CarLot();
            var dereksCar = new Car();
            dereksCar.Make = "Chevy";
            dereksCar.Model = "C8";
            dereksCar.Year = 2021;
            dereksCar.EngineNoise = "chop, chop, chop";
            dereksCar.HonkNoise = "Beep";
            dereksCar.IsDrivable = true;
            CarLot.numberOfCars = 3;

            //Object Initializer Syntax
            var wifesCar = new Car()
            {
                Year = 2022,
                Make = "Mercedes",
                Model = "G-Wagon",
                EngineNoise = "Vroom",
                HonkNoise = "Honk",
                IsDrivable = true
            };

            //Custom Constructor
            var dailyCar = new Car(2022, "Ford", "F-150", "Whistle", "Honk", true);

            //call methods

            dereksCar.MakeEngineNoise();
            wifesCar.MakeEngineNoise();
            dailyCar.MakeEngineNoise();


            //*************BONUS*************//

            //Done Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make {car.Make} Model {car.Model}");
            }
        }
    }
}
