using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Location(int id, string name, string desc, Item reqItem = null, Quest avaQuest = null, Monster livMonster = null) {
            this.ID = id;
            this.Name = name;
            this.Description = desc;
        }

        public Item ItemRequiredToEnter { get; set; }
        public Quest AvailableQuest { get; set; }
        public Monster LivingMonster { get; set; }
        public Location ToNorth { get; set; }
        public Location ToEast { get; set; }
        public Location ToSouth { get; set; }
        public Location ToWest { get; set; }

    }
}
