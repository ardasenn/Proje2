using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entity_Configurations
{
    public class MealAndFoodConfigurations : EntityTypeConfiguration<MealAndFood>
    {
        public MealAndFoodConfigurations()
        {

            HasKey(mf => mf.MealAndFoodID);
            //HasKey(mf => new { mf.MealID, mf.FoodID });

        }

    }


}