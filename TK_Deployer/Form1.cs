using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TK_Deployer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            FileInfo info = new FileInfo(path);

            List<string> functionNames = new List<string>();
            List<string> functions = new List<string>();

            string test = "";

            if (info.Exists)
            {
                StreamReader reader = new StreamReader(info.OpenRead());

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if(test == "")
                    {
                        test = line + ", \\n? :" + (line.Contains("\n") == true).ToString();
                    }

                    if(line.Trim().StartsWith("function "))
                    {
                        functionNames.Add(GetInBetween(line, "function ", "\\("));
                    }
                }

                reader.Close();

                foreach (string str in functionNames)
                {
                    test += "\r\n" + str;
                }

                textBox2.Text = test;
            }
        }

        public string GetInBetween(string String, string Before, string After)
        {
            Regex rep_regex = new Regex(Before + "(.*)" + After);
            MatchCollection regMatches = rep_regex.Matches(String);
            foreach (Match m in regMatches)
            {
                if (m.Success)
                {
                    return m.Groups[1].Value.Trim();
                }
            }

            return "";
        }
    }
}
