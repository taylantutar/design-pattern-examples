using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _03_Factory.models.abstracts;

namespace _03_Factory.models.concrete
{
    public class BMW1 : ICar
    {
        public BMW1(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }

        public string Brand {get;set;}
        public string Model {get;set;}
        public string Color {get;set;}

        public override string ToString()
        {
            return $"BMW 1 is creating Brand:{Brand}, Model: {Model} Color:{Color}";
        }
    }
}