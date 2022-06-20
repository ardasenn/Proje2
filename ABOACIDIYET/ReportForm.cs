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
    public partial class ReportForm : Form
    {
        KiloRepository kiloRepository;
        int userID;
        public ReportForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            kiloRepository = new KiloRepository();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            List<Kilo> kilos = kiloRepository.GetByUserId(userID);
            chart1.DataSource = kilos;
            chart1.Series["Series1"].XValueMember = "CreationDate";
            chart1.Series["Series1"].YValueMembers = "Weight";
        }
    }
}
