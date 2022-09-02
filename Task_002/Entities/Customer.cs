using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002.Entities
{
    public class Customer
    {
        public uint Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
