using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : Creature
    {
        public int Gold { get; set; }
        public int ExpPoints { get; set; }
        public int Level {
            get { return ((ExpPoints / 100) + 1); }
        }
        public Location CurrentLocation { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> QuestLog { get; set; }


        public Player(int id, string name, int mhp, int gold, int exp) : base(id, name, mhp)
        {
            this.Gold = gold;
            this.ExpPoints = exp;
            

            Inventory = new List<InventoryItem>();
            QuestLog = new List<PlayerQuest>();
        }

     
        public bool HasRequiredItemsToEnter(Location location)
        {
            if (location.ItemRequiredToEnter == null)
            {
                //no reqired item so true
                return true;
            }

            return Inventory.Exists(ii => ii.Details.ID == location.ItemRequiredToEnter.ID);

            /*
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == location.ItemRequiredToEnter.ID)
                {
                    //reqired item is found so true
                    return true;
                }
            }
            // no reqired item so false
            return false;
            */
        }

        public bool HasThisQuest(Quest quest)
        {

            return QuestLog.Exists(pq => pq.Details.ID  == quest.ID);

            /*
            foreach (PlayerQuest pq in QuestLog)
            {
                if (pq.Details.ID == quest.ID)
                {
                    return true;
                }
            }
            return false;
            */
        }

        public bool CompletedThisQuest(Quest quest)
        {
            foreach(PlayerQuest pq in QuestLog)
            {
                if(pq.Details.ID == quest.ID)
                {
                    return pq.IsCompleted;
                }
            }
            return false;
        }

        public bool HasQuestCompletionItems(Quest quest)
        {
            //check that player has all items required to complete quest
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems)
            {
               // bool playerHasThatItem = false;

                //checking that player has specified item in inventory
                if (!Inventory.Exists(ii => ii.Details.ID == qci.Details.ID && ii.Quantity >= qci.Quantity))
                {
                    return false;
                }
                /*
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        playerHasThatItem = true;

                        //checking that player has enough items to complete quest 
                        if (ii.Quantity < qci.Quantity)
                        {
                            return false;
                        }
                    }
                }
                
            
                //if there is no required items in inwentory setting variable and quitting search
                if (!playerHasThatItem)
                {
                    return false;
                }
                */
            }
            return true;
        }

        public void RemoveCompletitionQuestItems(Quest quest)
        {
            //remove quest items from players inventory
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                InventoryItem item = Inventory.SingleOrDefault(ii => ii.Details.ID == qci.Details.ID);

                if(item != null)
                {
                    item.Quantity -= qci.Quantity;
                }

                /*
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        ii.Quantity -= qci.Quantity;
                        break;
                    }
                }
                */
            }
        }

        public void AddItemToInventory(Item itemToAdd)
        {
            InventoryItem item = Inventory.SingleOrDefault(ii => ii.Details.ID == itemToAdd.ID);

            if (item == null)
            {
                //adding new item to Inventory
                Inventory.Add(new InventoryItem(itemToAdd, 1));
            }
            else
            {
                //incresing quantity of existing item
                item.Quantity++;
            }

            /*
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == itemToAdd.ID)
                {
                    ii.Quantity++;
                    return;
                }
            }

            //if player didn't have this item in inventory add it
            Inventory.Add(new InventoryItem(itemToAdd, 1));
          */
        }

        public void MarkQuestCompleted(Quest quest)
        {
            PlayerQuest playerQuest = QuestLog.SingleOrDefault(pq => pq.Details.ID == quest.ID);

            if(playerQuest != null)
            {
                playerQuest.IsCompleted = true;
            }


            /*
            foreach (PlayerQuest pq in QuestLog)
            {
                if (pq.Details.ID == quest.ID)
                {
                    pq.IsCompleted = true;
                    return;
                }
            }
            */
        }
    }
}
