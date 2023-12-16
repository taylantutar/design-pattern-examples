using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_AbstractFactory.models.abstracts
{
    public interface IFactory
    {
        ICar CreateCar();
    }
}