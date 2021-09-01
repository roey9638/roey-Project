using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Temperatures
    {
        public string City { get; set; }
        public int Date { get; set; }
        public int Degrees { get; set; }
        public int Moisture { get; set; }

        public Temperatures(string city, int date, int degrees, int moisture)
        {
            City = city;
            Date = date;
            Degrees = degrees;
            Moisture = moisture;
        }

        public override string ToString()
        {
            return $"City = {City} Date = {Date} Degrees = {Degrees} Moisture = {Moisture}";
        }

    }

    //---[Qst 02 A.]--- Sorting The List By [City]
    public class SortCity : IComparer<Temperatures>
    {
        public int Compare(Temperatures x, Temperatures y)
        {
            return x.City.CompareTo(y.City);
        }
    }


    //---[Qst 02 B.]--- Sorting The List if the [x.City] and the [y.City] are (Equal / == (0)) Then it will (Equal / CompareTo) by [Date]. it will do [return x.Date.CompareTo(y.Date)].
    //But if [x.City] and the [y.City] are [Not] (Equal / == (0)) then it will do the (else) it will (Equal / CompareTo) by [City]. it will do [return x.City.CompareTo(y.City)].
    public class SortCityDate : IComparer<Temperatures>
    {
        public int Compare(Temperatures x, Temperatures y)
        {
            if (x.City.CompareTo(y.City) == 0)
            {
                return x.Date.CompareTo(y.Date);
            }
            else
            {
                return x.City.CompareTo(y.City);
            }
        }
    }


    //---[Qst 02 C.]--- Sorting The List if the [x.Degrees] and the [y.Degrees] are (Equal / == (0)) Then it will (Equal / CompareTo) by [City]. it will do [return x.City.CompareTo(y.City) * -1].
    //But if [x.Degrees] and the [y.Degrees] are [Not] (Equal / == (0)) then it will do the (else) it will (Equal / CompareTo) by [Degrees]. it will do [return x.Degrees.CompareTo(y.Degrees) * -1].
    public class SortByTempThenCity : IComparer<Temperatures>
    {
        public int Compare(Temperatures x, Temperatures y)
        {
            if (x.Degrees.CompareTo(y.Degrees) == 0)
            {
                return x.City.CompareTo(y.City);
            }
            else
            {
                return x.Degrees.CompareTo(y.Degrees) * -1;
            }
        }
    }


    //---[Qst 02 D.]--- Sorting The List if the [x.Moistures] and the [y.Moisture] are (Equal / == (0)) Then Continue Down VV.
    //Then we Check if [x.Degrees] and the [y.Degrees] are (Equal / == (0)) Then it will [Sort] the [list] by [return x.City.CompareTo(y.City)].
    //But if [x.Degrees] and the [y.Degrees] are Not (Equal / == (0)) then it [Sort] the [list] by [return x.Degrees.CompareTo(y.Degrees) * -1].
    //If The [x.Moisture] and the [y.Moisture] are Not (Equal / == (0)) in the [First (if)] then it will [Sort] the [list] by [return x.Moisture.CompareTo(y.Moisture) * -1].
    public class SortByMoistureThenDegreesThenCity : IComparer<Temperatures>
    {
        public int Compare(Temperatures x, Temperatures y)
        {
            if (x.Moisture.CompareTo(y.Moisture) == 0)
            {
                if (x.Degrees.CompareTo(y.Degrees) == 0)
                {
                    return x.City.CompareTo(y.City);
                }
                else
                {
                    return x.Degrees.CompareTo(y.Degrees) * -1;
                }
            }
            else
            {
                return x.Moisture.CompareTo(y.Moisture) * -1;
            }

        }
    }


}
