﻿namespace Scada.Admin.App.Forms.Tools
{
    partial class FrmSettings
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
            this.gbPathOptions = new System.Windows.Forms.GroupBox();
            this.btnBrowseTextEditorPath = new System.Windows.Forms.Button();
            this.txtTextEditorPath = new System.Windows.Forms.TextBox();
            this.lblTextEditorPath = new System.Windows.Forms.Label();
            this.btnBrowseTableEditorPath = new System.Windows.Forms.Button();
            this.txtTableEditorPath = new System.Windows.Forms.TextBox();
            this.lblTableEditorPath = new System.Windows.Forms.Label();
            this.btnBrowseSchemeEditorPath = new System.Windows.Forms.Button();
            this.txtSchemeEditorPath = new System.Windows.Forms.TextBox();
            this.lblSchemeEditorPath = new System.Windows.Forms.Label();
            this.btnBrowseCommDir = new System.Windows.Forms.Button();
            this.txtCommDir = new System.Windows.Forms.TextBox();
            this.lblCommDir = new System.Windows.Forms.Label();
            this.btnBrowseServerDir = new System.Windows.Forms.Button();
            this.txtServerDir = new System.Windows.Forms.TextBox();
            this.lblServerDir = new System.Windows.Forms.Label();
            this.gbChannelOptions = new System.Windows.Forms.GroupBox();
            this.chkPrependDeviceName = new System.Windows.Forms.CheckBox();
            this.numCnlGap = new System.Windows.Forms.NumericUpDown();
            this.lblCnlGap = new System.Windows.Forms.Label();
            this.lblCnlShift = new System.Windows.Forms.Label();
            this.numCnlShift = new System.Windows.Forms.NumericUpDown();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.numCnlMult = new System.Windows.Forms.NumericUpDown();
            this.lblCnlMult = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbPathOptions.SuspendLayout();
            this.gbChannelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCnlGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCnlShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCnlMult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPathOptions
            // 
            this.gbPathOptions.Controls.Add(this.btnBrowseTextEditorPath);
            this.gbPathOptions.Controls.Add(this.txtTextEditorPath);
            this.gbPathOptions.Controls.Add(this.lblTextEditorPath);
            this.gbPathOptions.Controls.Add(this.btnBrowseTableEditorPath);
            this.gbPathOptions.Controls.Add(this.txtTableEditorPath);
            this.gbPathOptions.Controls.Add(this.lblTableEditorPath);
            this.gbPathOptions.Controls.Add(this.btnBrowseSchemeEditorPath);
            this.gbPathOptions.Controls.Add(this.txtSchemeEditorPath);
            this.gbPathOptions.Controls.Add(this.lblSchemeEditorPath);
            this.gbPathOptions.Controls.Add(this.btnBrowseCommDir);
            this.gbPathOptions.Controls.Add(this.txtCommDir);
            this.gbPathOptions.Controls.Add(this.lblCommDir);
            this.gbPathOptions.Controls.Add(this.btnBrowseServerDir);
            this.gbPathOptions.Controls.Add(this.txtServerDir);
            this.gbPathOptions.Controls.Add(this.lblServerDir);
            this.gbPathOptions.Location = new System.Drawing.Point(12, 12);
            this.gbPathOptions.Name = "gbPathOptions";
            this.gbPathOptions.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.gbPathOptions.Size = new System.Drawing.Size(410, 223);
            this.gbPathOptions.TabIndex = 0;
            this.gbPathOptions.TabStop = false;
            this.gbPathOptions.Text = "Paths";
            // 
            // btnBrowseTextEditorPath
            // 
            this.btnBrowseTextEditorPath.Location = new System.Drawing.Point(322, 187);
            this.btnBrowseTextEditorPath.Name = "btnBrowseTextEditorPath";
            this.btnBrowseTextEditorPath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTextEditorPath.TabIndex = 14;
            this.btnBrowseTextEditorPath.Text = "Browse...";
            this.btnBrowseTextEditorPath.UseVisualStyleBackColor = true;
            this.btnBrowseTextEditorPath.Click += new System.EventHandler(this.btnBrowseTextEditorPath_Click);
            // 
            // txtTextEditorPath
            // 
            this.txtTextEditorPath.Location = new System.Drawing.Point(13, 188);
            this.txtTextEditorPath.Name = "txtTextEditorPath";
            this.txtTextEditorPath.Size = new System.Drawing.Size(303, 20);
            this.txtTextEditorPath.TabIndex = 13;
            this.txtTextEditorPath.TextChanged += new System.EventHandler(this.control_Changed);
            // 
            // lblTextEditorPath
            // 
            this.lblTextEditorPath.AutoSize = true;
            this.lblTextEditorPath.Location = new System.Drawing.Point(10, 172);
            this.lblTextEditorPath.Name = "lblTextEditorPath";
            this.lblTextEditorPath.Size = new System.Drawing.Size(57, 13);
            this.lblTextEditorPath.TabIndex = 12;
            this.lblTextEditorPath.Text = "Text editor";
            // 
            // btnBrowseTableEditorPath
            // 
            this.btnBrowseTableEditorPath.Location = new System.Drawing.Point(322, 148);
            this.btnBrowseTableEditorPath.Name = "btnBrowseTableEditorPath";
            this.btnBrowseTableEditorPath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTableEditorPath.TabIndex = 11;
            this.btnBrowseTableEditorPath.Text = "Browse...";
            this.btnBrowseTableEditorPath.UseVisualStyleBackColor = true;
            this.btnBrowseTableEditorPath.Click += new System.EventHandler(this.btnBrowseTableEditorPath_Click);
            // 
            // txtTableEditorPath
            // 
            this.txtTableEditorPath.Location = new System.Drawing.Point(13, 149);
            this.txtTableEditorPath.Name = "txtTableEditorPath";
            this.txtTableEditorPath.Size = new System.Drawing.Size(303, 20);
            this.txtTableEditorPath.TabIndex = 10;
            this.txtTableEditorPath.TextChanged += new System.EventHandler(this.control_Changed);
            // 
            // lblTableEditorPath
            // 
            this.lblTableEditorPath.AutoSize = true;
            this.lblTableEditorPath.Location = new System.Drawing.Point(10, 133);
            this.lblTableEditorPath.Name = "lblTableEditorPath";
            this.lblTableEditorPath.Size = new System.Drawing.Size(63, 13);
            this.lblTableEditorPath.TabIndex = 9;
            this.lblTableEditorPath.Text = "Table editor";
            // 
            // btnBrowseSchemeEditorPath
            // 
            this.btnBrowseSchemeEditorPath.Location = new System.Drawing.Point(322, 109);
            this.btnBrowseSchemeEditorPath.Name = "btnBrowseSchemeEditorPath";
            this.btnBrowseSchemeEditorPath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSchemeEditorPath.TabIndex = 8;
            this.btnBrowseSchemeEditorPath.Text = "Browse...";
            this.btnBrowseSchemeEditorPath.UseVisualStyleBackColor = true;
            this.btnBrowseSchemeEditorPath.Click += new System.EventHandler(this.btnBrowseSchemeEditorPath_Click);
            // 
            // txtSchemeEditorPath
            // 
            this.txtSchemeEditorPath.Location = new System.Drawing.Point(13, 110);
            this.txtSchemeEditorPath.Name = "txtSchemeEditorPath";
            this.txtSchemeEditorPath.Size = new System.Drawing.Size(303, 20);
            this.txtSchemeEditorPath.TabIndex = 7;
            this.txtSchemeEditorPath.TextChanged += new System.EventHandler(this.control_Changed);
            // 
            // lblSchemeEditorPath
            // 
            this.lblSchemeEditorPath.AutoSize = true;
            this.lblSchemeEditorPath.Location = new System.Drawing.Point(10, 94);
            this.lblSchemeEditorPath.Name = "lblSchemeEditorPath";
            this.lblSchemeEditorPath.Size = new System.Drawing.Size(75, 13);
            this.lblSchemeEditorPath.TabIndex = 6;
            this.lblSchemeEditorPath.Text = "Scheme editor";
            // 
            // btnBrowseCommDir
            // 
            this.btnBrowseCommDir.Location = new System.Drawing.Point(322, 70);
            this.btnBrowseCommDir.Name = "btnBrowseCommDir";
            this.btnBrowseCommDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseCommDir.TabIndex = 5;
            this.btnBrowseCommDir.Text = "Browse...";
            this.btnBrowseCommDir.UseVisualStyleBackColor = true;
            this.btnBrowseCommDir.Click += new System.EventHandler(this.btnBrowseCommDir_Click);
            // 
            // txtCommDir
            // 
            this.txtCommDir.Location = new System.Drawing.Point(13, 71);
            this.txtCommDir.Name = "txtCommDir";
            this.txtCommDir.Size = new System.Drawing.Size(303, 20);
            this.txtCommDir.TabIndex = 4;
            this.txtCommDir.TextChanged += new System.EventHandler(this.control_Changed);
            // 
            // lblCommDir
            // 
            this.lblCommDir.AutoSize = true;
            this.lblCommDir.Location = new System.Drawing.Point(10, 55);
            this.lblCommDir.Name = "lblCommDir";
            this.lblCommDir.Size = new System.Drawing.Size(117, 13);
            this.lblCommDir.TabIndex = 3;
            this.lblCommDir.Text = "Communicator directory";
            // 
            // btnBrowseServerDir
            // 
            this.btnBrowseServerDir.Location = new System.Drawing.Point(322, 31);
            this.btnBrowseServerDir.Name = "btnBrowseServerDir";
            this.btnBrowseServerDir.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseServerDir.TabIndex = 2;
            this.btnBrowseServerDir.Text = "Browse...";
            this.btnBrowseServerDir.UseVisualStyleBackColor = true;
            this.btnBrowseServerDir.Click += new System.EventHandler(this.btnBrowseServerDir_Click);
            // 
            // txtServerDir
            // 
            this.txtServerDir.Location = new System.Drawing.Point(13, 32);
            this.txtServerDir.Name = "txtServerDir";
            this.txtServerDir.Size = new System.Drawing.Size(303, 20);
            this.txtServerDir.TabIndex = 1;
            this.txtServerDir.TextChanged += new System.EventHandler(this.control_Changed);
            // 
            // lblServerDir
            // 
            this.lblServerDir.AutoSize = true;
            this.lblServerDir.Location = new System.Drawing.Point(10, 16);
            this.lblServerDir.Name = "lblServerDir";
            this.lblServerDir.Size = new System.Drawing.Size(81, 13);
            this.lblServerDir.TabIndex = 0;
            this.lblServerDir.Text = "Server directory";
            // 
            // gbChannelOptions
            // 
            this.gbChannelOptions.Controls.Add(this.chkPrependDeviceName);
            this.gbChannelOptions.Controls.Add(this.numCnlGap);
            this.gbChannelOptions.Controls.Add(this.lblCnlGap);
            this.gbChannelOptions.Controls.Add(this.lblCnlShift);
            this.gbChannelOptions.Controls.Add(this.numCnlShift);
            this.gbChannelOptions.Controls.Add(this.lblExplanation);
            this.gbChannelOptions.Controls.Add(this.numCnlMult);
            this.gbChannelOptions.Controls.Add(this.lblCnlMult);
            this.gbChannelOptions.Location = new System.Drawing.Point(12, 241);
            this.gbChannelOptions.Name = "gbChannelOptions";
            this.gbChannelOptions.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.gbChannelOptions.Size = new System.Drawing.Size(410, 104);
            this.gbChannelOptions.TabIndex = 1;
            this.gbChannelOptions.TabStop = false;
            this.gbChannelOptions.Text = "Channel Generation";
            // 
            // chkPrependDeviceName
            // 
            this.chkPrependDeviceName.AutoSize = true;
            this.chkPrependDeviceName.Location = new System.Drawing.Point(158, 73);
            this.chkPrependDeviceName.Name = "chkPrependDeviceName";
            this.chkPrependDeviceName.Size = new System.Drawing.Size(130, 17);
            this.chkPrependDeviceName.TabIndex = 7;
            this.chkPrependDeviceName.Text = "Prepend device name";
            this.chkPrependDeviceName.UseVisualStyleBackColor = true;
            this.chkPrependDeviceName.CheckedChanged += new System.EventHandler(this.control_Changed);
            // 
            // numCnlGap
            // 
            this.numCnlGap.Location = new System.Drawing.Point(13, 71);
            this.numCnlGap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCnlGap.Name = "numCnlGap";
            this.numCnlGap.Size = new System.Drawing.Size(100, 20);
            this.numCnlGap.TabIndex = 6;
            this.numCnlGap.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCnlGap.ValueChanged += new System.EventHandler(this.control_Changed);
            // 
            // lblCnlGap
            // 
            this.lblCnlGap.AutoSize = true;
            this.lblCnlGap.Location = new System.Drawing.Point(10, 55);
            this.lblCnlGap.Name = "lblCnlGap";
            this.lblCnlGap.Size = new System.Drawing.Size(27, 13);
            this.lblCnlGap.TabIndex = 5;
            this.lblCnlGap.Text = "Gap";
            // 
            // lblCnlShift
            // 
            this.lblCnlShift.AutoSize = true;
            this.lblCnlShift.Location = new System.Drawing.Point(155, 16);
            this.lblCnlShift.Name = "lblCnlShift";
            this.lblCnlShift.Size = new System.Drawing.Size(28, 13);
            this.lblCnlShift.TabIndex = 3;
            this.lblCnlShift.Text = "Shift";
            // 
            // numCnlShift
            // 
            this.numCnlShift.Location = new System.Drawing.Point(158, 32);
            this.numCnlShift.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCnlShift.Name = "numCnlShift";
            this.numCnlShift.Size = new System.Drawing.Size(100, 20);
            this.numCnlShift.TabIndex = 4;
            this.numCnlShift.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCnlShift.ValueChanged += new System.EventHandler(this.control_Changed);
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Location = new System.Drawing.Point(119, 34);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(33, 13);
            this.lblExplanation.TabIndex = 2;
            this.lblExplanation.Text = "× N +";
            // 
            // numCnlMult
            // 
            this.numCnlMult.Location = new System.Drawing.Point(13, 32);
            this.numCnlMult.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCnlMult.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCnlMult.Name = "numCnlMult";
            this.numCnlMult.Size = new System.Drawing.Size(100, 20);
            this.numCnlMult.TabIndex = 1;
            this.numCnlMult.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCnlMult.ValueChanged += new System.EventHandler(this.control_Changed);
            // 
            // lblCnlMult
            // 
            this.lblCnlMult.AutoSize = true;
            this.lblCnlMult.Location = new System.Drawing.Point(10, 16);
            this.lblCnlMult.Name = "lblCnlMult";
            this.lblCnlMult.Size = new System.Drawing.Size(55, 13);
            this.lblCnlMult.TabIndex = 0;
            this.lblCnlMult.Text = "Multiplicity";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(266, 351);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(347, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Executable files (*.exe)|*.exe|All Files (*.*)|*.*";
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(434, 386);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbChannelOptions);
            this.Controls.Add(this.gbPathOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.gbPathOptions.ResumeLayout(false);
            this.gbPathOptions.PerformLayout();
            this.gbChannelOptions.ResumeLayout(false);
            this.gbChannelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCnlGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCnlShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCnlMult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPathOptions;
        private System.Windows.Forms.Button btnBrowseServerDir;
        private System.Windows.Forms.TextBox txtServerDir;
        private System.Windows.Forms.Label lblServerDir;
        private System.Windows.Forms.Button btnBrowseCommDir;
        private System.Windows.Forms.TextBox txtCommDir;
        private System.Windows.Forms.Label lblCommDir;
        private System.Windows.Forms.Button btnBrowseSchemeEditorPath;
        private System.Windows.Forms.TextBox txtSchemeEditorPath;
        private System.Windows.Forms.Label lblSchemeEditorPath;
        private System.Windows.Forms.Button btnBrowseTableEditorPath;
        private System.Windows.Forms.TextBox txtTableEditorPath;
        private System.Windows.Forms.Label lblTableEditorPath;
        private System.Windows.Forms.GroupBox gbChannelOptions;
        private System.Windows.Forms.NumericUpDown numCnlMult;
        private System.Windows.Forms.Label lblCnlMult;
        private System.Windows.Forms.NumericUpDown numCnlShift;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblCnlShift;
        private System.Windows.Forms.NumericUpDown numCnlGap;
        private System.Windows.Forms.Label lblCnlGap;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowseTextEditorPath;
        private System.Windows.Forms.TextBox txtTextEditorPath;
        private System.Windows.Forms.Label lblTextEditorPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox chkPrependDeviceName;
    }
}