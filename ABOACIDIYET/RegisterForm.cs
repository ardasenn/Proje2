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
    public partial class RegisterForm : Form
    {
        UserRepository userRepository;
        public RegisterForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            dtpBirthDate.MaxDate = DateTime.Now;
            rdbMale.Checked = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            int affRow = 0;
            try
            {
                if (!txtHeight.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtHeight.Text)) throw new Exception("Hatalı bir boy değeri girdiniz.");                
                if (txtPassword.Text != txtPasswordAgain.Text)
                {
                    throw new Exception("Şifreniz uyuşmamakta. Lütfen tekrar deneyiniz");                   
                }
                User user = new User()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Height = Convert.ToInt32(txtHeight.Text),
                    BirthDate = dtpBirthDate.Value,
                    Gender = rdbMale.Checked ? Gender.Erkek : Gender.Kadin,
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    Password = txtPassword.Text,

                };
                affRow = userRepository.Insert(user);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(affRow > 0) MessageBox.Show("Kullanıcı Eklendi");
        }
    }
}