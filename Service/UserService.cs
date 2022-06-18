using ABOACIDIYET.Entities;
using Access.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
    public class UserService
    {
        UserRepository userRep;
        public UserService()
        {
            userRep = new UserRepository();
        }
        public void UserReptekiInsertKullananMetot(string isim)
        {
           User user2 = new User();
            user2.FirstName = isim;
            userRep.Insert(user2);


            
        }
    }
}
