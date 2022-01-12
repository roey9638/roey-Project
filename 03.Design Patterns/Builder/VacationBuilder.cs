using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class VacationBuilder
    {
        
        protected Vacation vacation;

        public VacationBuilder()
        {
            vacation = new Vacation();
        }

        public abstract void BuildFlight();
        public abstract void BuildHotel();
        public abstract void BuildTransportation();

        public void ConsructVacation()
        {
            BuildFlight();
            BuildHotel();
            BuildTransportation();
        }

        public Vacation GetVacation()
        {
            return vacation;
        }
    }
}
