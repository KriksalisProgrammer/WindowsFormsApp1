using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Models.Component
{
    internal class BuyControler
    {
        event EventHandler ComponentUpgrate;
        public event EventHandler ComponentBuy;
        public void BuyComponent(IModuls moduls)
        {
            if(Resourse.Money>=moduls.Price&&!moduls.isBuy)
            {
                Resourse.Money =- moduls.Price;
                moduls.isBuy = true;
                ComponentBuy?.Invoke(this,new EventArgs());
                MessageBox.Show("Куплено");
            }          
        }



        public void UpgrateComponent(IModuls moduls,int money)
        {
            if(moduls.isBuy&&money>=moduls.Price)
            {
                ComponentUpgrate?.Invoke(this, new EventArgs());
            }
        }
    }
}
