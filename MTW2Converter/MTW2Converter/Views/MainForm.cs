using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MTW2Converter.Model;

namespace MTW2Converter.Views
{
    public partial class MainForm : Form
    {
        private readonly OpenFileDialog fileDialog;
        private readonly FolderBrowserDialog folderBrowserDialog;
        private readonly FolderBrowserDialog outfolderBrowserDialog;
        private readonly AboutForm aboutForm;
        private readonly ToolTip tip;

        private static IList<FileDetail> files;
        internal static PrivateFontCollection FontCollection;
        internal static Font CustomFont;

        public MainForm()
        {
            files = new List<FileDetail>();
            FontCollection = new();
            byte[] fontData = Properties.Resources.WebFont;
            unsafe
            {
                fixed (byte* pFontData = fontData)
                {
                    FontCollection.AddMemoryFont((IntPtr)pFontData, fontData.Length);
                }
            }
            CustomFont = new Font(FontCollection.Families[0], 9F, FontStyle.Regular);

            tip = new();

            InitializeComponent();
            Font = CustomFont;
            ConvertOutInfo.Font = new Font(FontCollection.Families[0], 11, FontStyle.Regular); ;
            MenuStripBar.Font = CustomFont;
            Icon = Properties.Resources.App;
            Text = "中世纪2 - .Strings.Bin To .TXT 转换工具";

            MenuItemConvertFile.Image = Properties.Resources.Convert;
            MenuItemClearAll.Image = Properties.Resources.Clear;
            MenuItemFile.Image = Properties.Resources.File;
            MenuItemFolder.Image = Properties.Resources.Folder;
            MenuItemAbout.Image = Properties.Resources.Help;

            fileDialog = new()
            {
                Multiselect = true,
                InitialDirectory = Application.StartupPath,
                Filter = "FILE_STRINGS|*.txt.strings.bin",
                CheckFileExists = true
            };

            folderBrowserDialog = new()
            {
                SelectedPath = Application.StartupPath,
                ShowNewFolderButton = false
            };

            outfolderBrowserDialog = new()
            {
                SelectedPath = Application.StartupPath,
                ShowNewFolderButton = false
            };

            aboutForm = new();

            tip.SetToolTip(TBOutputPath, "设置后将转换后的txt文件输出到指定的目录\n若不设置则输出到源文件所在的目录");
            MenuItemConvertFile.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MenuItemFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo directoryInfo = new(folderBrowserDialog.SelectedPath);
                FileInfo[] fileInfos = directoryInfo.GetFiles("*.txt.strings.bin");
                files.Clear();
                files = fileInfos.Select(p => new FileDetail() { FolderPath = folderBrowserDialog.SelectedPath + "\\", FileName = p.Name }).ToList();
                
                ConvertOutInfo.Clear();
                ConvertOutInfo.AppendText($"共有{{{files.Count}}}个文件要转换");
            }
            if (files.Count > 0)
            {
                MenuItemConvertFile.Enabled = true;
                ConvertOutInfo.Select(3, files.Count.ToString().Length);
                ConvertOutInfo.SelectionColor = Color.Green;
            }
        }

        private void MenuItemFile_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                files.Clear();
                foreach (string item in fileDialog.FileNames)
                {
                    files.Add(new FileDetail() { FolderPath = Path.GetDirectoryName(item) + "\\", FileName = Path.GetFileName(item) });
                }

                ConvertOutInfo.Clear();
                ConvertOutInfo.AppendText($"共有{{{files.Count}}}个文件要转换");
            }
            if (files.Count > 0)
            {
                MenuItemConvertFile.Enabled = true;
                ConvertOutInfo.Select(3, files.Count.ToString().Length);
                ConvertOutInfo.SelectionColor = Color.Green;
            }
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog(this);
        }

        private void BtnOutputFolder_Click(object sender, EventArgs e)
        {
            if (outfolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TBOutputPath.Text = outfolderBrowserDialog.SelectedPath + "\\";
            }
        }

        private void BtnClearOutPath_Click(object sender, EventArgs e)
        {
            TBOutputPath.Text = string.Empty;
        }

        private void MenuItemClearAll_Click(object sender, EventArgs e)
        {
            files.Clear();
            ConvertOutInfo.Clear();
            TBOutputPath.Text = string.Empty;
            MenuItemConvertFile.Enabled = false;
        }

        private void MenuItemConvertFile_Click(object sender, EventArgs e)
        {
            MenuItemConvertFile.Enabled = false;
            ConvertOutInfo.AppendText("\n");
            ConvertOutInfo.AppendText("Starting to convert the selected files");
            ConvertOutInfo.AppendText("\n");
            int errorfifle = 0;
            int errorindex = 0;

            if (!string.IsNullOrEmpty(TBOutputPath.Text))
            {
                Directory.CreateDirectory(TBOutputPath.Text);
            }

            try
            {
                for (int i = 0; i < files.Count; i++)
                {
                    errorindex = i;
                    ConvertOutInfo.AppendText($"Converting file [{files[i].FileName}]({(i + 1)} of {files.Count})");

                    using (FileStream fs = new(files[i].FolderPath + files[i].FileName, FileMode.Open, FileAccess.Read))
                    {
                        BinaryReader binReader = new(fs);

                        ushort firstchar = BitConverter.ToUInt16(binReader.ReadBytes(2), 0);
                        ushort secondchar = BitConverter.ToUInt16(binReader.ReadBytes(2), 0);
                        ushort validrecords = BitConverter.ToUInt16(binReader.ReadBytes(4), 0);
                        //ushort validrecords = 0;
                        if (firstchar != 2 && firstchar != 2 || secondchar != 2048)//检查文件头部信息
                        {
                            errorfifle++;
                            binReader.Close();
                            binReader.Dispose();
                            fs.Close();
                            fs.Dispose();

                            ConvertOutInfo.AppendText(" 失败：文件内容格式与预期格式不符合");
                            ConvertOutInfo.Select(ConvertOutInfo.TextLength - 17, 17);
                            ConvertOutInfo.SelectionColor = Color.Red;
                            ConvertOutInfo.AppendText("\n");
                            continue;
                        }

                        //int[] _headinfo = { 0xFFFE, 0xAC00 };
                        //byte[] bBuffer = binReader.ReadBytes((int)fs.Length);
                        //string str = Encoding.Unicode.GetString(bBuffer, 6, bBuffer.Length - 6).Replace("\0", "");
                        //str = Helper.Dec2HexStreamByPack(0xFFFE) + Helper.Dec2HexStreamByPack(0xAC00);
                        //continue;

                        File.Delete(files[i].FolderPath + files[i].FileName.Replace(".strings.bin", ""));
                        using (FileStream fs_write = new((string.IsNullOrEmpty(TBOutputPath.Text) ? files[i].FolderPath : TBOutputPath.Text) + files[i].FileName.Replace(".strings.bin", ""), FileMode.Create))
                        {
                            byte[] hexarray = { 0xff, 0xfe, 0xac, 0x0000, 0x0d, 0x00, 0x0a, 0x00 };
                            fs_write.Write(hexarray, 0, hexarray.Length);

                            for (int m = 0; m < validrecords; m++)
                            {
                                string _predata = "";
                                ushort _prelength = BitConverter.ToUInt16(binReader.ReadBytes(2), 0);
                                for (int j = 0; j < _prelength; j++)
                                {
                                    _predata += Encoding.Unicode.GetString(binReader.ReadBytes(2));
                                }

                                string _posdata = "";
                                ushort _poslength = BitConverter.ToUInt16(binReader.ReadBytes(2), 0);
                                for (int k = 0; k < _poslength; k++)
                                {
                                    byte[] _tempbyte = binReader.ReadBytes(2);
                                    ushort _temp = BitConverter.ToUInt16(_tempbyte, 0);
                                    if (_temp == 10)
                                    {
                                        _posdata += "\n";
                                    }
                                    else
                                    {
                                        _posdata += Encoding.Unicode.GetString(_tempbyte);
                                    }
                                }

                                byte[] buffer = Encoding.Unicode.GetBytes("{" + _predata + "}" + _posdata + "\r\n");
                                fs_write.Write(buffer, 0, buffer.Length);
                                fs_write.Flush();
                            }

                            ConvertOutInfo.AppendText(" 成功");
                            ConvertOutInfo.Select(ConvertOutInfo.TextLength - 2, 2);
                            ConvertOutInfo.SelectionColor = Color.GreenYellow;
                            ConvertOutInfo.AppendText("\n");
                        }
                    }
                }
                ConvertOutInfo.AppendText("\nConversion Ended.");
                ConvertOutInfo.AppendText($"\nBatch convert of {files.Count} files finished. {files.Count - errorfifle} succeeded, {errorfifle} failed.");
            }
            catch (Exception ex)
            {
                File.Delete(Application.StartupPath + "\\" + files[errorindex].FileName.Replace(".strings.bin", ""));
                Directory.CreateDirectory(Application.StartupPath + "\\log\\");
                File.WriteAllText(Application.StartupPath + "\\log\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log", ex.Message, Encoding.UTF8);
                ConvertOutInfo.AppendText("\n");
                ConvertOutInfo.AppendText("转换异常出错，请查看日志。");
                ConvertOutInfo.Select(ConvertOutInfo.TextLength - 13, 13);
                ConvertOutInfo.SelectionColor = Color.Brown;
                ConvertOutInfo.AppendText("\n");
            }
            finally
            {
                files.Clear();
            }
        }
    }
}
