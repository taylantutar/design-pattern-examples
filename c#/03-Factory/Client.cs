using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using _03_Factory.models.abstracts;
using _03_Factory.models.concrete;

namespace _03_Factory
{
    public class Client
    {
        public Client()
        {
        }

        public ICar GetCar(CarType carType)
        {
            var factory = new CarFactory();
            return factory.CreateCar(carType);
        }
    }

}