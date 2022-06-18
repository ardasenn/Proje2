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
        private string mealName;
        private int mealCalorie;
        private DateTime mealTime;
      

        public int MealID { get => mealID; set => mealID = value; }
        public string MealName { get => mealName; set => mealName = value; }
        public int MealCalorie { get => mealCalorie; set => mealCalorie = value; }
        public DateTime MealTime { get => mealTime; set => mealTime = value; }

        public int UserID { get ; set ; }
        public virtual User User { get ; set; }
        public ICollection<MealAndFood> MealAndFoods { get; set; }
    }
}
