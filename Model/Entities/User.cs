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
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("İsminizi boş geçemezsiniz..");
                else firstName = value;
            }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Soyadınızı boş geçemezsiniz..");
                else lastName = value;
            }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if (!(value.Contains("@") && value.EndsWith(".com"))) throw new Exception("Geçerli bir email adresi giriniz");//neden || neden && değil ?
                else email = value;
            }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value.ToString().Length <= 3 && value.ToString().All(char.IsNumber) && value.ToString().Length > 2 )
                {
                    height = value;
                }
                else { throw new Exception("Boyunuz mantıklı bir değer olmak zorunda"); }
            }
        }


        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 5 ) throw new Exception("Şifreniz 5 karakterden az veya en az bir sayı içermeli");
                else password = value;
                
            }
        }

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set 
            {if (DateTime.Now.Year - value.Year <= 7) throw new Exception("Kullanıcı 7 yaşından küçük olamaz...");
            else birthDate = value;
            }
        }
        public Gender Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public virtual ICollection<Kilo> Kilos { get; set; }
        public virtual ICollection<Target> Targets { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<UserAndActivity> UserAndActivities { get; set; }


    }
}
