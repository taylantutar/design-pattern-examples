
using _03_Factory.models.abstracts;

namespace _03_Factory.models.concrete
{
    public class CarFactory : IFactory
    {
        public ICar CreateCar(CarType carType)
        {
            if (carType == CarType.BMW1)
            {
                return new BMW1("BMW","118","Blue");
            }else if(carType == CarType.BMW2){
                return new BMW2("BMW","220","Black");
            }
            return new BMW1("BMW","118","Blue");
        }
    }
}