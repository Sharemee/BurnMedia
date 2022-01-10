namespace BurnMedia
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ComboBox_Devices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_SupportedMedia = new System.Windows.Forms.Label();
            this.backgroundBurnWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalSize = new System.Windows.Forms.Label();
            this.progressBarCapacity = new System.Windows.Forms.ProgressBar();
            this.Btn_Format = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBurn = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.Label_Status = new System.Windows.Forms.Label();
            this.buttonBurn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMediaType = new System.Windows.Forms.Label();
            this.buttonDetectMedia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxVerification = new System.Windows.Forms.ComboBox();
            this.labelVerification = new System.Windows.Forms.Label();
            this.checkBoxEject = new System.Windows.Forms.CheckBox();
            this.checkBoxCloseMedia = new System.Windows.Forms.CheckBox();
            this.TextBox_VolumeLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveFiles = new System.Windows.Forms.Button();
            this.buttonAddFolders = new System.Windows.Forms.Button();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.tabPageFormat = new System.Windows.Forms.TabPage();
            this.checkBoxQuickFormat = new System.Windows.Forms.CheckBox();
            this.checkBoxEjectFormat = new System.Windows.Forms.CheckBox();
            this.formatProgressBar = new System.Windows.Forms.ProgressBar();
            this.Label_FormatStatus = new System.Windows.Forms.Label();
            this.backgroundFormatWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPageBurn.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBox_Devices
            // 
            this.ComboBox_Devices.FormattingEnabled = true;
            this.ComboBox_Devices.Location = new System.Drawing.Point(12, 11);
            this.ComboBox_Devices.Name = "ComboBox_Devices";
            this.ComboBox_Devices.Size = new System.Drawing.Size(196, 20);
            this.ComboBox_Devices.TabIndex = 1;
            this.ComboBox_Devices.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            this.ComboBox_Devices.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.devicesComboBox_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supported Media:";
            // 
            // Label_SupportedMedia
            // 
            this.Label_SupportedMedia.Location = new System.Drawing.Point(364, 8);
            this.Label_SupportedMedia.Name = "Label_SupportedMedia";
            this.Label_SupportedMedia.Size = new System.Drawing.Size(262, 53);
            this.Label_SupportedMedia.TabIndex = 3;
            // 
            // backgroundBurnWorker
            // 
            this.backgroundBurnWorker.WorkerReportsProgress = true;
            this.backgroundBurnWorker.WorkerSupportsCancellation = true;
            this.backgroundBurnWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundBurnWorker_DoWork);
            this.backgroundBurnWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundBurnWorker_ProgressChanged);
            this.backgroundBurnWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundBurnWorker_RunWorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Files (*.*)|*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // labelTotalSize
            // 
            this.labelTotalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalSize.AutoSize = true;
            this.labelTotalSize.Location = new System.Drawing.Point(193, 67);
            this.labelTotalSize.Name = "labelTotalSize";
            this.labelTotalSize.Size = new System.Drawing.Size(59, 12);
            this.labelTotalSize.TabIndex = 7;
            this.labelTotalSize.Text = "totalSize";
            // 
            // progressBarCapacity
            // 
            this.progressBarCapacity.Location = new System.Drawing.Point(6, 85);
            this.progressBarCapacity.Name = "progressBarCapacity";
            this.progressBarCapacity.Size = new System.Drawing.Size(230, 11);
            this.progressBarCapacity.Step = 1;
            this.progressBarCapacity.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarCapacity.TabIndex = 8;
            // 
            // Btn_Format
            // 
            this.Btn_Format.Location = new System.Drawing.Point(244, 93);
            this.Btn_Format.Name = "Btn_Format";
            this.Btn_Format.Size = new System.Drawing.Size(83, 27);
            this.Btn_Format.TabIndex = 10;
            this.Btn_Format.Text = "&Format Disc";
            this.Btn_Format.UseVisualStyleBackColor = true;
            this.Btn_Format.Click += new System.EventHandler(this.Btn_Format_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBurn);
            this.tabControl1.Controls.Add(this.tabPageFormat);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 306);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPageBurn
            // 
            this.tabPageBurn.Controls.Add(this.groupBox3);
            this.tabPageBurn.Controls.Add(this.groupBox2);
            this.tabPageBurn.Controls.Add(this.groupBox1);
            this.tabPageBurn.Location = new System.Drawing.Point(4, 22);
            this.tabPageBurn.Name = "tabPageBurn";
            this.tabPageBurn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBurn.Size = new System.Drawing.Size(610, 280);
            this.tabPageBurn.TabIndex = 0;
            this.tabPageBurn.Text = "Burn Files";
            this.tabPageBurn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusProgressBar);
            this.groupBox3.Controls.Add(this.Label_Status);
            this.groupBox3.Controls.Add(this.buttonBurn);
            this.groupBox3.Location = new System.Drawing.Point(359, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 143);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Progress";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Location = new System.Drawing.Point(12, 65);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(224, 15);
            this.statusProgressBar.TabIndex = 8;
            // 
            // Label_Status
            // 
            this.Label_Status.Location = new System.Drawing.Point(9, 17);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(227, 42);
            this.Label_Status.TabIndex = 7;
            this.Label_Status.Text = "status";
            this.Label_Status.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonBurn
            // 
            this.buttonBurn.Location = new System.Drawing.Point(84, 85);
            this.buttonBurn.Name = "buttonBurn";
            this.buttonBurn.Size = new System.Drawing.Size(88, 28);
            this.buttonBurn.TabIndex = 6;
            this.buttonBurn.Text = "&Burn";
            this.buttonBurn.UseVisualStyleBackColor = true;
            this.buttonBurn.Click += new System.EventHandler(this.buttonBurn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMediaType);
            this.groupBox2.Controls.Add(this.buttonDetectMedia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelTotalSize);
            this.groupBox2.Controls.Add(this.progressBarCapacity);
            this.groupBox2.Location = new System.Drawing.Point(359, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 122);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected media type:";
            // 
            // labelMediaType
            // 
            this.labelMediaType.Location = new System.Drawing.Point(117, 18);
            this.labelMediaType.Name = "labelMediaType";
            this.labelMediaType.Size = new System.Drawing.Size(119, 37);
            this.labelMediaType.TabIndex = 10;
            this.labelMediaType.Text = "Press \'Detect Media\' Button";
            // 
            // buttonDetectMedia
            // 
            this.buttonDetectMedia.Location = new System.Drawing.Point(12, 18);
            this.buttonDetectMedia.Name = "buttonDetectMedia";
            this.buttonDetectMedia.Size = new System.Drawing.Size(98, 26);
            this.buttonDetectMedia.TabIndex = 9;
            this.buttonDetectMedia.Text = "Detect Media";
            this.buttonDetectMedia.UseVisualStyleBackColor = true;
            this.buttonDetectMedia.Click += new System.EventHandler(this.buttonDetectMedia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVerification);
            this.groupBox1.Controls.Add(this.labelVerification);
            this.groupBox1.Controls.Add(this.checkBoxEject);
            this.groupBox1.Controls.Add(this.checkBoxCloseMedia);
            this.groupBox1.Controls.Add(this.TextBox_VolumeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonRemoveFiles);
            this.groupBox1.Controls.Add(this.buttonAddFolders);
            this.groupBox1.Controls.Add(this.buttonAddFiles);
            this.groupBox1.Controls.Add(this.listBoxFiles);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 270);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files to burn";
            // 
            // comboBoxVerification
            // 
            this.comboBoxVerification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVerification.FormattingEnabled = true;
            this.comboBoxVerification.Items.AddRange(new object[] {
            "None",
            "Quick",
            "Full"});
            this.comboBoxVerification.Location = new System.Drawing.Point(99, 237);
            this.comboBoxVerification.Name = "comboBoxVerification";
            this.comboBoxVerification.Size = new System.Drawing.Size(121, 20);
            this.comboBoxVerification.TabIndex = 9;
            this.comboBoxVerification.SelectedIndexChanged += new System.EventHandler(this.comboBoxVerification_SelectedIndexChanged);
            // 
            // labelVerification
            // 
            this.labelVerification.AutoSize = true;
            this.labelVerification.Location = new System.Drawing.Point(10, 240);
            this.labelVerification.Name = "labelVerification";
            this.labelVerification.Size = new System.Drawing.Size(83, 12);
            this.labelVerification.TabIndex = 8;
            this.labelVerification.Text = "Verification:";
            // 
            // checkBoxEject
            // 
            this.checkBoxEject.AutoSize = true;
            this.checkBoxEject.Checked = true;
            this.checkBoxEject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEject.Location = new System.Drawing.Point(163, 204);
            this.checkBoxEject.Name = "checkBoxEject";
            this.checkBoxEject.Size = new System.Drawing.Size(138, 16);
            this.checkBoxEject.TabIndex = 7;
            this.checkBoxEject.Text = "Eject when finished";
            this.checkBoxEject.UseVisualStyleBackColor = true;
            // 
            // checkBoxCloseMedia
            // 
            this.checkBoxCloseMedia.AutoSize = true;
            this.checkBoxCloseMedia.Checked = true;
            this.checkBoxCloseMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCloseMedia.Location = new System.Drawing.Point(10, 204);
            this.checkBoxCloseMedia.Name = "checkBoxCloseMedia";
            this.checkBoxCloseMedia.Size = new System.Drawing.Size(90, 16);
            this.checkBoxCloseMedia.TabIndex = 6;
            this.checkBoxCloseMedia.Text = "Close media";
            this.checkBoxCloseMedia.UseVisualStyleBackColor = true;
            // 
            // TextBox_VolumeLabel
            // 
            this.TextBox_VolumeLabel.Location = new System.Drawing.Point(123, 176);
            this.TextBox_VolumeLabel.Name = "TextBox_VolumeLabel";
            this.TextBox_VolumeLabel.Size = new System.Drawing.Size(128, 21);
            this.TextBox_VolumeLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Volume Label:";
            // 
            // buttonRemoveFiles
            // 
            this.buttonRemoveFiles.Location = new System.Drawing.Point(218, 145);
            this.buttonRemoveFiles.Name = "buttonRemoveFiles";
            this.buttonRemoveFiles.Size = new System.Drawing.Size(106, 25);
            this.buttonRemoveFiles.TabIndex = 3;
            this.buttonRemoveFiles.Text = "Remove File(s)...";
            this.buttonRemoveFiles.UseVisualStyleBackColor = true;
            this.buttonRemoveFiles.Click += new System.EventHandler(this.buttonRemoveFiles_Click);
            // 
            // buttonAddFolders
            // 
            this.buttonAddFolders.Location = new System.Drawing.Point(107, 145);
            this.buttonAddFolders.Name = "buttonAddFolders";
            this.buttonAddFolders.Size = new System.Drawing.Size(98, 25);
            this.buttonAddFolders.TabIndex = 2;
            this.buttonAddFolders.Text = "Add Folders...";
            this.buttonAddFolders.UseVisualStyleBackColor = true;
            this.buttonAddFolders.Click += new System.EventHandler(this.buttonAddFolders_Click);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(10, 145);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(84, 25);
            this.buttonAddFiles.TabIndex = 1;
            this.buttonAddFiles.Text = "Add Files...";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 24;
            this.listBoxFiles.Location = new System.Drawing.Point(10, 18);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(315, 100);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxFiles_DrawItem);
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // tabPageFormat
            // 
            this.tabPageFormat.Controls.Add(this.checkBoxQuickFormat);
            this.tabPageFormat.Controls.Add(this.checkBoxEjectFormat);
            this.tabPageFormat.Controls.Add(this.formatProgressBar);
            this.tabPageFormat.Controls.Add(this.Label_FormatStatus);
            this.tabPageFormat.Controls.Add(this.Btn_Format);
            this.tabPageFormat.Location = new System.Drawing.Point(4, 22);
            this.tabPageFormat.Name = "tabPageFormat";
            this.tabPageFormat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFormat.Size = new System.Drawing.Size(610, 280);
            this.tabPageFormat.TabIndex = 1;
            this.tabPageFormat.Text = "Format Disc";
            this.tabPageFormat.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuickFormat
            // 
            this.checkBoxQuickFormat.AutoSize = true;
            this.checkBoxQuickFormat.Checked = true;
            this.checkBoxQuickFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxQuickFormat.Location = new System.Drawing.Point(226, 48);
            this.checkBoxQuickFormat.Name = "checkBoxQuickFormat";
            this.checkBoxQuickFormat.Size = new System.Drawing.Size(96, 16);
            this.checkBoxQuickFormat.TabIndex = 14;
            this.checkBoxQuickFormat.Text = "Quick Format";
            this.checkBoxQuickFormat.UseVisualStyleBackColor = true;
            // 
            // checkBoxEjectFormat
            // 
            this.checkBoxEjectFormat.AutoSize = true;
            this.checkBoxEjectFormat.Checked = true;
            this.checkBoxEjectFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEjectFormat.Location = new System.Drawing.Point(226, 26);
            this.checkBoxEjectFormat.Name = "checkBoxEjectFormat";
            this.checkBoxEjectFormat.Size = new System.Drawing.Size(138, 16);
            this.checkBoxEjectFormat.TabIndex = 12;
            this.checkBoxEjectFormat.Text = "Eject when finished";
            this.checkBoxEjectFormat.UseVisualStyleBackColor = true;
            // 
            // formatProgressBar
            // 
            this.formatProgressBar.Location = new System.Drawing.Point(126, 205);
            this.formatProgressBar.Name = "formatProgressBar";
            this.formatProgressBar.Size = new System.Drawing.Size(318, 15);
            this.formatProgressBar.TabIndex = 13;
            // 
            // Label_FormatStatus
            // 
            this.Label_FormatStatus.Location = new System.Drawing.Point(125, 148);
            this.Label_FormatStatus.Name = "Label_FormatStatus";
            this.Label_FormatStatus.Size = new System.Drawing.Size(321, 51);
            this.Label_FormatStatus.TabIndex = 11;
            this.Label_FormatStatus.Text = "status";
            this.Label_FormatStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // backgroundFormatWorker
            // 
            this.backgroundFormatWorker.WorkerReportsProgress = true;
            this.backgroundFormatWorker.WorkerSupportsCancellation = true;
            this.backgroundFormatWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundFormatWorker_DoWork);
            this.backgroundFormatWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundFormatWorker_ProgressChanged);
            this.backgroundFormatWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundFormatWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 370);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Label_SupportedMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_Devices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BurnMedia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBurn.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageFormat.ResumeLayout(false);
            this.tabPageFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_Devices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_SupportedMedia;
        private System.ComponentModel.BackgroundWorker backgroundBurnWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalSize;
        private System.Windows.Forms.ProgressBar progressBarCapacity;
        private System.Windows.Forms.Button Btn_Format;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBurn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEject;
        private System.Windows.Forms.CheckBox checkBoxCloseMedia;
        private System.Windows.Forms.TextBox TextBox_VolumeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveFiles;
        private System.Windows.Forms.Button buttonAddFolders;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button buttonBurn;
        private System.Windows.Forms.TabPage tabPageFormat;
        private System.ComponentModel.BackgroundWorker backgroundFormatWorker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.ProgressBar statusProgressBar;
        private System.Windows.Forms.CheckBox checkBoxEjectFormat;
        private System.Windows.Forms.ProgressBar formatProgressBar;
        private System.Windows.Forms.Label Label_FormatStatus;
        private System.Windows.Forms.CheckBox checkBoxQuickFormat;
        private System.Windows.Forms.Label labelMediaType;
        private System.Windows.Forms.Button buttonDetectMedia;
        private System.Windows.Forms.ComboBox comboBoxVerification;
        private System.Windows.Forms.Label labelVerification;
    }
}

