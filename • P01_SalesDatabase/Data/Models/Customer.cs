using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __P01_SalesDatabase.Data.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreaditCardNumber { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
