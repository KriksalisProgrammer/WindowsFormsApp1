using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Component
{
    public class Engine: IModuls
    {
        public event EventHandler EnergyConsumption;
        public string Name { get; set; }
        public int Protect { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }
        public bool isBuy { get; set; }
        public int EnergyConsMap { get; private set; }
        public int EnergyConsBattle { get; private set; }
        
        public Engine()
        {
            Name = "Двигатель";
            Price = 200;
            Protect = -10;
            Level = 1;
            isBuy = false;
            EnergyConsMap = 50000000;
            EnergyConsBattle = 1000000;
        }

        public void Upgrate()
        {
            if (Level == 1)
            {
                Price = 300;
                Protect = -8;
                Level = 2;
                EnergyConsMap = 48000000;
                EnergyConsBattle = 800000;
            }
            else if (Level == 2)
            {
                Price = 450;
                Protect = -5;
                Level = 3;
                EnergyConsMap = 45000000;
                EnergyConsBattle = 600000;
            }
        }
        public void EnergyConsumpMap(int energy,int point)
        {
            if(energy>=point*EnergyConsMap)
            {
                energy -= energy * EnergyConsMap;
                EnergyConsumption?.Invoke(this, new EventArgs());
            }
        }
        public void EnergyConsumpFight(int energy)
        {
            if(energy>=EnergyConsBattle)
            {
                energy -= EnergyConsBattle;
                EnergyConsumption?.Invoke(this, new EventArgs());
            }
        }
    }
}
