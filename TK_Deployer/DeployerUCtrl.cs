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
    public partial class DeployerUCtrl : UserControl
    {
        public MainUCtrl Main;

        bool DeActivateEvents = false;

        public DeployerUCtrl()
        {
            InitializeComponent();
        }

        DeploySolution mSource;
        internal DeploySolution Source
        {
            get { return mSource; }
            set
            {
                mSource = value;
                UpdateDeploys(mSource);
            }
        }

        List<Deployment> selectedDeploys = new List<Deployment>();

        private void UpdateDeploys(DeploySolution mSource)
        {
            BindingSource source = new BindingSource();
            source.DataSource = mSource.Deploys;
            source.AllowNew = true;

            DeploysDataGrid.DataSource = source;
        }

        private void DeploysDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            List<int> selectedIndices = new List<int>();


            foreach (DataGridViewCell cell in DeploysDataGrid.SelectedCells)
            {
                if (!selectedIndices.Contains(cell.RowIndex))
                {
                    selectedIndices.Add(cell.RowIndex);
                }
            }

            ShowDeploy(selectedIndices);

        }

        private void ShowDeploy(List<int> deploysIndices)
        {
            if (deploysIndices.Count > 0)
            {
                selectedDeploys.Clear();

                foreach (int index in deploysIndices)
                {
                    selectedDeploys.Add(mSource.Deploys[index]);
                }

                if (deploysIndices.Count > 1)
                {
                    DeploymentGroup.Text = "Deployment : MULTI";
                }
                else
                {
                    DeploymentGroup.Text = "Deployment : " + selectedDeploys[0].Name;
                }
            }
            else
            {
                DeploymentGroup.Text = "Deployment : - NONE -";
            }

            RefreshTools();
        }

        public void RefreshTools()
        {
            int index = 0;
            DeploysToolsLB.Items.Clear();

            if(selectedDeploys.Count > 0)
            {
                if (selectedDeploys.Count == 1)
                {
                    Deployment selectedDeploy = selectedDeploys[0];

                    DeployNow.Text = "Deploy " + selectedDeploy.Name;

                    foreach (Tool tool in mSource.Tools)
                    {
                        DeploysToolsLB.Items.Add(tool.Name, tool.IsScript ? 0 : 1);
                        if (selectedDeploy.Tools.Contains(tool))
                        {
                            DeActivateEvents = true;
                            DeploysToolsLB.Items[index].Checked = true;
                            DeActivateEvents = false;
                        }
                        index++;
                    }

                    //Refresh Tools that didn't exists anymore
                    List<Tool> OldTools = new List<Tool>();
                    foreach (Tool tool in selectedDeploy.Tools)
                    {
                        OldTools.Add(tool);
                    }

                    foreach (Tool tool in OldTools)
                    {
                        if (!mSource.Tools.Contains(tool))
                        {
                            selectedDeploy.Tools.Remove(tool);
                        }
                    }
                }
                else
                {
                    DeployNow.Text = "Deploy MULTI";
                }
            }
            else
            {
                Logger.Log("No Deploy selected !", LogSeverities.Error);
                DeployNow.Text = "Deploy NOTHING";
            }
        }

        private void DeploysToolsLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!DeActivateEvents)
            {
                Deployment selectedDeploy = selectedDeploys.Count == 1 ? selectedDeploys[0] : null;

                if(selectedDeploy != null)
                {
                    if (e.NewValue == CheckState.Checked)
                    {
                        selectedDeploy.Tools.Add(mSource.Tools[e.Index]);
                    }
                    else
                    {
                        selectedDeploy.Tools.Remove(mSource.Tools[e.Index]);
                    }
                }
                else
                {
                    Logger.Log("No Deploy selected !", LogSeverities.Error);
                }
            }
        }

        private void DeployNow_Click(object sender, EventArgs e)
        {
            if (selectedDeploys.Count > 0)
            {
                foreach (Deployment deploy in selectedDeploys)
                {
                    Source.Deploy(deploy);
                }
            }
            else
            {
                Logger.Log("No Deploy selected !", LogSeverities.Error);
            }
        }

        private void SourceScripts_Click(object sender, EventArgs e)
        {
            if (selectedDeploys.Count > 0)
            {
                foreach (Deployment deploy in selectedDeploys)
                {
                    Source.SourceScripts(deploy);
                }
            }
            else
            {
                Logger.Log("No Deploy selected !", LogSeverities.Error);
            }
        }

        private void DeploysDataGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                copyDeploymentToolStripMenuItem.Tag = e.RowIndex;
                DeploymentContextMenu.Show(Cursor.Position);
            }
        }

        private void copyDeploymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = (int)copyDeploymentToolStripMenuItem.Tag;
            if (rowIndex < Source.Deploys.Count)
            {
                Deployment refDeploy = Source.Deploys[rowIndex];
                Deployment newDeploy = new Deployment(refDeploy.Name + "_Copy");

                newDeploy.Company = refDeploy.Company;
                newDeploy.Configuration = refDeploy.Configuration;
                newDeploy.ExternalLibrary = refDeploy.ExternalLibrary;
                newDeploy.ExternalLibraryOut = refDeploy.ExternalLibraryOut;
                newDeploy.Host = refDeploy.Host;
                newDeploy.Length = refDeploy.Length;
                newDeploy.OutputPath = refDeploy.OutputPath;
                newDeploy.Platform = refDeploy.Platform;
                newDeploy.ReleaseInfoPath = refDeploy.ReleaseInfoPath;

                newDeploy.Tools = new List<Tool>();
                foreach (Tool tool in refDeploy.Tools)
                {
                    newDeploy.Tools.Add(tool);
                }

                Source.Deploys.Insert(rowIndex + 1, newDeploy);
                (DeploysDataGrid.DataSource as BindingSource).ResetBindings(false);
            }
        }

        private void deleteDeploymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = (int)copyDeploymentToolStripMenuItem.Tag;
            if (rowIndex < Source.Deploys.Count)
            {
                Deployment refDeploy = Source.Deploys[rowIndex];
                if (MessageBox.Show("Are you sure you want to delete " + refDeploy.Name + " ?", "Delete Deployment", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Source.Deploys.RemoveAt(rowIndex);
                    (DeploysDataGrid.DataSource as BindingSource).ResetBindings(false);
                }
            }
        }

        private void DeployerUCtrl_Load(object sender, EventArgs e)
        {
            ImageList list = new ImageList();
            list.Images.Add(global::TK_Deployer.Properties.Resources.icon_script);
            list.Images.Add(global::TK_Deployer.Properties.Resources.icon_solution);

            DeploysToolsLB.SmallImageList = DeploysToolsLB.LargeImageList = list;
        }
    }
}
