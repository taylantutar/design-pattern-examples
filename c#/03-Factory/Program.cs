
using _03_Factory;

Client client = new Client();
var car1 = client.GetCar(CarType.BMW1);
Console.WriteLine(car1);

Console.WriteLine("********************");

var car2 = client.GetCar(CarType.BMW2);
Console.WriteLine(car2);

public enum CarType
{
    BMW1,
    BMW2
}
