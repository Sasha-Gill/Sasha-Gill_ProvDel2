using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ContrabanfCars: Car
    {
        public void ContrabandCars(int contrabandAmount, int passengers)
        {
            contrabandAmount = generator.Next(1,4);
            passengers = generator.Next(1, 4);
        }
    }
}
