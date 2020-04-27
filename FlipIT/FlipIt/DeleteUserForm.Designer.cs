namespace FlipIt
{
    partial class DeleteUserForm
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
            this.DeleteUserLabel = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteUserLabel
            // 
            this.DeleteUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteUserLabel.Font = new System.Drawing.Font("Arial", 20F);
            this.DeleteUserLabel.Location = new System.Drawing.Point(104, 21);
            this.DeleteUserLabel.Name = "DeleteUserLabel";
            this.DeleteUserLabel.Size = new System.Drawing.Size(190, 39);
            this.DeleteUserLabel.TabIndex = 0;
            this.DeleteUserLabel.Text = "Delete user";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 16;
            this.userListBox.Location = new System.Drawing.Point(111, 99);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(183, 260);
            this.userListBox.TabIndex = 1;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(111, 376);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(183, 78);
            this.deleteUserButton.TabIndex = 2;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.DeleteUserLabel);
            this.MaximumSize = new System.Drawing.Size(650, 750);
            this.MinimumSize = new System.Drawing.Size(450, 550);
            this.Name = "DeleteUserForm";
            this.Text = "DeleteUserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DeleteUserLabel;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Button deleteUserButton;
    }
}