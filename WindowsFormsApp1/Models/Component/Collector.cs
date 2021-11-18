using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Component
{
    public class Collector : IModuls
    {
        public string Name { get; set; }
        public int Protect { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }
        public bool isBuy { get; set; }
        public Image ImageModuls { get; set; }
        public int Collect { get; private set; }
        public Collector()
        {
            Name = "Колектор";
            Price = 75;
            Protect = 10;
            Level = 1;
            isBuy = false;
            ImageModuls = Properties.Resources.Collector;
            Collect = 20;

        }

        public event EventHandler isBuyEvent;

        public void Upgrate()
        {
            if (Level == 1)
            {
                Price = 131;
                Protect = 12;
                Level = 2;
                Collect = 30;
            }
            else if (Level == 2)
            {
                Price = 230;
                Protect = 15;
                Level = 3;
                Collect = 40;
            }
        }
    }
}
