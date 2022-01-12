using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Customer : Proto<Customer>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Customer(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public Customer Clone()
        {
            Customer clone = new Customer(this.Name, this.Age) ;
            return clone;
        }
    }
}
