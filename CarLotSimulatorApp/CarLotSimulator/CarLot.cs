using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public CarLot()
    {
    }

    public static int numberOfCars = 0; // static field
    
    public List<Car> Cars = new List<Car>();

    public List<Car> ParkingLot { get; set; } = new List<Car>();
}