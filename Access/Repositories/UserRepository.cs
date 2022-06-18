using ABOACIDIYET.Entities;
using ABOACIDIYET.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class UserRepository
    {
        AboDbContext db;
        public UserRepository()
        {
            db = new AboDbContext();
        }
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            users = db.Users.ToList();
            return users;
        }
        public int Insert(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) && string.IsNullOrWhiteSpace(user.LastName) && string.IsNullOrWhiteSpace(user.Password)) throw new Exception("FirstName, LastName ve Parola bilgilerini giriniz");
            //if (db.Users.Where(x=> x.Email == user.Email)) throw new Exception("Böyle bir email adresi zaten kayıtta mevcut");

            user.UserType = UserType.User;
            db.Users.Add(user);
            int affRows = db.SaveChanges();
            return affRows;
        }
        public User GetUserById(int userID)
        {
            return db.Users.Find(userID);
        }
        /// <summary>
        /// email unique olduğu için single or default ile kontrol yapılır.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public User CheckLogin(string email, string password)
        {
            User user = db.Users.Where(a => a.Email == email).SingleOrDefault();
            if (user != null)
            {
                if (user.Password != null && user.Password == password)
                {
                    return user;
                }
            }
            else
            {
                new Exception("Böyle bir emaile sahip kayıtlı kullanıcı yoktur");
            }
            return null;
        }
        /// <summary>
        /// userları listele
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<User> GetByUserId(int userID)
        {
            return db.Users.Where(a => a.UserID == userID).ToList();

        }

    }
}