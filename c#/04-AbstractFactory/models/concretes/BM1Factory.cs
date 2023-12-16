
using _04_AbstractFactory.models.abstracts;

namespace _04_AbstractFactory.models.concrete
{
    public class BM1Factory : IFactory
    {
        public ICar CreateCar()
        {
            return new BMW1("BMW","118","Blue");
        }
    }
}