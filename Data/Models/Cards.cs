using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class Cards
    {
        public int IdCard { get; set; }
        public DateTime ExpireDate { get; set; }
        public int IdAccount { get; set; }
        public string CardNumber { get; set; }
        public string Pin { get; set; }
        public bool Blocked { get; set; }
        public bool Active { get; set; }
    }
}
