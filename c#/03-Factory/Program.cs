
using _03_Factory;

Console.WriteLine("***Starting****");

var bMW1Builder = new BMW1Factory();
Client client = new Client(bMW1Builder);
client.CreateCar();

Console.WriteLine("********************");

var bMW2Builder = new BMW2Factory();
client.SetFactory(bMW2Builder);
client.CreateCar();

Console.WriteLine("***Finishing****");
