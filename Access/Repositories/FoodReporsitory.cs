using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class FoodReporsitory
    {
        AboDbContext db;
        public FoodReporsitory()
        {
            db = new AboDbContext();
        }
        /// <summary>
        /// KategoriId ye göre Listele
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        public List<Food> GetByCategoryId(int categoryID)
        {
            return db.Foods.Where(a => a.CategoryID == categoryID).ToList();

        }
        /// <summary>
        /// UserId ye göre yemekleri listele
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<MealAndFood> GetByUserAndFoodId(int foodID,int userID)  // not al böyle bişey mmükün mü
        {
            return db.MealsAndFoods.Where(a => a.Meal.UserID == userID && a.FoodID == foodID).ToList();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mealID"></param>
        /// <returns></returns>
        public Food GetByFoodId(int foodID)
        {
            return db.Foods.Find(foodID);
        }
        public int Insert(Food food)
        {
            db.Foods.Add(food);
            int affRows = db.SaveChanges();
            return affRows;
        }
        public int Delete(Food food)
        {
            Food deleteFood = db.Foods.Find(food.FoodID);
            db.Foods.Remove(deleteFood);
            int affRows = db.SaveChanges();
            return affRows;
        }

    }
}
