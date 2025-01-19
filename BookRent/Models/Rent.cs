using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Models
{
    public class Rent
    {
        public int RentId { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime GivenTime { get; set; }
        public DateTime ReturnedTime {  get; set; }
        public bool IsReturned { get; set; }
    }
}
