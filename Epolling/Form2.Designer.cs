﻿namespace Epolling
{
    partial class Form2
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.surnameTextbox = new System.Windows.Forms.TextBox();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 42);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 68);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Surname";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Enabled = false;
            this.nameTextbox.Location = new System.Drawing.Point(66, 39);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 2;
            // 
            // surnameTextbox
            // 
            this.surnameTextbox.Enabled = false;
            this.surnameTextbox.Location = new System.Drawing.Point(66, 65);
            this.surnameTextbox.Name = "surnameTextbox";
            this.surnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextbox.TabIndex = 3;
            // 
            // IdTextbox
            // 
            this.IdTextbox.Enabled = false;
            this.IdTextbox.Location = new System.Drawing.Point(66, 12);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(100, 20);
            this.IdTextbox.TabIndex = 5;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 15);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 540);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.surnameTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Epolling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox surnameTextbox;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Label idLabel;
    }
}