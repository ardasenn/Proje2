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
    public partial class AdminScreen : Form
    {
        MealRepository mealRepository;
        KiloRepository kiloRepository;
        FoodReporsitory foodRepository;
        public AdminScreen()
        {
            InitializeComponent();
            mealRepository = new MealRepository();
            kiloRepository = new KiloRepository();
            foodRepository = new FoodReporsitory();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {

            chart1.DataSource = foodRepository.FoodsAndCalories();
            chart1.Series["Besinler"].XValueMember = "FoodID";
            chart1.Series["Besinler"].YValueMembers = "FoodCalorie";
            chart1.Titles.Add("Besinler ve Kalorileri");


        }
    }
}
