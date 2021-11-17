using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.VIew
{
    public partial class FormComponent : UserControl
    {
        public string Level;
        public string Name;
        public string Price;
        public string PriceNextLevel;

        public FormComponent()
        {
            InitializeComponent();
        }

        public void Init()
        {
            labelLavel.Text = Level;
            labelNameComponent.Text=Name;
            buttonBuy.Text = "Купить" + Price;
            buttonUpgrate.Text = "Улучшить" + Price;
        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpgrate_Click(object sender, EventArgs e)
        {

        }

        private void labelLavel_Click(object sender, EventArgs e)
        {

        }
    }
}
