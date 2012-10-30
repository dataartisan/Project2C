using Project2B.Gui;

namespace Project2B
{
    partial class GameGui
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
            this.LocationList = new System.Windows.Forms.ListBox();
            this.PlayerList = new System.Windows.Forms.ListBox();
            this.LocationItemButton = new System.Windows.Forms.Button();
            this.PlayerItemDropButton = new System.Windows.Forms.Button();
            this.PlayerItemEatButton = new System.Windows.Forms.Button();
            this.PlayerItemTurnOnButton = new System.Windows.Forms.Button();
            this.PlayerNameText = new System.Windows.Forms.TextBox();
            this.PlayerNameEntry = new System.Windows.Forms.Button();
            this.NameEnterPanel = new System.Windows.Forms.Panel();
            this.PlayerItemPanel = new System.Windows.Forms.Panel();
            this.UnEquipPlayerWeapon = new System.Windows.Forms.Button();
            this.EquipWeaponButton = new System.Windows.Forms.Button();
            this.TurnOffButton = new System.Windows.Forms.Button();
            this.LocationShapePanel = new System.Windows.Forms.Panel();
            this.LocationNameText = new System.Windows.Forms.TextBox();
            this.West = new System.Windows.Forms.Label();
            this.East = new System.Windows.Forms.Label();
            this.South = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Label();
            this.North = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SouthLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.WestLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.EastLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.NorthLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.DownLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.UpLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.LocationItemPanel = new System.Windows.Forms.Panel();
            this.LocationSwitchPanel = new System.Windows.Forms.Panel();
            this.LowerButton = new System.Windows.Forms.Button();
            this.RaiseButton = new System.Windows.Forms.Button();
            this.LightOffButton = new System.Windows.Forms.Button();
            this.LightOnButton = new System.Windows.Forms.Button();
            this.PlayerHealthBar = new System.Windows.Forms.ProgressBar();
            this.PlayerHealthLabel = new System.Windows.Forms.Label();
            this.HealthNumber = new System.Windows.Forms.Label();
            this.PlayerHealthPanel = new System.Windows.Forms.Panel();
            this.TripLogBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.ShowLogButton = new System.Windows.Forms.Button();
            this.LookGoPanel = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.WestButton = new System.Windows.Forms.Button();
            this.EastButton = new System.Windows.Forms.Button();
            this.SouthButton = new System.Windows.Forms.Button();
            this.NorthButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.LookButton = new System.Windows.Forms.Button();
            this.LookDescription = new System.Windows.Forms.TextBox();
            this.PlayerCoinDisplayPanel = new System.Windows.Forms.Panel();
            this.PlayerCoinDisplay = new System.Windows.Forms.TextBox();
            this.LocationLookPanel = new System.Windows.Forms.Panel();
            this.ExitOrContinuePanel = new System.Windows.Forms.Panel();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NameEnterPanel.SuspendLayout();
            this.PlayerItemPanel.SuspendLayout();
            this.LocationShapePanel.SuspendLayout();
            this.LocationItemPanel.SuspendLayout();
            this.LocationSwitchPanel.SuspendLayout();
            this.PlayerHealthPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.LookGoPanel.SuspendLayout();
            this.PlayerCoinDisplayPanel.SuspendLayout();
            this.LocationLookPanel.SuspendLayout();
            this.ExitOrContinuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationList
            // 
            this.LocationList.FormattingEnabled = true;
            this.LocationList.Location = new System.Drawing.Point(3, 3);
            this.LocationList.Name = "LocationList";
            this.LocationList.Size = new System.Drawing.Size(120, 95);
            this.LocationList.TabIndex = 0;
            // 
            // PlayerList
            // 
            this.PlayerList.FormattingEnabled = true;
            this.PlayerList.Location = new System.Drawing.Point(0, 3);
            this.PlayerList.Name = "PlayerList";
            this.PlayerList.Size = new System.Drawing.Size(120, 121);
            this.PlayerList.TabIndex = 1;
            this.PlayerList.SelectedIndexChanged += new System.EventHandler(this.PlayerList_SelectedIndexChanged);
            // 
            // LocationItemButton
            // 
            this.LocationItemButton.Location = new System.Drawing.Point(122, 3);
            this.LocationItemButton.Name = "LocationItemButton";
            this.LocationItemButton.Size = new System.Drawing.Size(75, 23);
            this.LocationItemButton.TabIndex = 2;
            this.LocationItemButton.Text = "Pick Up";
            this.LocationItemButton.UseVisualStyleBackColor = true;
            this.LocationItemButton.Click += new System.EventHandler(this.LocationItemButton_Click);
            // 
            // PlayerItemDropButton
            // 
            this.PlayerItemDropButton.Location = new System.Drawing.Point(122, 3);
            this.PlayerItemDropButton.Name = "PlayerItemDropButton";
            this.PlayerItemDropButton.Size = new System.Drawing.Size(75, 23);
            this.PlayerItemDropButton.TabIndex = 3;
            this.PlayerItemDropButton.Text = "Drop";
            this.PlayerItemDropButton.UseVisualStyleBackColor = true;
            this.PlayerItemDropButton.Click += new System.EventHandler(this.PlayerItemDropButton_Click);
            // 
            // PlayerItemEatButton
            // 
            this.PlayerItemEatButton.Location = new System.Drawing.Point(122, 32);
            this.PlayerItemEatButton.Name = "PlayerItemEatButton";
            this.PlayerItemEatButton.Size = new System.Drawing.Size(75, 24);
            this.PlayerItemEatButton.TabIndex = 4;
            this.PlayerItemEatButton.Text = "Eat";
            this.PlayerItemEatButton.UseVisualStyleBackColor = true;
            this.PlayerItemEatButton.Click += new System.EventHandler(this.PlayerItemEatButton_Click);
            // 
            // PlayerItemTurnOnButton
            // 
            this.PlayerItemTurnOnButton.Location = new System.Drawing.Point(122, 62);
            this.PlayerItemTurnOnButton.Name = "PlayerItemTurnOnButton";
            this.PlayerItemTurnOnButton.Size = new System.Drawing.Size(75, 23);
            this.PlayerItemTurnOnButton.TabIndex = 5;
            this.PlayerItemTurnOnButton.Text = "Turn On";
            this.PlayerItemTurnOnButton.UseVisualStyleBackColor = true;
            this.PlayerItemTurnOnButton.Click += new System.EventHandler(this.PlayerItemTurnOnButton_Click);
            // 
            // PlayerNameText
            // 
            this.PlayerNameText.Location = new System.Drawing.Point(50, 28);
            this.PlayerNameText.Multiline = true;
            this.PlayerNameText.Name = "PlayerNameText";
            this.PlayerNameText.Size = new System.Drawing.Size(144, 37);
            this.PlayerNameText.TabIndex = 6;
            // 
            // PlayerNameEntry
            // 
            this.PlayerNameEntry.Location = new System.Drawing.Point(86, 71);
            this.PlayerNameEntry.Name = "PlayerNameEntry";
            this.PlayerNameEntry.Size = new System.Drawing.Size(75, 23);
            this.PlayerNameEntry.TabIndex = 7;
            this.PlayerNameEntry.Text = "Enter";
            this.PlayerNameEntry.UseVisualStyleBackColor = true;
            this.PlayerNameEntry.Click += new System.EventHandler(this.button5_Click);
            // 
            // NameEnterPanel
            // 
            this.NameEnterPanel.Controls.Add(this.PlayerNameText);
            this.NameEnterPanel.Controls.Add(this.PlayerNameEntry);
            this.NameEnterPanel.Location = new System.Drawing.Point(566, 382);
            this.NameEnterPanel.Name = "NameEnterPanel";
            this.NameEnterPanel.Size = new System.Drawing.Size(246, 100);
            this.NameEnterPanel.TabIndex = 9;
            // 
            // PlayerItemPanel
            // 
            this.PlayerItemPanel.Controls.Add(this.UnEquipPlayerWeapon);
            this.PlayerItemPanel.Controls.Add(this.EquipWeaponButton);
            this.PlayerItemPanel.Controls.Add(this.TurnOffButton);
            this.PlayerItemPanel.Controls.Add(this.PlayerList);
            this.PlayerItemPanel.Controls.Add(this.PlayerItemDropButton);
            this.PlayerItemPanel.Controls.Add(this.PlayerItemTurnOnButton);
            this.PlayerItemPanel.Controls.Add(this.PlayerItemEatButton);
            this.PlayerItemPanel.Location = new System.Drawing.Point(37, 270);
            this.PlayerItemPanel.Name = "PlayerItemPanel";
            this.PlayerItemPanel.Size = new System.Drawing.Size(297, 129);
            this.PlayerItemPanel.TabIndex = 10;
            // 
            // UnEquipPlayerWeapon
            // 
            this.UnEquipPlayerWeapon.Location = new System.Drawing.Point(219, 32);
            this.UnEquipPlayerWeapon.Name = "UnEquipPlayerWeapon";
            this.UnEquipPlayerWeapon.Size = new System.Drawing.Size(75, 23);
            this.UnEquipPlayerWeapon.TabIndex = 8;
            this.UnEquipPlayerWeapon.Text = "UnEquip";
            this.UnEquipPlayerWeapon.UseVisualStyleBackColor = true;
            this.UnEquipPlayerWeapon.Click += new System.EventHandler(this.UnEquipPlayerWeapon_Click);
            // 
            // EquipWeaponButton
            // 
            this.EquipWeaponButton.Location = new System.Drawing.Point(219, 3);
            this.EquipWeaponButton.Name = "EquipWeaponButton";
            this.EquipWeaponButton.Size = new System.Drawing.Size(75, 23);
            this.EquipWeaponButton.TabIndex = 7;
            this.EquipWeaponButton.Text = "Equip";
            this.EquipWeaponButton.UseVisualStyleBackColor = true;
            this.EquipWeaponButton.Click += new System.EventHandler(this.EquipWeaponButton_Click);
            // 
            // TurnOffButton
            // 
            this.TurnOffButton.Location = new System.Drawing.Point(122, 91);
            this.TurnOffButton.Name = "TurnOffButton";
            this.TurnOffButton.Size = new System.Drawing.Size(75, 23);
            this.TurnOffButton.TabIndex = 6;
            this.TurnOffButton.Text = "Turn Off";
            this.TurnOffButton.UseVisualStyleBackColor = true;
            this.TurnOffButton.Click += new System.EventHandler(this.TurnOffButton_Click);
            // 
            // LocationShapePanel
            // 
            this.LocationShapePanel.Controls.Add(this.LocationNameText);
            this.LocationShapePanel.Controls.Add(this.West);
            this.LocationShapePanel.Controls.Add(this.East);
            this.LocationShapePanel.Controls.Add(this.South);
            this.LocationShapePanel.Controls.Add(this.Down);
            this.LocationShapePanel.Controls.Add(this.Up);
            this.LocationShapePanel.Controls.Add(this.North);
            this.LocationShapePanel.Controls.Add(this.shapeContainer1);
            this.LocationShapePanel.Location = new System.Drawing.Point(482, 54);
            this.LocationShapePanel.Name = "LocationShapePanel";
            this.LocationShapePanel.Size = new System.Drawing.Size(409, 322);
            this.LocationShapePanel.TabIndex = 11;
            // 
            // LocationNameText
            // 
            this.LocationNameText.Enabled = false;
            this.LocationNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LocationNameText.Location = new System.Drawing.Point(150, 139);
            this.LocationNameText.Multiline = true;
            this.LocationNameText.Name = "LocationNameText";
            this.LocationNameText.Size = new System.Drawing.Size(128, 24);
            this.LocationNameText.TabIndex = 7;
            // 
            // West
            // 
            this.West.AutoSize = true;
            this.West.Location = new System.Drawing.Point(100, 197);
            this.West.Name = "West";
            this.West.Size = new System.Drawing.Size(32, 13);
            this.West.TabIndex = 6;
            this.West.Text = "West";
            // 
            // East
            // 
            this.East.AutoSize = true;
            this.East.Location = new System.Drawing.Point(281, 87);
            this.East.Name = "East";
            this.East.Size = new System.Drawing.Size(28, 13);
            this.East.TabIndex = 5;
            this.East.Text = "East";
            // 
            // South
            // 
            this.South.AutoSize = true;
            this.South.Location = new System.Drawing.Point(300, 204);
            this.South.Name = "South";
            this.South.Size = new System.Drawing.Size(35, 13);
            this.South.TabIndex = 4;
            this.South.Text = "South";
            // 
            // Down
            // 
            this.Down.AutoSize = true;
            this.Down.Location = new System.Drawing.Point(171, 269);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(35, 13);
            this.Down.TabIndex = 3;
            this.Down.Text = "Down";
            // 
            // Up
            // 
            this.Up.AutoSize = true;
            this.Up.Location = new System.Drawing.Point(185, 18);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(21, 13);
            this.Up.TabIndex = 2;
            this.Up.Text = "Up";
            // 
            // North
            // 
            this.North.AutoSize = true;
            this.North.Location = new System.Drawing.Point(113, 87);
            this.North.Name = "North";
            this.North.Size = new System.Drawing.Size(33, 13);
            this.North.TabIndex = 1;
            this.North.Text = "North";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.SouthLine,
            this.WestLine,
            this.EastLine,
            this.NorthLine,
            this.DownLine,
            this.UpLine,
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(409, 322);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // SouthLine
            // 
            this.SouthLine.Enabled = false;
            this.SouthLine.Name = "SouthLine";
            this.SouthLine.X1 = 265;
            this.SouthLine.X2 = 329;
            this.SouthLine.Y1 = 195;
            this.SouthLine.Y2 = 255;
            // 
            // WestLine
            // 
            this.WestLine.Enabled = false;
            this.WestLine.Name = "WestLine";
            this.WestLine.X1 = 94;
            this.WestLine.X2 = 163;
            this.WestLine.Y1 = 240;
            this.WestLine.Y2 = 197;
            // 
            // EastLine
            // 
            this.EastLine.Enabled = false;
            this.EastLine.Name = "EastLine";
            this.EastLine.X1 = 271;
            this.EastLine.X2 = 357;
            this.EastLine.Y1 = 122;
            this.EastLine.Y2 = 88;
            // 
            // NorthLine
            // 
            this.NorthLine.Enabled = false;
            this.NorthLine.Name = "NorthLine";
            this.NorthLine.X1 = 69;
            this.NorthLine.X2 = 155;
            this.NorthLine.Y1 = 93;
            this.NorthLine.Y2 = 120;
            // 
            // DownLine
            // 
            this.DownLine.Enabled = false;
            this.DownLine.Name = "DownLine";
            this.DownLine.X1 = 214;
            this.DownLine.X2 = 214;
            this.DownLine.Y1 = 217;
            this.DownLine.Y2 = 296;
            // 
            // UpLine
            // 
            this.UpLine.Enabled = false;
            this.UpLine.Name = "UpLine";
            this.UpLine.X1 = 213;
            this.UpLine.X2 = 214;
            this.UpLine.Y1 = 9;
            this.UpLine.Y2 = 88;
            // 
            // ovalShape1
            // 
            this.ovalShape1.Location = new System.Drawing.Point(147, 90);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(134, 127);
            // 
            // LocationItemPanel
            // 
            this.LocationItemPanel.Controls.Add(this.LocationList);
            this.LocationItemPanel.Controls.Add(this.LocationItemButton);
            this.LocationItemPanel.Location = new System.Drawing.Point(921, 7);
            this.LocationItemPanel.Name = "LocationItemPanel";
            this.LocationItemPanel.Size = new System.Drawing.Size(200, 100);
            this.LocationItemPanel.TabIndex = 12;
            // 
            // LocationSwitchPanel
            // 
            this.LocationSwitchPanel.Controls.Add(this.LowerButton);
            this.LocationSwitchPanel.Controls.Add(this.RaiseButton);
            this.LocationSwitchPanel.Controls.Add(this.LightOffButton);
            this.LocationSwitchPanel.Controls.Add(this.LightOnButton);
            this.LocationSwitchPanel.Location = new System.Drawing.Point(482, 7);
            this.LocationSwitchPanel.Name = "LocationSwitchPanel";
            this.LocationSwitchPanel.Size = new System.Drawing.Size(409, 38);
            this.LocationSwitchPanel.TabIndex = 13;
            // 
            // LowerButton
            // 
            this.LowerButton.Location = new System.Drawing.Point(312, 5);
            this.LowerButton.Name = "LowerButton";
            this.LowerButton.Size = new System.Drawing.Size(75, 23);
            this.LowerButton.TabIndex = 3;
            this.LowerButton.Text = "Lower";
            this.LowerButton.UseVisualStyleBackColor = true;
            this.LowerButton.Click += new System.EventHandler(this.LowerButton_Click);
            // 
            // RaiseButton
            // 
            this.RaiseButton.Location = new System.Drawing.Point(213, 5);
            this.RaiseButton.Name = "RaiseButton";
            this.RaiseButton.Size = new System.Drawing.Size(75, 23);
            this.RaiseButton.TabIndex = 2;
            this.RaiseButton.Text = "Raise";
            this.RaiseButton.UseVisualStyleBackColor = true;
            this.RaiseButton.Click += new System.EventHandler(this.RaiseButton_Click);
            // 
            // LightOffButton
            // 
            this.LightOffButton.Location = new System.Drawing.Point(116, 5);
            this.LightOffButton.Name = "LightOffButton";
            this.LightOffButton.Size = new System.Drawing.Size(75, 23);
            this.LightOffButton.TabIndex = 1;
            this.LightOffButton.Text = "Light Off";
            this.LightOffButton.UseVisualStyleBackColor = true;
            this.LightOffButton.Click += new System.EventHandler(this.LightOffButton_Click);
            // 
            // LightOnButton
            // 
            this.LightOnButton.Location = new System.Drawing.Point(19, 5);
            this.LightOnButton.Name = "LightOnButton";
            this.LightOnButton.Size = new System.Drawing.Size(75, 23);
            this.LightOnButton.TabIndex = 0;
            this.LightOnButton.Text = "Light On";
            this.LightOnButton.UseVisualStyleBackColor = true;
            this.LightOnButton.Click += new System.EventHandler(this.LightOnButton_Click);
            // 
            // PlayerHealthBar
            // 
            this.PlayerHealthBar.Location = new System.Drawing.Point(23, 28);
            this.PlayerHealthBar.Name = "PlayerHealthBar";
            this.PlayerHealthBar.Size = new System.Drawing.Size(100, 23);
            this.PlayerHealthBar.TabIndex = 14;
            // 
            // PlayerHealthLabel
            // 
            this.PlayerHealthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerHealthLabel.AutoSize = true;
            this.PlayerHealthLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PlayerHealthLabel.Location = new System.Drawing.Point(46, 9);
            this.PlayerHealthLabel.Name = "PlayerHealthLabel";
            this.PlayerHealthLabel.Size = new System.Drawing.Size(0, 13);
            this.PlayerHealthLabel.TabIndex = 15;
            this.PlayerHealthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HealthNumber
            // 
            this.HealthNumber.AutoSize = true;
            this.HealthNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HealthNumber.Location = new System.Drawing.Point(61, 60);
            this.HealthNumber.Name = "HealthNumber";
            this.HealthNumber.Size = new System.Drawing.Size(0, 13);
            this.HealthNumber.TabIndex = 16;
            this.HealthNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayerHealthPanel
            // 
            this.PlayerHealthPanel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerHealthPanel.Controls.Add(this.HealthNumber);
            this.PlayerHealthPanel.Controls.Add(this.PlayerHealthLabel);
            this.PlayerHealthPanel.Controls.Add(this.PlayerHealthBar);
            this.PlayerHealthPanel.Location = new System.Drawing.Point(37, 9);
            this.PlayerHealthPanel.Name = "PlayerHealthPanel";
            this.PlayerHealthPanel.Size = new System.Drawing.Size(143, 87);
            this.PlayerHealthPanel.TabIndex = 17;
            // 
            // TripLogBox
            // 
            this.TripLogBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TripLogBox.Location = new System.Drawing.Point(3, 51);
            this.TripLogBox.Multiline = true;
            this.TripLogBox.Name = "TripLogBox";
            this.TripLogBox.ReadOnly = true;
            this.TripLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TripLogBox.Size = new System.Drawing.Size(194, 106);
            this.TripLogBox.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ClearLogButton);
            this.panel3.Controls.Add(this.ShowLogButton);
            this.panel3.Controls.Add(this.TripLogBox);
            this.panel3.Location = new System.Drawing.Point(37, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 160);
            this.panel3.TabIndex = 19;
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(107, 12);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(75, 23);
            this.ClearLogButton.TabIndex = 20;
            this.ClearLogButton.Text = "Clear Log";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // ShowLogButton
            // 
            this.ShowLogButton.Location = new System.Drawing.Point(10, 12);
            this.ShowLogButton.Name = "ShowLogButton";
            this.ShowLogButton.Size = new System.Drawing.Size(75, 23);
            this.ShowLogButton.TabIndex = 19;
            this.ShowLogButton.Text = "Show Log";
            this.ShowLogButton.UseVisualStyleBackColor = true;
            this.ShowLogButton.Click += new System.EventHandler(this.ShowLogButton_Click);
            // 
            // LookGoPanel
            // 
            this.LookGoPanel.Controls.Add(this.ReturnButton);
            this.LookGoPanel.Controls.Add(this.WestButton);
            this.LookGoPanel.Controls.Add(this.EastButton);
            this.LookGoPanel.Controls.Add(this.SouthButton);
            this.LookGoPanel.Controls.Add(this.NorthButton);
            this.LookGoPanel.Controls.Add(this.DownButton);
            this.LookGoPanel.Controls.Add(this.UpButton);
            this.LookGoPanel.Controls.Add(this.GoButton);
            this.LookGoPanel.Controls.Add(this.LookButton);
            this.LookGoPanel.Location = new System.Drawing.Point(921, 113);
            this.LookGoPanel.Name = "LookGoPanel";
            this.LookGoPanel.Size = new System.Drawing.Size(315, 174);
            this.LookGoPanel.TabIndex = 20;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(14, 133);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 8;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // WestButton
            // 
            this.WestButton.Location = new System.Drawing.Point(220, 137);
            this.WestButton.Name = "WestButton";
            this.WestButton.Size = new System.Drawing.Size(75, 23);
            this.WestButton.TabIndex = 7;
            this.WestButton.Text = "West";
            this.WestButton.UseVisualStyleBackColor = true;
            this.WestButton.Click += new System.EventHandler(this.WestButton_Click);
            // 
            // EastButton
            // 
            this.EastButton.Location = new System.Drawing.Point(123, 134);
            this.EastButton.Name = "EastButton";
            this.EastButton.Size = new System.Drawing.Size(75, 23);
            this.EastButton.TabIndex = 6;
            this.EastButton.Text = "East";
            this.EastButton.UseVisualStyleBackColor = true;
            this.EastButton.Click += new System.EventHandler(this.EastButton_Click);
            // 
            // SouthButton
            // 
            this.SouthButton.Location = new System.Drawing.Point(220, 78);
            this.SouthButton.Name = "SouthButton";
            this.SouthButton.Size = new System.Drawing.Size(75, 23);
            this.SouthButton.TabIndex = 5;
            this.SouthButton.Text = "South";
            this.SouthButton.UseVisualStyleBackColor = true;
            this.SouthButton.Click += new System.EventHandler(this.SouthButton_Click);
            // 
            // NorthButton
            // 
            this.NorthButton.Location = new System.Drawing.Point(123, 78);
            this.NorthButton.Name = "NorthButton";
            this.NorthButton.Size = new System.Drawing.Size(75, 23);
            this.NorthButton.TabIndex = 4;
            this.NorthButton.Text = "North";
            this.NorthButton.UseVisualStyleBackColor = true;
            this.NorthButton.Click += new System.EventHandler(this.NorthButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(220, 14);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(75, 23);
            this.DownButton.TabIndex = 3;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(123, 14);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(75, 23);
            this.UpButton.TabIndex = 2;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(14, 78);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // LookButton
            // 
            this.LookButton.Location = new System.Drawing.Point(14, 16);
            this.LookButton.Name = "LookButton";
            this.LookButton.Size = new System.Drawing.Size(75, 23);
            this.LookButton.TabIndex = 0;
            this.LookButton.Text = "Look";
            this.LookButton.UseVisualStyleBackColor = true;
            this.LookButton.Click += new System.EventHandler(this.LookButton_Click);
            // 
            // LookDescription
            // 
            this.LookDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LookDescription.Enabled = false;
            this.LookDescription.Location = new System.Drawing.Point(14, 10);
            this.LookDescription.Multiline = true;
            this.LookDescription.Name = "LookDescription";
            this.LookDescription.Size = new System.Drawing.Size(287, 91);
            this.LookDescription.TabIndex = 21;
            // 
            // PlayerCoinDisplayPanel
            // 
            this.PlayerCoinDisplayPanel.Controls.Add(this.PlayerCoinDisplay);
            this.PlayerCoinDisplayPanel.Location = new System.Drawing.Point(37, 410);
            this.PlayerCoinDisplayPanel.Name = "PlayerCoinDisplayPanel";
            this.PlayerCoinDisplayPanel.Size = new System.Drawing.Size(200, 81);
            this.PlayerCoinDisplayPanel.TabIndex = 21;
            // 
            // PlayerCoinDisplay
            // 
            this.PlayerCoinDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerCoinDisplay.Enabled = false;
            this.PlayerCoinDisplay.Location = new System.Drawing.Point(46, 17);
            this.PlayerCoinDisplay.Multiline = true;
            this.PlayerCoinDisplay.Name = "PlayerCoinDisplay";
            this.PlayerCoinDisplay.Size = new System.Drawing.Size(100, 44);
            this.PlayerCoinDisplay.TabIndex = 0;
            this.PlayerCoinDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocationLookPanel
            // 
            this.LocationLookPanel.Controls.Add(this.LookDescription);
            this.LocationLookPanel.Location = new System.Drawing.Point(921, 293);
            this.LocationLookPanel.Name = "LocationLookPanel";
            this.LocationLookPanel.Size = new System.Drawing.Size(315, 112);
            this.LocationLookPanel.TabIndex = 22;
            // 
            // ExitOrContinuePanel
            // 
            this.ExitOrContinuePanel.Controls.Add(this.ContinueButton);
            this.ExitOrContinuePanel.Controls.Add(this.ExitButton);
            this.ExitOrContinuePanel.Location = new System.Drawing.Point(921, 411);
            this.ExitOrContinuePanel.Name = "ExitOrContinuePanel";
            this.ExitOrContinuePanel.Size = new System.Drawing.Size(315, 81);
            this.ExitOrContinuePanel.TabIndex = 23;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(187, 15);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 50);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(54, 15);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 48);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit Game";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // GameGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 494);
            this.Controls.Add(this.ExitOrContinuePanel);
            this.Controls.Add(this.LocationLookPanel);
            this.Controls.Add(this.PlayerCoinDisplayPanel);
            this.Controls.Add(this.LocationShapePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PlayerHealthPanel);
            this.Controls.Add(this.LocationSwitchPanel);
            this.Controls.Add(this.LocationItemPanel);
            this.Controls.Add(this.PlayerItemPanel);
            this.Controls.Add(this.NameEnterPanel);
            this.Controls.Add(this.LookGoPanel);
            this.Name = "GameGui";
            this.Text = "GameGui";
            this.NameEnterPanel.ResumeLayout(false);
            this.NameEnterPanel.PerformLayout();
            this.PlayerItemPanel.ResumeLayout(false);
            this.LocationShapePanel.ResumeLayout(false);
            this.LocationShapePanel.PerformLayout();
            this.LocationItemPanel.ResumeLayout(false);
            this.LocationSwitchPanel.ResumeLayout(false);
            this.PlayerHealthPanel.ResumeLayout(false);
            this.PlayerHealthPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.LookGoPanel.ResumeLayout(false);
            this.PlayerCoinDisplayPanel.ResumeLayout(false);
            this.PlayerCoinDisplayPanel.PerformLayout();
            this.LocationLookPanel.ResumeLayout(false);
            this.LocationLookPanel.PerformLayout();
            this.ExitOrContinuePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LocationList;
        private System.Windows.Forms.ListBox PlayerList;
        private System.Windows.Forms.Button LocationItemButton;
        private System.Windows.Forms.Button PlayerItemDropButton;
        private System.Windows.Forms.Button PlayerItemEatButton;
        private System.Windows.Forms.Button PlayerItemTurnOnButton;
        private System.Windows.Forms.TextBox PlayerNameText;
        private System.Windows.Forms.Button PlayerNameEntry;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Panel NameEnterPanel;
        private System.Windows.Forms.Panel PlayerItemPanel;
        private System.Windows.Forms.Panel LocationShapePanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Label North;
        private Microsoft.VisualBasic.PowerPacks.LineShape SouthLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape WestLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape EastLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape NorthLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape DownLine;
        private Microsoft.VisualBasic.PowerPacks.LineShape UpLine;
        private System.Windows.Forms.Label West;
        private System.Windows.Forms.Label East;
        private System.Windows.Forms.Label South;
        private System.Windows.Forms.Label Down;
        private System.Windows.Forms.Label Up;
        private System.Windows.Forms.Panel LocationItemPanel;
        private System.Windows.Forms.Panel LocationSwitchPanel;
        private System.Windows.Forms.Button LowerButton;
        private System.Windows.Forms.Button RaiseButton;
        private System.Windows.Forms.Button LightOffButton;
        private System.Windows.Forms.Button LightOnButton;
        private System.Windows.Forms.ProgressBar PlayerHealthBar;
        private System.Windows.Forms.Label PlayerHealthLabel;
        private System.Windows.Forms.Label HealthNumber;
        private System.Windows.Forms.Panel PlayerHealthPanel;
        private System.Windows.Forms.TextBox TripLogBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button TurnOffButton;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.Button ShowLogButton;
        private System.Windows.Forms.Panel LookGoPanel;
        private System.Windows.Forms.TextBox LookDescription;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button WestButton;
        private System.Windows.Forms.Button EastButton;
        private System.Windows.Forms.Button SouthButton;
        private System.Windows.Forms.Button NorthButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button LookButton;
        private System.Windows.Forms.Panel PlayerCoinDisplayPanel;
        private System.Windows.Forms.TextBox PlayerCoinDisplay;
        private System.Windows.Forms.Panel LocationLookPanel;
        private System.Windows.Forms.Panel ExitOrContinuePanel;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button EquipWeaponButton;
        private System.Windows.Forms.Button UnEquipPlayerWeapon;
        private System.Windows.Forms.TextBox LocationNameText;
        
    }
}