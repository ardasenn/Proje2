using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class MealRepository
    {
        AboDbContext db;
        public MealRepository()
        {
            db = new AboDbContext();
        }
        public List<Meal> GetMeals()
        {
            List<Meal> meals = new List<Meal>();
            meals = db.Meals.ToList();
            return meals;
        }
        /// <summary>
        /// UserId ye göre öğünler listelenir
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<Meal> GetByUserId(int userID)
        {
            return db.Meals.Where(a => a.UserID == userID).ToList();
        }
        /// <summary>
        /// yemekID ye göre öğünleri listele
        /// </summary>
        /// <param name="foodID"></param>
        /// <returns></returns>
        public List<MealAndFood> GetByFoodId(int foodID)
        {
            return db.MealsAndFoods.Where(a => a.FoodID == foodID).ToList();
        }
        /// <summary>
        /// ÖğünId ye göre öğün dön
        /// </summary>
        /// <param name="mealID"></param>
        /// <returns></returns>
        public Meal GetByMealId(int mealID)
        {
            return db.Meals.Find(mealID);
        }
        /// <summary>
        /// Öğün ekleme
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public int Insert(Meal meal)
        {
            db.Meals.Add(meal);
            int affRows = db.SaveChanges();
            return affRows;
        }
        /// <summary>
        /// Öğün ıd sine göre öğünü silme
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public int Delete(int foodID)
        {
            Meal deleteMeal = db.Meals.Find(foodID);
            db.Meals.Remove(deleteMeal);
            int affRows = db.SaveChanges();
            return affRows;
        }
        public int Delete(Meal meal)
        {
            Meal deleteMeal = db.Meals.Find(meal.MealID);
            db.Meals.Remove(deleteMeal);
            int affRows = db.SaveChanges();
            return affRows;
        }
    }
}