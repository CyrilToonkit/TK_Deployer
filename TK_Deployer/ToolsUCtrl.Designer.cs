namespace TK_Deployer
{
    partial class ToolsUCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsUCtrl));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ToolDetails = new TK.GraphComponents.CollapsibleGroup();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SourcesGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SourcesBrowsetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FolderBrowseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SourcesRemovetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sourceAddFromSol = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutputsGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.OutputsBrowsetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OutputsRemovetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BuildingFileBT = new System.Windows.Forms.Button();
            this.BuildingFileTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ToolsOverridePlatformTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ToolsScriptCB = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.versionBuildNUD = new System.Windows.Forms.NumericUpDown();
            this.versionMinorNUD = new System.Windows.Forms.NumericUpDown();
            this.versionMajorNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.toolLabel = new System.Windows.Forms.Label();
            this.collapsibleGroup1 = new TK.GraphComponents.CollapsibleGroup();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ToolsListBox = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ToolRenameBT = new System.Windows.Forms.Button();
            this.ToolNewBT = new System.Windows.Forms.Button();
            this.ToolNameLbl = new System.Windows.Forms.Label();
            this.ToolNewNameTB = new System.Windows.Forms.TextBox();
            this.ToolDeleteBT = new System.Windows.Forms.Button();
            this.Help = new TK.GraphComponents.CollapsibleGroup();
            this.collapsibleGroup2 = new TK.GraphComponents.CollapsibleGroup();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ToolDetails.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourcesGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputsGridView)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versionBuildNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionMinorNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionMajorNUD)).BeginInit();
            this.collapsibleGroup1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Help.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolDetails
            // 
            this.ToolDetails.AllowResize = false;
            this.ToolDetails.Collapsed = false;
            this.ToolDetails.CollapseOnClick = false;
            this.ToolDetails.Controls.Add(this.splitContainer1);
            this.ToolDetails.Controls.Add(this.ToolsScriptCB);
            this.ToolDetails.Controls.Add(this.panel4);
            this.ToolDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolDetails.DockingChanges = TK.GraphComponents.DockingPossibilities.None;
            this.ToolDetails.Location = new System.Drawing.Point(159, 0);
            this.ToolDetails.Name = "ToolDetails";
            this.ToolDetails.OpenedBaseHeight = 150;
            this.ToolDetails.OpenedBaseWidth = 200;
            this.ToolDetails.Size = new System.Drawing.Size(314, 458);
            this.ToolDetails.TabIndex = 2;
            this.ToolDetails.TabStop = false;
            this.ToolDetails.Text = "Tool Details";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 59);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(308, 396);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SourcesGridView);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sources";
            // 
            // SourcesGridView
            // 
            this.SourcesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SourcesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SourcesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourcesGridView.Location = new System.Drawing.Point(3, 41);
            this.SourcesGridView.Name = "SourcesGridView";
            this.SourcesGridView.Size = new System.Drawing.Size(302, 114);
            this.SourcesGridView.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SourcesBrowsetoolStripButton,
            this.FolderBrowseToolStripButton,
            this.SourcesRemovetoolStripButton,
            this.sourceAddFromSol});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(302, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SourcesBrowsetoolStripButton
            // 
            this.SourcesBrowsetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SourcesBrowsetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SourcesBrowsetoolStripButton.Image")));
            this.SourcesBrowsetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SourcesBrowsetoolStripButton.Name = "SourcesBrowsetoolStripButton";
            this.SourcesBrowsetoolStripButton.Size = new System.Drawing.Size(94, 22);
            this.SourcesBrowsetoolStripButton.Text = "Add Source(s)...";
            this.SourcesBrowsetoolStripButton.Click += new System.EventHandler(this.SourcesBrowsetoolStripButton_Click);
            // 
            // FolderBrowseToolStripButton
            // 
            this.FolderBrowseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FolderBrowseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FolderBrowseToolStripButton.Image")));
            this.FolderBrowseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FolderBrowseToolStripButton.Name = "FolderBrowseToolStripButton";
            this.FolderBrowseToolStripButton.Size = new System.Drawing.Size(78, 22);
            this.FolderBrowseToolStripButton.Text = "Add Folder...";
            this.FolderBrowseToolStripButton.Click += new System.EventHandler(this.FolderBrowseToolStripButton_Click);
            // 
            // SourcesRemovetoolStripButton
            // 
            this.SourcesRemovetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SourcesRemovetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SourcesRemovetoolStripButton.Image")));
            this.SourcesRemovetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SourcesRemovetoolStripButton.Name = "SourcesRemovetoolStripButton";
            this.SourcesRemovetoolStripButton.Size = new System.Drawing.Size(54, 22);
            this.SourcesRemovetoolStripButton.Text = "Remove";
            this.SourcesRemovetoolStripButton.Click += new System.EventHandler(this.SourcesRemovetoolStripButton_Click);
            // 
            // sourceAddFromSol
            // 
            this.sourceAddFromSol.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sourceAddFromSol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sourceAddFromSol.Image = ((System.Drawing.Image)(resources.GetObject("sourceAddFromSol.Image")));
            this.sourceAddFromSol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sourceAddFromSol.Name = "sourceAddFromSol";
            this.sourceAddFromSol.Size = new System.Drawing.Size(108, 19);
            this.sourceAddFromSol.Text = "Add from solution";
            this.sourceAddFromSol.Click += new System.EventHandler(this.sourceAddFromSol_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutputsGridView);
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 168);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outputs";
            // 
            // OutputsGridView
            // 
            this.OutputsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OutputsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputsGridView.Location = new System.Drawing.Point(3, 41);
            this.OutputsGridView.Name = "OutputsGridView";
            this.OutputsGridView.Size = new System.Drawing.Size(302, 124);
            this.OutputsGridView.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OutputsBrowsetoolStripButton,
            this.OutputsRemovetoolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(302, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // OutputsBrowsetoolStripButton
            // 
            this.OutputsBrowsetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OutputsBrowsetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OutputsBrowsetoolStripButton.Image")));
            this.OutputsBrowsetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OutputsBrowsetoolStripButton.Name = "OutputsBrowsetoolStripButton";
            this.OutputsBrowsetoolStripButton.Size = new System.Drawing.Size(121, 22);
            this.OutputsBrowsetoolStripButton.Text = "Add output path(s)...";
            this.OutputsBrowsetoolStripButton.Click += new System.EventHandler(this.OutputsBrowsetoolStripButton_Click);
            // 
            // OutputsRemovetoolStripButton
            // 
            this.OutputsRemovetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OutputsRemovetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OutputsRemovetoolStripButton.Image")));
            this.OutputsRemovetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OutputsRemovetoolStripButton.Name = "OutputsRemovetoolStripButton";
            this.OutputsRemovetoolStripButton.Size = new System.Drawing.Size(54, 22);
            this.OutputsRemovetoolStripButton.Text = "Remove";
            this.OutputsRemovetoolStripButton.Click += new System.EventHandler(this.OutputsRemovetoolStripButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BuildingFileBT);
            this.panel2.Controls.Add(this.BuildingFileTB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 33);
            this.panel2.TabIndex = 5;
            // 
            // BuildingFileBT
            // 
            this.BuildingFileBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildingFileBT.Location = new System.Drawing.Point(261, 6);
            this.BuildingFileBT.Name = "BuildingFileBT";
            this.BuildingFileBT.Size = new System.Drawing.Size(29, 23);
            this.BuildingFileBT.TabIndex = 2;
            this.BuildingFileBT.Text = "...";
            this.BuildingFileBT.UseVisualStyleBackColor = true;
            this.BuildingFileBT.Click += new System.EventHandler(this.BuildingFileBT_Click);
            // 
            // BuildingFileTB
            // 
            this.BuildingFileTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildingFileTB.Location = new System.Drawing.Point(77, 6);
            this.BuildingFileTB.Name = "BuildingFileTB";
            this.BuildingFileTB.Size = new System.Drawing.Size(178, 20);
            this.BuildingFileTB.TabIndex = 1;
            this.BuildingFileTB.TextChanged += new System.EventHandler(this.BuildingFileTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building file :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ToolsOverridePlatformTB);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 33);
            this.panel3.TabIndex = 6;
            // 
            // ToolsOverridePlatformTB
            // 
            this.ToolsOverridePlatformTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolsOverridePlatformTB.Location = new System.Drawing.Point(136, 6);
            this.ToolsOverridePlatformTB.Name = "ToolsOverridePlatformTB";
            this.ToolsOverridePlatformTB.Size = new System.Drawing.Size(169, 20);
            this.ToolsOverridePlatformTB.TabIndex = 1;
            this.ToolsOverridePlatformTB.TextChanged += new System.EventHandler(this.ToolsOverridePlatformTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Override Platform Name :";
            // 
            // ToolsScriptCB
            // 
            this.ToolsScriptCB.AutoSize = true;
            this.ToolsScriptCB.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsScriptCB.Location = new System.Drawing.Point(3, 42);
            this.ToolsScriptCB.Name = "ToolsScriptCB";
            this.ToolsScriptCB.Size = new System.Drawing.Size(308, 17);
            this.ToolsScriptCB.TabIndex = 1;
            this.ToolsScriptCB.Text = "Script Type (No building process)";
            this.ToolsScriptCB.UseVisualStyleBackColor = true;
            this.ToolsScriptCB.CheckedChanged += new System.EventHandler(this.ToolsScriptCB_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.versionBuildNUD);
            this.panel4.Controls.Add(this.versionMinorNUD);
            this.panel4.Controls.Add(this.versionMajorNUD);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.toolLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 26);
            this.panel4.TabIndex = 8;
            // 
            // versionBuildNUD
            // 
            this.versionBuildNUD.Location = new System.Drawing.Point(277, 4);
            this.versionBuildNUD.Name = "versionBuildNUD";
            this.versionBuildNUD.Size = new System.Drawing.Size(39, 20);
            this.versionBuildNUD.TabIndex = 5;
            // 
            // versionMinorNUD
            // 
            this.versionMinorNUD.Location = new System.Drawing.Point(236, 4);
            this.versionMinorNUD.Name = "versionMinorNUD";
            this.versionMinorNUD.Size = new System.Drawing.Size(39, 20);
            this.versionMinorNUD.TabIndex = 4;
            // 
            // versionMajorNUD
            // 
            this.versionMajorNUD.Location = new System.Drawing.Point(196, 4);
            this.versionMajorNUD.Name = "versionMajorNUD";
            this.versionMajorNUD.Size = new System.Drawing.Size(39, 20);
            this.versionMajorNUD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "V";
            // 
            // toolLabel
            // 
            this.toolLabel.AutoSize = true;
            this.toolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolLabel.Location = new System.Drawing.Point(1, 4);
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(130, 17);
            this.toolLabel.TabIndex = 0;
            this.toolLabel.Text = "Nothing selected";
            // 
            // collapsibleGroup1
            // 
            this.collapsibleGroup1.AllowResize = true;
            this.collapsibleGroup1.Collapsed = false;
            this.collapsibleGroup1.CollapseOnClick = true;
            this.collapsibleGroup1.Controls.Add(this.tableLayoutPanel1);
            this.collapsibleGroup1.Dock = System.Windows.Forms.DockStyle.Left;
            this.collapsibleGroup1.DockingChanges = TK.GraphComponents.DockingPossibilities.All;
            this.collapsibleGroup1.Location = new System.Drawing.Point(0, 0);
            this.collapsibleGroup1.Name = "collapsibleGroup1";
            this.collapsibleGroup1.OpenedBaseHeight = 150;
            this.collapsibleGroup1.OpenedBaseWidth = 200;
            this.collapsibleGroup1.Size = new System.Drawing.Size(159, 458);
            this.collapsibleGroup1.TabIndex = 1;
            this.collapsibleGroup1.TabStop = false;
            this.collapsibleGroup1.Text = "Tools";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ToolsListBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ToolDeleteBT, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(153, 439);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ToolsListBox
            // 
            this.ToolsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsListBox.Location = new System.Drawing.Point(3, 3);
            this.ToolsListBox.MultiSelect = false;
            this.ToolsListBox.Name = "ToolsListBox";
            this.ToolsListBox.Size = new System.Drawing.Size(147, 339);
            this.ToolsListBox.TabIndex = 1;
            this.ToolsListBox.UseCompatibleStateImageBehavior = false;
            this.ToolsListBox.View = System.Windows.Forms.View.List;
            this.ToolsListBox.SelectedIndexChanged += new System.EventHandler(this.ToolsListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.ToolNameLbl);
            this.panel1.Controls.Add(this.ToolNewNameTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 58);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ToolRenameBT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ToolNewBT, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(147, 30);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // ToolRenameBT
            // 
            this.ToolRenameBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolRenameBT.Location = new System.Drawing.Point(3, 3);
            this.ToolRenameBT.Name = "ToolRenameBT";
            this.ToolRenameBT.Size = new System.Drawing.Size(67, 24);
            this.ToolRenameBT.TabIndex = 4;
            this.ToolRenameBT.Text = "Rename";
            this.ToolRenameBT.UseVisualStyleBackColor = true;
            this.ToolRenameBT.Click += new System.EventHandler(this.ToolRenameBT_Click);
            // 
            // ToolNewBT
            // 
            this.ToolNewBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolNewBT.Location = new System.Drawing.Point(76, 3);
            this.ToolNewBT.Name = "ToolNewBT";
            this.ToolNewBT.Size = new System.Drawing.Size(68, 24);
            this.ToolNewBT.TabIndex = 3;
            this.ToolNewBT.Text = "New";
            this.ToolNewBT.UseVisualStyleBackColor = true;
            this.ToolNewBT.Click += new System.EventHandler(this.ToolNewBT_Click);
            // 
            // ToolNameLbl
            // 
            this.ToolNameLbl.AutoSize = true;
            this.ToolNameLbl.Location = new System.Drawing.Point(4, 9);
            this.ToolNameLbl.Name = "ToolNameLbl";
            this.ToolNameLbl.Size = new System.Drawing.Size(41, 13);
            this.ToolNameLbl.TabIndex = 4;
            this.ToolNameLbl.Text = "Name :";
            // 
            // ToolNewNameTB
            // 
            this.ToolNewNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolNewNameTB.Location = new System.Drawing.Point(51, 6);
            this.ToolNewNameTB.Name = "ToolNewNameTB";
            this.ToolNewNameTB.Size = new System.Drawing.Size(93, 20);
            this.ToolNewNameTB.TabIndex = 2;
            // 
            // ToolDeleteBT
            // 
            this.ToolDeleteBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolDeleteBT.Location = new System.Drawing.Point(3, 348);
            this.ToolDeleteBT.Name = "ToolDeleteBT";
            this.ToolDeleteBT.Size = new System.Drawing.Size(147, 24);
            this.ToolDeleteBT.TabIndex = 2;
            this.ToolDeleteBT.Text = "Delete";
            this.ToolDeleteBT.UseVisualStyleBackColor = true;
            this.ToolDeleteBT.Click += new System.EventHandler(this.ToolDeleteBT_Click);
            // 
            // Help
            // 
            this.Help.AllowResize = true;
            this.Help.Collapsed = false;
            this.Help.CollapseOnClick = true;
            this.Help.Controls.Add(this.collapsibleGroup2);
            this.Help.Dock = System.Windows.Forms.DockStyle.Right;
            this.Help.DockingChanges = TK.GraphComponents.DockingPossibilities.None;
            this.Help.Location = new System.Drawing.Point(473, 0);
            this.Help.Name = "Help";
            this.Help.OpenedBaseHeight = 150;
            this.Help.OpenedBaseWidth = 140;
            this.Help.Size = new System.Drawing.Size(122, 458);
            this.Help.TabIndex = 3;
            this.Help.TabStop = false;
            this.Help.Text = "Help";
            // 
            // collapsibleGroup2
            // 
            this.collapsibleGroup2.AllowResize = true;
            this.collapsibleGroup2.Collapsed = false;
            this.collapsibleGroup2.CollapseOnClick = true;
            this.collapsibleGroup2.Dock = System.Windows.Forms.DockStyle.Top;
            this.collapsibleGroup2.DockingChanges = TK.GraphComponents.DockingPossibilities.All;
            this.collapsibleGroup2.Location = new System.Drawing.Point(3, 16);
            this.collapsibleGroup2.Name = "collapsibleGroup2";
            this.collapsibleGroup2.OpenedBaseHeight = 150;
            this.collapsibleGroup2.OpenedBaseWidth = 200;
            this.collapsibleGroup2.Size = new System.Drawing.Size(116, 117);
            this.collapsibleGroup2.TabIndex = 1;
            this.collapsibleGroup2.TabStop = false;
            this.collapsibleGroup2.Text = "General";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ToolsUCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToolDetails);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.collapsibleGroup1);
            this.Name = "ToolsUCtrl";
            this.Size = new System.Drawing.Size(595, 458);
            this.Load += new System.EventHandler(this.ToolsUCtrl_Load);
            this.ToolDetails.ResumeLayout(false);
            this.ToolDetails.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourcesGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputsGridView)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versionBuildNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionMinorNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionMajorNUD)).EndInit();
            this.collapsibleGroup1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Help.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TK.GraphComponents.CollapsibleGroup collapsibleGroup1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ToolNewBT;
        private System.Windows.Forms.Button ToolDeleteBT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ToolNameLbl;
        private System.Windows.Forms.TextBox ToolNewNameTB;
        private TK.GraphComponents.CollapsibleGroup ToolDetails;
        private System.Windows.Forms.CheckBox ToolsScriptCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView SourcesGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView OutputsGridView;
        private System.Windows.Forms.Button BuildingFileBT;
        private System.Windows.Forms.TextBox BuildingFileTB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SourcesRemovetoolStripButton;
        private System.Windows.Forms.ToolStripButton SourcesBrowsetoolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton OutputsBrowsetoolStripButton;
        private System.Windows.Forms.ToolStripButton OutputsRemovetoolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ToolsOverridePlatformTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ToolRenameBT;
        private System.Windows.Forms.ListView ToolsListBox;
        private System.Windows.Forms.ToolStripButton sourceAddFromSol;
        private TK.GraphComponents.CollapsibleGroup Help;
        private TK.GraphComponents.CollapsibleGroup collapsibleGroup2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown versionMajorNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label toolLabel;
        private System.Windows.Forms.NumericUpDown versionBuildNUD;
        private System.Windows.Forms.NumericUpDown versionMinorNUD;
        private System.Windows.Forms.ToolStripButton FolderBrowseToolStripButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
