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
using WindowsFormsApp1.Models.Component;

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

            FormComponent[] formComponents = new FormComponent[10];
            for(var i=0;i<Moduls.listModuls.Count;i++)
            {
                formComponents[i].Name=Moduls.listModuls[i].
            }
        }
    }
}
