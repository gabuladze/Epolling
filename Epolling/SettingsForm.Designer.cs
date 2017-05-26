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
            this.candidatesTab = new System.Windows.Forms.TabPage();
            this.partiesTab = new System.Windows.Forms.TabPage();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.settingsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // candidatesTab
            // 
            this.candidatesTab.Location = new System.Drawing.Point(4, 22);
            this.candidatesTab.Name = "candidatesTab";
            this.candidatesTab.Padding = new System.Windows.Forms.Padding(3);
            this.candidatesTab.Size = new System.Drawing.Size(431, 401);
            this.candidatesTab.TabIndex = 1;
            this.candidatesTab.Text = "Candidates";
            this.candidatesTab.UseVisualStyleBackColor = true;
            // 
            // partiesTab
            // 
            this.partiesTab.Location = new System.Drawing.Point(4, 22);
            this.partiesTab.Name = "partiesTab";
            this.partiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.partiesTab.Size = new System.Drawing.Size(431, 401);
            this.partiesTab.TabIndex = 0;
            this.partiesTab.Text = "Parties";
            this.partiesTab.UseVisualStyleBackColor = true;
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.partiesTab);
            this.settingsTabControl.Controls.Add(this.candidatesTab);
            this.settingsTabControl.Controls.Add(this.settingsTab);
            this.settingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(439, 427);
            this.settingsTabControl.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(431, 401);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 427);
            this.Controls.Add(this.settingsTabControl);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "SettingsForm";
            this.settingsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage candidatesTab;
        private System.Windows.Forms.TabPage partiesTab;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage settingsTab;
    }
}