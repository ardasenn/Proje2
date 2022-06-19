using ABOACIDIYET.Entities;
using ABOACIDIYET.Enums;
using Access;
using Access.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABOACIDIYET
{
    public partial class UserScreen : Form
    {
        User user;
        AboDbContext db;
        ActivityRepository activityRepository;
        MealRepository mealRepository;
        FoodReporsitory foodRepository;
        List<Activity> activities;
        List<Target> targets;
        List<UserAndActivity> usersAndActivities;
        List<MealAndFood> mealsAndFoods;
        List<Meal> meals;
        List<Food> foods;
        TargetRepository targetRepository;

        KiloRepository kilo;
        public UserScreen(User user)
        {
            InitializeComponent();
            this.user = user;
            activityRepository = new ActivityRepository();
            mealRepository = new MealRepository();
            foodRepository = new FoodReporsitory();
            targetRepository = new TargetRepository();
            activities = activityRepository.GetActivity();
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            FillProgress();
            cbMeal.Items.AddRange(Enum.GetNames(typeof(MealType)));
            cbMeal.SelectedIndex = 0;
            lblDataTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy");
            FillComboBox();
            FillListBox();
            FillFlowLayout();
            cbActivityTime.SelectedIndex = 0;
        }

        private void FillProgress()
        {
            Target target = targetRepository.GetTarget(user.UserID,DateTime.Now.Date);
            if (target!=null)
            {
                progressBar1.Maximum = Convert.ToInt32((target.EndDate - target.StartDate).TotalDays);
                progressBar1.Value = Math.Abs(Convert.ToInt32((DateTime.Now.Date - target.StartDate).TotalDays));
                lblTargetEndDate.Text = target.EndDate.ToString("dd/MM/yyyy");
                lblTargetStartDate.Text = target.StartDate.ToString("dd/MM/yyyy");
            }         
        }

        void FillComboBox()
        {
            cbActivity.DataSource = activities;
            cbActivity.DisplayMember = "ActivityName";
            cbActivity.ValueMember = "BurnedCalorieInActivity";
            for (int i = 30; i < 210; i += 30)
            {
                cbActivityTime.Items.Add(i);
            }
            //Raporlar kısmı var beklettim
        }
        void FillListBox()
        {
            listBox1.Items.Clear();
            usersAndActivities = activityRepository.GetByUserId(user.UserID, DateTime.Today);
            if (usersAndActivities != null)
            {
                for (int i = 0; i < usersAndActivities.Count; i++)
                {

                    listBox1.Items.Add(activities[usersAndActivities[i].ActivityID - 1].ActivityName);
                }
            }
        }
        void FillFlowLayout()
        {
            meals = mealRepository.GetByUserIdThatDay(user.UserID, DateTime.Now.Date);

            flowLayoutPanel1.SuspendLayout();
            foreach (Meal ogun in meals)
            {
                mealsAndFoods = mealRepository.GetMealAndFoodByMealId(ogun.MealID);
                ListView listView = new ListView();
                listView.View = View.Details;
                listView.Columns.Add("Yemek", 60, HorizontalAlignment.Left);
                listView.Columns.Add("Porsiyon", 40, HorizontalAlignment.Left);
                listView.Columns.Add("Porsiyon Tipi", 20, HorizontalAlignment.Left);
                listView.Columns.Add("Kalorisi", 40, HorizontalAlignment.Left);
                listView.Columns.Add("Kategori", 120, HorizontalAlignment.Left);
                listView.Size = new Size(320, 100);
                foreach (MealAndFood ogunlerVeYiyecekler in mealsAndFoods)
                {

                    Food food = foodRepository.GetByFoodId(ogunlerVeYiyecekler.FoodID);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = food.FoodName;
                    lvi.SubItems.Add(food.Portion.ToString());
                    lvi.SubItems.Add(food.PortionType.ToString());
                    lvi.SubItems.Add(food.FoodCalorie.ToString());
                    lvi.SubItems.Add(food.Category.CategoryName);
                    listView.Items.Add(lvi);
                }
                flowLayoutPanel1.Controls.Add(listView);
            }
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.PerformLayout();
        }
        void FillTargetsLabel()
        {
            //güncel hedef çekilmeli
            targets = (List<Target>)user.Targets;
            foreach (var item in targets)
            {
                lblTargetStartDate.Text += $" :\n {item.StartDate.ToString()}";
                lblTargetEndDate.Text += $" :\n {item.EndDate.ToString()}";
            }
        }
        private void btnKiloSave_Click(object sender, EventArgs e)
        {
            Kilo kg = new Kilo();
            kg.Weight = Convert.ToInt32(txtKilo.Text);
            kg.CreationDate = DateTime.Now;
            kg.UserID = user.UserID;
            kilo = new KiloRepository();
            if (kilo.Insert(kg) >= 1) MessageBox.Show("Kayıt başarıyla yapılmıştır");
        }
        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            if (cbActivity.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir alan seçiniz");
            }
            else
            {
                activityRepository.InsertUserActivity(user, activities[cbActivity.SelectedIndex], Convert.ToInt32(cbActivityTime.SelectedItem));
                FillListBox();
            }
        }
        private void btnMealSelect_Click(object sender, EventArgs e)
        {
            if (cbMeal.SelectedItem != null)
            {
                MealRegisterForm mealRegisterForm = new MealRegisterForm(user, Convert.ToInt32(cbMeal.SelectedIndex) + 1);
                mealRegisterForm.ShowDialog();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TargetRegisterForm form = new TargetRegisterForm(user);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
