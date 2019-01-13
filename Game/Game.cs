using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace Game
{
    public partial class Game : Form
    {
        private Player _player;
        private Monster _currentMonster;

        public Game()
        {
            InitializeComponent();

            _player = new Player(1, "Wiszmir", 100, 20, 0);
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));

            // displaying of _player object fields
            lblName.Text = _player.Name;
            lblHP.Text = _player.CurrentHP.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExp.Text = _player.ExpPoints.ToString();
            lblLvl.Text = _player.Level.ToString();
        }

        private void MoveTo(Location newLocation)
        {
            if (!_player.HasRequiredItemsToEnter(newLocation)) {
                rtbMessage.Text += "You must have a " + newLocation.ItemRequiredToEnter.Name + " to enter this location " + Environment.NewLine;
                return;
            }

            //update current location
            _player.CurrentLocation = newLocation;

            //update visibility of move buttons
            btnNorth.Visible = (newLocation.ToNorth != null);
            btnEast.Visible = (newLocation.ToEast != null);
            btnSouth.Visible = (newLocation.ToSouth != null);
            btnWest.Visible = (newLocation.ToWest != null);

            //displaying location name and description
            rtbLocation.Text = "You are in " + newLocation.Name + "." + Environment.NewLine;
            rtbLocation.Text += newLocation.Description + Environment.NewLine;

            //healing player to max HP and update displayed hp
            _player.CurrentHP = _player.MaxHP;
            lblHP.Text = _player.CurrentHP.ToString();

            //Does location has quest
            if (newLocation.AvailableQuest != null)
            {
                //checking that player alredy has quest or player completed thih quest elier 
                bool playerHasQuest = _player.HasThisQuest(newLocation.AvailableQuest);
                bool playerCompletedQuest = _player.CompletedThisQuest(newLocation.AvailableQuest);

                //if player alredy has quest
                if (playerHasQuest)
                {
                    //if player alredy completed quest
                    if (!playerCompletedQuest)
                    {
                        //check that player has all items required to complete quest
                        bool playerHasAllItemsToCompleteQuest = _player.HasQuestCompletionItems(newLocation.AvailableQuest);
                        rtbMessage.Text += Environment.NewLine;
                        rtbMessage.Text += "playerHasAllItemsToCompleteQuest: " + playerHasAllItemsToCompleteQuest + Environment.NewLine;


                        //if player has all items to complete quest
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            //display message
                            rtbMessage.Text += Environment.NewLine;
                            rtbMessage.Text += "Congratulations!!!" + Environment.NewLine;
                            rtbMessage.Text += "You complete the '" + newLocation.AvailableQuest.Name + "' quest" + Environment.NewLine;

                            //remove quest items from players inventory
                            _player.RemoveCompletitionQuestItems(newLocation.AvailableQuest);

                            //give quest rewards
                            rtbMessage.Text += "You recive:" + Environment.NewLine;
                            rtbMessage.Text += newLocation.AvailableQuest.RewardExperiencePoints.ToString() + " Exp points," + Environment.NewLine;
                            rtbMessage.Text += newLocation.AvailableQuest.RewardGold.ToString() + " gold," + Environment.NewLine;
                            rtbMessage.Text += newLocation.AvailableQuest.RewardItem.Name + Environment.NewLine + Environment.NewLine;

                            _player.ExpPoints += newLocation.AvailableQuest.RewardExperiencePoints;
                            _player.Gold += newLocation.AvailableQuest.RewardGold;
                            lblGold.Text = _player.Gold.ToString();
                            lblExp.Text = _player.ExpPoints.ToString();

                            //add reward item to players inventory
                            _player.AddItemToInventory(newLocation.AvailableQuest.RewardItem);


                            //Marking quest as compleated
                            _player.MarkQuestCompleted(newLocation.AvailableQuest);
                        }
                    }
                }

                //if player doesn't have this quest
                else
                {
                    rtbMessage.Text += "You recive the '" + newLocation.AvailableQuest.Name + "' quest" + Environment.NewLine;
                    rtbMessage.Text += newLocation.AvailableQuest.Description + Environment.NewLine;
                    rtbMessage.Text += "To complete it return with: " + Environment.NewLine;

                    foreach (QuestCompletionItem qce in newLocation.AvailableQuest.QuestCompletionItems)
                    {
                        if (qce.Quantity == 1)
                        {
                            rtbMessage.Text += qce.Quantity.ToString() + " " + qce.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            rtbMessage.Text += qce.Quantity.ToString() + " " + qce.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    rtbMessage.Text += Environment.NewLine;

                    //add quest to players QuestLog
                    _player.QuestLog.Add(new PlayerQuest(newLocation.AvailableQuest));
                }
            }
            //Does location has monster

            if (newLocation.LivingMonster != null)
            {
                rtbMessage.Text += "You see a " + newLocation.LivingMonster.Name + Environment.NewLine + Environment.NewLine;

                //spawn a monster
                Monster standardMonster = World.MonsterByID(newLocation.LivingMonster.ID);

                _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.MaxHP, standardMonster.MaximumDamage, standardMonster.RewardExperiencePoints, standardMonster.RewardGold);

                foreach (LootItem li in standardMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(li);
                }

                //showing controls
                cboWeapons.Visible = true;
                cboPotions.Visible = true;
                btnUseWeapon.Visible = true;
                btnUsePotion.Visible = true;
            }
            else
            {
                _currentMonster = null;

                cboWeapons.Visible = false;
                cboPotions.Visible = false;
                btnUseWeapon.Visible = false;
                btnUsePotion.Visible = false;
            }

            //UI update
            UpdateInventoryListUI();
            UpdateQuestLogUI();
            UpdateWeaponListUI();
            UpdatePotionListUI();
            lblLvl.Text = _player.Level.ToString();

            ScrollToBottomOfMessages();

        }

        //refresh player inventory hud
        private void UpdateInventoryListUI()
        {
            dvgInventory.RowHeadersVisible = false;

            dvgInventory.ColumnCount = 2;
            dvgInventory.Columns[0].Name = "Name";
            dvgInventory.Columns[0].Width = 197;
            dvgInventory.Columns[1].Name = "Quantity";

            dvgInventory.Rows.Clear();

            foreach (InventoryItem ii in _player.Inventory)
            {
                if (ii.Quantity > 0)
                {
                    dvgInventory.Rows.Add(new[] { ii.Details.Name, ii.Quantity.ToString() });
                }
            }
        }

        //refresh players QuestLog
        private void UpdateQuestLogUI()
        {
            dvgQuestLog.RowHeadersVisible = false;

            dvgQuestLog.ColumnCount = 2;
            dvgQuestLog.Columns[0].Name = "Name";
            dvgQuestLog.Columns[0].Width = 197;
            dvgQuestLog.Columns[1].Name = "Done?";

            dvgQuestLog.Rows.Clear();

            foreach (PlayerQuest pq in _player.QuestLog)
            {
                dvgQuestLog.Rows.Add(new[] { pq.Details.Name, pq.IsCompleted.ToString() });
            }
        }

        //refreshing weapon combobox
        private void UpdateWeaponListUI()
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach (InventoryItem ii in _player.Inventory)
            {
                if (ii.Details is Weapon)
                {
                    if (ii.Quantity > 0)
                    {
                        weapons.Add((Weapon)ii.Details);
                    }
                }
            }

            //if player has no weapon hide weapon controls
            if (weapons.Count == 0)
            {
                cboWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                cboWeapons.DataSource = weapons;
                cboWeapons.DisplayMember = "Name";
                cboWeapons.ValueMember = "ID";

                cboWeapons.SelectedIndex = 0;
            }
        }

        //refreshing potion combobox
        private void UpdatePotionListUI()
        {
            List<HealingPotion> healingPotions = new List<HealingPotion>();

            foreach (InventoryItem ii in _player.Inventory)
            {
                if (ii.Details is HealingPotion)
                {
                    if (ii.Quantity > 0)
                    {
                        healingPotions.Add((HealingPotion)ii.Details);
                    }
                }
            }

            //if player has no potions hide weapon controls
            if (healingPotions.Count == 0)
            {
                cboPotions.Visible = false;
                btnUsePotion.Visible = false;
            }
            else
            {
                cboPotions.DataSource = healingPotions;
                cboPotions.DisplayMember = "Name";
                cboPotions.ValueMember = "ID";

                cboWeapons.SelectedIndex = 0;
            }
        }

        //Move buttons operations
        private void btnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.ToNorth);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.ToEast);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.ToSouth);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.ToWest);
        }

        //Use buttons Operations
        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            //Use selected Weapon
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

            //generate current weapopn DMG
            int playerDMG = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

            //apply playerDMG on monsterHP
            _currentMonster.CurrentHP -= playerDMG;

            //display message
            rtbMessage.Text += "You hit the " + _currentMonster.Name + " for " + playerDMG.ToString() + " HP" + Environment.NewLine;
            ScrollToBottomOfMessages();

            //checking that monster is still alive
            if (_currentMonster.CurrentHP <= 0)
            {
                //Monster is dead
                rtbMessage.Text += Environment.NewLine;
                rtbMessage.Text += "You slay a " + _currentMonster.Name + "!" + Environment.NewLine;

                //give player exp and gold
                rtbMessage.Text += "You recive " + _currentMonster.RewardExperiencePoints.ToString() + " EXP and " + _currentMonster.RewardGold.ToString() + " gold" + Environment.NewLine;
                ScrollToBottomOfMessages();
                _player.ExpPoints += _currentMonster.RewardExperiencePoints;
                _player.Gold += _currentMonster.RewardGold;

                lblExp.Text = _player.ExpPoints.ToString();
                lblGold.Text = _player.Gold.ToString();

                List<InventoryItem> loot = new List<InventoryItem>();

                foreach (LootItem li in _currentMonster.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= li.DropPercentage)
                    {
                        loot.Add(new InventoryItem(li.Details, 1));
                    }
                }

                if (loot.Count == 0)
                {
                    foreach (LootItem li in _currentMonster.LootTable)
                    {
                        if (li.IsDefault)
                        {
                            loot.Add(new InventoryItem(li.Details, 1));
                        }
                    }
                }
                foreach (InventoryItem ii in loot)
                {
                    _player.AddItemToInventory(ii.Details);

                    if (ii.Quantity == 1)
                    {
                        rtbMessage.Text += "You loot a " + ii.Quantity.ToString() + " " + ii.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessage.Text += "You loot a " + ii.Quantity.ToString() + " " + ii.Details.NamePlural + Environment.NewLine;
                    }
                }
                ScrollToBottomOfMessages();
            }
            else
            {
                int monsterDMG = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

                rtbMessage.Text += "The " + _currentMonster.Name + " did " + monsterDMG.ToString() + " dmg to you." + Environment.NewLine;

                _player.CurrentHP -= monsterDMG;

                lblHP.Text = _player.CurrentHP.ToString();

                if (_player.CurrentHP <= 0)
                {
                    rtbMessage.Text += "The " + _currentMonster.Name + " killed you." + Environment.NewLine;

                    MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
                }
            }
            rtbMessage.Text += Environment.NewLine;
            UpdateInventoryListUI();
            ScrollToBottomOfMessages();
            lblLvl.Text = _player.Level.ToString();
        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            HealingPotion potion = (HealingPotion) cboPotions.SelectedItem;

            _player.CurrentHP += potion.AmountToHeal;

            if(_player.CurrentHP > _player.MaxHP)
            {
                _player.CurrentHP = _player.MaxHP;
            }

            foreach(InventoryItem ii in _player.Inventory)
            {
                if(ii.Details.ID == potion.ID)
                {
                    ii.Quantity--;
                    break;
                }
            }

            rtbMessage.Text += "You drink a " + potion.Name + " to heal you self." + Environment.NewLine;

            lblHP.Text = _player.CurrentHP.ToString();
            UpdatePotionListUI();
            UpdateInventoryListUI();

            int monsterDMG = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

            rtbMessage.Text += "The " + _currentMonster.Name + " did " + monsterDMG.ToString() + " dmg to you.";

            _player.CurrentHP -= monsterDMG;

            lblHP.Text = _player.CurrentHP.ToString();

            if (_player.CurrentHP <= 0)
            {
                rtbMessage.Text += "The " + _currentMonster.Name + " killed you." + Environment.NewLine;

                MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            }

            lblHP.Text = _player.CurrentHP.ToString();
            rtbMessage.Text += Environment.NewLine;
            ScrollToBottomOfMessages();
        }

        private void ScrollToBottomOfMessages()
        {
            rtbMessage.SelectionStart = rtbMessage.Text.Length;
            rtbMessage.ScrollToCaret();
        }
    } 
}
