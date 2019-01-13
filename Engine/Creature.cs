using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Creature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }

        public Creature(int id, string name, int mhp)
        {
            this.ID = id;
            this.Name = name;
            this.MaxHP = mhp;
            this.CurrentHP = mhp;
        }
    }
}
