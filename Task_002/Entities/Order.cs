using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002.Entities
{
    public class Order
    {
        public uint Id { get; set; }
        public string ProductName { get; set; }
        public uint Quontity { get; set; }
        public decimal Price { get; set; }
        public uint CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
