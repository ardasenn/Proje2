using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entity_Configurations
{
    public class UserConfigurations : EntityTypeConfiguration<User>
    {
        public UserConfigurations()
        {
            Property(a => a.FirstName).IsRequired().HasMaxLength(100);
            Property(a => a.LastName).IsRequired().HasMaxLength(100);
            Property(a => a.Email).IsRequired().HasMaxLength(100);
            HasIndex(a => a.Email).IsUnique(); // email unique olucak
            Property(a => a.Password).IsRequired().HasMaxLength(20);
            Property(a => a.Gender).IsRequired();


            //one to many relations
            HasMany(a => a.Kilos).WithRequired(a => a.User).HasForeignKey(a => a.UserID);
            HasMany(a => a.Meals).WithRequired(a => a.User).HasForeignKey(a => a.UserID);
            HasMany(a => a.Targets).WithRequired(a => a.User).HasForeignKey(a => a.UserID);
            HasMany(a => a.UserAndActivities).WithRequired(a => a.User).HasForeignKey(a => a.UserID);
        }
    }
}
