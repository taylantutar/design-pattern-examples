using _04_AbstractFactory;
using _04_AbstractFactory.models.concrete;

Client client = new Client();
client.SetFactory(new BM1Factory());
var car1 = client.GetCar();
Console.WriteLine(car1);

Console.WriteLine("********************");

client.SetFactory(new BM2Factory());
var car2 = client.GetCar();
Console.WriteLine(car2);
