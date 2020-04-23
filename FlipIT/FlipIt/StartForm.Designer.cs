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
            this.SuspendLayout();
            // 
            // programLabel
            // 
            this.programLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLabel.Location = new System.Drawing.Point(46, 28);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(273, 38);
            this.programLabel.TabIndex = 1;
            this.programLabel.Text = "Choose Players";
            // 
            // startGame_Button
            // 
            this.startGame_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startGame_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame_Button.Location = new System.Drawing.Point(53, 490);
            this.startGame_Button.Name = "startGame_Button";
            this.startGame_Button.Size = new System.Drawing.Size(405, 132);
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
            this.selectedPlayerListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPlayerListBox.FormattingEnabled = true;
            this.selectedPlayerListBox.ItemHeight = 23;
            this.selectedPlayerListBox.Location = new System.Drawing.Point(53, 185);
            this.selectedPlayerListBox.Name = "selectedPlayerListBox";
            this.selectedPlayerListBox.Size = new System.Drawing.Size(405, 211);
            this.selectedPlayerListBox.TabIndex = 3;
            // 
            // dropDownOfPlayers
            // 
            this.dropDownOfPlayers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownOfPlayers.FormattingEnabled = true;
            this.dropDownOfPlayers.Location = new System.Drawing.Point(53, 125);
            this.dropDownOfPlayers.Name = "dropDownOfPlayers";
            this.dropDownOfPlayers.Size = new System.Drawing.Size(280, 31);
            this.dropDownOfPlayers.TabIndex = 4;
            this.dropDownOfPlayers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // linkLabelCreateNewPlayer
            // 
            this.linkLabelCreateNewPlayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateNewPlayer.Location = new System.Drawing.Point(49, 90);
            this.linkLabelCreateNewPlayer.Name = "linkLabelCreateNewPlayer";
            this.linkLabelCreateNewPlayer.Size = new System.Drawing.Size(177, 23);
            this.linkLabelCreateNewPlayer.TabIndex = 5;
            this.linkLabelCreateNewPlayer.TabStop = true;
            this.linkLabelCreateNewPlayer.Text = "Create New Player";
            this.linkLabelCreateNewPlayer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateNewPlayer_LinkClicked);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.Location = new System.Drawing.Point(339, 123);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(119, 33);
            this.addPlayerButton.TabIndex = 6;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removePlayerButton.Location = new System.Drawing.Point(53, 421);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(101, 49);
            this.removePlayerButton.TabIndex = 7;
            this.removePlayerButton.Text = "Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(511, 634);
            this.Controls.Add(this.programLabel);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.linkLabelCreateNewPlayer);
            this.Controls.Add(this.dropDownOfPlayers);
            this.Controls.Add(this.selectedPlayerListBox);
            this.Controls.Add(this.startGame_Button);
            this.MinimumSize = new System.Drawing.Size(529, 681);
            this.Name = "StartForm";
            this.Text = "StartWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label programLabel;
        private System.Windows.Forms.Button startGame_Button;
        private System.Windows.Forms.ListBox selectedPlayerListBox;
        private System.Windows.Forms.ComboBox dropDownOfPlayers;
        private System.Windows.Forms.LinkLabel linkLabelCreateNewPlayer;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
    }
}