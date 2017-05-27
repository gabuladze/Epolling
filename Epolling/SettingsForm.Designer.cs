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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveUsersButton = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votingcompletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userrolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.epollingDataSet1 = new Epolling.EpollingDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveUserRolesButton = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toggleElectionStatusButton = new System.Windows.Forms.Button();
            this.electionStatus = new System.Windows.Forms.Label();
            this.electionStatusLabel = new System.Windows.Forms.Label();
            this.resultsTab = new System.Windows.Forms.TabPage();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.votesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partiesTableAdapter = new Epolling.EpollingDataSetTableAdapters.partiesTableAdapter();
            this.candidatesTableAdapter = new Epolling.EpollingDataSetTableAdapters.candidatesTableAdapter();
            this.user_rolesTableAdapter = new Epolling.EpollingDataSetTableAdapters.user_rolesTableAdapter();
            this.usersTableAdapter = new Epolling.EpollingDataSetTableAdapters.usersTableAdapter();
            this.candidatesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epollingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            this.partiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.settingsTabControl.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userrolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epollingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.resultsTab.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // candidatesTab
            // 
            this.candidatesTab.Controls.Add(this.saveCandidatesButton);
            this.candidatesTab.Controls.Add(this.dataGridView2);
            this.candidatesTab.Location = new System.Drawing.Point(4, 22);
            this.candidatesTab.Name = "candidatesTab";
            this.candidatesTab.Padding = new System.Windows.Forms.Padding(3);
            this.candidatesTab.Size = new System.Drawing.Size(518, 503);
            this.candidatesTab.TabIndex = 1;
            this.candidatesTab.Text = "Candidates";
            this.candidatesTab.UseVisualStyleBackColor = true;
            // 
            // saveCandidatesButton
            // 
            this.saveCandidatesButton.Location = new System.Drawing.Point(435, 472);
            this.saveCandidatesButton.Name = "saveCandidatesButton";
            this.saveCandidatesButton.Size = new System.Drawing.Size(75, 23);
            this.saveCandidatesButton.TabIndex = 1;
            this.saveCandidatesButton.Text = "Save";
            this.saveCandidatesButton.UseVisualStyleBackColor = true;
            this.saveCandidatesButton.Click += new System.EventHandler(this.saveCandidatesButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.votesDataGridViewTextBoxColumn,
            this.partyidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.candidatesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(512, 463);
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
            this.partiesTab.Size = new System.Drawing.Size(518, 503);
            this.partiesTab.TabIndex = 0;
            this.partiesTab.Text = "Parties";
            this.partiesTab.UseVisualStyleBackColor = true;
            // 
            // savePartiesButton
            // 
            this.savePartiesButton.Location = new System.Drawing.Point(437, 477);
            this.savePartiesButton.Name = "savePartiesButton";
            this.savePartiesButton.Size = new System.Drawing.Size(75, 23);
            this.savePartiesButton.TabIndex = 1;
            this.savePartiesButton.Text = "Save";
            this.savePartiesButton.UseVisualStyleBackColor = true;
            this.savePartiesButton.Click += new System.EventHandler(this.savePartiesButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 468);
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
            this.settingsTabControl.Size = new System.Drawing.Size(526, 529);
            this.settingsTabControl.TabIndex = 0;
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.groupBox2);
            this.settingsTab.Controls.Add(this.groupBox1);
            this.settingsTab.Controls.Add(this.toggleElectionStatusButton);
            this.settingsTab.Controls.Add(this.electionStatus);
            this.settingsTab.Controls.Add(this.electionStatusLabel);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(518, 503);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.saveUsersButton);
            this.groupBox2.Controls.Add(this.dataGridView5);
            this.groupBox2.Location = new System.Drawing.Point(9, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 221);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users";
            // 
            // saveUsersButton
            // 
            this.saveUsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveUsersButton.Location = new System.Drawing.Point(420, 192);
            this.saveUsersButton.Name = "saveUsersButton";
            this.saveUsersButton.Size = new System.Drawing.Size(75, 23);
            this.saveUsersButton.TabIndex = 2;
            this.saveUsersButton.Text = "Save";
            this.saveUsersButton.UseVisualStyleBackColor = true;
            this.saveUsersButton.Click += new System.EventHandler(this.saveUsersButton_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.idnumberDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.votingcompletedDataGridViewTextBoxColumn,
            this.roleidDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.usersBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView5.Location = new System.Drawing.Point(3, 16);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(495, 174);
            this.dataGridView5.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            // 
            // idnumberDataGridViewTextBoxColumn
            // 
            this.idnumberDataGridViewTextBoxColumn.DataPropertyName = "id_number";
            this.idnumberDataGridViewTextBoxColumn.HeaderText = "id_number";
            this.idnumberDataGridViewTextBoxColumn.Name = "idnumberDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // votingcompletedDataGridViewTextBoxColumn
            // 
            this.votingcompletedDataGridViewTextBoxColumn.DataPropertyName = "voting_completed";
            this.votingcompletedDataGridViewTextBoxColumn.HeaderText = "voting_completed";
            this.votingcompletedDataGridViewTextBoxColumn.Name = "votingcompletedDataGridViewTextBoxColumn";
            // 
            // roleidDataGridViewTextBoxColumn
            // 
            this.roleidDataGridViewTextBoxColumn.DataPropertyName = "role_id";
            this.roleidDataGridViewTextBoxColumn.DataSource = this.userrolesBindingSource;
            this.roleidDataGridViewTextBoxColumn.DisplayMember = "display_name";
            this.roleidDataGridViewTextBoxColumn.HeaderText = "role_id";
            this.roleidDataGridViewTextBoxColumn.Name = "roleidDataGridViewTextBoxColumn";
            this.roleidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roleidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roleidDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // userrolesBindingSource
            // 
            this.userrolesBindingSource.DataMember = "user_roles";
            this.userrolesBindingSource.DataSource = this.epollingDataSet1;
            // 
            // epollingDataSet1
            // 
            this.epollingDataSet1.DataSetName = "EpollingDataSet";
            this.epollingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.epollingDataSet1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.saveUserRolesButton);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Location = new System.Drawing.Point(9, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 226);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Roles";
            // 
            // saveUserRolesButton
            // 
            this.saveUserRolesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveUserRolesButton.Location = new System.Drawing.Point(420, 190);
            this.saveUserRolesButton.Name = "saveUserRolesButton";
            this.saveUserRolesButton.Size = new System.Drawing.Size(75, 23);
            this.saveUserRolesButton.TabIndex = 1;
            this.saveUserRolesButton.Text = "Save";
            this.saveUserRolesButton.UseVisualStyleBackColor = true;
            this.saveUserRolesButton.Click += new System.EventHandler(this.saveUserRolesButton_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn3,
            this.displaynameDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.userrolesBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView4.Location = new System.Drawing.Point(3, 16);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(495, 168);
            this.dataGridView4.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            // 
            // displaynameDataGridViewTextBoxColumn
            // 
            this.displaynameDataGridViewTextBoxColumn.DataPropertyName = "display_name";
            this.displaynameDataGridViewTextBoxColumn.HeaderText = "display_name";
            this.displaynameDataGridViewTextBoxColumn.Name = "displaynameDataGridViewTextBoxColumn";
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
            this.resultsTab.Controls.Add(this.fillByToolStrip);
            this.resultsTab.Controls.Add(this.dataGridView3);
            this.resultsTab.Location = new System.Drawing.Point(4, 22);
            this.resultsTab.Name = "resultsTab";
            this.resultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTab.Size = new System.Drawing.Size(518, 503);
            this.resultsTab.TabIndex = 3;
            this.resultsTab.Text = "Results";
            this.resultsTab.UseVisualStyleBackColor = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(5, 156);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(53, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.fillByToolStripButton.Text = "Refresh";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.partyidDataGridViewTextBoxColumn1,
            this.votesDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.candidatesBindingSource1;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(512, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // partyidDataGridViewTextBoxColumn1
            // 
            this.partyidDataGridViewTextBoxColumn1.DataPropertyName = "party_id";
            this.partyidDataGridViewTextBoxColumn1.DataSource = this.partiesBindingSource;
            this.partyidDataGridViewTextBoxColumn1.DisplayMember = "name";
            this.partyidDataGridViewTextBoxColumn1.HeaderText = "Party";
            this.partyidDataGridViewTextBoxColumn1.Name = "partyidDataGridViewTextBoxColumn1";
            this.partyidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.partyidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partyidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partyidDataGridViewTextBoxColumn1.ValueMember = "Id";
            // 
            // votesDataGridViewTextBoxColumn1
            // 
            this.votesDataGridViewTextBoxColumn1.DataPropertyName = "votes";
            this.votesDataGridViewTextBoxColumn1.HeaderText = "Votes";
            this.votesDataGridViewTextBoxColumn1.Name = "votesDataGridViewTextBoxColumn1";
            this.votesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // candidatesBindingSource1
            // 
            this.candidatesBindingSource1.DataMember = "candidates";
            this.candidatesBindingSource1.DataSource = this.epollingDataSet;
            // 
            // partiesTableAdapter
            // 
            this.partiesTableAdapter.ClearBeforeFill = true;
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // user_rolesTableAdapter
            // 
            this.user_rolesTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 529);
            this.Controls.Add(this.settingsTabControl);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "Settings";
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userrolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epollingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.resultsTab.ResumeLayout(false);
            this.resultsTab.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource candidatesBindingSource1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn partyidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn votesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private EpollingDataSet epollingDataSet1;
        private System.Windows.Forms.BindingSource userrolesBindingSource;
        private EpollingDataSetTableAdapters.user_rolesTableAdapter user_rolesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveUsersButton;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button saveUserRolesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private EpollingDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn votingcompletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn roleidDataGridViewTextBoxColumn;
    }
}