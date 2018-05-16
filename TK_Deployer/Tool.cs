using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TK_Deployer
{
    public class Tool
    {
        public Tool()
        {
        }

        public Tool(string inName)
        {
            mName = inName;
        }

        string mName;
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        bool mIsScript = false;
        public bool IsScript
        {
            get { return mIsScript; }
            set { mIsScript = value; }
        }

        List<Deployable> mOutputFiles = new List<Deployable>();
        public List<Deployable> OutputFiles
        {
            get { return mOutputFiles; }
            set { mOutputFiles = value; }
        }

        List<Deployable> mSourceFiles = new List<Deployable>();
        public List<Deployable> SourceFiles
        {
            get { return mSourceFiles; }
            set { mSourceFiles = value; }
        }

        Deployable mBuilderFile = new Deployable();
        public Deployable BuilderFile
        {
            get { return mBuilderFile; }
            set { mBuilderFile = value; }
        }

        string mPlatform = "";
        public string Platform
        {
            get { return mPlatform; }
            set { mPlatform = value; }
        }
    }
}
