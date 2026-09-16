using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BongcheonMonthlyRent
{
    internal class Room
    {
        public int id;
        public Queue<Tenant> tenants;

        public Room(int id)
        {
            this.id = id;
            tenants = new Queue<Tenant>();
        }
    }
}
