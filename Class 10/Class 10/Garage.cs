using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_10
{
    class Garage : IGarage
    {
        public Car[] cars { get; set; }
        public string[] carTypes { get; set; }


        public Garage(Car[] carTypes)
        {

        }

        public void AddCar(Car car)
        {

        }

        public void FixCar()
        {

        }

        public void TakeOutCar()
        {

        }
    }
}
