using ABOACIDIYET.Entities;
using ABOACIDIYET.Enums;
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
        User user;
        int mealType;
        public MealRegisterForm(User user, int mealType)
        {
            InitializeComponent(); // buraya UserID gelmesi gerekir ? ve öğün ıd ??

            foodReporsitory = new FoodReporsitory();
            categoryRepository = new CategoryRepository();
            mealRepository = new MealRepository();
            this.user = user;
            this.mealType = mealType;

        }

        private void MealRegisterForm_Load(object sender, EventArgs e)
        {

            lblHeader.Text = Enum.GetName(typeof(MealType), mealType).ToString() + " Yediklerim";
            //kategori bas 
            cmbCategory.DataSource = categoryRepository.GetCategories();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

            int categoryId = (int)cmbCategory.SelectedValue;

            cmbFood.DataSource = foodReporsitory.GetByCategoryId(categoryId);
            cmbFood.DisplayMember = "FoodName";
            cmbFood.ValueMember = "FoodID";

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

            if (lvFoodAndMeal.SelectedItems.Count <= 0) return;

            int seciliYemek = lvFoodAndMeal.SelectedItems[0].Index;
            lvFoodAndMeal.Items[seciliYemek].Remove();

        }
        void ListViewByFoodId()
        {
            int foodId = Convert.ToInt32(cmbFood.SelectedValue);
            Food food = foodReporsitory.GetByFoods(foodId);

            ListViewItem lvi = new ListViewItem();
            lvi.Text = food.FoodName;
            lvi.SubItems.Add(food.Category.CategoryName);
            lvi.SubItems.Add(food.FoodCalorie.ToString());
            lvi.SubItems.Add(food.Portion.ToString());
            
            lvi.Tag = food;

            lvFoodAndMeal.Items.Add(lvi);
            
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedValue != null)
            {
                //MessageBox.Show(cmbCategory.SelectedValue.ToString());
                try
                {
                    int categoryId = (int)cmbCategory.SelectedValue;

                    cmbFood.DataSource = foodReporsitory.GetByCategoryId(categoryId);
                    cmbFood.DisplayMember = "FoodName";
                    cmbFood.ValueMember = "FoodID";
                }
                catch (Exception)
                {

                }

            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //(MyEnum)Enum.Parse(typeof(MyEnum), myString);

            Meal meal = new Meal();
            meal.UserID = user.UserID;
            meal.MealName = (MealType)mealType;
            meal.MealTime = DateTime.Now;
            int Result = mealRepository.Insert(meal);
            if (Result > 0)
            {
                meal = mealRepository.LastMealByUserId(user.UserID);
                for (int i = 0; i < lvFoodAndMeal.Items.Count; i++)
                {
                    Food food = (Food)lvFoodAndMeal.Items[i].Tag;
                    MealAndFood mealAndFood = new MealAndFood();
                    mealAndFood.MealID = meal.MealID;
                    MessageBox.Show(meal.MealID.ToString());
                    mealAndFood.FoodID = food.FoodID;
                    MessageBox.Show(food.FoodID.ToString());
                    mealRepository.InsertMealAndFood(mealAndFood);
                }
            }

            this.Close();

        }
    }
}
