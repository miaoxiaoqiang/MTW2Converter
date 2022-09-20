using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTW2Converter.Views
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Font = MainForm.CustomFont;
            Icon = Properties.Resources.App;

            DescriptText.Font = MainForm.CustomFont;
            DescriptText.AppendText("  此工具能够将中世纪2全面战争游戏目录中的text文件夹里特定的.strings.bin文件转换成.txt文件。");

            DescriptText.AppendText("\n");
            DescriptText.SelectionColor = Color.Red;
            DescriptText.AppendText("  注意：");
            DescriptText.AppendText("\n");
            DescriptText.AppendText("  此工具不会转换所有.strings.bin文件。问题是这些文件有两种类型，类型1没有标记，这意味着没有好的方法从这类文件中提取适当的信息（至少不是游戏可以理解的信息）；类型2是有标记的，这是转换工具可以解释并生成有用信息的内容。");
            DescriptText.AppendText("\n");
            DescriptText.AppendText("  原因可能是它们被静态链接到按钮之类的东西，并且是通过ID而不是标记访问的。");
            DescriptText.AppendText("\n");
            DescriptText.AppendText("  无法转换的文件如下：\n");
            DescriptText.SelectionColor = Color.IndianRed;
            DescriptText.AppendText("  battle.txt.strings.bin\n  battle_ed.txt.strings.bin\n  shared.txt.strings.bin\n  strat.txt.strings.bin");
            
            //battle.txt, battle_ed.txt, shared.txt, strat.txt, tooltips.txt

            DescriptText.AppendText("\n\n");
            DescriptText.SelectionColor = Color.DarkGray;
            DescriptText.SelectionAlignment = HorizontalAlignment.Center;
            DescriptText.AppendText("Copyright © 2017-2022 Strong. All Rights Reserved");

        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
