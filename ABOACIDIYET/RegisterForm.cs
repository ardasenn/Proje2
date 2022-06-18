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
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            int affRow = 0;
            try
            {
                if (txtPassword.Text != txtPasswordAgain.Text)
                {
                    throw new Exception("Şifre tekrarı hatalı");
                    //MessageBox.Show("Şifre tekrarı hatalı");
                    //return;
                }
                User user = new User()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
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
            finally
            {
                MessageBox.Show(affRow > 0 ? "Kullanıcı Eklendi" : "Kullanıcı Eklenemedi");
            }

        }
    }
}