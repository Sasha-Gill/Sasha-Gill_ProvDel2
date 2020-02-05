using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CleanCar: Car
    {
        public void CleanCars(int contrabandAmount, int passengers)
        {
            contrabandAmount = 0;
            passengers = generator.Next(1, 3);

        }
    }
}
