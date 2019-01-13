using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : Creature
    {
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(int id, string name, int mhp, int mDmg, int rewExp, int rewGold) : base(id, name, mhp)
        {
            this.MaximumDamage = mDmg;
            this.RewardExperiencePoints = rewExp;
            this.RewardGold = rewGold;
            LootTable = new List<LootItem>();
        }
    }
}
