using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Person
    {
        public string name;

        event DelagateNameLength TooLongNameEvent;


        private string Name
        {
            get { return name; }
            set
            {              
                name = value;
                if(value.Length > 10)
                {
                    if (TooLongNameEvent != null)
                    {
                        TooLongNameEvent += InvokeEvent;
                        TooLongNameEvent();
                    }
                }
            }
        }

        public void NameLength()
        {
            if (TooLongNameEvent != null)
            {
                TooLongNameEvent += InvokeEvent;
                TooLongNameEvent();
            }
        }

        private void InvokeEvent()
        {
            Console.WriteLine($"The name is to long {name}");
        }
    }
}
