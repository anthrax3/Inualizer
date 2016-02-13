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
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/YasserGersy/Inualizer");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/YasserGersy");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Prince.Gersy2");

        }
        int cpunt = 20;

        private void timer1_Tick(object sender, EventArgs e)
        {
            cpunt--;
            button1.Text = "Close (" + cpunt + ")";
            if (cpunt == 0)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
        }
    }
}
