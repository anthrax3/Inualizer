namespace Individualizer
{
    partial class FrmSettings2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkbxSubDirs = new System.Windows.Forms.CheckBox();
            this.checkBoxShowFilePath = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbxAllowed = new System.Windows.Forms.ListBox();
            this.btnAddAllowed = new System.Windows.Forms.Button();
            this.btnRemoveAllowed = new System.Windows.Forms.Button();
            this.btnClearAllwd = new System.Windows.Forms.Button();
            this.textBoxAllowed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkbxSubDirs
            // 
            this.chkbxSubDirs.AutoSize = true;
            this.chkbxSubDirs.Checked = true;
            this.chkbxSubDirs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxSubDirs.Location = new System.Drawing.Point(12, 12);
            this.chkbxSubDirs.Name = "chkbxSubDirs";
            this.chkbxSubDirs.Size = new System.Drawing.Size(100, 17);
            this.chkbxSubDirs.TabIndex = 9;
            this.chkbxSubDirs.Text = "Check Sub Dirs";
            this.chkbxSubDirs.UseVisualStyleBackColor = true;
            this.chkbxSubDirs.CheckedChanged += new System.EventHandler(this.chkbxSubDirs_CheckedChanged);
            // 
            // checkBoxShowFilePath
            // 
            this.checkBoxShowFilePath.AutoSize = true;
            this.checkBoxShowFilePath.Location = new System.Drawing.Point(12, 36);
            this.checkBoxShowFilePath.Name = "checkBoxShowFilePath";
            this.checkBoxShowFilePath.Size = new System.Drawing.Size(96, 17);
            this.checkBoxShowFilePath.TabIndex = 10;
            this.checkBoxShowFilePath.Text = "Show File path";
            this.checkBoxShowFilePath.UseVisualStyleBackColor = true;
            this.checkBoxShowFilePath.CheckedChanged += new System.EventHandler(this.checkBoxShowFilePath_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Disallowed Extinstions";
            // 
            // lstbxAllowed
            // 
            this.lstbxAllowed.FormattingEnabled = true;
            this.lstbxAllowed.Location = new System.Drawing.Point(32, 77);
            this.lstbxAllowed.Name = "lstbxAllowed";
            this.lstbxAllowed.Size = new System.Drawing.Size(120, 95);
            this.lstbxAllowed.TabIndex = 12;
            this.lstbxAllowed.SelectedIndexChanged += new System.EventHandler(this.lstbxAllowed_SelectedIndexChanged);
            // 
            // btnAddAllowed
            // 
            this.btnAddAllowed.Location = new System.Drawing.Point(159, 176);
            this.btnAddAllowed.Name = "btnAddAllowed";
            this.btnAddAllowed.Size = new System.Drawing.Size(75, 23);
            this.btnAddAllowed.TabIndex = 13;
            this.btnAddAllowed.Text = "Add";
            this.btnAddAllowed.UseVisualStyleBackColor = true;
            this.btnAddAllowed.Click += new System.EventHandler(this.btnAddAllowed_Click);
            // 
            // btnRemoveAllowed
            // 
            this.btnRemoveAllowed.Location = new System.Drawing.Point(159, 106);
            this.btnRemoveAllowed.Name = "btnRemoveAllowed";
            this.btnRemoveAllowed.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAllowed.TabIndex = 13;
            this.btnRemoveAllowed.Text = "Remove";
            this.btnRemoveAllowed.UseVisualStyleBackColor = true;
            this.btnRemoveAllowed.Click += new System.EventHandler(this.btnRemoveAllowed_Click);
            // 
            // btnClearAllwd
            // 
            this.btnClearAllwd.Location = new System.Drawing.Point(158, 77);
            this.btnClearAllwd.Name = "btnClearAllwd";
            this.btnClearAllwd.Size = new System.Drawing.Size(75, 23);
            this.btnClearAllwd.TabIndex = 13;
            this.btnClearAllwd.Text = "Clear all ";
            this.btnClearAllwd.UseVisualStyleBackColor = true;
            this.btnClearAllwd.Click += new System.EventHandler(this.btnClearAllwd_Click);
            // 
            // textBoxAllowed
            // 
            this.textBoxAllowed.Location = new System.Drawing.Point(32, 176);
            this.textBoxAllowed.Name = "textBoxAllowed";
            this.textBoxAllowed.Size = new System.Drawing.Size(100, 20);
            this.textBoxAllowed.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // FrmSettings2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAllowed);
            this.Controls.Add(this.btnClearAllwd);
            this.Controls.Add(this.btnRemoveAllowed);
            this.Controls.Add(this.btnAddAllowed);
            this.Controls.Add(this.lstbxAllowed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxShowFilePath);
            this.Controls.Add(this.chkbxSubDirs);
            this.Name = "FrmSettings2";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbxSubDirs;
        private System.Windows.Forms.CheckBox checkBoxShowFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbxAllowed;
        private System.Windows.Forms.Button btnAddAllowed;
        private System.Windows.Forms.Button btnRemoveAllowed;
        private System.Windows.Forms.Button btnClearAllwd;
        private System.Windows.Forms.TextBox textBoxAllowed;
        private System.Windows.Forms.Button button1;
    }
}