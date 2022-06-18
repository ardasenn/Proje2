using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entity_Configurations
{
    public class CategoryConfigurations : EntityTypeConfiguration<Category>
    {
        public CategoryConfigurations()
        {
            Property(a => a.CategoryName).IsRequired().HasMaxLength(100);
            //Relation
            HasMany(a => a.Foods).WithRequired(a => a.Category).HasForeignKey(a => a.CategoryID);
        }
    }
}
