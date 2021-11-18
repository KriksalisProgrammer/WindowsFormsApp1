using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Component;

namespace WindowsFormsApp1.Models
{
    public class Ship
    {
        
        public int Strength { get; private set; }
        public int Damage { get; private set; }
        

        public ComandCenter comand = new ComandCenter();
        public Corpus corpus = new Corpus();
        public Engine engine = new Engine();
        public AKB aKB = new AKB();
        public Cannon cannon = new Cannon();
        public Collector collector = new Collector();
        public Store store = new Store();

        public Ship()
        {
            
        }
    }
}
