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
    { User user;
        TargetRepository targetRepository;
        public TargetRegisterForm(User _user) // userıd gelmeli
        {
            InitializeComponent();
            user=_user;
            targetRepository = new TargetRepository();
        }
        private void TargetRegisterForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.MinDate = DateTime.Now;
            dtpEndDate.MinDate = DateTime.Now.AddDays(1);
            cmbTarget.Items.AddRange(Enum.GetNames(typeof(TargetType)));
            cmbTarget.SelectedIndex = 0;
            FillListView();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvNewTarget.SelectedItems.Count <=0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz hedefinizi seçiniz");
                return;
            }
            int targetId = lvNewTarget.SelectedItems[0].Index;
            lvNewTarget.Items[targetId].Remove();
        }
        void InsertToListView()
        {
            Target target = new Target();            
            target.TargetType = (TargetType)Enum.Parse(typeof(TargetType),cmbTarget.SelectedItem.ToString());
            target.StartDate = dtpStartDate.Value;
            target.EndDate = dtpEndDate.Value;
            target.UserID=user.UserID; 

            ListViewItem lvi = new ListViewItem();
            lvi.Text = target.TargetType.ToString();
            lvi.SubItems.Add(target.StartDate.ToString());
            lvi.SubItems.Add(target.EndDate.ToString());
            lvi.Tag = target;
            lvNewTarget.Items.Add(lvi);
        }
        void FillListView()
        {
           lvTargetsScreen.Items.Clear();
           List<Target> targetList=targetRepository.GetByUserId(user.UserID);

            foreach (Target item in targetList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.TargetID.ToString();
                lvi.SubItems.Add(item.TargetType.ToString());
                lvi.SubItems.Add(item.StartDate.ToString());
                lvi.SubItems.Add(item.EndDate.ToString());
                lvi.Tag = item;
                lvTargetsScreen.Items.Add(lvi);
  
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbTarget.SelectedIndex != -1 )
            {
                InsertToListView();
            }
            else MessageBox.Show("Lütfen hedef türü ve aralığı seçiniz..");
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            List<Target> targetList = targetRepository.GetByUserId(user.UserID);
            
            for (int i = 0; i < lvNewTarget.Items.Count; i++)
            {
                Target target = (Target)lvNewTarget.Items[i].Tag;
                foreach (Target mevcutTargets in targetList)
                {
                    if (target.StartDate >= mevcutTargets.StartDate && target.StartDate <= mevcutTargets.EndDate)
                    {
                        MessageBox.Show("Eklemeye çalıştığınız hedefinizin başlangıç tarihi mevcut hedeflerinizle çakışmaktadır.");
                        return;
                    }
                    else if (target.EndDate >= mevcutTargets.StartDate && target.EndDate <= mevcutTargets.EndDate)
                    {
                        MessageBox.Show("Eklemeye çalıştığınız hedefinizin bitiş tarihi mevcut hedeflerinizle çakışmaktadır.");
                        return;
                    }
                    else if (target.StartDate <= mevcutTargets.StartDate && target.EndDate >= mevcutTargets.EndDate)
                    {
                        MessageBox.Show("Eklemeye çalıştığınız hedef mevcut hedeflerinizi kapsamamalıdır");
                        return;
                    }
                }

                if (targetRepository.Insert(target) >= 1) MessageBox.Show("Kayıt işlemi başarılı");
                   lvNewTarget.Items.RemoveAt(i);
                FillListView();
            }
        }
    }
}
