using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABOACIDIYET.Entities
{
    public class MealAndFood
    {

        public int MealAndFoodID { get; set; }
        //[Key, Column(Order = 0)]
        public int MealID { get; set; }
        //[Key, Column(Order = 1)]
        public int FoodID { get; set; }

        public virtual Meal Meal { get; set; }
        public virtual Food Food { get; set; }

    }
}
