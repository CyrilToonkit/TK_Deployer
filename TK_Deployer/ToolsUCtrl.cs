using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TK.GraphComponents;
using MiniLogger;
using System.IO;
using SolutionVersions.VSClasses;

namespace TK_Deployer
{
    public partial class ToolsUCtrl : UserControl
    {
        public MainUCtrl Main;

        Tool currentTool = null;

        DeploySolution mSource;
        internal DeploySolution Source
        {
            get { return mSource; }
            set
            {
                mSource = value;

                if (ParentForm != null)
                {
                    ParentForm.Text = Main.SoftName + " (" + (mSource == null ? " : NOTHING LOADED" : mSource.Path) + ")";
                }

                UpdateTools();
            }
        }

        private void UpdateTools()
        {
            ToolsListBox.Focus();

            int selectedItem = -1;
            if (ToolsListBox.SelectedIndices.Count > 0)
            {
                selectedItem = ToolsListBox.SelectedIndices[0];
            }

            ToolsListBox.Items.Clear();

            foreach (Tool tool in mSource.Tools)
            {
                ToolsListBox.Items.Add(tool.Name,tool.IsScript ? 0 : 1);
            }

            if (mSource.Tools.Count > 0 && selectedItem != -1)
            {
                ToolsListBox.Items[selectedItem].Selected = true;
                ToolsListBox.Items[0].Focused = true;
            }
            else
            {
                SourcesGridView.DataSource = null;
            }
        }

        public ToolsUCtrl()
        {
            InitializeComponent();
        }

        private void ToolsUCtrl_Load(object sender, EventArgs e)
        {
            ImageList list = new ImageList();
            list.Images.Add(global::TK_Deployer.Properties.Resources.icon_script);
            list.Images.Add(global::TK_Deployer.Properties.Resources.icon_solution);

            ToolsListBox.SmallImageList = ToolsListBox.LargeImageList = list;
        }

        private void ToolsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToolsListBox.SelectedIndices.Count > 0)
            {
                int SelectedIndex = ToolsListBox.SelectedIndices[0];

                currentTool = mSource.Tools[SelectedIndex];
                toolLabel.Text = currentTool.Name;
                ToolsScriptCB.Checked = currentTool.IsScript;
            }
            else
            {
                currentTool = null;
                toolLabel.Text = "Nothing selected";
                versionMajorNUD.Enabled = false;
                versionMinorNUD.Enabled = false;
                versionBuildNUD.Enabled = false;
            }

            ShowTool();
        }

        private void ShowTool()
        {
            if (currentTool != null)
            {
                BindingSource source = new BindingSource();
                source.DataSource = currentTool.SourceFiles;
                source.AllowNew = true;

                SourcesGridView.DataSource = source;

                source = new BindingSource();
                source.DataSource = currentTool.OutputFiles;
                source.AllowNew = true;

                OutputsGridView.DataSource = source;

                BuildingFileTB.Text = currentTool.BuilderFile.Path;

                ToolsOverridePlatformTB.Text = currentTool.Platform;
            }
            else
            {
                SourcesGridView.DataSource = null;
                OutputsGridView.DataSource = null;
                BuildingFileTB.Text = "";
                ToolsOverridePlatformTB.Text = "";
            }
        }

        private void ToolRenameBT_Click(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                if (ToolNewNameTB.Text != "")
                {
                    if (!ToolExists(ToolNewNameTB.Text))
                    {
                        string oldName = currentTool.Name;
                        currentTool.Name = ToolNewNameTB.Text;

                        UpdateTools();

                        Logger.Log("Tool " + oldName + " renamed successfully to " + currentTool.Name, LogSeverities.Log);
                    }
                    else
                    {
                        Logger.Log("Tool " + ToolNewNameTB.Text + " already exists !", LogSeverities.Error);
                    }
                }
                else
                {
                    Logger.Log("A Tool cannot have an empty name !", LogSeverities.Error);
                }
            }
        }

        private bool ToolExists(string p)
        {
            foreach (Tool tool in mSource.Tools)
            {
                if (tool.Name == p)
                {
                    return true;
                }
            }

            return false;
        }

        private void ToolNewBT_Click(object sender, EventArgs e)
        {
            if (ToolNewNameTB.Text != "")
            {
                if (!ToolExists(ToolNewNameTB.Text))
                {
                    Tool newTool = new Tool(ToolNewNameTB.Text);
                    mSource.Tools.Add(newTool);
                    ToolsListBox.Items.Add(newTool.Name, 0);

                    if (ToolsListBox.Items.Count == 1)
                    {
                        ToolsListBox.Items[0].Selected = true;
                    }

                    Main.ToolsChanged(mSource.Tools);

                    Logger.Log("New Tool " + newTool.Name + " created successfully", LogSeverities.Info);
                }
                else
                {
                    Logger.Log("Tool " + ToolNewNameTB.Text + " already exists !", LogSeverities.Error);
                }
            }
            else
            {
                Logger.Log("A Tool cannot have an empty name !", LogSeverities.Error);
            }
        }

        private void ToolDeleteBT_Click(object sender, EventArgs e)
        {
            if (ToolsListBox.SelectedIndices.Count > 0)
            {
                string toolName = mSource.Tools[ToolsListBox.SelectedIndices[0]].Name;

                if (MessageBox.Show("Are you sure you want to delete tool " + toolName + " ?", "Delete tool", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    mSource.Tools.RemoveAt(ToolsListBox.SelectedIndices[0]);
                    ToolsListBox.Items.RemoveAt(ToolsListBox.SelectedIndices[0]);
                    Main.ToolsChanged(mSource.Tools);

                    Logger.Log("Tool " + toolName + " removed successfully", LogSeverities.Info);
                }
            }
        }

        private void ToolsScriptCB_CheckedChanged(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                splitContainer1.Panel2Collapsed = ToolsScriptCB.Checked;
                currentTool.IsScript = ToolsScriptCB.Checked;
                sourceAddFromSol.Visible = !ToolsScriptCB.Checked;
                UpdateTools();
            }
        }

        private void BuildingFileBT_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "VS Solutions|*.sln";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BuildingFileTB.Text = openFileDialog1.FileName;
            }
        }

        private void BuildingFileTB_TextChanged(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                currentTool.BuilderFile.Path = BuildingFileTB.Text;
            }
        }

        private void SourcesBrowsetoolStripButton_Click(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                openFileDialog1.Filter = "Jscript|*.js|VBScript|*.vbs|C#|*.cs|All files|*.*";
                openFileDialog1.Multiselect = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] files = openFileDialog1.FileNames;

                    foreach (string file in files)
                    {
                        currentTool.SourceFiles.Add(new Deployable(file));
                    }

                    (SourcesGridView.DataSource as BindingSource).ResetBindings(false);
                }
            }
        }

        private void FolderBrowseToolStripButton_Click(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentTool.SourceFiles.Add(new Deployable(folderBrowserDialog1.SelectedPath));
                    (SourcesGridView.DataSource as BindingSource).ResetBindings(false);
                }
            }
        }

        private void OutputsBrowsetoolStripButton_Click(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                openFileDialog1.Filter = "Dlls|*.dll";
                openFileDialog1.Multiselect = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] files = openFileDialog1.FileNames;

                    foreach (string file in files)
                    {
                        currentTool.OutputFiles.Add(new Deployable(file));
                    }

                    (OutputsGridView.DataSource as BindingSource).ResetBindings(false);
                }
            }
        }

        private void SourcesRemovetoolStripButton_Click(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                if (SourcesGridView.SelectedRows.Count > 0)
                {
                    foreach(DataGridViewRow row in SourcesGridView.SelectedRows)
                    {
                        currentTool.SourceFiles.RemoveAt(row.Index);
                    }

                    (SourcesGridView.DataSource as BindingSource).ResetBindings(false);
                }
                else
                {
                    Main.ErrorBox("Please select a source to remove (full row)", "No seleted rows");
                }
             }
        }

        private void OutputsRemovetoolStripButton_Click(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                if (OutputsGridView.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in OutputsGridView.SelectedRows)
                    {
                        currentTool.OutputFiles.RemoveAt(row.Index);
                    }

                    (OutputsGridView.DataSource as BindingSource).ResetBindings(false);
                }
                else
                {
                    Main.ErrorBox("Please select a source to remove (full row)", "No seleted rows");
                }
            }
        }

        private void ToolsOverridePlatformTB_TextChanged(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                currentTool.Platform = ToolsOverridePlatformTB.Text;
            }
        }

        private void sourceAddFromSol_Click(object sender, EventArgs e)
        {
            if (BuildingFileTB.Text != "")
            {
                FileInfo info = new FileInfo(BuildingFileTB.Text);
                if (info.Exists)
                {
                    SolutionReader sol = new SolutionReader();
                    sol.Open(info.FullName);
                    List<string> files = sol.GetAbsolutePaths();

                    if (files.Count > 0)
                    {
                        foreach (string file in files)
                        {
                            currentTool.SourceFiles.Add(new Deployable(file));
                        }

                        (SourcesGridView.DataSource as BindingSource).ResetBindings(false);
                    }
                }
                else
                {
                    Logger.Log(info.FullName + " does not exists !", LogSeverities.Error);
                }
            }
            else
            {
                Logger.Log("Please fill the Building file field to load files from solution !", LogSeverities.Error);
            }
        }
    }
}
