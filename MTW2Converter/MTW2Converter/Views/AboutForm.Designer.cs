namespace MTW2Converter.Views
{
    partial class AboutForm
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
            this.DescriptText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DescriptText
            // 
            this.DescriptText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptText.CausesValidation = false;
            this.DescriptText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptText.Location = new System.Drawing.Point(0, 0);
            this.DescriptText.Name = "DescriptText";
            this.DescriptText.ReadOnly = true;
            this.DescriptText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DescriptText.ShortcutsEnabled = false;
            this.DescriptText.Size = new System.Drawing.Size(329, 229);
            this.DescriptText.TabIndex = 0;
            this.DescriptText.Text = "";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 229);
            this.Controls.Add(this.DescriptText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于此工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox DescriptText;
    }
}