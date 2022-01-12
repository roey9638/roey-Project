using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Bill : Proto<Bill>
    {
        public Customer customer1 { get; set; }
        public Customer customer2 { get; set; }

        public Bill(Customer c1, Customer c2)
        {
            customer1 = c1;
            customer2 = c2;
        }

        public Bill Clone()
        {
            var clone = new Bill(this.customer1.Clone(), this.customer2.Clone());

            return clone;
        }

        public override string ToString()
        {
            return $"Customer 1 Age : {customer1.Age} Name : {customer1.Name} Customer 2 Age: {customer2.Age} Name : {customer2.Name}:";
        }
    }
}
