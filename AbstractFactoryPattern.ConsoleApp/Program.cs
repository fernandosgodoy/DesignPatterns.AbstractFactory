// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern.ConsoleApp;

Console.WriteLine("Hello, World!");

// Abstract factory #1
RentVehicleFactory factory1 = new SingleContract();
Client client1 = new Client(factory1);
client1.Run();

// Abstract factory #2
RentVehicleFactory factory2 = new UberContract();
Client client2 = new Client(factory2);
client2.Run();

// Wait for user input
Console.ReadKey();
