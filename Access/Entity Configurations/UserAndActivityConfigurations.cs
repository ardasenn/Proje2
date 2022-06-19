using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entity_Configurations
{
    public class UserAndActivityConfigurations : EntityTypeConfiguration<UserAndActivity>
    {
        public UserAndActivityConfigurations()
        {

            //HasKey(ua => new { ua.UserID, ua.ActivityID });
            HasKey(ua => ua.UserAndActivityID);
        }
    }
}