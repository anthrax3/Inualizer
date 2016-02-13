using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Individualizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            richTextBox1.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() != DialogResult.OK)
                return;
            
            Add(o.FileName);
            ReadSingle(o.FileName,this.ShowFilePath);
        }

        private void Add(string p  )
        {
            if(listBox1.Items.Contains(p))
            return;
             
                if (System.IO.Directory.Exists(p))
                {

                    if (this.CheckSubDirs)
                    {

                        string[] fils = System.IO.Directory.GetFiles(p, "*");
                        string[] dirs = System.IO.Directory.GetDirectories(p);

                        foreach (string f in fils)
                            Add(f);

                        foreach (string f in dirs)
                            Add(f);
                    }
                }
                else if(!IsBanned(p))
                    listBox1.Items.Add(p);


        }
        List<string> DisAllowedEx = new List<string>();
        private bool IsBanned(string p)
        {
            try
            {
                string ex = GetExtin(p);
                return (this.DisAllowedEx.Contains(ex));
            }
            catch { return false; }
        }
        private string GetExtin(string p, char sep='.')
        {
            try
            {
                string[] pcs = p.Split(new char[] { sep });
                return "."+pcs[pcs.Length - 1];

            }
            catch { return "."; }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            ReadAll();
        }

        private void btnChangeDir_Click(object sender, EventArgs e)
        {
            string x = "";
            
            FolderBrowserDialog d = new FolderBrowserDialog();
            if (d.ShowDialog() != DialogResult.OK)
                return;
            x=label1.Text= d.SelectedPath;
            button4_Click(null, null);
            string[] fils = System.IO.Directory.GetFiles(x, "*");
            string[] dirs = System.IO.Directory.GetDirectories(x);

            foreach (string f in fils)
                Add(f);

            foreach (string f in dirs)
                Add(f);

          
        }

        private void ReadAll()
        {
            richTextBox1.Text = "";
            foreach (string it in listBox1.Items)
               ReadSingle(it,this.ShowFilePath);
                
             
        }

        private void ReadSingle(string it,bool show)
        {
            try
            {
            string x = System.IO.File.ReadAllText(it);
            richTextBox1.Text += Environment.NewLine +((show)?it:"")+ Environment.NewLine + x;
             }
                catch { }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            if (s.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                System.IO.File.WriteAllText(s.FileName, richTextBox1.Text,Encoding.UTF8);

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            DisAllowedEx.Clear();
            this.ShowFilePath = Program.GetShowFilePath();
            this.CheckSubDirs = Program.GetCheckSubDirs();
            string[] xs = Program.GetDisAllowed();
            foreach (string x in xs)
            {
                string p = x.Trim();
                if (x.Length > 0)
                    this.DisAllowedEx.Add(x);
            }

        }

        public bool ShowFilePath { get; set; }

        public bool CheckSubDirs { get; set; }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmSettings2().ShowDialog();
            LoadSettings
                ();
           
        }
    }
}
