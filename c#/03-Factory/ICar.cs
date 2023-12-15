using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_Factory
{
    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        string Color { get; set; }
    }

    public class BMW1 : ICar
    {
        public BMW1(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }



        public override string ToString()
        {
            return $"BMW 1 is creating Brand:{Brand}, Model: {Model} Color:{Color}";
        }
    }

    public class BMW2 : ICar
    {
        public BMW2(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            Color = color;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"BMW 2 is creating Brand:{Brand}, Model: {Model} Color:{Color}";
        }

    }
}