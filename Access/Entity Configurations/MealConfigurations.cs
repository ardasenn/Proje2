using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entity_Configurations
{
    public class MealConfigurations:EntityTypeConfiguration<Meal>
    {
        public MealConfigurations()
        {
            HasKey(a => a.MealID);
            Property(a => a.MealName).IsRequired().HasMaxLength(100);
        }
    }
}
