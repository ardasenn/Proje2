using ABOACIDIYET.Entities;
using Access.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABOACIDIYET
{
    public partial class MealRegisterForm : Form
    {
        CategoryRepository categoryRepository;
        FoodReporsitory foodReporsitory;
        MealRepository mealRepository;
        public MealRegisterForm()
        {
            InitializeComponent(); // buraya UserID gelmesi gerekir ? ve öğün ıd ??

            foodReporsitory = new FoodReporsitory();
            categoryRepository = new CategoryRepository();
            mealRepository = new MealRepository();
        }

        private void MealRegisterForm_Load(object sender, EventArgs e)
        {
            //kategori bas 
            cmbCategory.DataSource = categoryRepository.GetCategories();
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryID";


            // besin bas,kategori ıd ye göre 
            if (cmbCategory.SelectedIndex != -1)
            {
                int categoryId = (int)cmbCategory.SelectedValue;
                cmbFood.DataSource = foodReporsitory.GetByCategoryId(categoryId);
                cmbFood.DisplayMember = "foodName";
                cmbFood.ValueMember = "foodID"; 
            }
            else
            {
                MessageBox.Show("Lütfen Kategori Seçiniz");
            }

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex !=-1 && cmbFood.SelectedIndex !=-1) // yani kategori ve besinden değer seçildiyse
            {
                ListViewByFoodId();
                
            }
            else MessageBox.Show("Lütfen Kategori ve Besin Seçiniz");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvFoodAndMeal.SelectedItems.Count!=-1)
            {
                MessageBox.Show("Lütfen silmek istediğiniz yiyeceği seçiniz");
                return;
            }
            int foodId = Convert.ToInt32(cmbFood.SelectedValue);
            int affRow = mealRepository.Delete(foodId);
            MessageBox.Show(affRow > 0 ? " Silindi" : "Hata Oluştu");

            ListViewByFoodId();
        }
        void ListViewByFoodId()
        {
            int foodId = Convert.ToInt32(cmbFood.SelectedValue);
            List<Food> foods = foodReporsitory.GetByFoods(foodId);

            lvFoodAndMeal.Items.Clear();
            foreach (var item in foods)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.FoodName;
                lvi.SubItems.Add(item.Category.CategoryName);
                lvi.SubItems.Add(item.FoodCalorie.ToString());
                lvi.SubItems.Add(item.Portion.ToString());

                lvFoodAndMeal.Items.Add(lvi);
            }
        }
    }
}
