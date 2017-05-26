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
            this.components = new System.ComponentModel.Container();
            this.candidatesTab = new System.Windows.Forms.TabPage();
            this.partiesTab = new System.Windows.Forms.TabPage();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.epollingDataSet = new Epolling.EpollingDataSet();
            this.partiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiesTableAdapter = new Epolling.EpollingDataSetTableAdapters.partiesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savePartiesButton = new System.Windows.Forms.Button();
            this.partiesTab.SuspendLayout();
            this.settingsTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epollingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).BeginInit();
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
            this.partiesTab.Controls.Add(this.savePartiesButton);
            this.partiesTab.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partiesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // epollingDataSet
            // 
            this.epollingDataSet.DataSetName = "EpollingDataSet";
            this.epollingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partiesBindingSource
            // 
            this.partiesBindingSource.DataMember = "parties";
            this.partiesBindingSource.DataSource = this.epollingDataSet;
            // 
            // partiesTableAdapter
            // 
            this.partiesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // savePartiesButton
            // 
            this.savePartiesButton.Location = new System.Drawing.Point(4, 351);
            this.savePartiesButton.Name = "savePartiesButton";
            this.savePartiesButton.Size = new System.Drawing.Size(75, 23);
            this.savePartiesButton.TabIndex = 1;
            this.savePartiesButton.Text = "Save";
            this.savePartiesButton.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.partiesTab.ResumeLayout(false);
            this.settingsTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epollingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage candidatesTab;
        private System.Windows.Forms.TabPage partiesTab;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EpollingDataSet epollingDataSet;
        private System.Windows.Forms.BindingSource partiesBindingSource;
        private EpollingDataSetTableAdapters.partiesTableAdapter partiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button savePartiesButton;
    }
}