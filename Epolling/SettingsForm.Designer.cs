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
            this.saveCandidatesButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.epollingDataSet = new Epolling.EpollingDataSet();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partiesTab = new System.Windows.Forms.TabPage();
            this.savePartiesButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.toggleElectionStatusButton = new System.Windows.Forms.Button();
            this.electionStatus = new System.Windows.Forms.Label();
            this.electionStatusLabel = new System.Windows.Forms.Label();
            this.resultsTab = new System.Windows.Forms.TabPage();
            this.partiesTableAdapter = new Epolling.EpollingDataSetTableAdapters.partiesTableAdapter();
            this.candidatesTableAdapter = new Epolling.EpollingDataSetTableAdapters.candidatesTableAdapter();
            this.candidatesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epollingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            this.partiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.settingsTabControl.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // candidatesTab
            // 
            this.candidatesTab.Controls.Add(this.saveCandidatesButton);
            this.candidatesTab.Controls.Add(this.dataGridView2);
            this.candidatesTab.Location = new System.Drawing.Point(4, 22);
            this.candidatesTab.Name = "candidatesTab";
            this.candidatesTab.Padding = new System.Windows.Forms.Padding(3);
            this.candidatesTab.Size = new System.Drawing.Size(431, 401);
            this.candidatesTab.TabIndex = 1;
            this.candidatesTab.Text = "Candidates";
            this.candidatesTab.UseVisualStyleBackColor = true;
            // 
            // saveCandidatesButton
            // 
            this.saveCandidatesButton.Location = new System.Drawing.Point(8, 361);
            this.saveCandidatesButton.Name = "saveCandidatesButton";
            this.saveCandidatesButton.Size = new System.Drawing.Size(75, 23);
            this.saveCandidatesButton.TabIndex = 1;
            this.saveCandidatesButton.Text = "Save";
            this.saveCandidatesButton.UseVisualStyleBackColor = true;
            this.saveCandidatesButton.Click += new System.EventHandler(this.saveCandidatesButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.votesDataGridViewTextBoxColumn,
            this.partyidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.candidatesBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(425, 352);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // votesDataGridViewTextBoxColumn
            // 
            this.votesDataGridViewTextBoxColumn.DataPropertyName = "votes";
            this.votesDataGridViewTextBoxColumn.HeaderText = "votes";
            this.votesDataGridViewTextBoxColumn.Name = "votesDataGridViewTextBoxColumn";
            // 
            // partyidDataGridViewTextBoxColumn
            // 
            this.partyidDataGridViewTextBoxColumn.DataPropertyName = "party_id";
            this.partyidDataGridViewTextBoxColumn.DataSource = this.partiesBindingSource;
            this.partyidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.partyidDataGridViewTextBoxColumn.HeaderText = "party_id";
            this.partyidDataGridViewTextBoxColumn.Name = "partyidDataGridViewTextBoxColumn";
            this.partyidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partyidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partyidDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // partiesBindingSource
            // 
            this.partiesBindingSource.DataMember = "parties";
            this.partiesBindingSource.DataSource = this.epollingDataSet;
            // 
            // epollingDataSet
            // 
            this.epollingDataSet.DataSetName = "EpollingDataSet";
            this.epollingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "candidates";
            this.candidatesBindingSource.DataSource = this.epollingDataSet;
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
            // savePartiesButton
            // 
            this.savePartiesButton.Location = new System.Drawing.Point(4, 351);
            this.savePartiesButton.Name = "savePartiesButton";
            this.savePartiesButton.Size = new System.Drawing.Size(75, 23);
            this.savePartiesButton.TabIndex = 1;
            this.savePartiesButton.Text = "Save";
            this.savePartiesButton.UseVisualStyleBackColor = true;
            this.savePartiesButton.Click += new System.EventHandler(this.savePartiesButton_Click);
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
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.partiesTab);
            this.settingsTabControl.Controls.Add(this.candidatesTab);
            this.settingsTabControl.Controls.Add(this.settingsTab);
            this.settingsTabControl.Controls.Add(this.resultsTab);
            this.settingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(439, 427);
            this.settingsTabControl.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.toggleElectionStatusButton);
            this.settingsTab.Controls.Add(this.electionStatus);
            this.settingsTab.Controls.Add(this.electionStatusLabel);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(431, 401);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // toggleElectionStatusButton
            // 
            this.toggleElectionStatusButton.Location = new System.Drawing.Point(197, 13);
            this.toggleElectionStatusButton.Name = "toggleElectionStatusButton";
            this.toggleElectionStatusButton.Size = new System.Drawing.Size(75, 23);
            this.toggleElectionStatusButton.TabIndex = 2;
            this.toggleElectionStatusButton.Text = "Toggle Status";
            this.toggleElectionStatusButton.UseVisualStyleBackColor = true;
            this.toggleElectionStatusButton.Click += new System.EventHandler(this.toggleElectionStatusButton_Click);
            // 
            // electionStatus
            // 
            this.electionStatus.AutoSize = true;
            this.electionStatus.Location = new System.Drawing.Point(109, 18);
            this.electionStatus.Name = "electionStatus";
            this.electionStatus.Size = new System.Drawing.Size(31, 13);
            this.electionStatus.TabIndex = 1;
            this.electionStatus.Text = "none";
            // 
            // electionStatusLabel
            // 
            this.electionStatusLabel.AutoSize = true;
            this.electionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.electionStatusLabel.Location = new System.Drawing.Point(6, 18);
            this.electionStatusLabel.Name = "electionStatusLabel";
            this.electionStatusLabel.Size = new System.Drawing.Size(97, 13);
            this.electionStatusLabel.TabIndex = 0;
            this.electionStatusLabel.Text = "Election Status:";
            // 
            // resultsTab
            // 
            this.resultsTab.Location = new System.Drawing.Point(4, 22);
            this.resultsTab.Name = "resultsTab";
            this.resultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTab.Size = new System.Drawing.Size(431, 401);
            this.resultsTab.TabIndex = 3;
            this.resultsTab.Text = "Results";
            this.resultsTab.UseVisualStyleBackColor = true;
            // 
            // partiesTableAdapter
            // 
            this.partiesTableAdapter.ClearBeforeFill = true;
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
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
            this.candidatesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epollingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            this.partiesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.settingsTabControl.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private EpollingDataSetTableAdapters.candidatesTableAdapter candidatesTableAdapter;
        private System.Windows.Forms.Button saveCandidatesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn votesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn partyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage resultsTab;
        private System.Windows.Forms.Button toggleElectionStatusButton;
        private System.Windows.Forms.Label electionStatus;
        private System.Windows.Forms.Label electionStatusLabel;
    }
}