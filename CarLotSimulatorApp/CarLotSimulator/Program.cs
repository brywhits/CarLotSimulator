using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            
            var carLotOne = new CarLot();
            
            var car1 = new Car();
            car1.Make = "Chrysler";
            car1.Model = "Thunderbolt Roadster";
            car1.Year = 1941;
            car1.IsDriveable = true;
            // car1.MakeEngineNoise("Vroom");
            // car1.MakeHonkNoise("Honk");
            carLotOne.ParkingLot.Add(car1);
            Console.WriteLine($"Number of cars in parking lot is: {CarLot.numberOfCars}");
            
            var car2 = new Car()
            {
                Make = "Mercury",
                Model = "Club Coupe", 
                Year = 1940, 
                IsDriveable = true
            };
            // car2.MakeEngineNoise("Roar");
            // car2.MakeHonkNoise("Beep");
            carLotOne.ParkingLot.Add(car2);
            Console.WriteLine($"Number of cars in parking lot is: {CarLot.numberOfCars}");

            //Parameterized Constructor = to instantiate, must provide arguments for all the different parameters
            var car3 = new Car(1948, "Studebaker", "Champion", "Bark Bark", "Vroom Vroom", true);
            // car3.MakeEngineNoise("Bark Bark");
            // car3.MakeHonkNoise("Vroom Vroom");
            carLotOne.ParkingLot.Add(car3);
            Console.WriteLine($"Number of cars in parking lot is: {CarLot.numberOfCars}");

            var car4 = new Car()
            {
                Year = 1950,
                Make = "Hyundai",
                Model = "Sonata",
                EngineNoise = "Yah Yah",
                HonkNoise = "Bark Bark",
                IsDriveable = true,
            };
            carLotOne.ParkingLot.Add(car4);
            Console.WriteLine($"Number of cars in parking lot is: {CarLot.numberOfCars}");



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            // carLotOne.CheckCars();


        }
    }
}
