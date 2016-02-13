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
    public partial class FrmSettings2 : Form
    {
        public FrmSettings2()
        {
            InitializeComponent();
        }

        private void chkbxSubDirs_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBoxShowFilePath_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void FrmSettings2_Load(object sender, EventArgs e)
        {
            checkBoxShowFilePath.Checked = Program.GetShowFilePath();
            this.chkbxSubDirs.Checked = Program.GetCheckSubDirs();
            string []allo = Program.GetDisAllowed();
            foreach (string i in allo)
                AddToListBox(i);

            
        }

        private void AddToListBox(string i)
        {
            i = i.Trim();
            if (i.Length < 1)
                return;
            if (lstbxAllowed.Items.Contains(i))
                return;
            lstbxAllowed.Items.Add(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void btnClearAllwd_Click(object sender, EventArgs e)
        {
            lstbxAllowed.Items.Clear();

        }

        private void btnRemoveAllowed_Click(object sender, EventArgs e)
        {
            if (lstbxAllowed.SelectedIndex < 0)
                return
                    ;
            lstbxAllowed.Items.RemoveAt(lstbxAllowed.SelectedIndex);
        }

        private void buttonRemoveDis_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonAddDis_Click(object sender, EventArgs e)
        {
             
        }

        private void btnAddAllowed_Click(object sender, EventArgs e)
        {
            string x = textBoxAllowed.Text.Trim();
            if (!(x.StartsWith(".")))
                x = "." + x;
            if (lstbxAllowed.Items.Contains(x))
                return;
             
            AddToListBox(x);
            textBoxAllowed.Text = "";
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Program.SetShowFilePath(checkBoxShowFilePath.Checked);
            Program.SetCheckSubDirs(chkbxSubDirs.Checked);

            string x = "";
            foreach (string it in lstbxAllowed.Items)
                x += (it+",");
            x = x.Substring(0,x.Length - 1);
            Program.setDisAllowed(x);
            this.Close();


           
        }

        private void lstbxAllowed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
