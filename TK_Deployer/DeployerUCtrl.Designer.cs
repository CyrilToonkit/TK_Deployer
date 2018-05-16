namespace TK_Deployer
{
    partial class DeployerUCtrl
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
            this.components = new System.ComponentModel.Container();
            this.DeploymentGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SourceScripts = new System.Windows.Forms.Button();
            this.DeployNow = new System.Windows.Forms.Button();
            this.collapsibleGroup1 = new TK.GraphComponents.CollapsibleGroup();
            this.DeploysToolsLB = new System.Windows.Forms.ListView();
            this.DeploymentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyDeploymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteDeploymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapsibleGroup2 = new TK.GraphComponents.CollapsibleGroup();
            this.DeploysDataGrid = new System.Windows.Forms.DataGridView();
            this.DeploymentGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.collapsibleGroup1.SuspendLayout();
            this.DeploymentContextMenu.SuspendLayout();
            this.collapsibleGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeploysDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DeploymentGroup
            // 
            this.DeploymentGroup.Controls.Add(this.groupBox1);
            this.DeploymentGroup.Controls.Add(this.collapsibleGroup1);
            this.DeploymentGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeploymentGroup.Location = new System.Drawing.Point(0, 115);
            this.DeploymentGroup.Name = "DeploymentGroup";
            this.DeploymentGroup.Size = new System.Drawing.Size(415, 239);
            this.DeploymentGroup.TabIndex = 5;
            this.DeploymentGroup.TabStop = false;
            this.DeploymentGroup.Text = "Deployment :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(173, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Controls.Add(this.SourceScripts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeployNow, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 189);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 28);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SourceScripts
            // 
            this.SourceScripts.Location = new System.Drawing.Point(139, 3);
            this.SourceScripts.Name = "SourceScripts";
            this.SourceScripts.Size = new System.Drawing.Size(91, 22);
            this.SourceScripts.TabIndex = 1;
            this.SourceScripts.Text = "Source scripts (adv)";
            this.SourceScripts.UseVisualStyleBackColor = true;
            this.SourceScripts.Click += new System.EventHandler(this.SourceScripts_Click);
            // 
            // DeployNow
            // 
            this.DeployNow.Location = new System.Drawing.Point(3, 3);
            this.DeployNow.Name = "DeployNow";
            this.DeployNow.Size = new System.Drawing.Size(130, 22);
            this.DeployNow.TabIndex = 0;
            this.DeployNow.Text = "Deploy now";
            this.DeployNow.UseVisualStyleBackColor = true;
            this.DeployNow.Click += new System.EventHandler(this.DeployNow_Click);
            // 
            // collapsibleGroup1
            // 
            this.collapsibleGroup1.AllowResize = true;
            this.collapsibleGroup1.Collapsed = false;
            this.collapsibleGroup1.CollapseOnClick = true;
            this.collapsibleGroup1.Controls.Add(this.DeploysToolsLB);
            this.collapsibleGroup1.Dock = System.Windows.Forms.DockStyle.Left;
            this.collapsibleGroup1.DockingChanges = TK.GraphComponents.DockingPossibilities.LeftRight;
            this.collapsibleGroup1.Location = new System.Drawing.Point(3, 16);
            this.collapsibleGroup1.Name = "collapsibleGroup1";
            this.collapsibleGroup1.OpenedBaseHeight = 150;
            this.collapsibleGroup1.OpenedBaseWidth = 200;
            this.collapsibleGroup1.Size = new System.Drawing.Size(170, 220);
            this.collapsibleGroup1.TabIndex = 1;
            this.collapsibleGroup1.TabStop = false;
            this.collapsibleGroup1.Text = "Tools";
            // 
            // DeploysToolsLB
            // 
            this.DeploysToolsLB.CheckBoxes = true;
            this.DeploysToolsLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeploysToolsLB.Location = new System.Drawing.Point(3, 16);
            this.DeploysToolsLB.MultiSelect = false;
            this.DeploysToolsLB.Name = "DeploysToolsLB";
            this.DeploysToolsLB.Size = new System.Drawing.Size(164, 201);
            this.DeploysToolsLB.TabIndex = 1;
            this.DeploysToolsLB.UseCompatibleStateImageBehavior = false;
            this.DeploysToolsLB.View = System.Windows.Forms.View.List;
            this.DeploysToolsLB.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DeploysToolsLB_ItemCheck);
            // 
            // DeploymentContextMenu
            // 
            this.DeploymentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyDeploymentToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteDeploymentToolStripMenuItem});
            this.DeploymentContextMenu.Name = "DeploymentContextMenu";
            this.DeploymentContextMenu.Size = new System.Drawing.Size(176, 54);
            // 
            // copyDeploymentToolStripMenuItem
            // 
            this.copyDeploymentToolStripMenuItem.Name = "copyDeploymentToolStripMenuItem";
            this.copyDeploymentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.copyDeploymentToolStripMenuItem.Text = "Copy Deployment";
            this.copyDeploymentToolStripMenuItem.Click += new System.EventHandler(this.copyDeploymentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // deleteDeploymentToolStripMenuItem
            // 
            this.deleteDeploymentToolStripMenuItem.Name = "deleteDeploymentToolStripMenuItem";
            this.deleteDeploymentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteDeploymentToolStripMenuItem.Text = "Delete Deployment";
            this.deleteDeploymentToolStripMenuItem.Click += new System.EventHandler(this.deleteDeploymentToolStripMenuItem_Click);
            // 
            // collapsibleGroup2
            // 
            this.collapsibleGroup2.AllowResize = true;
            this.collapsibleGroup2.Collapsed = false;
            this.collapsibleGroup2.CollapseOnClick = true;
            this.collapsibleGroup2.Controls.Add(this.DeploysDataGrid);
            this.collapsibleGroup2.Dock = System.Windows.Forms.DockStyle.Top;
            this.collapsibleGroup2.DockingChanges = TK.GraphComponents.DockingPossibilities.None;
            this.collapsibleGroup2.Location = new System.Drawing.Point(0, 0);
            this.collapsibleGroup2.Name = "collapsibleGroup2";
            this.collapsibleGroup2.OpenedBaseHeight = 150;
            this.collapsibleGroup2.OpenedBaseWidth = 200;
            this.collapsibleGroup2.Size = new System.Drawing.Size(415, 115);
            this.collapsibleGroup2.TabIndex = 6;
            this.collapsibleGroup2.TabStop = false;
            this.collapsibleGroup2.Text = "Deployments list";
            // 
            // DeploysDataGrid
            // 
            this.DeploysDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeploysDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeploysDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeploysDataGrid.Location = new System.Drawing.Point(3, 16);
            this.DeploysDataGrid.Name = "DeploysDataGrid";
            this.DeploysDataGrid.Size = new System.Drawing.Size(409, 96);
            this.DeploysDataGrid.TabIndex = 3;
            this.DeploysDataGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DeploysDataGrid_CellMouseUp);
            this.DeploysDataGrid.SelectionChanged += new System.EventHandler(this.DeploysDataGrid_SelectionChanged);
            // 
            // DeployerUCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeploymentGroup);
            this.Controls.Add(this.collapsibleGroup2);
            this.Name = "DeployerUCtrl";
            this.Size = new System.Drawing.Size(415, 354);
            this.Load += new System.EventHandler(this.DeployerUCtrl_Load);
            this.DeploymentGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.collapsibleGroup1.ResumeLayout(false);
            this.DeploymentContextMenu.ResumeLayout(false);
            this.collapsibleGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeploysDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DeploymentGroup;
        private System.Windows.Forms.DataGridView DeploysDataGrid;
        private TK.GraphComponents.CollapsibleGroup collapsibleGroup2;
        private TK.GraphComponents.CollapsibleGroup collapsibleGroup1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeployNow;
        private System.Windows.Forms.ContextMenuStrip DeploymentContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyDeploymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteDeploymentToolStripMenuItem;
        private System.Windows.Forms.ListView DeploysToolsLB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SourceScripts;
    }
}
