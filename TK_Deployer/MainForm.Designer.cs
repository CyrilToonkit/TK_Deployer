namespace TK_Deployer
{
    partial class MainForm
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
            this.mainUCtrl1 = new TK_Deployer.MainUCtrl();
            this.SuspendLayout();
            // 
            // mainUCtrl1
            // 
            this.mainUCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainUCtrl1.Location = new System.Drawing.Point(0, 0);
            this.mainUCtrl1.Name = "mainUCtrl1";
            this.mainUCtrl1.Size = new System.Drawing.Size(584, 467);
            this.mainUCtrl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 467);
            this.Controls.Add(this.mainUCtrl1);
            this.Name = "MainForm";
            this.Text = "TK Deployer BETA";
            this.ResumeLayout(false);
            this.Icon = global::TK_Deployer.Properties.Resources.Deployer;
        }

        #endregion

        private MainUCtrl mainUCtrl1;
    }
}