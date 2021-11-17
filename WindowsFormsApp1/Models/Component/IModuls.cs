using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Component
{
    internal interface IModuls
    {
        string Name { get; set; }
        int Protect { get; set; }
        int Price { get; set; }
        int Level { get; set; }
        bool isBuy { get; set; }
       

    }
}
