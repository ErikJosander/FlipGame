namespace FlipIt
{
    partial class ShowStatisticsForm
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
            this.treeViewMatches = new System.Windows.Forms.TreeView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.getMatchesButton = new System.Windows.Forms.Button();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.selectedNodeMatch = new System.Windows.Forms.Button();
            this.specificMatchListBox = new System.Windows.Forms.ListBox();
            this.nameSearchInput = new System.Windows.Forms.TextBox();
            this.nameSearchButton = new System.Windows.Forms.Button();
            this.getAllPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewMatches
            // 
            this.treeViewMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewMatches.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewMatches.Location = new System.Drawing.Point(12, 47);
            this.treeViewMatches.MaximumSize = new System.Drawing.Size(360, 450);
            this.treeViewMatches.MinimumSize = new System.Drawing.Size(346, 300);
            this.treeViewMatches.Name = "treeViewMatches";
            this.treeViewMatches.Size = new System.Drawing.Size(360, 300);
            this.treeViewMatches.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 83);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(600, 83);
            this.dateTimePicker2.MinimumSize = new System.Drawing.Size(178, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // getMatchesButton
            // 
            this.getMatchesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getMatchesButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMatchesButton.Location = new System.Drawing.Point(398, 128);
            this.getMatchesButton.MaximumSize = new System.Drawing.Size(200, 70);
            this.getMatchesButton.MinimumSize = new System.Drawing.Size(190, 58);
            this.getMatchesButton.Name = "getMatchesButton";
            this.getMatchesButton.Size = new System.Drawing.Size(190, 70);
            this.getMatchesButton.TabIndex = 2;
            this.getMatchesButton.Text = "Get Matches";
            this.getMatchesButton.UseVisualStyleBackColor = true;
            this.getMatchesButton.Click += new System.EventHandler(this.getMatchesButton_Click);
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(395, 44);
            this.startDateLabel.MinimumSize = new System.Drawing.Size(67, 16);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(72, 16);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(597, 44);
            this.endDateLabel.MinimumSize = new System.Drawing.Size(67, 16);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(67, 16);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Date";
            // 
            // selectedNodeMatch
            // 
            this.selectedNodeMatch.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedNodeMatch.Location = new System.Drawing.Point(12, 363);
            this.selectedNodeMatch.Name = "selectedNodeMatch";
            this.selectedNodeMatch.Size = new System.Drawing.Size(360, 124);
            this.selectedNodeMatch.TabIndex = 5;
            this.selectedNodeMatch.Text = "Get Match Info";
            this.selectedNodeMatch.UseVisualStyleBackColor = true;
            this.selectedNodeMatch.Click += new System.EventHandler(this.selectedNodeMatch_Click);
            // 
            // specificMatchListBox
            // 
            this.specificMatchListBox.FormattingEnabled = true;
            this.specificMatchListBox.ItemHeight = 16;
            this.specificMatchListBox.Location = new System.Drawing.Point(398, 223);
            this.specificMatchListBox.Name = "specificMatchListBox";
            this.specificMatchListBox.Size = new System.Drawing.Size(389, 196);
            this.specificMatchListBox.TabIndex = 6;
            this.specificMatchListBox.DoubleClick += new System.EventHandler(this.specificMatchListBox_DoubleClick);
            // 
            // nameSearchInput
            // 
            this.nameSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSearchInput.Location = new System.Drawing.Point(600, 128);
            this.nameSearchInput.Name = "nameSearchInput";
            this.nameSearchInput.Size = new System.Drawing.Size(178, 22);
            this.nameSearchInput.TabIndex = 7;
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSearchButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearchButton.Location = new System.Drawing.Point(600, 156);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(178, 41);
            this.nameSearchButton.TabIndex = 8;
            this.nameSearchButton.Text = "Name Search";
            this.nameSearchButton.UseVisualStyleBackColor = true;
            this.nameSearchButton.Click += new System.EventHandler(this.nameSearchButton_Click);
            // 
            // getAllPlayerButton
            // 
            this.getAllPlayerButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllPlayerButton.Location = new System.Drawing.Point(398, 426);
            this.getAllPlayerButton.Name = "getAllPlayerButton";
            this.getAllPlayerButton.Size = new System.Drawing.Size(389, 64);
            this.getAllPlayerButton.TabIndex = 9;
            this.getAllPlayerButton.Text = "All Payers";
            this.getAllPlayerButton.UseVisualStyleBackColor = true;
            this.getAllPlayerButton.Click += new System.EventHandler(this.getAllPlayerButton_Click);
            // 
            // ShowStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 502);
            this.Controls.Add(this.getAllPlayerButton);
            this.Controls.Add(this.nameSearchButton);
            this.Controls.Add(this.nameSearchInput);
            this.Controls.Add(this.specificMatchListBox);
            this.Controls.Add(this.selectedNodeMatch);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.getMatchesButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.treeViewMatches);
            this.MinimumSize = new System.Drawing.Size(800, 540);
            this.Name = "ShowStatisticsForm";
            this.Text = "ShowStatisticsForm";
            this.Load += new System.EventHandler(this.ShowStatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMatches;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button getMatchesButton;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button selectedNodeMatch;
        private System.Windows.Forms.ListBox specificMatchListBox;
        private System.Windows.Forms.TextBox nameSearchInput;
        private System.Windows.Forms.Button nameSearchButton;
        private System.Windows.Forms.Button getAllPlayerButton;
    }
}