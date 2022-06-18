using ABOACIDIYET.Entities;
using ABOACIDIYET.Enums;
using Access;
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

    public partial class LoginScreen : Form
    {
        AboDbContext db;
        UserRepository userRepository;
        public LoginScreen()
        {
            InitializeComponent();
            db = new AboDbContext();

        }
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            db.Database.Initialize(true);
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string email = txtUserName.Text;
            string password = txtUserPassword.Text;

            try
            {
                userRepository = new UserRepository();
                User user = userRepository.CheckLogin(email, password);
                if (user != null)
                {
                    switch (user.UserType)
                    {
                        case UserType.Admin:
                            AdminScreen adminScreen = new AdminScreen();
                            this.Hide();
                            adminScreen.ShowDialog();
                            this.Show();
                            break;
                        case UserType.User:
                            UserScreen userScreen = new UserScreen(user);
                            this.Hide();
                            userScreen.ShowDialog();
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen doğru bilgileri giriniz. Eğer üye değilseniz kayıt olunuz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}