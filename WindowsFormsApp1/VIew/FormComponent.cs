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
        public Image ImageModuls { get { return ImageModuls; } set { pictureBox1.Image = value; } }
        [Category("Custom Props")]
        public string Level { get { return Level; } set { labelLavel.Text = value; } }
        [Category("Custom Props")]
        public string Name { get { return Name; } set { labelNameComponent.Text = value; } }
        [Category("Custom Props")]
        public string Price { get { return Price; } set { buttonBuy.Text = value; } }
        [Category("Custom Props")]
        public string PriceNextLevel { get { return PriceNextLevel; } set { buttonUpgrate.Text = value; } }

        public FormComponent()
        {
            InitializeComponent();
            
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
