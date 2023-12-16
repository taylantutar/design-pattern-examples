using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace _04_AbstractFactory.models.abstracts
{
    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        string Color { get; set; }
    }
}