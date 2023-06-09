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


            //Now that the Car class is created we can instanciate 3 new cars
            var cars = new Car();

            var focus = new Car();
            focus.HonkNoise = "Loud";
            focus.IsDriveable = true;
            focus.Make = "Ford";
            focus.Model = "Focus";
            focus.Year = 2023;
            focus.EngineNoise = "Roar";

            var srt = new Car();
            srt.HonkNoise ="Horn";
            srt.IsDriveable = true;
            srt.Make = "Jeep";
            srt.Model = "SRT";
            srt.Year = 2023;
            srt.EngineNoise = "Trex";

            var carrola = new Car();
            carrola.HonkNoise = "cute";
            carrola.IsDriveable = true;
            carrola.Make = "Toyota";
            carrola.Model = "Carolla";
            carrola.Year = 2021;
            carrola.EngineNoise = "Mouse";


            //Set the properties for each of the cars
            //Call each of the methods for each car
            focus.MakeEngineNoise(focus.EngineNoise);
            srt.MakeEngineNoise(srt.EngineNoise);
            carrola.MakeEngineNoise(carrola.EngineNoise);
            focus.MakeHonkNoise(focus.HonkNoise);
            srt.MakeHonkNoise(srt.HonkNoise);
            carrola.MakeHonkNoise(carrola.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
