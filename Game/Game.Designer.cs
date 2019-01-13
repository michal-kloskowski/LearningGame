namespace Game
{
    partial class Game
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.HP = new System.Windows.Forms.Label();
            this.Gold = new System.Windows.Forms.Label();
            this.Exp = new System.Windows.Forms.Label();
            this.Lvl = new System.Windows.Forms.Label();
            this.lblLvl = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.Label();
            this.SelectAction = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.dvgInventory = new System.Windows.Forms.DataGridView();
            this.dvgQuestLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgQuestLog)).BeginInit();
            this.SuspendLayout();
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.Location = new System.Drawing.Point(18, 46);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(25, 13);
            this.HP.TabIndex = 0;
            this.HP.Text = "HP:";
            // 
            // Gold
            // 
            this.Gold.AutoSize = true;
            this.Gold.Location = new System.Drawing.Point(18, 74);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(32, 13);
            this.Gold.TabIndex = 1;
            this.Gold.Text = "Gold:";
            // 
            // Exp
            // 
            this.Exp.AutoSize = true;
            this.Exp.Location = new System.Drawing.Point(18, 100);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(28, 13);
            this.Exp.TabIndex = 2;
            this.Exp.Text = "Exp:";
            // 
            // Lvl
            // 
            this.Lvl.AutoSize = true;
            this.Lvl.Location = new System.Drawing.Point(18, 126);
            this.Lvl.Name = "Lvl";
            this.Lvl.Size = new System.Drawing.Size(24, 13);
            this.Lvl.TabIndex = 3;
            this.Lvl.Text = "Lvl:";
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Location = new System.Drawing.Point(62, 126);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(0, 13);
            this.lblLvl.TabIndex = 7;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(62, 100);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(0, 13);
            this.lblExp.TabIndex = 6;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(62, 74);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 13);
            this.lblGold.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(62, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 4;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(62, 46);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(0, 13);
            this.lblHP.TabIndex = 8;
            // 
            // PName
            // 
            this.PName.AutoSize = true;
            this.PName.Location = new System.Drawing.Point(18, 20);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(38, 13);
            this.PName.TabIndex = 9;
            this.PName.Text = "Name:";
            // 
            // SelectAction
            // 
            this.SelectAction.AutoSize = true;
            this.SelectAction.Location = new System.Drawing.Point(617, 531);
            this.SelectAction.Name = "SelectAction";
            this.SelectAction.Size = new System.Drawing.Size(70, 13);
            this.SelectAction.TabIndex = 10;
            this.SelectAction.Text = "Select Action";
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(369, 559);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboWeapons.TabIndex = 11;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(369, 593);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 21);
            this.cboPotions.TabIndex = 12;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(620, 559);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 13;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(620, 593);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 14;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(493, 433);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 15;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(535, 462);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 16;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(493, 491);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 17;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(454, 462);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 18;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);

            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(347, 19);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(360, 105);
            this.rtbLocation.TabIndex = 19;
            this.rtbLocation.Text = "";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(347, 130);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(360, 286);
            this.rtbMessage.TabIndex = 20;
            this.rtbMessage.Text = "";
            // 
            // dvgInventory
            // 
            this.dvgInventory.AllowUserToAddRows = false;
            this.dvgInventory.AllowUserToDeleteRows = false;
            this.dvgInventory.AllowUserToResizeRows = false;
            this.dvgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgInventory.Enabled = false;
            this.dvgInventory.Location = new System.Drawing.Point(21, 147);
            this.dvgInventory.MultiSelect = false;
            this.dvgInventory.Name = "dvgInventory";
            this.dvgInventory.ReadOnly = true;
            this.dvgInventory.RowHeadersVisible = false;
            this.dvgInventory.Size = new System.Drawing.Size(312, 309);
            this.dvgInventory.TabIndex = 21;
            // 
            // dvgQuestLog
            // 
            this.dvgQuestLog.AllowUserToAddRows = false;
            this.dvgQuestLog.AllowUserToDeleteRows = false;
            this.dvgQuestLog.AllowUserToResizeRows = false;
            this.dvgQuestLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgQuestLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgQuestLog.Enabled = false;
            this.dvgQuestLog.Location = new System.Drawing.Point(21, 462);
            this.dvgQuestLog.MultiSelect = false;
            this.dvgQuestLog.Name = "dvgQuestLog";
            this.dvgQuestLog.ReadOnly = true;
            this.dvgQuestLog.RowHeadersVisible = false;
            this.dvgQuestLog.Size = new System.Drawing.Size(312, 179);
            this.dvgQuestLog.TabIndex = 22;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.dvgQuestLog);
            this.Controls.Add(this.dvgInventory);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.SelectAction);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblLvl);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.Lvl);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.HP);
            this.Name = "Game";
            this.Text = "Game";
 //           this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgQuestLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.Label Gold;
        private System.Windows.Forms.Label Exp;
        private System.Windows.Forms.Label Lvl;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.Label SelectAction;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.DataGridView dvgInventory;
        private System.Windows.Forms.DataGridView dvgQuestLog;
    }
}

