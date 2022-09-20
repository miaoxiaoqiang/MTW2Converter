namespace MTW2Converter.Views
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStripBar = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOperate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConvertFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnClearOutPath = new System.Windows.Forms.Button();
            this.BtnOutputFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBOutputPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConvertOutInfo = new System.Windows.Forms.RichTextBox();
            this.MenuStripBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripBar
            // 
            this.MenuStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuOperate,
            this.MenuHelp});
            this.MenuStripBar.Location = new System.Drawing.Point(0, 0);
            this.MenuStripBar.Name = "MenuStripBar";
            this.MenuStripBar.Size = new System.Drawing.Size(459, 25);
            this.MenuStripBar.TabIndex = 1;
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFolder,
            this.MenuItemFile});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(58, 21);
            this.MenuFile.Text = "文件(&F)";
            // 
            // MenuItemFolder
            // 
            this.MenuItemFolder.Name = "MenuItemFolder";
            this.MenuItemFolder.Size = new System.Drawing.Size(124, 22);
            this.MenuItemFolder.Text = "选择目录";
            this.MenuItemFolder.Click += new System.EventHandler(this.MenuItemFolder_Click);
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(124, 22);
            this.MenuItemFile.Text = "选择文件";
            this.MenuItemFile.Click += new System.EventHandler(this.MenuItemFile_Click);
            // 
            // MenuOperate
            // 
            this.MenuOperate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemConvertFile,
            this.MenuItemClearAll});
            this.MenuOperate.Name = "MenuOperate";
            this.MenuOperate.Size = new System.Drawing.Size(61, 21);
            this.MenuOperate.Text = "处理(&H)";
            // 
            // MenuItemConvertFile
            // 
            this.MenuItemConvertFile.Name = "MenuItemConvertFile";
            this.MenuItemConvertFile.Size = new System.Drawing.Size(100, 22);
            this.MenuItemConvertFile.Text = "转换";
            this.MenuItemConvertFile.Click += new System.EventHandler(this.MenuItemConvertFile_Click);
            // 
            // MenuItemClearAll
            // 
            this.MenuItemClearAll.Name = "MenuItemClearAll";
            this.MenuItemClearAll.Size = new System.Drawing.Size(100, 22);
            this.MenuItemClearAll.Text = "清屏";
            this.MenuItemClearAll.Click += new System.EventHandler(this.MenuItemClearAll_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(61, 21);
            this.MenuHelp.Text = "帮助(&H)";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(100, 22);
            this.MenuItemAbout.Text = "关于";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnClearOutPath);
            this.groupBox1.Controls.Add(this.BtnOutputFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBOutputPath);
            this.groupBox1.Location = new System.Drawing.Point(2, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出目录";
            // 
            // BtnClearOutPath
            // 
            this.BtnClearOutPath.Location = new System.Drawing.Point(375, 19);
            this.BtnClearOutPath.Name = "BtnClearOutPath";
            this.BtnClearOutPath.Size = new System.Drawing.Size(75, 23);
            this.BtnClearOutPath.TabIndex = 3;
            this.BtnClearOutPath.Text = "清除";
            this.BtnClearOutPath.UseVisualStyleBackColor = true;
            this.BtnClearOutPath.Click += new System.EventHandler(this.BtnClearOutPath_Click);
            // 
            // BtnOutputFolder
            // 
            this.BtnOutputFolder.Location = new System.Drawing.Point(294, 19);
            this.BtnOutputFolder.Name = "BtnOutputFolder";
            this.BtnOutputFolder.Size = new System.Drawing.Size(75, 23);
            this.BtnOutputFolder.TabIndex = 2;
            this.BtnOutputFolder.Text = "选择";
            this.BtnOutputFolder.UseVisualStyleBackColor = true;
            this.BtnOutputFolder.Click += new System.EventHandler(this.BtnOutputFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "路径：";
            // 
            // TBOutputPath
            // 
            this.TBOutputPath.Location = new System.Drawing.Point(57, 20);
            this.TBOutputPath.Name = "TBOutputPath";
            this.TBOutputPath.ReadOnly = true;
            this.TBOutputPath.ShortcutsEnabled = false;
            this.TBOutputPath.Size = new System.Drawing.Size(231, 21);
            this.TBOutputPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConvertOutInfo);
            this.groupBox2.Location = new System.Drawing.Point(2, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消息窗口";
            // 
            // ConvertOutInfo
            // 
            this.ConvertOutInfo.BackColor = System.Drawing.SystemColors.MenuText;
            this.ConvertOutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertOutInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.ConvertOutInfo.Location = new System.Drawing.Point(3, 17);
            this.ConvertOutInfo.Name = "ConvertOutInfo";
            this.ConvertOutInfo.ReadOnly = true;
            this.ConvertOutInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ConvertOutInfo.ShortcutsEnabled = false;
            this.ConvertOutInfo.Size = new System.Drawing.Size(448, 246);
            this.ConvertOutInfo.TabIndex = 0;
            this.ConvertOutInfo.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MenuStripBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStripBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MenuStripBar.ResumeLayout(false);
            this.MenuStripBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStripBar;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFolder;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBOutputPath;
        private System.Windows.Forms.Button BtnOutputFolder;
        private System.Windows.Forms.Button BtnClearOutPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox ConvertOutInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuOperate;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConvertFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClearAll;
    }
}

