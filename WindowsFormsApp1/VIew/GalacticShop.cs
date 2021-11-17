using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.VIew
{
    public partial class GalacticShop : Form
    {
        Ship ship = new Ship();
        public GalacticShop()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            labelMoney.Text = ship.Money.ToString();
        }
        private void populateItems()
        {
            List<FormComponent> listModuls = new List<FormComponent>();
            for(var i=0;i<10;i++)
            {

            }
        }
    }
}
