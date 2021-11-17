using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models.Component
{
    static class Moduls
    {
        static Ship ship = new Ship();
        public static ArrayList listModuls = new ArrayList();
        static Moduls()
        {
            listModuls.Add(ship.comand);
            listModuls.Add(ship.corpus);
            listModuls.Add(ship.engine);
        }
    }
}
