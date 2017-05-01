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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addCandidateLabel = new System.Windows.Forms.Label();
            this.candidateNameTextbox = new System.Windows.Forms.Label();
            this.addCandidateButton = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 4;
            // 
            // addCandidateLabel
            // 
            this.addCandidateLabel.AutoSize = true;
            this.addCandidateLabel.Location = new System.Drawing.Point(239, 50);
            this.addCandidateLabel.Name = "addCandidateLabel";
            this.addCandidateLabel.Size = new System.Drawing.Size(77, 13);
            this.addCandidateLabel.TabIndex = 5;
            this.addCandidateLabel.Text = "Add Candidate";
            // 
            // candidateNameTextbox
            // 
            this.candidateNameTextbox.AutoSize = true;
            this.candidateNameTextbox.Location = new System.Drawing.Point(244, 85);
            this.candidateNameTextbox.Name = "candidateNameTextbox";
            this.candidateNameTextbox.Size = new System.Drawing.Size(35, 13);
            this.candidateNameTextbox.TabIndex = 6;
            this.candidateNameTextbox.Text = "Name";
            // 
            // addCandidateButton
            // 
            this.addCandidateButton.Location = new System.Drawing.Point(285, 109);
            this.addCandidateButton.Name = "addCandidateButton";
            this.addCandidateButton.Size = new System.Drawing.Size(75, 23);
            this.addCandidateButton.TabIndex = 7;
            this.addCandidateButton.Text = "Add";
            this.addCandidateButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 427);
            this.Controls.Add(this.addCandidateButton);
            this.Controls.Add(this.candidateNameTextbox);
            this.Controls.Add(this.addCandidateLabel);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label addCandidateLabel;
        private System.Windows.Forms.Label candidateNameTextbox;
        private System.Windows.Forms.Button addCandidateButton;
    }
}