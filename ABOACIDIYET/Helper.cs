using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABOACIDIYET
{
    public class Helper
    {
        Form form;
        public Helper(Form _form)
        {
            form = _form;

        }
        public void Clean()
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox) item.Text = string.Empty;
                else if (item is CheckBox)
                {
                    CheckBox cBox = (CheckBox)item;
                    cBox.Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    dtp.Value = DateTime.Now;
                }
                else if (item is ListBox)
                {
                    ListBox lbox = (ListBox)item;
                    lbox.SelectedIndex = -1;
                }
                else if (item is ComboBox)
                {
                    ComboBox cBox = (ComboBox)item;
                    cBox.SelectedIndex = -1;
                }
            }
        }
    }
}

