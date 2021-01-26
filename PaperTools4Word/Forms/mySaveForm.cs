using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;

namespace PaperTools4Word.Forms
{
    

    public partial class mySaveForm : Form
    {
        Word.Application WordApp;
        bool isRenameNeed = false;
        

        public mySaveForm()
        {
            InitializeComponent();
            WordApp = Globals.ThisAddIn.Application;
        }

        private void mySaveButton_Click(object sender, EventArgs e)
        {
            if(this.saveDir.Text == "")
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "请选择保存路径";
                saveFile.RestoreDirectory = true;
                saveFile.Filter = "word文件 (*.docx)|*.docx";
                saveFile.FileName = this.finaFilename.Text;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    //wkb.SaveAs(saveFile.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook);

                    WordApp.ActiveDocument.SaveAs2(saveFile.FileName, WordApp.ActiveDocument.SaveFormat);
                    saveRevisionLogFile("文件名：" + Path.GetFileName(saveFile.FileName), "v第一次创建", Path.GetDirectoryName(saveFile.FileName));
                    this.Dispose();
                    return;
                }
            }

            //路径不为空，可以直接保存
            if(MessageBox.Show("路径：\n" + saveDir.Text + "\\" + 
                finaFilename.Text + "." + WordApp.ActiveDocument.SaveFormat + ".docx", "保存版本", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                WordApp.ActiveDocument.SaveAs2(saveDir.Text + "\\" + finaFilename.Text + ".docx", WordApp.ActiveDocument.SaveFormat);

            }
            else
            {
                return;
            }

            if (this.useDefeatSave.Checked)
            {
                Properties.Settings.Default.useDefaultSaveSetting = true;
            }

            saveRevisionLogFile("文件名：" + finaFilename.Text, "v" + this.ves1after.Text + "." + ves2after.Text);
            this.Dispose();
        }

        private void mySaveForm_Load(object sender, EventArgs e)
        {
            //载入相关的变量
            isRenameNeed = false;
            Utils.SaveClass ms = new Utils.SaveClass(WordApp.ActiveDocument.Name);
            this.saveDir.Text = WordApp.ActiveDocument.Path;


            this.thesisName.Text = ms.thesis_name;
            this.verName.Text = ms.version_name;

            if (this.thesisName.Text == "")
            {
                this.thesisName.Text = "请输入论文题目";
            }

            if (this.verName.Text == "")
            {
                this.verName.Text = "请输入版本名称";
            }

            //决定顺序
            if (this.thesisName.Text == "请输入论文题目")
            {
                this.thesisName.TabIndex = 0;
            }
            else
            {
                if (this.verName.Text == "请输入版本名称")
                {
                    this.verName.TabIndex = 0;
                }
                else
                {
                    this.noteInput.TabIndex = 0;
                }
            }

            //恢复正常的tab顺序

            if (this.thesisName.Text == "请输入论文题目" || this.verName.Text == "请输入版本名称")
            {
                isRenameNeed = true;
            }

            for (int i = 0; i < 4; i++)
            {
                this.ves1before.Items.Add((i + ms.version1).ToString());
            }
            this.ves1before.SelectedIndex = 0;

            for (int i = 0; i < 4; i++)
            {
                this.ves2before.Items.Add((i + ms.version2).ToString());
            }
            this.ves2before.SelectedIndex = 0;
        }

        private void ves2before_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ves2after.Items.Clear();
            for (int i = 1; i < 4; i++)
            {
                this.ves2after.Items.Add((Convert.ToInt32(this.ves2before.SelectedItem) + i).ToString());
            }
            this.ves2after.SelectedIndex = 0;
        }



        private void ves1before_SelectedIndexChanged(object sender, EventArgs e)
        {
            ves1after.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                this.ves1after.Items.Add((Convert.ToInt32(this.ves1before.SelectedItem) + i).ToString());
            }
            this.ves1after.SelectedIndex = 0;
            updateFilename();
        }


        private void updateFilename()
        {
            this.finaFilename.Text = thesisName.Text.Trim().Replace("-", "_").Replace(".", "_") + "." + verName.Text.Trim() + "-v" + ves1after.SelectedItem + "." +
                ves2after.SelectedItem + (noTimestamp.Checked ? "" : "-" + DateTime.Now.ToString("yyyyMMdd"));
        }

        private void noTimestamp_CheckedChanged(object sender, EventArgs e)
        {
            updateFilename();
        }

        private void ves2after_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFilename();
        }


        private void saveRevisionLogFile(string s, string ver = "没有版本", string dir_="")
        {
            string path = "";
            if(noteInput.Text.Trim().Length > 0)
            {
                //写入修改日志

                { 
                    if(dir_ == "")
                    {
                        path = this.saveDir.Text;
                    }
                    else
                    {
                        path = dir_;
                    }

                    path = path + "\\1、" + finaFilename.Text.Split('.')[0].Replace("-", "_") + "-修改日志.txt";

                    string line = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  v" + ver + 
                        "  by：" + WordApp.ActiveDocument.BuiltInDocumentProperties.Item["Last Author"].Value + "     " 
                        + "      " + s + "\n" + noteInput.Text + "\n\n";
                    //MessageBox.Show("日志文件：" + path);

                    if (!File.Exists(path))
                    {
                        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);

                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(line);
                        sw.Flush();
                        sw.Close();

                    }
                    else
                    {
                        FileStream fs = new FileStream(path, FileMode.Append);
                        //文本写入
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(line);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }

        private void ves1after_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFilename();
        }

        private void saveOrigin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(isRenameNeed.ToString());
            if(this.saveDir.Text == "" || isRenameNeed)
            {
                //文件需要改名保存，调用版本保存
                mySaveButton_Click("", e);
                return;
            }

            WordApp.ActiveDocument.Save();
            saveRevisionLogFile("文件名：" + WordApp.ActiveDocument.Name, "v" + this.ves1before.Text + "." + ves2before.Text);
            this.Dispose();
        }

        private void thesisName_TextChanged(object sender, EventArgs e)
        {
            updateFilename();
        }

        private void verName_TextChanged(object sender, EventArgs e)
        {
            updateFilename();
        }

    }
}
