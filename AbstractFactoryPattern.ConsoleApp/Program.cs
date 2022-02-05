// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern.BusinessLogic;
using AbstractFactoryPattern.BusinessLogic.FactoryContracts;

Console.WriteLine("Hello, World!");

// Abstract factory #1
RentVehicleFactory factory1 = new SingleContract();
RentVehicleClient client1 = new RentVehicleClient(factory1);
client1.Run();

// Abstract factory #2
RentVehicleFactory factory2 = new UberContract();
RentVehicleClient client2 = new RentVehicleClient(factory2);
client2.Run();

// Wait for user input
Console.ReadKey();
