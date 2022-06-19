using ABOACIDIYET.Entities;
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
        List<UserAndActivity> usersActivities;
        KiloRepository kilo;
        public UserScreen(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            FillComboBox();
            cbActivity.SelectedIndex = 0;
            lblDataTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        void FillComboBox()
        {
            activities=activityRepository.GetActivity();
            cbActivity.DataSource = activities;
            cbActivity.DisplayMember = "ActivityName";
            for (int i = 30; i < 210; i+=30)
            {
                cbActivityTime.Items.Add(i);
            }
            //Raporlar kısmı var beklettim
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
            //else if (cbActivity.SelectedIndex == 0)
            //{

            //}

            
        }
    }
}
