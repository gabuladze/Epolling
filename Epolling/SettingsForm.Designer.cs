namespace Epolling
{
    partial class SettingsForm
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
            this.candidatesListLabel = new System.Windows.Forms.Label();
            this.candidatesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // candidatesListLabel
            // 
            this.candidatesListLabel.AutoSize = true;
            this.candidatesListLabel.Location = new System.Drawing.Point(13, 13);
            this.candidatesListLabel.Name = "candidatesListLabel";
            this.candidatesListLabel.Size = new System.Drawing.Size(107, 13);
            this.candidatesListLabel.TabIndex = 0;
            this.candidatesListLabel.Text = "Edit list of candidates";
            // 
            // candidatesListBox
            // 
            this.candidatesListBox.FormattingEnabled = true;
            this.candidatesListBox.Location = new System.Drawing.Point(16, 50);
            this.candidatesListBox.Name = "candidatesListBox";
            this.candidatesListBox.Size = new System.Drawing.Size(200, 342);
            this.candidatesListBox.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 427);
            this.Controls.Add(this.candidatesListBox);
            this.Controls.Add(this.candidatesListLabel);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label candidatesListLabel;
        private System.Windows.Forms.ListBox candidatesListBox;
    }
}