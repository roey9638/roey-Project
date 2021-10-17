using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_WindowsForm
{
    public class ClientList
    {
        List<client> clients = new List<client>();

        public void Add(client client)
        {
            clients.Add(client);
        }
    }
}
