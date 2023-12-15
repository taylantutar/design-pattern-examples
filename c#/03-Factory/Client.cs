using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;

namespace _03_Factory
{
    public class Client
    {
        private IFactory _Factory { get; set; }

        public Client(IFactory Factory)
        {
            _Factory = Factory;
        }

        public void SetFactory(IFactory Factory){
            _Factory = Factory;
        }

        public void CreateCar()
        {
            var car = _Factory.CreateCar();
            Console.WriteLine(car);
        }
    }
}