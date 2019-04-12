using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class Customers
    {
        public int IdCustomer { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Suffix { get; set; }
        public DateTime Birthdate { get; set; }
        public string IdCardPersonal { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public int CityId { get; set; }
        public string Country { get; set; }
        public bool Active { get; set; }
    }
}
