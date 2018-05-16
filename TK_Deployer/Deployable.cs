using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TK_Deployer
{
    public class Deployable
    {
        public Deployable()
        {
        }

        public Deployable(string inPath)
        {
            mPath = inPath;

            int lastSlash = mPath.LastIndexOf('\\');

            if (lastSlash != -1)
            {
                mName = mPath.Substring(lastSlash + 1);
                if(mName.Contains("."))
                {
                    mName = mName.Split(".".ToCharArray())[0];
                }
            }
        }

        string mName;
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        string mPath;
        public string Path
        {
            get { return mPath; }
            set { mPath = value; }
        }

        string mOutputModifier = "";
        public string OutputModifier
        {
            get { return mOutputModifier; }
            set { mOutputModifier = value; }
        }

        public bool IsFile
        {
            get { return mPath.Contains("."); }
        }
    }
}
