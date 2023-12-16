using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using _04_AbstractFactory.models.abstracts;

namespace _04_AbstractFactory
{
    public class Client
    {
        private IFactory Factory; 
        
        public void SetFactory(IFactory factory){
            this.Factory = factory;
        }

        public ICar GetCar()
        {
            return Factory.CreateCar();
        }
    }

}