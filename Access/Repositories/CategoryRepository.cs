using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class CategoryRepository
    {
        AboDbContext db;
        public CategoryRepository()
        {
            db = new AboDbContext();
        }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories = db.Categories.ToList();
            return categories;
        }
        public int Insert(Category category)
        {
            db.Categories.Add(category);
            int affRows = db.SaveChanges();
            return affRows;
        }
        public int Delete(Category category)
        {
            Category deleteCategory = db.Categories.Find(category.CategoryID);
            db.Categories.Remove(deleteCategory);
            int affRows = db.SaveChanges();
            return affRows;
        }
    }
}
