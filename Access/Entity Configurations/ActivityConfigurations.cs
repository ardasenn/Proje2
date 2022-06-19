using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entity_Configurations
{
    public class ActivityConfigurations : EntityTypeConfiguration<Activity>
    {
        public ActivityConfigurations()
        {
            Property(a => a.ActivityName).IsRequired().HasMaxLength(100);
            Property(a => a.BurnedCalorieInActivity).IsRequired();

            HasMany(a => a.UserAndActivities).WithRequired(a => a.Activity).HasForeignKey(a => a.ActivityID);
        }
    }
}
