using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models.Component;

namespace WindowsFormsApp1.VIew
{
    public partial class FormComponent : UserControl
    {
        
        private BuyControler controler = new BuyControler();


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
           IModuls moduls= FindObject();
           controler.BuyComponent(moduls);
            controler.ComponentBuy += Controler_ComponentBuy;
        }

        private void Controler_ComponentBuy(object sender, EventArgs e)
        {
            GalacticShop galactic = new GalacticShop();
            galactic.Init(); 
        }

        private void buttonUpgrate_Click(object sender, EventArgs e)
        {

        }

        private void labelLavel_Click(object sender, EventArgs e)
        {

        }
       
        private IModuls FindObject()
        {
            IModuls moduls = Moduls.moduls.Find(x => x.Name == labelNameComponent.Text);
            return moduls;
        }
    }
}
