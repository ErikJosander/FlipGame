namespace FlipIt
{
    partial class StartForm
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
            this.programLabel = new System.Windows.Forms.Label();
            this.startGame_Button = new System.Windows.Forms.Button();
            this.selectedPlayerListBox = new System.Windows.Forms.ListBox();
            this.dropDownOfPlayers = new System.Windows.Forms.ComboBox();
            this.linkLabelCreateNewPlayer = new System.Windows.Forms.LinkLabel();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.statisticsLink = new System.Windows.Forms.LinkLabel();
            this.deletePLayerLink = new System.Windows.Forms.LinkLabel();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // programLabel
            // 
            this.programLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.programLabel.AutoSize = true;
            this.programLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLabel.Location = new System.Drawing.Point(198, 9);
            this.programLabel.MinimumSize = new System.Drawing.Size(116, 38);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(116, 38);
            this.programLabel.TabIndex = 1;
            this.programLabel.Text = "FLIPIT";
            this.programLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startGame_Button
            // 
            this.startGame_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startGame_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startGame_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame_Button.Location = new System.Drawing.Point(43, 478);
            this.startGame_Button.Margin = new System.Windows.Forms.Padding(0);
            this.startGame_Button.MaximumSize = new System.Drawing.Size(886, 132);
            this.startGame_Button.MinimumSize = new System.Drawing.Size(415, 132);
            this.startGame_Button.Name = "startGame_Button";
            this.startGame_Button.Size = new System.Drawing.Size(417, 132);
            this.startGame_Button.TabIndex = 2;
            this.startGame_Button.TabStop = false;
            this.startGame_Button.Text = "Start Game";
            this.startGame_Button.UseVisualStyleBackColor = true;
            this.startGame_Button.Click += new System.EventHandler(this.startGame_Button_Click);
            // 
            // selectedPlayerListBox
            // 
            this.selectedPlayerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedPlayerListBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.selectedPlayerListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPlayerListBox.FormattingEnabled = true;
            this.selectedPlayerListBox.ItemHeight = 23;
            this.selectedPlayerListBox.Location = new System.Drawing.Point(43, 173);
            this.selectedPlayerListBox.Margin = new System.Windows.Forms.Padding(0);
            this.selectedPlayerListBox.MaximumSize = new System.Drawing.Size(886, 510);
            this.selectedPlayerListBox.MinimumSize = new System.Drawing.Size(415, 211);
            this.selectedPlayerListBox.Name = "selectedPlayerListBox";
            this.selectedPlayerListBox.Size = new System.Drawing.Size(417, 211);
            this.selectedPlayerListBox.TabIndex = 2;
            this.selectedPlayerListBox.TabStop = false;
            // 
            // dropDownOfPlayers
            // 
            this.dropDownOfPlayers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownOfPlayers.FormattingEnabled = true;
            this.dropDownOfPlayers.Location = new System.Drawing.Point(43, 113);
            this.dropDownOfPlayers.Margin = new System.Windows.Forms.Padding(0);
            this.dropDownOfPlayers.Name = "dropDownOfPlayers";
            this.dropDownOfPlayers.Size = new System.Drawing.Size(280, 31);
            this.dropDownOfPlayers.TabIndex = 4;
            this.dropDownOfPlayers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // linkLabelCreateNewPlayer
            // 
            this.linkLabelCreateNewPlayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateNewPlayer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelCreateNewPlayer.Location = new System.Drawing.Point(39, 78);
            this.linkLabelCreateNewPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabelCreateNewPlayer.Name = "linkLabelCreateNewPlayer";
            this.linkLabelCreateNewPlayer.Size = new System.Drawing.Size(177, 23);
            this.linkLabelCreateNewPlayer.TabIndex = 5;
            this.linkLabelCreateNewPlayer.TabStop = true;
            this.linkLabelCreateNewPlayer.Text = "Create New Player";
            this.linkLabelCreateNewPlayer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateNewPlayer_LinkClicked);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPlayerButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.Location = new System.Drawing.Point(329, 111);
            this.addPlayerButton.Margin = new System.Windows.Forms.Padding(0);
            this.addPlayerButton.MaximumSize = new System.Drawing.Size(600, 33);
            this.addPlayerButton.MinimumSize = new System.Drawing.Size(119, 33);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(131, 33);
            this.addPlayerButton.TabIndex = 6;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removePlayerButton.Location = new System.Drawing.Point(43, 409);
            this.removePlayerButton.Margin = new System.Windows.Forms.Padding(0);
            this.removePlayerButton.MaximumSize = new System.Drawing.Size(101, 49);
            this.removePlayerButton.MinimumSize = new System.Drawing.Size(101, 49);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(101, 49);
            this.removePlayerButton.TabIndex = 7;
            this.removePlayerButton.Text = "Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // statisticsLink
            // 
            this.statisticsLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsLink.AutoSize = true;
            this.statisticsLink.Font = new System.Drawing.Font("Arial", 12F);
            this.statisticsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.statisticsLink.Location = new System.Drawing.Point(370, 78);
            this.statisticsLink.Margin = new System.Windows.Forms.Padding(0);
            this.statisticsLink.Name = "statisticsLink";
            this.statisticsLink.Size = new System.Drawing.Size(90, 23);
            this.statisticsLink.TabIndex = 8;
            this.statisticsLink.TabStop = true;
            this.statisticsLink.Text = "Statistics";
            this.statisticsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.statisticsLink_LinkClicked);
            // 
            // deletePLayerLink
            // 
            this.deletePLayerLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePLayerLink.AutoSize = true;
            this.deletePLayerLink.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletePLayerLink.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePLayerLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.deletePLayerLink.Location = new System.Drawing.Point(150, 442);
            this.deletePLayerLink.Margin = new System.Windows.Forms.Padding(0);
            this.deletePLayerLink.Name = "deletePLayerLink";
            this.deletePLayerLink.Size = new System.Drawing.Size(93, 16);
            this.deletePLayerLink.TabIndex = 9;
            this.deletePLayerLink.TabStop = true;
            this.deletePLayerLink.Text = "Delete Player";
            this.deletePLayerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deletePLayerLink_LinkClicked);
            // 
            // tutorialButton
            // 
            this.tutorialButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tutorialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tutorialButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialButton.Location = new System.Drawing.Point(329, 409);
            this.tutorialButton.Margin = new System.Windows.Forms.Padding(0);
            this.tutorialButton.MaximumSize = new System.Drawing.Size(600, 49);
            this.tutorialButton.MinimumSize = new System.Drawing.Size(119, 49);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(131, 49);
            this.tutorialButton.TabIndex = 2;
            this.tutorialButton.TabStop = false;
            this.tutorialButton.Text = "Tutorial";
            this.tutorialButton.UseVisualStyleBackColor = true;
            this.tutorialButton.Click += new System.EventHandler(this.tutorialButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(511, 634);
            this.Controls.Add(this.tutorialButton);
            this.Controls.Add(this.deletePLayerLink);
            this.Controls.Add(this.statisticsLink);
            this.Controls.Add(this.programLabel);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.linkLabelCreateNewPlayer);
            this.Controls.Add(this.dropDownOfPlayers);
            this.Controls.Add(this.selectedPlayerListBox);
            this.Controls.Add(this.startGame_Button);
            this.MaximumSize = new System.Drawing.Size(998, 972);
            this.MinimumSize = new System.Drawing.Size(529, 681);
            this.Name = "StartForm";
            this.Text = "StartWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label programLabel;
        private System.Windows.Forms.Button startGame_Button;
        private System.Windows.Forms.ListBox selectedPlayerListBox;
        private System.Windows.Forms.ComboBox dropDownOfPlayers;
        private System.Windows.Forms.LinkLabel linkLabelCreateNewPlayer;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.LinkLabel statisticsLink;
        private System.Windows.Forms.LinkLabel deletePLayerLink;
        private System.Windows.Forms.Button tutorialButton;
    }
}