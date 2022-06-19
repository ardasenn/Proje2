using ABOACIDIYET.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABOACIDIYET.Entities
{
    public class Meal
    {
        public Meal()
        {
            MealAndFoods = new List<MealAndFood>();
        }
        private int mealID;
        private MealType mealName;
        private DateTime mealTime;
      

        public int MealID { get => mealID; set => mealID = value; }
        public int UserID { get; set; }
        public MealType MealName { get => mealName; set => mealName = value; }
        public DateTime MealTime { get => mealTime; set => mealTime = value; }


        public virtual User User { get ; set; }
        public ICollection<MealAndFood> MealAndFoods { get; set; }
    }
}
