using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using MiniLogger;
using System.Windows.Forms;
using SolutionVersions;

namespace TK_Deployer
{
    public class DeploySolution
    {
        [XmlIgnore]
        public MainUCtrl Main = null;

        string mPath = "";
        public string Path
        {
            get { return mPath; }
            set { mPath = value; }
        }

        List<Deployment> mDeploys = new List<Deployment>();
        public List<Deployment> Deploys
        {
            get { return mDeploys; }
            set { mDeploys = value; }
        }

        List<Tool> mTools = new List<Tool>();
        public List<Tool> Tools
        {
            get { return mTools; }
            set { mTools = value; }
        }

        public string Save()
        {
            if (mPath != "")
            {
                Save(mPath);
            }
            else
            {
                return "No path to save (use Save as)!";
            }

            return "";
        }

        public string Save(string inPath)
        {
            mPath = inPath;

            string status = "";
            StreamWriter writer = null;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(DeploySolution));

                writer = new StreamWriter(inPath, false);
                ser.Serialize(writer, this);
            }
            catch (Exception e) { status = e.Message; }

            if (writer != null)
            {
                writer.Close();
            }

            return status;
        }

        public string Load(string inPath)
        {
            mPath = inPath;

            string status = "";
            StreamReader reader = null;
            DeploySolution read = null;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(DeploySolution));

                reader = new StreamReader(inPath);
                read = (DeploySolution)ser.Deserialize(reader);

                //Resolve
                foreach (Deployment deploy in read.Deploys)
                {
                    List<Tool> resolvedTools = new List<Tool>();  
                    foreach (Tool tool in deploy.Tools)
                    {
                        //Find in Tools
                        foreach (Tool realTool in read.Tools)
                        {
                            if (realTool.Name == tool.Name)
                            {
                                resolvedTools.Add(realTool);
                            }
                        }
                    }

                    deploy.Tools = resolvedTools;
                }
            }
            catch (Exception e) { status = e.Message; }

            if (reader != null)
            {
                reader.Close();
            }

            if (read != null)
            {
                mDeploys = read.Deploys;
                mTools = read.Tools;
                mPath = read.Path;
            }

            return status;
        }

        internal void Deploy(Deployment deployment)
        {
            string errors = "";
            try
            {
                Logger.Log(" - Deploying " + deployment.Name + " ----------- ", LogSeverities.Info);

                //Collect files to be deployed
                List<Deployable> deployables = new List<Deployable>();
                foreach (Tool tool in deployment.Tools)
                {
                    List<Deployable> toDeploy = tool.IsScript ? tool.SourceFiles : tool.OutputFiles;

                    foreach (Deployable file in toDeploy)
                    {
                        deployables.Add(file);
                    }

                    //Add the packages (folders) if we have a compiled tool
                    if (!tool.IsScript)
                    {
                        foreach (Deployable deployable in tool.SourceFiles)
                        {
                            if (!deployable.IsFile)
                            {
                                deployables.Add(deployable);
                            }
                        }
                    }
                }

                //Get Output
                DirectoryInfo OutputInfo = new DirectoryInfo(deployment.OutputPath);
                if (OutputInfo.Exists)
                {
                    string confirmation = "";

                    if (OutputInfo.GetDirectories().Count() > 0)
                    {
                        confirmation = "Your output directory is not supposed to have subdirectories\n";
                    }

                    if (OutputInfo.GetFiles().Count() > deployables.Count * 2)
                    {
                        confirmation += "Your output directory contains much more files than your deployment\n";
                    }

                    if (!string.IsNullOrEmpty(confirmation))
                    {
                        DialogResult rslt = MessageBox.Show(confirmation + "Are you sure you want to remove folder " + deployment.OutputPath + " ?", "Check output folder", MessageBoxButtons.YesNoCancel);
                        if (rslt == DialogResult.Cancel)
                        {
                            errors += "Output folder is not empty, deployment aborted by user";
                            return;
                        }
                        else
                        {
                            if (rslt == DialogResult.Yes)
                            {
                                OutputInfo.Delete(true);
                                Logger.Log(OutputInfo.FullName + " deleted (confirmed by user).", LogSeverities.Log);
                            }
                        }
                    }
                    else
                    {
                        OutputInfo.Delete(true);
                        Logger.Log(OutputInfo.FullName + " deleted.", LogSeverities.Log);
                    }

                }

                // *** CopyLibrairies ***

                if (deployment.ExternalLibrary != "" && deployment.ExternalLibraryOut != "")
                {
                    DirectoryInfo ExternalLibraryInfo = new DirectoryInfo(deployment.ExternalLibrary);
                    if (!ExternalLibraryInfo.Exists)
                    {
                        errors += "Library " + ExternalLibraryInfo.FullName + " not found !\n";
                    }
                    else
                    {
                        DirectoryInfo ExternalLibraryOutInfo = new DirectoryInfo(deployment.ExternalLibraryOut);
                        if (ExternalLibraryOutInfo.Exists)
                        {
                            ExternalLibraryOutInfo.Delete(true);
                            Logger.Log(ExternalLibraryOutInfo.FullName + " deleted.", LogSeverities.Log);
                        }

                        CreateDirectory(ExternalLibraryOutInfo);
                        CopyFolder(ExternalLibraryInfo.FullName, ExternalLibraryOutInfo.FullName);
                        Logger.Log(ExternalLibraryInfo.FullName + " copied to " + ExternalLibraryOutInfo.FullName, LogSeverities.Log);
                    }
                }

                // *** Update Release Infos ***

                if (deployment.ReleaseInfoPath != "")
                {
                    FileInfo releaseInfo = new FileInfo(deployment.ReleaseInfoPath);
                    if (releaseInfo.Exists)
                    {
                        Logger.Log("Release Info will be updated", LogSeverities.Log);

                        ReleaseInfo newInfo = new ReleaseInfo();
                        newInfo.LoadFromFile(deployment.ReleaseInfoPath);

                        newInfo.sBuildDate = DateTime.Now.ToString("yyyy-MM-dd", null);

                        if (deployment.Company != "")
                        {
                            newInfo.Company = deployment.Company;
                            Logger.Log("Company changed to " + newInfo.Company, LogSeverities.Log);
                        }

                        if (deployment.Host != "")
                        {
                            newInfo.Host = deployment.Host;
                            Logger.Log("Host changed to " + newInfo.Host, LogSeverities.Log);
                        }

                        if (deployment.Length != 0)
                        {
                            newInfo.Length = deployment.Length;
                            Logger.Log("Length changed to " + newInfo.Length, LogSeverities.Log);
                        }

                        newInfo.Save(deployment.ReleaseInfoPath);
                    }
                    else
                    {
                        errors += "ReleaseInfos " + releaseInfo.FullName + " not found !\n";
                    }
                    
                }
                // *** Build ***

                List<Tool> toolsToBuild = new List<Tool>();
                List<string> builderPaths = new List<string>();

                foreach (Tool tool in deployment.Tools)
                {
                    if (!tool.IsScript && tool.BuilderFile.Path != "" && !builderPaths.Contains(tool.BuilderFile.Path))
                    {
                        toolsToBuild.Add(tool);
                        builderPaths.Add(tool.BuilderFile.Path);
                    }
                }

                foreach (Tool tool in toolsToBuild)
                {
                    FileInfo buildInfo = new FileInfo(tool.BuilderFile.Path);
                    if (buildInfo.Exists)
                    {
                        //Determine if Building is obsolete
                        //TODO : check sources modification date (and Librairies change...)
                        //Let's rebuild anyway for now...
                        bool needRebuild = true;

                        DateTime buildDate = buildInfo.LastWriteTime;
                        
                        foreach (Deployable file in tool.OutputFiles)
                        {
                            FileInfo info = new FileInfo(deployment.ReplaceWildCards(tool, file.Path));
                            if (info.Exists)
                            { 
                                if(info.LastWriteTime < buildDate)
                                {
                                    needRebuild = true;
                                    break;
                                }
                            }
                        }

                        if (needRebuild)
                        {
                            Logger.Log(tool.Name + " is obsolete, rebuild !", LogSeverities.Log);

                            string Configuration = deployment.Configuration.ToString();
                            string Platform = tool.Platform != "" ? tool.Platform : deployment.Platform.ToString();

                            if (Platform == "Any_CPU")
                            {
                                Platform = "Any CPU";
                            }

                            execute("C:\\Windows\\Microsoft.NET\\Framework\\v3.5", "MSBuild.exe", "\"" + buildInfo.FullName + "\" /t:rebuild /p:Configuration=\"" + Configuration + "\" /p:Platform=\"" + Platform + "\"");
                        }
                        else
                        {
                            Logger.Log(tool.Name + " is up to date", LogSeverities.Log);
                        }
                    }
                    else
                    {
                        errors += "Buildable " + buildInfo.FullName + " not found !\n";
                    }
                }

                // *** Publish ***

                OutputInfo = new DirectoryInfo(deployment.OutputPath);
                CreateDirectory(OutputInfo);

                foreach (Tool tool in deployment.Tools)
                {
                    List<Deployable> toDeploy = new List<Deployable>(tool.IsScript ? tool.SourceFiles : tool.OutputFiles);

                    //Add the packages (folders) if we have a compiled tool
                    if (!tool.IsScript)
                    {
                        foreach (Deployable deployable in tool.SourceFiles)
                        {
                            if (!deployable.IsFile)
                            {
                                toDeploy.Add(deployable);
                            }
                        }
                    }

                    foreach (Deployable file in toDeploy)
                    {
                        //File
                        if (file.IsFile)
                        {
                            FileInfo info = new FileInfo(deployment.ReplaceWildCards(tool, file.Path));
                            if (info.Exists)
                            {
                                string outFileName = OutputInfo.FullName + "\\" + info.Name;
                                info.CopyTo(outFileName, true);
                                Logger.Log(tool.Name + " copied to " + outFileName, LogSeverities.Log);
                            }
                            else
                            {
                                errors += "Tool " + tool.Name + ", " + info.FullName + " file not found !\n";
                            }
                        }
                        else
                        {
                            //Folder (package)
                            DirectoryInfo info = new DirectoryInfo(deployment.ReplaceWildCards(tool, file.Path));
                            if (info.Exists)
                            {
                                string outFileName = OutputInfo.FullName + "\\" + info.Name;
                                DirectoryInfo OutInfo = new DirectoryInfo(outFileName);

                                CreateDirectory(OutInfo);
                                CopyFolder(info.FullName, OutInfo.FullName);
                                Logger.Log(info.FullName + " copied to " + OutInfo.FullName, LogSeverities.Log);

                            }
                            else
                            {
                                errors += "Tool " + tool.Name + ", " + info.FullName + " folder not found !\n";
                            }
                        }
                    }
                }

                if (errors == "")
                {
                    Logger.Log(" - Deploy " + deployment.Name + " successfull --", LogSeverities.Info);
                }
                else
                {
                    Logger.Log("Deployment error(s) : " + errors, LogSeverities.Error);
                }
            }
            catch (Exception e)
            {
                Logger.Log("Deployment error(s) : " + errors + "\n" + e.Message, LogSeverities.Error);
            }
        }

        internal void SourceScripts(Deployment deployment)
        {
            string errors = "";

            try
            {
                Logger.Log(" - Sourcing scripts for " + deployment.Name + " ----------- ", LogSeverities.Info);
                
                //Get Output
                DirectoryInfo OutputInfo = new DirectoryInfo(deployment.OutputPath);
                if (OutputInfo.Exists)
                {
                    //Collect files to be deployed
                    List<Tool> scriptTools = new List<Tool>();
                    foreach (Tool tool in deployment.Tools)
                    {
                        if(tool.IsScript)
                        {
                            scriptTools.Add(tool);
                        }
                    }

                    if (scriptTools.Count > 0)
                    {
                        string warnings = "";

                        FileInfo[] outputsInfo = OutputInfo.GetFiles();
                        List<FileInfo> scripts = new List<FileInfo>();
                        Dictionary<FileInfo, string> scriptsDic = new Dictionary<FileInfo, string>();

                        foreach (Tool tool in scriptTools)
                        {
                            foreach (Deployable file in tool.SourceFiles)
                            {
                                bool found = false;
                                foreach (FileInfo info in outputsInfo)
                                {
                                    if (file.Name == info.Name)
                                    {
                                        FileInfo sourceInfo = new FileInfo(deployment.ReplaceWildCards(tool, file.Path));
                                        if (sourceInfo.LastWriteTime > info.LastWriteTime)
                                        {
                                            warnings += file.Name + " is more recent on sources, sourcing aborted\n";
                                        }
                                        else
                                        {
                                            found = true;
                                            scripts.Add(info);
                                            scriptsDic.Add(info, file.Name);
                                            break;
                                        }
                                    }
                                }

                                if (!found)
                                {
                                    Logger.Log("File " + file.Path + " not found in outputs", LogSeverities.Warning);
                                    warnings += "File " + file.Path + " not found in outputs\n";

                                }
                                else
                                {
                                    Logger.Log("File " + file.Path + " found", LogSeverities.Log);
                                }
                            }
                        }

                        if (string.IsNullOrEmpty(warnings) || MessageBox.Show(warnings, "Sourcing errors", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            foreach (FileInfo info in scripts)
                            {
                                info.CopyTo(scriptsDic[info]);
                                Logger.Log(info.FullName + " copied to " + scriptsDic[info], LogSeverities.Log);
                            }
                        }
                        else
                        {
                            errors += "Sourcing errors, aborted by user\n";
                        }
                    }
                    else
                    {
                        errors += "No files to Source\n";
                    }
                }
                else
                {
                    errors += "Cannot find output directory " + deployment.OutputPath + "\n";
                }

                if(errors == "")
                {
                    Logger.Log(" - Sourcing scripts for " + deployment.Name + " successfull --", LogSeverities.Info);
                }
                else
                {
                    Logger.Log("Sourcing error(s) : " + errors, LogSeverities.Error);
                }
            }
            catch (Exception e)
            {
                Logger.Log("Deployment error(s) : " + errors + "\n" + e.Message, LogSeverities.Error);
            }
        }

        public void CreateDirectory(DirectoryInfo dirInfo)
	    {
		    if (dirInfo.Parent != null) CreateDirectory(dirInfo.Parent);
		    if (!dirInfo.Exists) dirInfo.Create();
	    }

        public void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = System.IO.Path.GetFileName(file);
                string dest = System.IO.Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = System.IO.Path.GetFileName(folder);
                string dest = System.IO.Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }

        public void execute(string workingDirectory, string fileName, string arguments)
        {
            /*
            // create the ProcessStartInfo using "cmd" as the program to be run, and "/c " as the parameters.
            // Incidentally, /c tells cmd that we want it to execute the command that follows, and then exit.
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo(workingDirectory + "\\" + fileName, arguments);

            procStartInfo.WorkingDirectory = workingDirectory;

            //This means that it will be redirected to the Process.StandardOutput StreamReader.
            procStartInfo.RedirectStandardOutput = true;
            //This means that it will be redirected to the Process.StandardError StreamReader. (same as StdOutput)
            procStartInfo.RedirectStandardError = true;

            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = true;
            // Now we create a process, assign its ProcessStartInfo and start it
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            //This is importend, else some Events will not fire!
            proc.EnableRaisingEvents = true;

            // passing the Startinfo to the process
            proc.StartInfo = procStartInfo;

            // The given Funktion will be raised if the Process wants to print an output to consol                    
            proc.OutputDataReceived += DoSomething;
            // Std Error
            proc.ErrorDataReceived += DoSomethingHorrible;
            // If Batch File is finished this Event will be raised
            proc.Exited += Exited;

            proc.Start();
            proc.WaitForExit();
             * */

            Process process = Process.Start(new ProcessStartInfo(workingDirectory+"\\"+fileName, arguments) {
                                    UseShellExecute = false,
                                    RedirectStandardOutput = true
                                });
            Logger.Log(process.StandardOutput.ReadToEnd(), LogSeverities.Info);
            process.WaitForExit();
            if (process.ExitCode != 0) { Logger.Log("Build Error !!", LogSeverities.Error); }
        }

        void DoSomething(object sendingProcess, DataReceivedEventArgs outLine)
        {
            Logger.Log(outLine.Data, LogSeverities.Info);
        }

        void DoSomethingHorrible(object sendingProcess, DataReceivedEventArgs outLine)
        {
            Logger.Log(outLine.Data, LogSeverities.Error);
        }

        void Exited(object sendingProcess, EventArgs args)
        {
            Logger.Log((sendingProcess as Process).ProcessName + " Exited in error !", LogSeverities.Error);
        }
    }
}
