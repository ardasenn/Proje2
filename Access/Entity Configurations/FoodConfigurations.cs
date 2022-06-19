using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entity_Configurations
{
    public class FoodConfigurations : EntityTypeConfiguration<Food>
    {
        public FoodConfigurations()
        {
            
            Property(a => a.FoodName).IsRequired().HasMaxLength(100);
            HasMany(a => a.MealAndFoods).WithRequired(a => a.Food).HasForeignKey(a => a.FoodID);
        }
    }
}
