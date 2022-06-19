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
    public partial class TargetRegisterForm : Form
    {
        TargetRepository targetRepository;
        public TargetRegisterForm() // userıd gelmeli
        {
            InitializeComponent();
            targetRepository = new TargetRepository();  
        }
        private void TargetRegisterForm_Load(object sender, EventArgs e)
        {
            cmbTarget.Items.Clear();
            cmbTarget.Items.AddRange(Enum.GetNames(typeof(TargetType)));

            //cmbTarget.DataSource = targetRepository.GetTargets();
            //cmbTarget.DisplayMember = "TargetType"; //??
            //cmbTarget.ValueMember = "TargetID";

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvTargets.SelectedItems.Count != -1)
            {
                MessageBox.Show("Lütfen silmek istediğiniz hedefinizi seçiniz");
                return;
            }
            int targetId = Convert.ToInt32(cmbTarget.SelectedValue);
            int affRow = targetRepository.Delete(targetId);
            MessageBox.Show(affRow > 0 ? " Silindi" : "Hata Oluştu");

            ListViewByFoodId();
        }
        void ListViewByFoodId()
        {
            int targetId = Convert.ToInt32(cmbTarget.SelectedValue);
            List<Target> targets = targetRepository.GetByTargets(targetId);

            lvTargets.Items.Clear();
            foreach (var item in targets)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.TargetType.ToString();
                lvi.SubItems.Add(item.StartDate.ToString());
                lvi.SubItems.Add(item.EndDate.ToString());
                

                lvTargets.Items.Add(lvi);
            }
        }

    }
    
}
