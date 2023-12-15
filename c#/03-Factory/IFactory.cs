using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_Factory
{
    public interface IFactory
    {
        ICar CreateCar ();

    }

    public class BMW1Factory : IFactory
    {
        public ICar CreateCar()
        {
            return new BMW1("BMW","118","White");
        }
    }

    public class BMW2Factory : IFactory
    {
        public ICar CreateCar()
        {
            return new BMW2("BMW","220","Blue");
        }
    }
}