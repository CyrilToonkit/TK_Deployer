namespace TK_Deployer
{
    partial class MainUCtrl
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
            MiniLogger.LogPreferences logPreferences1 = new MiniLogger.LogPreferences();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deployerUCtrl1 = new TK_Deployer.DeployerUCtrl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolsUCtrl1 = new TK_Deployer.ToolsUCtrl();
            this.collapsibleGroup1 = new TK.GraphComponents.CollapsibleGroup();
            this.logUCtrl1 = new MiniLogger.LogUCtrl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.collapsibleGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 315);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.deployerUCtrl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Deployments";
            // 
            // deployerUCtrl1
            // 
            this.deployerUCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deployerUCtrl1.Location = new System.Drawing.Point(3, 3);
            this.deployerUCtrl1.Name = "deployerUCtrl1";
            this.deployerUCtrl1.Size = new System.Drawing.Size(420, 283);
            this.deployerUCtrl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.toolsUCtrl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tools";
            // 
            // toolsUCtrl1
            // 
            this.toolsUCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsUCtrl1.Location = new System.Drawing.Point(3, 3);
            this.toolsUCtrl1.Name = "toolsUCtrl1";
            this.toolsUCtrl1.Size = new System.Drawing.Size(420, 284);
            this.toolsUCtrl1.TabIndex = 0;
            // 
            // collapsibleGroup1
            // 
            this.collapsibleGroup1.AllowResize = true;
            this.collapsibleGroup1.Collapsed = false;
            this.collapsibleGroup1.CollapseOnClick = true;
            this.collapsibleGroup1.Controls.Add(this.logUCtrl1);
            this.collapsibleGroup1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.collapsibleGroup1.DockingChanges = TK.GraphComponents.DockingPossibilities.None;
            this.collapsibleGroup1.Location = new System.Drawing.Point(0, 339);
            this.collapsibleGroup1.Name = "collapsibleGroup1";
            this.collapsibleGroup1.OpenedBaseHeight = 42;
            this.collapsibleGroup1.OpenedBaseWidth = 200;
            this.collapsibleGroup1.Size = new System.Drawing.Size(434, 58);
            this.collapsibleGroup1.TabIndex = 5;
            this.collapsibleGroup1.TabStop = false;
            this.collapsibleGroup1.Text = "Info";
            // 
            // logUCtrl1
            // 
            this.logUCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logUCtrl1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logUCtrl1.Location = new System.Drawing.Point(3, 16);
            logPreferences1.ShowErrors = true;
            logPreferences1.ShowInfos = true;
            logPreferences1.ShowLogs = true;
            logPreferences1.ShowWarnings = true;
            this.logUCtrl1.LoggingPreferences = logPreferences1;
            this.logUCtrl1.Name = "logUCtrl1";
            this.logUCtrl1.Size = new System.Drawing.Size(428, 39);
            this.logUCtrl1.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Xml files|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Xml files|*.xml";
            // 
            // MainUCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.collapsibleGroup1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainUCtrl";
            this.Size = new System.Drawing.Size(434, 397);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.collapsibleGroup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ToolsUCtrl toolsUCtrl1;
        private TK.GraphComponents.CollapsibleGroup collapsibleGroup1;
        private DeployerUCtrl deployerUCtrl1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MiniLogger.LogUCtrl logUCtrl1;
    }
}
