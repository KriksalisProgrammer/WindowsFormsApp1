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
            populateItems();
        }
        private void Init()
        {
            labelMoney.Text = ship.Money.ToString();
        }
        private void populateItems()
        {
            FormComponent[] formComponents = new FormComponent[3];
            for(var i=0;i<formComponents.Length;i++)
            {
                formComponents[i] = new FormComponent();
                formComponents[i].Name = Moduls.moduls[i].Name;
                formComponents[i].Level =Moduls.moduls[i].Level.ToString();
                formComponents[i].Price = Moduls.moduls[i].Price.ToString();
                formComponents[i].PriceNextLevel = "2000";
                if(flowLayoutPanel1.Controls.Count<0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                flowLayoutPanel1.Controls.Add(formComponents[i]);
            }
        }
    }
}
