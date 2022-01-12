using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Vacation
    {
        private string flight;
        private string hotel;
        private string transportation;

        public void SetFlight(string flight)
        {
            this.flight = flight;
        }

        public void SetHotel(string hotel)
        {
            this.hotel = hotel;
        }

        public void SetTransportation(string transportation)
        {
            this.transportation = transportation;
        }

        public override string ToString()
        {
            return $"Flight is: {flight} , Hotel is: {hotel} , Transportation is: {transportation}";
        }
    }
}
