using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LowCost : VacationBuilder
    {
        public override void BuildFlight()
        {
            vacation.SetFlight("Business Class");
        }

        public override void BuildHotel()
        {
            vacation.SetHotel("3 Stars Hotel");
        }

        public override void BuildTransportation()
        {
            vacation.SetTransportation("A Bus To The Hotel");
        }
    }
}
