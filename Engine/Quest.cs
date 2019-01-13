using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }
        public Item RewardItem { get; set; }

        public Quest(int id, string name, string desc, int rewExp, int rewGold, Item rewItem = null)
        {
            this.ID = id;
            this.Name = name;
            this.Description = desc;
            this.RewardExperiencePoints = rewExp;
            this.RewardGold = rewGold;
            this.RewardItem = rewItem;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
