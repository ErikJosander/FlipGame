namespace FlipIt
{
    partial class CreateUserForm
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
            this.createUserLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInputTextBox = new System.Windows.Forms.TextBox();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createUserLabel
            // 
            this.createUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserLabel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createUserLabel.Location = new System.Drawing.Point(48, 42);
            this.createUserLabel.MinimumSize = new System.Drawing.Size(300, 50);
            this.createUserLabel.Name = "createUserLabel";
            this.createUserLabel.Size = new System.Drawing.Size(300, 50);
            this.createUserLabel.TabIndex = 2;
            this.createUserLabel.Text = "Create User";
            this.createUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createUserLabel.Click += new System.EventHandler(this.createUserLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(80, 156);
            this.nameLabel.MinimumSize = new System.Drawing.Size(70, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 30);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // nameInputTextBox
            // 
            this.nameInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameInputTextBox.Location = new System.Drawing.Point(160, 159);
            this.nameInputTextBox.MinimumSize = new System.Drawing.Size(80, 20);
            this.nameInputTextBox.Name = "nameInputTextBox";
            this.nameInputTextBox.Size = new System.Drawing.Size(143, 22);
            this.nameInputTextBox.TabIndex = 3;
            this.nameInputTextBox.TextChanged += new System.EventHandler(this.nameInputTextBox_TextChanged);
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.createPlayerButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.createPlayerButton.Location = new System.Drawing.Point(48, 284);
            this.createPlayerButton.MaximumSize = new System.Drawing.Size(400, 220);
            this.createPlayerButton.MinimumSize = new System.Drawing.Size(300, 170);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(300, 170);
            this.createPlayerButton.TabIndex = 4;
            this.createPlayerButton.Text = "Create User";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 503);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.nameInputTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createUserLabel);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(414, 550);
            this.Name = "CreateUserForm";
            this.Text = "CreateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createUserLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInputTextBox;
        private System.Windows.Forms.Button createPlayerButton;
    }
}