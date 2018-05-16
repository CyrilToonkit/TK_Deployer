using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiniLogger;

namespace TK_Deployer
{
    public partial class MainUCtrl : UserControl
    {
        public string SoftName = "TK_Deployer BETA";

        DeploySolution mSolution;
        public DeploySolution Solution
        {
          get { return mSolution; }
          set { mSolution = value; }
        }

        public MainUCtrl()
        {
            InitializeComponent();
            
            logUCtrl1.Bind(Logger.GetInstance());

            toolsUCtrl1.Main = this;
            deployerUCtrl1.Main = this;

            LoadData();
        }

        public void LoadData()
        {
            LoadData("");
        }

        public void LoadData(string xmlFile)
        {
            //Empty Load
            if (xmlFile == "")
            {
                mSolution = new DeploySolution();
                mSolution.Main = this;
                Logger.Log("Empty Solution Loaded", LogSeverities.Info);
            }
            else
            {
                string status = Solution.Load(xmlFile);

                if (status != "")
                {
                    ErrorBox(status, "Open Error");
                }
                else
                {
                    Logger.Log("Solution loaded successfully from " + Solution.Path, LogSeverities.Info);
                }
            }

            deployerUCtrl1.Source = mSolution;
            toolsUCtrl1.Source = mSolution;
        }

        internal void ToolsChanged(List<Tool> tools)
        {
            deployerUCtrl1.RefreshTools();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string status = Solution.Save();

            if (status != "")
            {
                ErrorBox(status, "Save Error");
            }
            else
            {
                Logger.Log("Solution saved successfully to " + Solution.Path, LogSeverities.Info);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string status = Solution.Save(saveFileDialog1.FileName);

                if (status != "")
                {
                    ErrorBox(status, "Save Error");
                }
                else
                {
                    Logger.Log("Solution saved successfully to " + Solution.Path, LogSeverities.Info);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadData(openFileDialog1.FileName);
            }
        }

        public void ErrorBox(string status, string p)
        {
            MessageBox.Show(status, p, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                deployerUCtrl1.RefreshTools();
            }
        }
    }
}
