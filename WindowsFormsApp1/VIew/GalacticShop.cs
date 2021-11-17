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
            FormComponent[] formComponents = new FormComponent[10];
            for(var i=0;i<formComponents.Length;i++)
            {
                formComponents[i] = new FormComponent();
                formComponents[i].Name = "Имя";
                formComponents[i].Level = "1";
                formComponents[i].Price = "1000";
                formComponents[i].PriceNextLevel = "2000";
                flowLayoutPanel1.Controls.Add(formComponents[i]);
            }
        }
    }
}
