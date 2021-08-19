using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_10
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //class client
    //{
    //    public void orderDish()
    //    {
    //        DishNotValidException wrongDish = new DishNotValidException("wrongDish");

    //        try
    //        {
    //            chef chef1 = new chef();
    //            chef1.MakeDish("");
    //        }
    //        catch
    //        {

    //        }
    //    }
    //}

    //class chef
    //{
    //    public chef()
    //    {

    //    }

    //    public void MakeDish(string order)
    //    {
    //        string food = Console.ReadLine();

    //        try
    //        {
    //            if (food == "falafel")
    //            {
    //                throw new PitaOutOfRangeException(" not enough pita");
    //            }
    //        }
    //        catch
    //        {
    //            throw new DishNotValidException("wrond dish");
    //        }
    //    }
    //}



    class Car
    {
        public string Brand { get; set; }
        public bool TotalLost { get; set; }
        public bool NeedRepair { get; set; }

        public Car(string brand , bool totalLost , bool needRepair)
        {
            Brand = brand;
            TotalLost = totalLost;
            NeedRepair = needRepair;

        }

    }


}
