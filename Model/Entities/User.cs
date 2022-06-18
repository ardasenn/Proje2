using ABOACIDIYET.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABOACIDIYET.Entities
{
    public class User
    {
        public User()
        {
            Kilos = new HashSet<Kilo>();
            Targets = new HashSet<Target>();
            Meals = new HashSet<Meal>();
            UserAndActivities = new HashSet<UserAndActivity>();
        }
        public int UserID { get; set; }
        public UserType UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Height { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public virtual ICollection<Kilo> Kilos { get; set; }
        public virtual ICollection<Target> Targets { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<UserAndActivity> UserAndActivities { get; set; }


    }
}
