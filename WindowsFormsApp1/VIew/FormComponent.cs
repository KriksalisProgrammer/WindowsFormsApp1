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
        [Category("Custom Props")]
        public string Level { get; set; }
        [Category("Custom Props")]
        public string Name { get; set; }
        [Category("Custom Props")]
        public string Price { get; set; }
        [Category("Custom Props")]
        public string PriceNextLevel { get; set; }

        public FormComponent()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            labelLavel.Text = Level;
            labelNameComponent.Text=Name;
            buttonBuy.Text = "Купить" + Price;
            buttonUpgrate.Text = "Улучшить" + PriceNextLevel;
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
