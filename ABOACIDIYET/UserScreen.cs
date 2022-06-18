using ABOACIDIYET.Entities;
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
    public partial class UserScreen : Form
    {
        User user;
        public UserScreen(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {
            
        }


    }
}
