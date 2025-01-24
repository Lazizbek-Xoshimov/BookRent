using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public UserType Type { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum UserType
    {
        Student,
        Teacher,
        Librariant
    }
}
