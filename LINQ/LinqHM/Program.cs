using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqHM
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQ linQ = new LINQ();
            //linQ.Qst01();
            //linQ.Qst02();
            //linQ.Qst03();
            //linQ.Qst04("H");
            //linQ.Qst05("H");
            //linQ.Qst06("H");
            //linQ.Qst07();
            //linQ.Qst08();
            //linQ.Qst09();
            //linQ.Qst10();
        }
    }
    class LINQ
    {
        #region Qst 01
        public void Qst01()
        {
            int[] arr = { 1, 5, 9, 10, -2, -6 };

            var query1 = from num in arr
                         where num < 0
                         select num;
            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Qst 02
        public void Qst02()
        {
            int[] arr = { 1, 5, 9, 10, -2, -6 };

            var query2 = from num in arr
                         orderby num descending
                         select num;
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Qst 03
        public void Qst03()
        {
            int[] arr = { 1, 5, 9, 10, -2, -6 };

            var query3 = from num in arr
                         where num > 5 && num / 3 % 2 == 0
                         select num * 3;

            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Qst 04
        public void Qst04(string name)
        {
            List<City> city = new List<City>()
            {
                new City( "Hadera"),
                new City( "Netanaya"),
                new City( "Tel Aviv"),
                new City( "Hertazlia"),
            };

            var query4 = from cityName in city
                         where cityName.Name.Contains(name)
                         select cityName;
            foreach (var item in query4)
            {
                Console.WriteLine(item.Name);
            }
        }
        #endregion

        #region Qst 05
        public void Qst05(string name)
        {
            List<City> city = new List<City>()
            {
                new City( "Hadera"),
                new City( "Netanaya"),
                new City( "Tel Aviv"),
                new City( "Hertazlia"),
            };

            var query5 = from cityName in city
                         where (!cityName.Name.StartsWith("H"))
                         select cityName;
            foreach (var item in query5)
            {
                Console.WriteLine(item.Name);
            }
        }
        #endregion

        #region Qst 06
        List<City> city = new List<City>()
        {
            new City( "Hadera"),
            new City( "Hertazlia"),
            new City( "Netanaya"),
            new City( "Tel Aviv")
        };

        public void Qst06(string name)
        {
            var query6 = city.Where(city => city.Name.Contains(name)).Take(1);

            foreach (var item in query6)
            {
                Console.WriteLine(item.Name);
            }
        }

        #endregion

        #region Qst 07
        public void Qst07()
        {
            List<City> city = new List<City>()
            {
            new City( "Hadera"),
            new City( "Hertazlia"),
            new City( "Netanaya"),
            new City( "Tel Aviv")
            };

            var query7 = (from cit in city
                          orderby cit.Name
                          select cit).Take(3);
            foreach (var item in query7)
            {
                Console.WriteLine(item.Name);
            }
        }
        #endregion

        #region Qst 08
        public void Qst08()
        {
            List<City> city = new List<City>()
            {
            new City( "Hadera" , 24000),
            new City( "Hertazlia" , 25500),
            new City( "Netanaya" , 27000),
            new City( "Tel Aviv" , 26000)
            };

            var query8 = from nums in city
                        orderby nums.Residents
                        where nums.Residents > 25000
                        select nums;
            foreach (var item in query8)
            {
                Console.WriteLine( item.Residents);
            }
        }
        #endregion

        #region Qst 09
        public void Qst09()
        {
            List<City> city = new List<City>()
            {
            new City( "Hadera" , 24000),
            new City( "Hertazlia" , 25500),
            new City( "Netanaya" , 27000),
            new City( "Tel Aviv" , 26000)
            };

            var query9 = from nums in city
                         orderby nums.Residents
                         where nums.Residents > 25000
                         select nums;
            foreach (var item in query9)
            {
                Console.WriteLine(item.Name + ": " + "Resident Numbers are: " + item.Residents);
            }
        }
        #endregion

        #region Qst 10
        public void Qst10()
        {
            List<City> city = new List<City>()
            {
            new City( "Hadera" , 24000),
            new City( "Hertazlia" , 25500),
            new City( "Netanaya" , 27000),
            new City( "Tel Aviv" , 26000)
            };

            var query10 = city.Where(cities => cities.Residents > 25000).Select(cityy => new { cityy.Name, cityy.Residents });


            foreach (var item in query10)
            {
                Console.WriteLine(item.Name + ": " + "Resident Numbers are: " + item.Residents);
            }
        }
        #endregion
    }

    class City
    {
        public string Name { get; set; }
        public int Residents { get; set; }


        public City(string name)
        {
            Name = name;
        }

        public City(string name , int residents) : this(name)
        {
            Residents = residents;
        }
    }


}
