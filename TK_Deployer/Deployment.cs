using System;
using System.Collections.Generic;
using System.Text;

namespace TK_Deployer
{
    public enum Configurations
    {
        Debug, Release
    }

    public enum Platforms
    {
        Win32, x64, Any_CPU
    }

    public class Deployment
    {
        public Deployment()
        {
        }

        public Deployment(string inName)
        {
            mName = inName;
        }

        string mName = "";
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        string mOutputPath = "";
        public string OutputPath
        {
            get { return mOutputPath; }
            set { mOutputPath = value; }
        }

        string mExternalLibrary = "";
        public string ExternalLibrary
        {
            get { return mExternalLibrary; }
            set { mExternalLibrary = value; }
        }

        string mExternalLibraryOut = "";
        public string ExternalLibraryOut
        {
            get { return mExternalLibraryOut; }
            set { mExternalLibraryOut = value; }
        }

        Configurations mConfiguration = Configurations.Release;
        public Configurations Configuration
        {
          get { return mConfiguration; }
          set { mConfiguration = value; }
        }

        Platforms mPlatform = Platforms.x64;
        public Platforms Platform
        {
          get { return mPlatform; }
          set { mPlatform = value; }
        }

        string mReleaseInfoPath = "";
        public string ReleaseInfoPath
        {
            get { return mReleaseInfoPath; }
            set { mReleaseInfoPath = value; }
        }

        string mCompany = "";
        public string Company
        {
            get { return mCompany; }
            set { mCompany = value; }
        }

        string mHost = "";
        public string Host
        {
            get { return mHost; }
            set { mHost = value; }
        }

        int mLength = 0;
        public int Length
        {
            get { return mLength; }
            set { mLength = value; }
        }

        List<Tool> mTools = new List<Tool>();
        public List<Tool> Tools
        {
            get { return mTools; }
            set { mTools = value; }
        }

        internal string ReplaceWildCards(Tool tool, string p)
        {
            string Plat =  tool.Platform != "" ? tool.Platform : Platform.ToString();
            if(Plat == "Any_CPU")
            {
                Plat = "Any CPU";
            }

            p = p.Replace("$CONF$", Configuration.ToString());
            p = p.Replace("$PLAT$", Plat);

            return p;
        }
    }
}
