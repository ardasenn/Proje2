using ABOACIDIYET.Entities;
using Access.Entity_Configurations;
using Access.Strategy;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class AboDbContext:DbContext
    {
        public AboDbContext():base("name=connectionString")
        {
            Database.SetInitializer(new FoodStrategy());

        }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Kilo> Kilos { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealAndFood> MealsAndFoods { get; set; }
        public DbSet<Target> Targets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAndActivity> UsersAndActivities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new ActivityConfigurations());
            modelBuilder.Configurations.Add(new CategoryConfigurations());
            modelBuilder.Configurations.Add(new FoodConfigurations());
            modelBuilder.Configurations.Add(new KiloConfigurations());
            modelBuilder.Configurations.Add(new MealConfigurations());
            modelBuilder.Configurations.Add(new TargetConfigurations());
            modelBuilder.Configurations.Add(new UserConfigurations());
            modelBuilder.Configurations.Add(new UserAndActivityConfigurations());
            modelBuilder.Configurations.Add(new MealAndFoodConfigurations());
        }
    }
}
