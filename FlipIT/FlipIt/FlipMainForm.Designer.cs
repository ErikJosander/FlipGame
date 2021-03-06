﻿namespace FlipIt
{
    partial class FlipMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlipMainForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.evaluateButton = new System.Windows.Forms.Button();
            this.dicePictureOne = new System.Windows.Forms.PictureBox();
            this.dicePictureTwo = new System.Windows.Forms.PictureBox();
            this.clickBoxGroup = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.totalRollLabel = new System.Windows.Forms.Label();
            this.programLabel = new System.Windows.Forms.Label();
            this.scoreListBox = new System.Windows.Forms.ListBox();
            this.playersTurnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureTwo)).BeginInit();
            this.clickBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 639);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.evaluateButton);
            this.splitContainer1.Panel1.Controls.Add(this.dicePictureOne);
            this.splitContainer1.Panel1.Controls.Add(this.dicePictureTwo);
            this.splitContainer1.Panel1.Controls.Add(this.clickBoxGroup);
            this.splitContainer1.Panel1.Controls.Add(this.rollDiceButton);
            this.splitContainer1.Panel1.Controls.Add(this.totalRollLabel);
            this.splitContainer1.Panel1.Controls.Add(this.programLabel);
            this.splitContainer1.Panel1MinSize = 180;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scoreListBox);
            this.splitContainer1.Panel2.Controls.Add(this.playersTurnLabel);
            this.splitContainer1.Panel2MinSize = 180;
            this.splitContainer1.Size = new System.Drawing.Size(981, 639);
            this.splitContainer1.SplitterDistance = 494;
            this.splitContainer1.SplitterWidth = 20;
            this.splitContainer1.TabIndex = 1;
            // 
            // evaluateButton
            // 
            this.evaluateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.evaluateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.evaluateButton.Font = new System.Drawing.Font("Arial", 25.8F);
            this.evaluateButton.Location = new System.Drawing.Point(271, 440);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.Size = new System.Drawing.Size(205, 187);
            this.evaluateButton.TabIndex = 18;
            this.evaluateButton.Text = "End Turn";
            this.evaluateButton.UseVisualStyleBackColor = true;
            this.evaluateButton.Click += new System.EventHandler(this.evaluateButton_Click);
            // 
            // dicePictureOne
            // 
            this.dicePictureOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dicePictureOne.Image = ((System.Drawing.Image)(resources.GetObject("dicePictureOne.Image")));
            this.dicePictureOne.Location = new System.Drawing.Point(238, 82);
            this.dicePictureOne.MaximumSize = new System.Drawing.Size(141, 126);
            this.dicePictureOne.MinimumSize = new System.Drawing.Size(141, 126);
            this.dicePictureOne.Name = "dicePictureOne";
            this.dicePictureOne.Size = new System.Drawing.Size(141, 126);
            this.dicePictureOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dicePictureOne.TabIndex = 15;
            this.dicePictureOne.TabStop = false;
            // 
            // dicePictureTwo
            // 
            this.dicePictureTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dicePictureTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dicePictureTwo.Image = ((System.Drawing.Image)(resources.GetObject("dicePictureTwo.Image")));
            this.dicePictureTwo.Location = new System.Drawing.Point(89, 82);
            this.dicePictureTwo.MaximumSize = new System.Drawing.Size(141, 126);
            this.dicePictureTwo.MinimumSize = new System.Drawing.Size(141, 126);
            this.dicePictureTwo.Name = "dicePictureTwo";
            this.dicePictureTwo.Size = new System.Drawing.Size(141, 126);
            this.dicePictureTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dicePictureTwo.TabIndex = 16;
            this.dicePictureTwo.TabStop = false;
            // 
            // clickBoxGroup
            // 
            this.clickBoxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clickBoxGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clickBoxGroup.Controls.Add(this.button5);
            this.clickBoxGroup.Controls.Add(this.button9);
            this.clickBoxGroup.Controls.Add(this.button4);
            this.clickBoxGroup.Controls.Add(this.button8);
            this.clickBoxGroup.Controls.Add(this.button3);
            this.clickBoxGroup.Controls.Add(this.button7);
            this.clickBoxGroup.Controls.Add(this.button2);
            this.clickBoxGroup.Controls.Add(this.button6);
            this.clickBoxGroup.Controls.Add(this.button1);
            this.clickBoxGroup.Location = new System.Drawing.Point(16, 240);
            this.clickBoxGroup.Name = "clickBoxGroup";
            this.clickBoxGroup.Size = new System.Drawing.Size(460, 179);
            this.clickBoxGroup.TabIndex = 14;
            this.clickBoxGroup.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(354, 40);
            this.button5.MaximumSize = new System.Drawing.Size(74, 55);
            this.button5.MinimumSize = new System.Drawing.Size(74, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 55);
            this.button5.TabIndex = 2;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(310, 101);
            this.button9.MaximumSize = new System.Drawing.Size(74, 55);
            this.button9.MinimumSize = new System.Drawing.Size(74, 55);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 55);
            this.button9.TabIndex = 2;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(274, 40);
            this.button4.MaximumSize = new System.Drawing.Size(74, 55);
            this.button4.MinimumSize = new System.Drawing.Size(74, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 55);
            this.button4.TabIndex = 2;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(230, 101);
            this.button8.MaximumSize = new System.Drawing.Size(74, 55);
            this.button8.MinimumSize = new System.Drawing.Size(74, 55);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 55);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(194, 40);
            this.button3.MaximumSize = new System.Drawing.Size(74, 55);
            this.button3.MinimumSize = new System.Drawing.Size(74, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.AutoSize = true;
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(150, 101);
            this.button7.MaximumSize = new System.Drawing.Size(74, 55);
            this.button7.MinimumSize = new System.Drawing.Size(74, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 55);
            this.button7.TabIndex = 2;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(114, 40);
            this.button2.MaximumSize = new System.Drawing.Size(74, 55);
            this.button2.MinimumSize = new System.Drawing.Size(74, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(70, 101);
            this.button6.MaximumSize = new System.Drawing.Size(74, 55);
            this.button6.MinimumSize = new System.Drawing.Size(74, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 55);
            this.button6.TabIndex = 2;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(34, 40);
            this.button1.MaximumSize = new System.Drawing.Size(74, 55);
            this.button1.MinimumSize = new System.Drawing.Size(74, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rollDiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rollDiceButton.FlatAppearance.BorderSize = 5;
            this.rollDiceButton.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceButton.Location = new System.Drawing.Point(16, 440);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(193, 187);
            this.rollDiceButton.TabIndex = 13;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click_1);
            // 
            // totalRollLabel
            // 
            this.totalRollLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalRollLabel.AutoSize = true;
            this.totalRollLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRollLabel.Location = new System.Drawing.Point(154, 9);
            this.totalRollLabel.Name = "totalRollLabel";
            this.totalRollLabel.Size = new System.Drawing.Size(180, 32);
            this.totalRollLabel.TabIndex = 11;
            this.totalRollLabel.Text = "totalRollLabel";
            // 
            // programLabel
            // 
            this.programLabel.AutoSize = true;
            this.programLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programLabel.Location = new System.Drawing.Point(9, 9);
            this.programLabel.Name = "programLabel";
            this.programLabel.Size = new System.Drawing.Size(91, 32);
            this.programLabel.TabIndex = 12;
            this.programLabel.Text = "Flip IT";
            // 
            // scoreListBox
            // 
            this.scoreListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreListBox.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreListBox.FormattingEnabled = true;
            this.scoreListBox.ItemHeight = 25;
            this.scoreListBox.Location = new System.Drawing.Point(75, 82);
            this.scoreListBox.MinimumSize = new System.Drawing.Size(349, 516);
            this.scoreListBox.Name = "scoreListBox";
            this.scoreListBox.Size = new System.Drawing.Size(350, 504);
            this.scoreListBox.TabIndex = 9;
            this.scoreListBox.SelectedIndexChanged += new System.EventHandler(this.scoreListBox_SelectedIndexChanged);
            // 
            // playersTurnLabel
            // 
            this.playersTurnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersTurnLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersTurnLabel.Location = new System.Drawing.Point(75, 9);
            this.playersTurnLabel.Name = "playersTurnLabel";
            this.playersTurnLabel.Size = new System.Drawing.Size(334, 54);
            this.playersTurnLabel.TabIndex = 8;
            this.playersTurnLabel.Text = "playersTurnLabel";
            // 
            // FlipMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 678);
            this.Name = "FlipMainForm";
            this.ShowIcon = false;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FlipMainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureTwo)).EndInit();
            this.clickBoxGroup.ResumeLayout(false);
            this.clickBoxGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.PictureBox dicePictureOne;
        public System.Windows.Forms.PictureBox dicePictureTwo;
        public System.Windows.Forms.GroupBox clickBoxGroup;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button rollDiceButton;
        public System.Windows.Forms.Label totalRollLabel;
        public System.Windows.Forms.Label programLabel;
        public System.Windows.Forms.ListBox scoreListBox;
        public System.Windows.Forms.Label playersTurnLabel;
        private System.Windows.Forms.Button evaluateButton;
    }
}

