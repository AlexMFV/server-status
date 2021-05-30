using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Status
{
    class Servers : CollectionBase
    {
        public void Add(Server server)
        {
            List.Add(server);
        }

        public void Remove(Server server)
        {
            List.Remove(server);
        }

        public Server this[int index]
        {
            get { return (Server)List[index]; }
            set { List[index] = value; }
        }
    }
}
