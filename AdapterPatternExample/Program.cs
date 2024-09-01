﻿using System;
using AdapterPattern;

    class Program
{
    static void Main(string[] args)
    {
        // Existing system works with IVehicle
        Vehicle car = new Car();
        car.Drive(); // driving.

        // New class Bicycle doesn't fit directly
        Bicycle bicycle = new Bicycle();

        // Adapter allows us to use Bicycle as an IVehicle
        Vehicle bicycleAdapter = new BicycleAdapter(bicycle);
        bicycleAdapter.Drive(); //  pedaling.

        Console.ReadKey();
    }
}
