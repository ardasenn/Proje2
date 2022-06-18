using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABOACIDIYET.Entities
{
    public class Category
    {
        private int categoryID;
        private string categoryName;
        private string categoryDescription;
        private string picturePath;
        public Category()
        {
            Foods = new List<Food>();
        }
        public Category(string categoryName, string categoryDescription, string picturePath)
        {
            this.categoryName = categoryName;
            this.categoryDescription = categoryDescription;
            this.picturePath = picturePath; 
            Foods = new List<Food>();
        }

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string CategoryDescription { get => categoryDescription; set => categoryDescription = value; }
        public string PicturePath { get => picturePath; set => picturePath = value; }

        public ICollection<Food> Foods { get; set; }

    }
}
