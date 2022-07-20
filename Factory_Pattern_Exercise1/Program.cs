using System;
using Factory_Pattern_Exercise;
Console.WriteLine($"Please enter a number of wheels:");
Console.WriteLine($"2 => Motorcycle");
Console.WriteLine($"4 => Car");
Console.WriteLine($"16 => BigRig");
Console.WriteLine($"Any other number => Generic Vehicle");

int numberOfWheels = int.Parse(Console.ReadLine());

var myVehicle = VehicleFactory.GetVehicle(numberOfWheels);
myVehicle.Drive();
