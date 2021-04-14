using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFizzBuzz.Form
{
    public class Number
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
