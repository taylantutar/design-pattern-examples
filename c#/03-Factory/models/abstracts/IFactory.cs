using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_Factory.models.abstracts
{
    public interface IFactory
    {
        ICar CreateCar (CarType carType);
    }
}