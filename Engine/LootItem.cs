using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPercentage { get; set; }
        public bool IsDefault { get; set; }

        public LootItem(Item details, int dropPerc, bool isDefault)
        {
            this.Details = details;
            this.DropPercentage = dropPerc;
            this.IsDefault = isDefault;
        }
    }
}
