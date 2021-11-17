﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Component
{
    public class Corpus : IModuls
    {
        public string Name { get; set; }
        public int Protect { get; set; }
        public int Price { get; set; }
        public int Level { get; set; }
        public bool isBuy { get; set; }
        public Corpus()
        {
            Name = "Корпус";
            Price = 100;
            Protect = 100;
            Level = 1;
            isBuy = false;
        }
        public void Upgrate()
        {
            if (Level == 1)
            {
                Price = 250;
                Protect = 200;
                Level = 2;
              
            }
            else if (Level == 2)
            {
                Price = 625;
                Protect = 300;
                Level = 3;
            }
        }
    }
}
