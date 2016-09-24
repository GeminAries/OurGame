namespace Game
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_inventoryList = new System.Windows.Forms.ListBox();
            this.label_inventory = new System.Windows.Forms.Label();
            this.textBox_inventoryDescription = new System.Windows.Forms.TextBox();
            this.button_examineItem = new System.Windows.Forms.Button();
            this.button_useItem = new System.Windows.Forms.Button();
            this.picture_manSilhouette = new System.Windows.Forms.PictureBox();
            this.picture_mainFrame = new System.Windows.Forms.PictureBox();
            this.button_openEquipmentManager = new System.Windows.Forms.Button();
            this.button_moveNorth = new System.Windows.Forms.Button();
            this.button_moveEast = new System.Windows.Forms.Button();
            this.button_moveSouth = new System.Windows.Forms.Button();
            this.button_moveWest = new System.Windows.Forms.Button();
            this.picture_map = new System.Windows.Forms.PictureBox();
            this.userEntryPanel = new System.Windows.Forms.TextBox();
            this.button_submitCommand = new System.Windows.Forms.Button();
            this.label_whatDoYouWantToDo = new System.Windows.Forms.Label();
            this.listBox_enemiesNearby = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_fight = new System.Windows.Forms.Button();
            this.button_flee = new System.Windows.Forms.Button();
            this.button_interact = new System.Windows.Forms.Button();
            this.button_rest = new System.Windows.Forms.Button();
            this.centralInfoHub = new System.Windows.Forms.TextBox();
            this.label_hitPoints = new System.Windows.Forms.Label();
            this.label_hpValue = new System.Windows.Forms.Label();
            this.label_abilityPoints = new System.Windows.Forms.Label();
            this.label_apValue = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_buffDebuffIconsGoHere = new System.Windows.Forms.Label();
            this.label_mapGoesHere = new System.Windows.Forms.Label();
            this.label_entitiesOfInterest = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CharacterNameLabel = new System.Windows.Forms.Label();
            this.textbox_CharName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_manSilhouette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_mainFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_inventoryList
            // 
            this.listBox_inventoryList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox_inventoryList.FormattingEnabled = true;
            this.listBox_inventoryList.Items.AddRange(new object[] {
            "Broken Watch",
            "Whip",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item",
            "-item"});
            this.listBox_inventoryList.Location = new System.Drawing.Point(8, 41);
            this.listBox_inventoryList.Name = "listBox_inventoryList";
            this.listBox_inventoryList.Size = new System.Drawing.Size(300, 186);
            this.listBox_inventoryList.TabIndex = 0;
            // 
            // label_inventory
            // 
            this.label_inventory.AutoSize = true;
            this.label_inventory.BackColor = System.Drawing.SystemColors.Control;
            this.label_inventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inventory.Location = new System.Drawing.Point(4, 16);
            this.label_inventory.Name = "label_inventory";
            this.label_inventory.Size = new System.Drawing.Size(88, 20);
            this.label_inventory.TabIndex = 2;
            this.label_inventory.Text = "Inventory:";
            // 
            // textBox_inventoryDescription
            // 
            this.textBox_inventoryDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_inventoryDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_inventoryDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_inventoryDescription.Location = new System.Drawing.Point(8, 233);
            this.textBox_inventoryDescription.Multiline = true;
            this.textBox_inventoryDescription.Name = "textBox_inventoryDescription";
            this.textBox_inventoryDescription.ReadOnly = true;
            this.textBox_inventoryDescription.Size = new System.Drawing.Size(300, 169);
            this.textBox_inventoryDescription.TabIndex = 3;
            this.textBox_inventoryDescription.Text = "This box will contain information about the item selected in inventory.";
            // 
            // button_examineItem
            // 
            this.button_examineItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_examineItem.Location = new System.Drawing.Point(233, 11);
            this.button_examineItem.Name = "button_examineItem";
            this.button_examineItem.Size = new System.Drawing.Size(75, 23);
            this.button_examineItem.TabIndex = 4;
            this.button_examineItem.Text = "Examine";
            this.button_examineItem.UseVisualStyleBackColor = true;
            this.button_examineItem.Click += new System.EventHandler(this.clicked_examineItem);
            // 
            // button_useItem
            // 
            this.button_useItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_useItem.Location = new System.Drawing.Point(152, 12);
            this.button_useItem.Name = "button_useItem";
            this.button_useItem.Size = new System.Drawing.Size(75, 23);
            this.button_useItem.TabIndex = 5;
            this.button_useItem.Text = "Use";
            this.button_useItem.UseVisualStyleBackColor = true;
            this.button_useItem.Click += new System.EventHandler(this.clicked_useItem);
            // 
            // picture_manSilhouette
            // 
            this.picture_manSilhouette.BackColor = System.Drawing.SystemColors.Window;
            this.picture_manSilhouette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_manSilhouette.Cursor = System.Windows.Forms.Cursors.Default;
            this.picture_manSilhouette.Image = global::Game.Properties.Resources.man300x300;
            this.picture_manSilhouette.Location = new System.Drawing.Point(8, 408);
            this.picture_manSilhouette.Name = "picture_manSilhouette";
            this.picture_manSilhouette.Size = new System.Drawing.Size(300, 312);
            this.picture_manSilhouette.TabIndex = 6;
            this.picture_manSilhouette.TabStop = false;
            // 
            // picture_mainFrame
            // 
            this.picture_mainFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_mainFrame.Cursor = System.Windows.Forms.Cursors.Default;
            this.picture_mainFrame.Location = new System.Drawing.Point(320, 38);
            this.picture_mainFrame.Name = "picture_mainFrame";
            this.picture_mainFrame.Size = new System.Drawing.Size(900, 571);
            this.picture_mainFrame.TabIndex = 1;
            this.picture_mainFrame.TabStop = false;
            // 
            // button_openEquipmentManager
            // 
            this.button_openEquipmentManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_openEquipmentManager.Location = new System.Drawing.Point(12, 726);
            this.button_openEquipmentManager.Name = "button_openEquipmentManager";
            this.button_openEquipmentManager.Size = new System.Drawing.Size(296, 23);
            this.button_openEquipmentManager.TabIndex = 7;
            this.button_openEquipmentManager.Text = "Manage Equipment";
            this.button_openEquipmentManager.UseVisualStyleBackColor = true;
            this.button_openEquipmentManager.Click += new System.EventHandler(this.openEquipmentManager);
            // 
            // button_moveNorth
            // 
            this.button_moveNorth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_moveNorth.Location = new System.Drawing.Point(1295, 468);
            this.button_moveNorth.Name = "button_moveNorth";
            this.button_moveNorth.Size = new System.Drawing.Size(75, 23);
            this.button_moveNorth.TabIndex = 8;
            this.button_moveNorth.Text = "North";
            this.button_moveNorth.UseVisualStyleBackColor = true;
            this.button_moveNorth.Click += new System.EventHandler(this.clicked_moveNorth);
            // 
            // button_moveEast
            // 
            this.button_moveEast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_moveEast.Location = new System.Drawing.Point(1379, 523);
            this.button_moveEast.Name = "button_moveEast";
            this.button_moveEast.Size = new System.Drawing.Size(75, 23);
            this.button_moveEast.TabIndex = 9;
            this.button_moveEast.Text = "East";
            this.button_moveEast.UseVisualStyleBackColor = true;
            this.button_moveEast.Click += new System.EventHandler(this.clicked_moveEast);
            // 
            // button_moveSouth
            // 
            this.button_moveSouth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_moveSouth.Location = new System.Drawing.Point(1295, 589);
            this.button_moveSouth.Name = "button_moveSouth";
            this.button_moveSouth.Size = new System.Drawing.Size(75, 23);
            this.button_moveSouth.TabIndex = 10;
            this.button_moveSouth.Text = "South";
            this.button_moveSouth.UseVisualStyleBackColor = true;
            this.button_moveSouth.Click += new System.EventHandler(this.clicked_moveSouth);
            // 
            // button_moveWest
            // 
            this.button_moveWest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_moveWest.Location = new System.Drawing.Point(1224, 523);
            this.button_moveWest.Name = "button_moveWest";
            this.button_moveWest.Size = new System.Drawing.Size(75, 23);
            this.button_moveWest.TabIndex = 11;
            this.button_moveWest.Text = "West";
            this.button_moveWest.UseVisualStyleBackColor = true;
            this.button_moveWest.Click += new System.EventHandler(this.clicked_moveWest);
            // 
            // picture_map
            // 
            this.picture_map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_map.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_map.Location = new System.Drawing.Point(1226, 12);
            this.picture_map.Name = "picture_map";
            this.picture_map.Size = new System.Drawing.Size(230, 167);
            this.picture_map.TabIndex = 12;
            this.picture_map.TabStop = false;
            this.picture_map.Click += new System.EventHandler(this.clicked_map);
            // 
            // userEntryPanel
            // 
            this.userEntryPanel.Location = new System.Drawing.Point(525, 726);
            this.userEntryPanel.Name = "userEntryPanel";
            this.userEntryPanel.Size = new System.Drawing.Size(612, 20);
            this.userEntryPanel.TabIndex = 13;
            this.userEntryPanel.Text = "The user will enter commands here, such as \"Examine tree\", \"Talk to (NPC name)\" e" +
    "tc.";
            this.userEntryPanel.Click += new System.EventHandler(this.clicked_userEntryPanel);
            // 
            // button_submitCommand
            // 
            this.button_submitCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_submitCommand.Location = new System.Drawing.Point(1143, 723);
            this.button_submitCommand.Name = "button_submitCommand";
            this.button_submitCommand.Size = new System.Drawing.Size(75, 23);
            this.button_submitCommand.TabIndex = 14;
            this.button_submitCommand.Text = "Submit";
            this.button_submitCommand.UseVisualStyleBackColor = true;
            this.button_submitCommand.Click += new System.EventHandler(this.clicked_userEntrySubmit);
            // 
            // label_whatDoYouWantToDo
            // 
            this.label_whatDoYouWantToDo.AutoSize = true;
            this.label_whatDoYouWantToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_whatDoYouWantToDo.Location = new System.Drawing.Point(334, 726);
            this.label_whatDoYouWantToDo.Name = "label_whatDoYouWantToDo";
            this.label_whatDoYouWantToDo.Size = new System.Drawing.Size(185, 20);
            this.label_whatDoYouWantToDo.TabIndex = 15;
            this.label_whatDoYouWantToDo.Text = "What do you want to do?";
            // 
            // listBox_enemiesNearby
            // 
            this.listBox_enemiesNearby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox_enemiesNearby.FormattingEnabled = true;
            this.listBox_enemiesNearby.Items.AddRange(new object[] {
            "Bat",
            "Spider",
            "Skeleton",
            "Skeleton",
            "Skeleton",
            "Ghost",
            "Giant Mosquito",
            "-enemy",
            "-enemy",
            "-enemy",
            "-friendly NPC",
            "-enemy",
            "-enemy",
            "-enemy",
            "-enemy",
            "-enemy",
            "-enemy",
            "-enemy",
            "-Strange Looking Door",
            "-enemy",
            "-enemy",
            "-enemy",
            "-enemy",
            "-enemy",
            "-enemy",
            "-enemy",
            "-Large footprint"});
            this.listBox_enemiesNearby.Location = new System.Drawing.Point(1226, 207);
            this.listBox_enemiesNearby.Name = "listBox_enemiesNearby";
            this.listBox_enemiesNearby.Size = new System.Drawing.Size(230, 251);
            this.listBox_enemiesNearby.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_fight, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_flee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_interact, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_rest, 1, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1224, 618);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 131);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // button_fight
            // 
            this.button_fight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_fight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_fight.Location = new System.Drawing.Point(20, 21);
            this.button_fight.Name = "button_fight";
            this.button_fight.Size = new System.Drawing.Size(75, 23);
            this.button_fight.TabIndex = 0;
            this.button_fight.Text = "Fight";
            this.button_fight.UseVisualStyleBackColor = true;
            // 
            // button_flee
            // 
            this.button_flee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_flee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_flee.Location = new System.Drawing.Point(135, 21);
            this.button_flee.Name = "button_flee";
            this.button_flee.Size = new System.Drawing.Size(75, 23);
            this.button_flee.TabIndex = 1;
            this.button_flee.Text = "Flee";
            this.button_flee.UseVisualStyleBackColor = true;
            // 
            // button_interact
            // 
            this.button_interact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_interact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_interact.Location = new System.Drawing.Point(20, 86);
            this.button_interact.Name = "button_interact";
            this.button_interact.Size = new System.Drawing.Size(75, 23);
            this.button_interact.TabIndex = 2;
            this.button_interact.Text = "Interact";
            this.button_interact.UseVisualStyleBackColor = false;
            // 
            // button_rest
            // 
            this.button_rest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_rest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rest.Location = new System.Drawing.Point(135, 86);
            this.button_rest.Name = "button_rest";
            this.button_rest.Size = new System.Drawing.Size(75, 23);
            this.button_rest.TabIndex = 3;
            this.button_rest.Text = "Rest";
            this.button_rest.UseVisualStyleBackColor = true;
            // 
            // centralInfoHub
            // 
            this.centralInfoHub.AcceptsReturn = true;
            this.centralInfoHub.Cursor = System.Windows.Forms.Cursors.Default;
            this.centralInfoHub.Location = new System.Drawing.Point(320, 618);
            this.centralInfoHub.Multiline = true;
            this.centralInfoHub.Name = "centralInfoHub";
            this.centralInfoHub.ReadOnly = true;
            this.centralInfoHub.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.centralInfoHub.Size = new System.Drawing.Size(899, 99);
            this.centralInfoHub.TabIndex = 4;
            this.centralInfoHub.Text = "Contextual information such as story elements, player interactions, surrounding d" +
    "escription, etc. go here.  This is the central info hub.\n";
            // 
            // label_hitPoints
            // 
            this.label_hitPoints.AutoSize = true;
            this.label_hitPoints.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_hitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hitPoints.ForeColor = System.Drawing.Color.Lime;
            this.label_hitPoints.Location = new System.Drawing.Point(335, 12);
            this.label_hitPoints.Name = "label_hitPoints";
            this.label_hitPoints.Size = new System.Drawing.Size(104, 24);
            this.label_hitPoints.TabIndex = 18;
            this.label_hitPoints.Text = "Hit Points:";
            // 
            // label_hpValue
            // 
            this.label_hpValue.AutoSize = true;
            this.label_hpValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hpValue.Location = new System.Drawing.Point(444, 11);
            this.label_hpValue.Name = "label_hpValue";
            this.label_hpValue.Size = new System.Drawing.Size(75, 24);
            this.label_hpValue.TabIndex = 19;
            this.label_hpValue.Text = "150/150";
            // 
            // label_abilityPoints
            // 
            this.label_abilityPoints.AutoSize = true;
            this.label_abilityPoints.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_abilityPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_abilityPoints.ForeColor = System.Drawing.Color.Blue;
            this.label_abilityPoints.Location = new System.Drawing.Point(556, 12);
            this.label_abilityPoints.Name = "label_abilityPoints";
            this.label_abilityPoints.Size = new System.Drawing.Size(135, 24);
            this.label_abilityPoints.TabIndex = 20;
            this.label_abilityPoints.Text = "Ability Points:";
            // 
            // label_apValue
            // 
            this.label_apValue.AutoSize = true;
            this.label_apValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apValue.Location = new System.Drawing.Point(697, 12);
            this.label_apValue.Name = "label_apValue";
            this.label_apValue.Size = new System.Drawing.Size(75, 24);
            this.label_apValue.TabIndex = 21;
            this.label_apValue.Text = "150/150";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Black;
            this.label_status.Location = new System.Drawing.Point(814, 12);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(72, 24);
            this.label_status.TabIndex = 22;
            this.label_status.Text = "Status:";
            // 
            // label_buffDebuffIconsGoHere
            // 
            this.label_buffDebuffIconsGoHere.AutoSize = true;
            this.label_buffDebuffIconsGoHere.Location = new System.Drawing.Point(966, 17);
            this.label_buffDebuffIconsGoHere.Name = "label_buffDebuffIconsGoHere";
            this.label_buffDebuffIconsGoHere.Size = new System.Drawing.Size(147, 13);
            this.label_buffDebuffIconsGoHere.TabIndex = 23;
            this.label_buffDebuffIconsGoHere.Text = "buff/debuff icons will go here.";
            // 
            // label_mapGoesHere
            // 
            this.label_mapGoesHere.AutoSize = true;
            this.label_mapGoesHere.Location = new System.Drawing.Point(1305, 75);
            this.label_mapGoesHere.Name = "label_mapGoesHere";
            this.label_mapGoesHere.Size = new System.Drawing.Size(77, 13);
            this.label_mapGoesHere.TabIndex = 24;
            this.label_mapGoesHere.Text = "map goes here";
            // 
            // label_entitiesOfInterest
            // 
            this.label_entitiesOfInterest.AutoSize = true;
            this.label_entitiesOfInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_entitiesOfInterest.Location = new System.Drawing.Point(1255, 182);
            this.label_entitiesOfInterest.Name = "label_entitiesOfInterest";
            this.label_entitiesOfInterest.Size = new System.Drawing.Size(164, 20);
            this.label_entitiesOfInterest.TabIndex = 25;
            this.label_entitiesOfInterest.Text = "Entities of Interest:";
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Lime;
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.Location = new System.Drawing.Point(686, 265);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(215, 37);
            this.startGameButton.TabIndex = 26;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.clicked_startGameButton);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CharacterNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textbox_CharName, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(605, 177);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.77419F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.22581F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 72);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // CharacterNameLabel
            // 
            this.CharacterNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CharacterNameLabel.AutoSize = true;
            this.CharacterNameLabel.Location = new System.Drawing.Point(134, 10);
            this.CharacterNameLabel.Name = "CharacterNameLabel";
            this.CharacterNameLabel.Size = new System.Drawing.Size(111, 13);
            this.CharacterNameLabel.TabIndex = 0;
            this.CharacterNameLabel.Text = "Input Character Name";
            // 
            // textbox_CharName
            // 
            this.textbox_CharName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_CharName.Location = new System.Drawing.Point(139, 42);
            this.textbox_CharName.Name = "textbox_CharName";
            this.textbox_CharName.Size = new System.Drawing.Size(100, 20);
            this.textbox_CharName.TabIndex = 2;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 761);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.label_entitiesOfInterest);
            this.Controls.Add(this.label_mapGoesHere);
            this.Controls.Add(this.label_buffDebuffIconsGoHere);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_apValue);
            this.Controls.Add(this.label_abilityPoints);
            this.Controls.Add(this.label_hpValue);
            this.Controls.Add(this.label_hitPoints);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBox_enemiesNearby);
            this.Controls.Add(this.label_whatDoYouWantToDo);
            this.Controls.Add(this.button_submitCommand);
            this.Controls.Add(this.centralInfoHub);
            this.Controls.Add(this.userEntryPanel);
            this.Controls.Add(this.picture_map);
            this.Controls.Add(this.button_moveWest);
            this.Controls.Add(this.button_moveSouth);
            this.Controls.Add(this.button_moveEast);
            this.Controls.Add(this.button_moveNorth);
            this.Controls.Add(this.button_openEquipmentManager);
            this.Controls.Add(this.picture_manSilhouette);
            this.Controls.Add(this.button_useItem);
            this.Controls.Add(this.button_examineItem);
            this.Controls.Add(this.textBox_inventoryDescription);
            this.Controls.Add(this.label_inventory);
            this.Controls.Add(this.picture_mainFrame);
            this.Controls.Add(this.listBox_inventoryList);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "GUI";
            this.Text = "User Interface";
            ((System.ComponentModel.ISupportInitialize)(this.picture_manSilhouette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_mainFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_map)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_inventoryList;
        private System.Windows.Forms.PictureBox picture_mainFrame;
        private System.Windows.Forms.Label label_inventory;
        private System.Windows.Forms.TextBox textBox_inventoryDescription;
        private System.Windows.Forms.Button button_examineItem;
        private System.Windows.Forms.Button button_useItem;
        private System.Windows.Forms.PictureBox picture_manSilhouette;
        private System.Windows.Forms.Button button_openEquipmentManager;
        private System.Windows.Forms.Button button_moveNorth;
        private System.Windows.Forms.Button button_moveEast;
        private System.Windows.Forms.Button button_moveSouth;
        private System.Windows.Forms.Button button_moveWest;
        private System.Windows.Forms.PictureBox picture_map;
        private System.Windows.Forms.TextBox userEntryPanel;
        private System.Windows.Forms.Button button_submitCommand;
        private System.Windows.Forms.Label label_whatDoYouWantToDo;
        private System.Windows.Forms.ListBox listBox_enemiesNearby;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_fight;
        private System.Windows.Forms.Button button_flee;
        private System.Windows.Forms.Button button_interact;
        private System.Windows.Forms.Button button_rest;
        private System.Windows.Forms.TextBox centralInfoHub;
        private System.Windows.Forms.Label label_hitPoints;
        private System.Windows.Forms.Label label_hpValue;
        private System.Windows.Forms.Label label_abilityPoints;
        private System.Windows.Forms.Label label_apValue;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_buffDebuffIconsGoHere;
        private System.Windows.Forms.Label label_mapGoesHere;
        private System.Windows.Forms.Label label_entitiesOfInterest;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label CharacterNameLabel;
        private System.Windows.Forms.TextBox textbox_CharName;
    }
}

