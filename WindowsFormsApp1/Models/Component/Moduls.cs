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
        private static Ship _ship = new Ship();
        public static List<IModuls> moduls = new List<IModuls>();
        
        static Moduls()
        {
            moduls.Add(_ship.comand);
            moduls.Add(_ship.corpus);
            moduls.Add(_ship.engine);
            moduls.Add(_ship.aKB);
            moduls.Add(_ship.cannon);
            moduls.Add(_ship.collector);
            moduls.Add(_ship.store);
        }
    }
}
