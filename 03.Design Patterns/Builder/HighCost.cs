using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HighCost : VacationBuilder
    {
        public override void BuildFlight()
        {
            vacation.SetFlight("First Class");
        }

        public override void BuildHotel()
        {
            vacation.SetHotel("5 Stars Hotel");
        }

        public override void BuildTransportation()
        {
            vacation.SetTransportation("Special Cab To The Hotel");
        }
    }
}
