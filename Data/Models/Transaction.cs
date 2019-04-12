using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class Transaction
    {
        public int IdTransaction { get; set; }
        public int IdFrom { get; set; }
        public int IdTo { get; set; }
        public decimal Value { get; set; }
        public string Vs { get; set; }
        public string Ss { get; set; }
        public string Ks { get; set; }
        public string Message { get; set; }
    }
}
