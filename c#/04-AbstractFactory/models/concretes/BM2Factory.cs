
using _04_AbstractFactory.models.abstracts;

namespace _04_AbstractFactory.models.concrete
{
    public class BM2Factory : IFactory

    {
        public ICar CreateCar()
        {
            return new BMW2("BMW","220","Black");
        }
    }
}