namespace MainForm {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.playersSaveMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsSaveMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.playersLoadMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsLoadMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.enrolmentsTab = new System.Windows.Forms.TabPage();
            this.selectEnrolTeamText = new System.Windows.Forms.TextBox();
            this.selectEnrolTeamLabel = new System.Windows.Forms.Label();
            this.selectEnrolPlayerLabel = new System.Windows.Forms.Label();
            this.selectEnrolPlayerText = new System.Windows.Forms.TextBox();
            this.confirmEnrolmentButton = new System.Windows.Forms.Button();
            this.teamEnrolLabel = new System.Windows.Forms.Label();
            this.playerEnrolLabel = new System.Windows.Forms.Label();
            this.teamEnrolListView = new System.Windows.Forms.ListView();
            this.teamEnrolColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerEnrolListView = new System.Windows.Forms.ListView();
            this.playerEnrolNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerEnrolTeamColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamTab = new System.Windows.Forms.TabPage();
            this.rosterListView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teamListView = new System.Windows.Forms.ListView();
            this.teamNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groundColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coachNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearFoundedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playersTab = new System.Windows.Forms.TabPage();
            this.teamDetailsRegionDisplay = new System.Windows.Forms.Label();
            this.teamDetailsYearDisplay = new System.Windows.Forms.Label();
            this.teamDetailsCoachDisplay = new System.Windows.Forms.Label();
            this.teamDetailsGroundDisplay = new System.Windows.Forms.Label();
            this.teamDetailsNameDisplay = new System.Windows.Forms.Label();
            this.teamDetailsRegionLabel = new System.Windows.Forms.Label();
            this.teamDetailsYearLabel = new System.Windows.Forms.Label();
            this.teamDetailsGroundLabel = new System.Windows.Forms.Label();
            this.teamDetailsCoachLabel = new System.Windows.Forms.Label();
            this.teamDetailsNameLabel = new System.Windows.Forms.Label();
            this.teamDetailsLabel = new System.Windows.Forms.Label();
            this.playersLabel = new System.Windows.Forms.Label();
            this.playersListView = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOBColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.POBColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainFormTabController = new System.Windows.Forms.TabControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.POBSearchBy = new System.Windows.Forms.RadioButton();
            this.searchByLabel = new System.Windows.Forms.Label();
            this.searchAge = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.searchDisplayListView = new System.Windows.Forms.ListView();
            this.searchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageChartTab = new System.Windows.Forms.TabPage();
            this.ageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.heightWeightChartTab = new System.Windows.Forms.TabPage();
            this.heightWeightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            this.enrolmentsTab.SuspendLayout();
            this.teamTab.SuspendLayout();
            this.playersTab.SuspendLayout();
            this.mainFormTabController.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.ageChartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).BeginInit();
            this.heightWeightChartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightWeightChart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuTool,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuTool
            // 
            this.fileMenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuTool,
            this.loadMenuTool,
            this.exitMenuTool});
            this.fileMenuTool.Name = "fileMenuTool";
            this.fileMenuTool.Size = new System.Drawing.Size(44, 24);
            this.fileMenuTool.Text = "File";
            // 
            // saveMenuTool
            // 
            this.saveMenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersSaveMenuTool,
            this.teamsSaveMenuTool});
            this.saveMenuTool.Name = "saveMenuTool";
            this.saveMenuTool.Size = new System.Drawing.Size(126, 26);
            this.saveMenuTool.Text = "Save...";
            // 
            // playersSaveMenuTool
            // 
            this.playersSaveMenuTool.Name = "playersSaveMenuTool";
            this.playersSaveMenuTool.Size = new System.Drawing.Size(130, 26);
            this.playersSaveMenuTool.Text = "Players";
            this.playersSaveMenuTool.Click += new System.EventHandler(this.playersSaveMenuTool_Click);
            // 
            // teamsSaveMenuTool
            // 
            this.teamsSaveMenuTool.Name = "teamsSaveMenuTool";
            this.teamsSaveMenuTool.Size = new System.Drawing.Size(130, 26);
            this.teamsSaveMenuTool.Text = "Teams";
            this.teamsSaveMenuTool.Click += new System.EventHandler(this.teamsSaveMenuTool_Click);
            // 
            // loadMenuTool
            // 
            this.loadMenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersLoadMenuTool,
            this.teamsLoadMenuTool});
            this.loadMenuTool.Name = "loadMenuTool";
            this.loadMenuTool.Size = new System.Drawing.Size(126, 26);
            this.loadMenuTool.Text = "Load...";
            // 
            // playersLoadMenuTool
            // 
            this.playersLoadMenuTool.Name = "playersLoadMenuTool";
            this.playersLoadMenuTool.Size = new System.Drawing.Size(130, 26);
            this.playersLoadMenuTool.Text = "Players";
            this.playersLoadMenuTool.Click += new System.EventHandler(this.playersLoadMenuTool_Click);
            // 
            // teamsLoadMenuTool
            // 
            this.teamsLoadMenuTool.Name = "teamsLoadMenuTool";
            this.teamsLoadMenuTool.Size = new System.Drawing.Size(130, 26);
            this.teamsLoadMenuTool.Text = "Teams";
            this.teamsLoadMenuTool.Click += new System.EventHandler(this.teamsLoadMenuTool_Click);
            // 
            // exitMenuTool
            // 
            this.exitMenuTool.Name = "exitMenuTool";
            this.exitMenuTool.Size = new System.Drawing.Size(126, 26);
            this.exitMenuTool.Text = "Exit";
            this.exitMenuTool.Click += new System.EventHandler(this.exitMenuTool_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerMenuTool,
            this.addTeamMenuTool});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addPlayerMenuTool
            // 
            this.addPlayerMenuTool.Name = "addPlayerMenuTool";
            this.addPlayerMenuTool.Size = new System.Drawing.Size(124, 26);
            this.addPlayerMenuTool.Text = "Player";
            this.addPlayerMenuTool.Click += new System.EventHandler(this.addPlayerMenuTool_Click);
            // 
            // addTeamMenuTool
            // 
            this.addTeamMenuTool.Name = "addTeamMenuTool";
            this.addTeamMenuTool.Size = new System.Drawing.Size(124, 26);
            this.addTeamMenuTool.Text = "Team";
            this.addTeamMenuTool.Click += new System.EventHandler(this.addTeamMenuTool_Click);
            // 
            // enrolmentsTab
            // 
            this.enrolmentsTab.Controls.Add(this.selectEnrolTeamText);
            this.enrolmentsTab.Controls.Add(this.selectEnrolTeamLabel);
            this.enrolmentsTab.Controls.Add(this.selectEnrolPlayerLabel);
            this.enrolmentsTab.Controls.Add(this.selectEnrolPlayerText);
            this.enrolmentsTab.Controls.Add(this.confirmEnrolmentButton);
            this.enrolmentsTab.Controls.Add(this.teamEnrolLabel);
            this.enrolmentsTab.Controls.Add(this.playerEnrolLabel);
            this.enrolmentsTab.Controls.Add(this.teamEnrolListView);
            this.enrolmentsTab.Controls.Add(this.playerEnrolListView);
            this.enrolmentsTab.Location = new System.Drawing.Point(4, 25);
            this.enrolmentsTab.Name = "enrolmentsTab";
            this.enrolmentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.enrolmentsTab.Size = new System.Drawing.Size(1080, 595);
            this.enrolmentsTab.TabIndex = 3;
            this.enrolmentsTab.Text = "Enrolments";
            this.enrolmentsTab.UseVisualStyleBackColor = true;
            // 
            // selectEnrolTeamText
            // 
            this.selectEnrolTeamText.Location = new System.Drawing.Point(647, 195);
            this.selectEnrolTeamText.Name = "selectEnrolTeamText";
            this.selectEnrolTeamText.ReadOnly = true;
            this.selectEnrolTeamText.Size = new System.Drawing.Size(126, 22);
            this.selectEnrolTeamText.TabIndex = 10;
            // 
            // selectEnrolTeamLabel
            // 
            this.selectEnrolTeamLabel.AutoSize = true;
            this.selectEnrolTeamLabel.Location = new System.Drawing.Point(644, 158);
            this.selectEnrolTeamLabel.Name = "selectEnrolTeamLabel";
            this.selectEnrolTeamLabel.Size = new System.Drawing.Size(48, 17);
            this.selectEnrolTeamLabel.TabIndex = 9;
            this.selectEnrolTeamLabel.Text = "Team:";
            // 
            // selectEnrolPlayerLabel
            // 
            this.selectEnrolPlayerLabel.AutoSize = true;
            this.selectEnrolPlayerLabel.Location = new System.Drawing.Point(644, 76);
            this.selectEnrolPlayerLabel.Name = "selectEnrolPlayerLabel";
            this.selectEnrolPlayerLabel.Size = new System.Drawing.Size(52, 17);
            this.selectEnrolPlayerLabel.TabIndex = 8;
            this.selectEnrolPlayerLabel.Text = "Player:";
            // 
            // selectEnrolPlayerText
            // 
            this.selectEnrolPlayerText.Location = new System.Drawing.Point(647, 112);
            this.selectEnrolPlayerText.Name = "selectEnrolPlayerText";
            this.selectEnrolPlayerText.ReadOnly = true;
            this.selectEnrolPlayerText.Size = new System.Drawing.Size(125, 22);
            this.selectEnrolPlayerText.TabIndex = 7;
            // 
            // confirmEnrolmentButton
            // 
            this.confirmEnrolmentButton.Location = new System.Drawing.Point(647, 258);
            this.confirmEnrolmentButton.Name = "confirmEnrolmentButton";
            this.confirmEnrolmentButton.Size = new System.Drawing.Size(126, 64);
            this.confirmEnrolmentButton.TabIndex = 6;
            this.confirmEnrolmentButton.Text = "Enrol";
            this.confirmEnrolmentButton.UseVisualStyleBackColor = true;
            this.confirmEnrolmentButton.Click += new System.EventHandler(this.confirmEnrolmentButton_Click);
            // 
            // teamEnrolLabel
            // 
            this.teamEnrolLabel.AutoSize = true;
            this.teamEnrolLabel.Location = new System.Drawing.Point(387, 26);
            this.teamEnrolLabel.Name = "teamEnrolLabel";
            this.teamEnrolLabel.Size = new System.Drawing.Size(55, 17);
            this.teamEnrolLabel.TabIndex = 5;
            this.teamEnrolLabel.Text = "Teams:";
            // 
            // playerEnrolLabel
            // 
            this.playerEnrolLabel.AutoSize = true;
            this.playerEnrolLabel.Location = new System.Drawing.Point(44, 26);
            this.playerEnrolLabel.Name = "playerEnrolLabel";
            this.playerEnrolLabel.Size = new System.Drawing.Size(59, 17);
            this.playerEnrolLabel.TabIndex = 4;
            this.playerEnrolLabel.Text = "Players:";
            // 
            // teamEnrolListView
            // 
            this.teamEnrolListView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.teamEnrolListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teamEnrolColumn});
            this.teamEnrolListView.FullRowSelect = true;
            this.teamEnrolListView.GridLines = true;
            this.teamEnrolListView.HideSelection = false;
            this.teamEnrolListView.Location = new System.Drawing.Point(390, 60);
            this.teamEnrolListView.Name = "teamEnrolListView";
            this.teamEnrolListView.Size = new System.Drawing.Size(138, 414);
            this.teamEnrolListView.TabIndex = 3;
            this.teamEnrolListView.UseCompatibleStateImageBehavior = false;
            this.teamEnrolListView.View = System.Windows.Forms.View.Details;
            this.teamEnrolListView.SelectedIndexChanged += new System.EventHandler(this.teamEnrolListView_SelectedIndexChanged);
            // 
            // teamEnrolColumn
            // 
            this.teamEnrolColumn.Text = "Team Name";
            this.teamEnrolColumn.Width = 100;
            // 
            // playerEnrolListView
            // 
            this.playerEnrolListView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.playerEnrolListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerEnrolNameColumn,
            this.playerEnrolTeamColumn});
            this.playerEnrolListView.FullRowSelect = true;
            this.playerEnrolListView.GridLines = true;
            this.playerEnrolListView.HideSelection = false;
            this.playerEnrolListView.Location = new System.Drawing.Point(47, 60);
            this.playerEnrolListView.Name = "playerEnrolListView";
            this.playerEnrolListView.Size = new System.Drawing.Size(263, 414);
            this.playerEnrolListView.TabIndex = 0;
            this.playerEnrolListView.UseCompatibleStateImageBehavior = false;
            this.playerEnrolListView.View = System.Windows.Forms.View.Details;
            this.playerEnrolListView.SelectedIndexChanged += new System.EventHandler(this.playerEnrolListView_SelectedIndexChanged);
            // 
            // playerEnrolNameColumn
            // 
            this.playerEnrolNameColumn.Text = "Name";
            this.playerEnrolNameColumn.Width = 100;
            // 
            // playerEnrolTeamColumn
            // 
            this.playerEnrolTeamColumn.Text = "Team";
            this.playerEnrolTeamColumn.Width = 100;
            // 
            // teamTab
            // 
            this.teamTab.Controls.Add(this.rosterListView);
            this.teamTab.Controls.Add(this.label2);
            this.teamTab.Controls.Add(this.label1);
            this.teamTab.Controls.Add(this.teamListView);
            this.teamTab.Location = new System.Drawing.Point(4, 25);
            this.teamTab.Name = "teamTab";
            this.teamTab.Padding = new System.Windows.Forms.Padding(3);
            this.teamTab.Size = new System.Drawing.Size(1080, 595);
            this.teamTab.TabIndex = 1;
            this.teamTab.Text = "Teams";
            this.teamTab.UseVisualStyleBackColor = true;
            // 
            // rosterListView
            // 
            this.rosterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
            this.rosterListView.FullRowSelect = true;
            this.rosterListView.GridLines = true;
            this.rosterListView.Location = new System.Drawing.Point(846, 48);
            this.rosterListView.Name = "rosterListView";
            this.rosterListView.Size = new System.Drawing.Size(190, 450);
            this.rosterListView.TabIndex = 3;
            this.rosterListView.UseCompatibleStateImageBehavior = false;
            this.rosterListView.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 212;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(843, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player List:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teams:";
            // 
            // teamListView
            // 
            this.teamListView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.teamListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teamNameColumn,
            this.groundColumn,
            this.coachNameColumn,
            this.yearFoundedColumn,
            this.regionColumn});
            this.teamListView.FullRowSelect = true;
            this.teamListView.GridLines = true;
            this.teamListView.Location = new System.Drawing.Point(46, 48);
            this.teamListView.Name = "teamListView";
            this.teamListView.Size = new System.Drawing.Size(736, 451);
            this.teamListView.TabIndex = 0;
            this.teamListView.UseCompatibleStateImageBehavior = false;
            this.teamListView.View = System.Windows.Forms.View.Details;
            this.teamListView.SelectedIndexChanged += new System.EventHandler(this.teamListView_SelectedIndexChanged);
            // 
            // teamNameColumn
            // 
            this.teamNameColumn.Text = "Name";
            this.teamNameColumn.Width = 100;
            // 
            // groundColumn
            // 
            this.groundColumn.Text = "Ground";
            this.groundColumn.Width = 120;
            // 
            // coachNameColumn
            // 
            this.coachNameColumn.Text = "Coach";
            this.coachNameColumn.Width = 120;
            // 
            // yearFoundedColumn
            // 
            this.yearFoundedColumn.Text = "Year Founded";
            this.yearFoundedColumn.Width = 100;
            // 
            // regionColumn
            // 
            this.regionColumn.Text = "Region";
            this.regionColumn.Width = 120;
            // 
            // playersTab
            // 
            this.playersTab.Controls.Add(this.teamDetailsRegionDisplay);
            this.playersTab.Controls.Add(this.teamDetailsYearDisplay);
            this.playersTab.Controls.Add(this.teamDetailsCoachDisplay);
            this.playersTab.Controls.Add(this.teamDetailsGroundDisplay);
            this.playersTab.Controls.Add(this.teamDetailsNameDisplay);
            this.playersTab.Controls.Add(this.teamDetailsRegionLabel);
            this.playersTab.Controls.Add(this.teamDetailsYearLabel);
            this.playersTab.Controls.Add(this.teamDetailsGroundLabel);
            this.playersTab.Controls.Add(this.teamDetailsCoachLabel);
            this.playersTab.Controls.Add(this.teamDetailsNameLabel);
            this.playersTab.Controls.Add(this.teamDetailsLabel);
            this.playersTab.Controls.Add(this.playersLabel);
            this.playersTab.Controls.Add(this.playersListView);
            this.playersTab.Location = new System.Drawing.Point(4, 25);
            this.playersTab.Name = "playersTab";
            this.playersTab.Padding = new System.Windows.Forms.Padding(3);
            this.playersTab.Size = new System.Drawing.Size(1080, 583);
            this.playersTab.TabIndex = 0;
            this.playersTab.Text = "Players";
            this.playersTab.UseVisualStyleBackColor = true;
            // 
            // teamDetailsRegionDisplay
            // 
            this.teamDetailsRegionDisplay.AutoSize = true;
            this.teamDetailsRegionDisplay.Location = new System.Drawing.Point(857, 266);
            this.teamDetailsRegionDisplay.Name = "teamDetailsRegionDisplay";
            this.teamDetailsRegionDisplay.Size = new System.Drawing.Size(96, 17);
            this.teamDetailsRegionDisplay.TabIndex = 12;
            this.teamDetailsRegionDisplay.Text = "region display";
            // 
            // teamDetailsYearDisplay
            // 
            this.teamDetailsYearDisplay.AutoSize = true;
            this.teamDetailsYearDisplay.Location = new System.Drawing.Point(857, 218);
            this.teamDetailsYearDisplay.Name = "teamDetailsYearDisplay";
            this.teamDetailsYearDisplay.Size = new System.Drawing.Size(84, 17);
            this.teamDetailsYearDisplay.TabIndex = 11;
            this.teamDetailsYearDisplay.Text = "year display";
            // 
            // teamDetailsCoachDisplay
            // 
            this.teamDetailsCoachDisplay.AutoSize = true;
            this.teamDetailsCoachDisplay.Location = new System.Drawing.Point(857, 171);
            this.teamDetailsCoachDisplay.Name = "teamDetailsCoachDisplay";
            this.teamDetailsCoachDisplay.Size = new System.Drawing.Size(94, 17);
            this.teamDetailsCoachDisplay.TabIndex = 10;
            this.teamDetailsCoachDisplay.Text = "coach display";
            // 
            // teamDetailsGroundDisplay
            // 
            this.teamDetailsGroundDisplay.AutoSize = true;
            this.teamDetailsGroundDisplay.Location = new System.Drawing.Point(857, 126);
            this.teamDetailsGroundDisplay.Name = "teamDetailsGroundDisplay";
            this.teamDetailsGroundDisplay.Size = new System.Drawing.Size(101, 17);
            this.teamDetailsGroundDisplay.TabIndex = 9;
            this.teamDetailsGroundDisplay.Text = "ground display";
            // 
            // teamDetailsNameDisplay
            // 
            this.teamDetailsNameDisplay.AutoSize = true;
            this.teamDetailsNameDisplay.Location = new System.Drawing.Point(857, 78);
            this.teamDetailsNameDisplay.Name = "teamDetailsNameDisplay";
            this.teamDetailsNameDisplay.Size = new System.Drawing.Size(91, 17);
            this.teamDetailsNameDisplay.TabIndex = 8;
            this.teamDetailsNameDisplay.Text = "name display";
            // 
            // teamDetailsRegionLabel
            // 
            this.teamDetailsRegionLabel.AutoSize = true;
            this.teamDetailsRegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDetailsRegionLabel.Location = new System.Drawing.Point(727, 266);
            this.teamDetailsRegionLabel.Name = "teamDetailsRegionLabel";
            this.teamDetailsRegionLabel.Size = new System.Drawing.Size(64, 17);
            this.teamDetailsRegionLabel.TabIndex = 7;
            this.teamDetailsRegionLabel.Text = "Region:";
            // 
            // teamDetailsYearLabel
            // 
            this.teamDetailsYearLabel.AutoSize = true;
            this.teamDetailsYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDetailsYearLabel.Location = new System.Drawing.Point(727, 218);
            this.teamDetailsYearLabel.Name = "teamDetailsYearLabel";
            this.teamDetailsYearLabel.Size = new System.Drawing.Size(115, 17);
            this.teamDetailsYearLabel.TabIndex = 6;
            this.teamDetailsYearLabel.Text = "Year Founded:";
            // 
            // teamDetailsGroundLabel
            // 
            this.teamDetailsGroundLabel.AutoSize = true;
            this.teamDetailsGroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDetailsGroundLabel.Location = new System.Drawing.Point(727, 126);
            this.teamDetailsGroundLabel.Name = "teamDetailsGroundLabel";
            this.teamDetailsGroundLabel.Size = new System.Drawing.Size(67, 17);
            this.teamDetailsGroundLabel.TabIndex = 5;
            this.teamDetailsGroundLabel.Text = "Ground:";
            // 
            // teamDetailsCoachLabel
            // 
            this.teamDetailsCoachLabel.AutoSize = true;
            this.teamDetailsCoachLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDetailsCoachLabel.Location = new System.Drawing.Point(727, 171);
            this.teamDetailsCoachLabel.Name = "teamDetailsCoachLabel";
            this.teamDetailsCoachLabel.Size = new System.Drawing.Size(58, 17);
            this.teamDetailsCoachLabel.TabIndex = 4;
            this.teamDetailsCoachLabel.Text = "Coach:";
            // 
            // teamDetailsNameLabel
            // 
            this.teamDetailsNameLabel.AutoSize = true;
            this.teamDetailsNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDetailsNameLabel.Location = new System.Drawing.Point(727, 78);
            this.teamDetailsNameLabel.Name = "teamDetailsNameLabel";
            this.teamDetailsNameLabel.Size = new System.Drawing.Size(54, 17);
            this.teamDetailsNameLabel.TabIndex = 3;
            this.teamDetailsNameLabel.Text = "Name:";
            // 
            // teamDetailsLabel
            // 
            this.teamDetailsLabel.AutoSize = true;
            this.teamDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDetailsLabel.Location = new System.Drawing.Point(815, 23);
            this.teamDetailsLabel.Name = "teamDetailsLabel";
            this.teamDetailsLabel.Size = new System.Drawing.Size(175, 29);
            this.teamDetailsLabel.TabIndex = 2;
            this.teamDetailsLabel.Text = "Team Details:";
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersLabel.Location = new System.Drawing.Point(29, 23);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(151, 17);
            this.playersLabel.TabIndex = 1;
            this.playersLabel.Text = "Registered Players:";
            // 
            // playersListView
            // 
            this.playersListView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.playersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.nameColumn,
            this.DOBColumn,
            this.heightColumn,
            this.weightColumn,
            this.POBColumn,
            this.teamColumn});
            this.playersListView.FullRowSelect = true;
            this.playersListView.GridLines = true;
            this.playersListView.Location = new System.Drawing.Point(32, 56);
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(671, 439);
            this.playersListView.TabIndex = 0;
            this.playersListView.UseCompatibleStateImageBehavior = false;
            this.playersListView.View = System.Windows.Forms.View.Details;
            this.playersListView.SelectedIndexChanged += new System.EventHandler(this.playersListView_SelectedIndexChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            this.IDColumn.Width = 70;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 100;
            // 
            // DOBColumn
            // 
            this.DOBColumn.Text = "Date of Birth";
            this.DOBColumn.Width = 100;
            // 
            // heightColumn
            // 
            this.heightColumn.Text = "Height";
            this.heightColumn.Width = 70;
            // 
            // weightColumn
            // 
            this.weightColumn.Text = "Weight";
            this.weightColumn.Width = 70;
            // 
            // POBColumn
            // 
            this.POBColumn.Text = "Place of Birth";
            this.POBColumn.Width = 120;
            // 
            // teamColumn
            // 
            this.teamColumn.Text = "Team";
            this.teamColumn.Width = 100;
            // 
            // mainFormTabController
            // 
            this.mainFormTabController.Controls.Add(this.playersTab);
            this.mainFormTabController.Controls.Add(this.teamTab);
            this.mainFormTabController.Controls.Add(this.enrolmentsTab);
            this.mainFormTabController.Controls.Add(this.searchTab);
            this.mainFormTabController.Controls.Add(this.ageChartTab);
            this.mainFormTabController.Controls.Add(this.heightWeightChartTab);
            this.mainFormTabController.Location = new System.Drawing.Point(28, 44);
            this.mainFormTabController.Name = "mainFormTabController";
            this.mainFormTabController.SelectedIndex = 0;
            this.mainFormTabController.Size = new System.Drawing.Size(1088, 612);
            this.mainFormTabController.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainFormTabController.TabIndex = 0;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchButton);
            this.searchTab.Controls.Add(this.searchText);
            this.searchTab.Controls.Add(this.POBSearchBy);
            this.searchTab.Controls.Add(this.searchByLabel);
            this.searchTab.Controls.Add(this.searchAge);
            this.searchTab.Controls.Add(this.label3);
            this.searchTab.Controls.Add(this.searchDisplayListView);
            this.searchTab.Location = new System.Drawing.Point(4, 25);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(1080, 595);
            this.searchTab.TabIndex = 4;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(50, 208);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(30, 165);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(294, 22);
            this.searchText.TabIndex = 5;
            // 
            // POBSearchBy
            // 
            this.POBSearchBy.AutoSize = true;
            this.POBSearchBy.Location = new System.Drawing.Point(50, 127);
            this.POBSearchBy.Name = "POBSearchBy";
            this.POBSearchBy.Size = new System.Drawing.Size(113, 21);
            this.POBSearchBy.TabIndex = 4;
            this.POBSearchBy.TabStop = true;
            this.POBSearchBy.Text = "Place of Birth";
            this.POBSearchBy.UseVisualStyleBackColor = true;
            // 
            // searchByLabel
            // 
            this.searchByLabel.AutoSize = true;
            this.searchByLabel.Location = new System.Drawing.Point(27, 68);
            this.searchByLabel.Name = "searchByLabel";
            this.searchByLabel.Size = new System.Drawing.Size(77, 17);
            this.searchByLabel.TabIndex = 3;
            this.searchByLabel.Text = "Search By:";
            // 
            // searchAge
            // 
            this.searchAge.AutoSize = true;
            this.searchAge.Location = new System.Drawing.Point(50, 100);
            this.searchAge.Name = "searchAge";
            this.searchAge.Size = new System.Drawing.Size(54, 21);
            this.searchAge.TabIndex = 2;
            this.searchAge.TabStop = true;
            this.searchAge.Text = "Age";
            this.searchAge.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search for Players";
            // 
            // searchDisplayListView
            // 
            this.searchDisplayListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.searchName});
            this.searchDisplayListView.FullRowSelect = true;
            this.searchDisplayListView.GridLines = true;
            this.searchDisplayListView.Location = new System.Drawing.Point(405, 28);
            this.searchDisplayListView.Name = "searchDisplayListView";
            this.searchDisplayListView.Size = new System.Drawing.Size(191, 442);
            this.searchDisplayListView.TabIndex = 0;
            this.searchDisplayListView.UseCompatibleStateImageBehavior = false;
            this.searchDisplayListView.View = System.Windows.Forms.View.Details;
            // 
            // searchName
            // 
            this.searchName.Text = "Player Name";
            this.searchName.Width = 182;
            // 
            // ageChartTab
            // 
            this.ageChartTab.Controls.Add(this.ageChart);
            this.ageChartTab.Location = new System.Drawing.Point(4, 25);
            this.ageChartTab.Name = "ageChartTab";
            this.ageChartTab.Padding = new System.Windows.Forms.Padding(3);
            this.ageChartTab.Size = new System.Drawing.Size(1080, 595);
            this.ageChartTab.TabIndex = 5;
            this.ageChartTab.Text = "Chart - Age";
            this.ageChartTab.UseVisualStyleBackColor = true;
            // 
            // ageChart
            // 
            chartArea1.AxisX.Title = "Age Groups";
            chartArea1.AxisY.Title = "Number of Players";
            chartArea1.Name = "ChartArea1";
            this.ageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ageChart.Legends.Add(legend1);
            this.ageChart.Location = new System.Drawing.Point(71, 43);
            this.ageChart.Name = "ageChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Age";
            this.ageChart.Series.Add(series1);
            this.ageChart.Size = new System.Drawing.Size(949, 502);
            this.ageChart.TabIndex = 0;
            this.ageChart.Text = "Age of Players";
            // 
            // heightWeightChartTab
            // 
            this.heightWeightChartTab.Controls.Add(this.heightWeightChart);
            this.heightWeightChartTab.Location = new System.Drawing.Point(4, 25);
            this.heightWeightChartTab.Name = "heightWeightChartTab";
            this.heightWeightChartTab.Padding = new System.Windows.Forms.Padding(3);
            this.heightWeightChartTab.Size = new System.Drawing.Size(1080, 583);
            this.heightWeightChartTab.TabIndex = 6;
            this.heightWeightChartTab.Text = "Chart - Height & Weight";
            this.heightWeightChartTab.UseVisualStyleBackColor = true;
            // 
            // heightWeightChart
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.Title = "Players";
            chartArea2.AxisY.Title = "Height (cm) and Weight (Kg)";
            chartArea2.AxisY2.Title = "Weight (Kg)";
            chartArea2.Name = "Players";
            this.heightWeightChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.heightWeightChart.Legends.Add(legend2);
            this.heightWeightChart.Location = new System.Drawing.Point(74, 30);
            this.heightWeightChart.Name = "heightWeightChart";
            series2.ChartArea = "Players";
            series2.Legend = "Legend1";
            series2.Name = "Height";
            series3.ChartArea = "Players";
            series3.Legend = "Legend1";
            series3.Name = "Weight";
            this.heightWeightChart.Series.Add(series2);
            this.heightWeightChart.Series.Add(series3);
            this.heightWeightChart.Size = new System.Drawing.Size(896, 547);
            this.heightWeightChart.TabIndex = 0;
            this.heightWeightChart.Text = "Height and Weight of Players";
            title1.Name = "Height and Weight of Players";
            this.heightWeightChart.Titles.Add(title1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 693);
            this.Controls.Add(this.mainFormTabController);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.enrolmentsTab.ResumeLayout(false);
            this.enrolmentsTab.PerformLayout();
            this.teamTab.ResumeLayout(false);
            this.teamTab.PerformLayout();
            this.playersTab.ResumeLayout(false);
            this.playersTab.PerformLayout();
            this.mainFormTabController.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.searchTab.PerformLayout();
            this.ageChartTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).EndInit();
            this.heightWeightChartTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heightWeightChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuTool;
        private System.Windows.Forms.ToolStripMenuItem saveMenuTool;
        private System.Windows.Forms.ToolStripMenuItem loadMenuTool;
        private System.Windows.Forms.ToolStripMenuItem exitMenuTool;
        private System.Windows.Forms.ToolStripMenuItem playersSaveMenuTool;
        private System.Windows.Forms.ToolStripMenuItem teamsSaveMenuTool;
        private System.Windows.Forms.ToolStripMenuItem playersLoadMenuTool;
        private System.Windows.Forms.ToolStripMenuItem teamsLoadMenuTool;
        private System.Windows.Forms.TabPage enrolmentsTab;
        private System.Windows.Forms.TabPage teamTab;
        private System.Windows.Forms.TabPage playersTab;
        private System.Windows.Forms.ListView playersListView;
        private System.Windows.Forms.ColumnHeader IDColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader DOBColumn;
        private System.Windows.Forms.ColumnHeader heightColumn;
        private System.Windows.Forms.ColumnHeader weightColumn;
        private System.Windows.Forms.ColumnHeader POBColumn;
        private System.Windows.Forms.ColumnHeader teamColumn;
        private System.Windows.Forms.TabControl mainFormTabController;
        private System.Windows.Forms.ListView teamListView;
        private System.Windows.Forms.ColumnHeader teamNameColumn;
        private System.Windows.Forms.ColumnHeader groundColumn;
        private System.Windows.Forms.ColumnHeader coachNameColumn;
        private System.Windows.Forms.ColumnHeader yearFoundedColumn;
        private System.Windows.Forms.ColumnHeader regionColumn;
        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerMenuTool;
        private System.Windows.Forms.ToolStripMenuItem addTeamMenuTool;
        private System.Windows.Forms.ListView teamEnrolListView;
        private System.Windows.Forms.ColumnHeader teamEnrolColumn;
        private System.Windows.Forms.ListView playerEnrolListView;
        private System.Windows.Forms.ColumnHeader playerEnrolNameColumn;
        private System.Windows.Forms.ColumnHeader playerEnrolTeamColumn;
        private System.Windows.Forms.Label teamEnrolLabel;
        private System.Windows.Forms.Label playerEnrolLabel;
        private System.Windows.Forms.Button confirmEnrolmentButton;
        private System.Windows.Forms.TextBox selectEnrolPlayerText;
        private System.Windows.Forms.TextBox selectEnrolTeamText;
        private System.Windows.Forms.Label selectEnrolTeamLabel;
        private System.Windows.Forms.Label selectEnrolPlayerLabel;
        private System.Windows.Forms.Label teamDetailsRegionLabel;
        private System.Windows.Forms.Label teamDetailsYearLabel;
        private System.Windows.Forms.Label teamDetailsGroundLabel;
        private System.Windows.Forms.Label teamDetailsCoachLabel;
        private System.Windows.Forms.Label teamDetailsNameLabel;
        private System.Windows.Forms.Label teamDetailsLabel;
        private System.Windows.Forms.Label teamDetailsRegionDisplay;
        private System.Windows.Forms.Label teamDetailsYearDisplay;
        private System.Windows.Forms.Label teamDetailsCoachDisplay;
        private System.Windows.Forms.Label teamDetailsGroundDisplay;
        private System.Windows.Forms.Label teamDetailsNameDisplay;
        private System.Windows.Forms.ListView rosterListView;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.RadioButton POBSearchBy;
        private System.Windows.Forms.Label searchByLabel;
        private System.Windows.Forms.RadioButton searchAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView searchDisplayListView;
        private System.Windows.Forms.ColumnHeader searchName;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.TabPage ageChartTab;
        private System.Windows.Forms.TabPage heightWeightChartTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart heightWeightChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ageChart;
    }
}

