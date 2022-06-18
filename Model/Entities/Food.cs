using ABOACIDIYET.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABOACIDIYET.Entities
{
    public class Food
    {
        private int foodID;
        private string foodName;
        private decimal portion;
        private PortionType portionType;
        private int foodCalorie;
        private int categoryID;
        public Food()
        {
            MealAndFoods = new List<MealAndFood>();
        }

        public Food(string foodName,decimal portion, PortionType portionType,int foodCalorie, int categoryID)
        {
            this.foodName = foodName;
            this.portion = portion;
            this.portionType = portionType;
            this.foodCalorie = foodCalorie;
            this.categoryID = categoryID;
            MealAndFoods = new List<MealAndFood>();
        }

        public int FoodID { get => foodID; set => foodID = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public decimal Portion { get => portion; set => portion = value; }
        public PortionType PortionType { get => portionType; set => portionType = value; }
        public int FoodCalorie { get => foodCalorie; set => foodCalorie = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }

        public virtual Category Category { get; set; }
        public ICollection<MealAndFood>MealAndFoods { get; set; }

    }
}
