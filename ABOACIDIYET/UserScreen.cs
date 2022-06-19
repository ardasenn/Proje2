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
        List<Activity> activities;
        List<Target> targets;
        List<UserAndActivity> usersAndActivities;
        KiloRepository kilo;
        public UserScreen(User user)
        {
            InitializeComponent();
            this.user = user;
            activityRepository = new ActivityRepository();
            activities = activityRepository.GetActivity();
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {

            cbMeal.Items.AddRange(Enum.GetNames(typeof(MealType)));
            cbMeal.SelectedIndex = 0;

            lblDataTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            FillListBox();
            FillComboBox();
        
            cbActivityTime.SelectedIndex = 0;
        }



        void FillComboBox()
        {

            cbActivity.DataSource = activities;
            cbActivity.DisplayMember = "ActivityName";
            cbActivity.ValueMember = "BurnedCalorieInActivity";
            for (int i = 30; i < 210; i+=30)
            {
                cbActivityTime.Items.Add(i);
            }
            //Raporlar kısmı var beklettim
        }

        void FillListBox()
        {
            listBox1.Items.Clear();
            usersAndActivities = activityRepository.GetByUserId(user.UserID,DateTime.Today);
            if (usersAndActivities != null)
            {
                for (int i = 0; i < usersAndActivities.Count; i++)
                {
                    
                    listBox1.Items.Add(activities[usersAndActivities[i].ActivityID-1].ActivityName);
                }
            }
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
            kg.UserID=user.UserID;          
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

                MealRegisterForm mealRegisterForm = new MealRegisterForm(user, Convert.ToInt32(cbMeal.SelectedIndex)+1);
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
