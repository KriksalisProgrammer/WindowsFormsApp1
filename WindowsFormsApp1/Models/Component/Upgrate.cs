using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Component
{
    internal class Component
    {
        event EventHandler ComponentBuy;
        event EventHandler ComponentUpgrate;
        public void BuyComponent(IModuls moduls,int money)
        {
            if(money>=moduls.Price)
            {
                money =- moduls.Price;
                ComponentBuy?.Invoke(this, new EventArgs());
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
