using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var lot = new CarLot();


            //Now that the Car class is created we can instanciate 3 new cars
            var cars = new Car();

            cars.HonkNoise = "Loud";
            cars.IsDriveable = true;
            cars.Make = "Ford";
            cars.Model = "Focus";
            cars.Year = 2023;
            cars.EngineNoise = "Roar";

            lot.Cars.Add(cars);


            var srt = new Car()
            {
                HonkNoise = "Horn",
                IsDriveable = true,
                Make = "Jeep",
                Model = "SRT",
                Year = 2023,
                EngineNoise = "Trex",
            };

            lot.Cars.Add(srt);


            var carrola = new Car();
            carrola.HonkNoise = "cute";
            carrola.IsDriveable = true;
            carrola.Make = "Toyota";
            carrola.Model = "Carolla";
            carrola.Year = 2021;
            carrola.EngineNoise = "Mouse";

            lot.Cars.Add(carrola);


            //Set the properties for each of the cars
            //Call each of the methods for each car
            cars.MakeEngineNoise(cars.EngineNoise);
            srt.MakeEngineNoise(srt.EngineNoise);
            carrola.MakeEngineNoise(carrola.EngineNoise);
            cars.MakeHonkNoise(cars.HonkNoise);
            srt.MakeHonkNoise(srt.HonkNoise);
            carrola.MakeHonkNoise(carrola.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year:{car.Year} Make:{car.Make} Model: {car.Model}");
            }
        }
    }
}
