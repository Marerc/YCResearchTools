using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word;
using System.IO;
using System.Diagnostics;

namespace PaperTools4Word
{
    public partial class tools4Word
    {
        Word.Application WordApp;
        object missing = System.Reflection.Missing.Value;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            WordApp = Globals.ThisAddIn.Application;
        }

        private void superscriptCase_Click(object sender, RibbonControlEventArgs e)
        {
            //只能选中数据
            switch (MessageBox.Show(
                "请确保仅仅选中需要上标【数据的部分】",
                "！！！Caution 请注意：",
                MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    Globals.ThisAddIn.searchSelReplaceSigSign();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }

        }


        private void tst_Click(object sender, RibbonControlEventArgs e)
        {
            //searchReplaceSigSign();
            Globals.ThisAddIn.CreateDocumentPropertyTable();
        }

        private void tableStandardizer_Click(object sender, RibbonControlEventArgs e)
        {
            int tableSelectedCount = WordApp.Selection.Tables.Count;
            if (tableSelectedCount < 1)
            {
                MessageBox.Show("您选中的内容中没有包括任何表格！", "提醒");
                return;
            }
            else
            {
                Forms.tableStandardization ts = new Forms.tableStandardization();
                ts.processAllTables.Text = "操作选中的所有表(" + tableSelectedCount.ToString() + "个)";

                if (tableSelectedCount == 1)
                {
                    ts.processAllTables.Visible = false;
                }

                ts.Show();
            }
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            //MessageBox.Show(WordApp.Selection.Tables.Count.ToString());
            //foreach(Word.Cell cell in WordApp.Selection.Tables[1].Rows[1].Cells)
            //{

            //}


        }

        private void mySave_Click(object sender, RibbonControlEventArgs e)
        {
            if (!Properties.Settings.Default.useDefaultSaveSetting)
            {
                Forms.mySaveForm ms = new Forms.mySaveForm();
                ms.Show();
            }
            else
            {
                //直接版本号加一保存在文件所在目录

            }
        }

        private void mySaveSetting_Click(object sender, RibbonControlEventArgs e)
        {
            Forms.mySaveForm ms = new Forms.mySaveForm();
            ms.Show();
        }

        private void viewLogs_Click(object sender, RibbonControlEventArgs e)
        {

            string log_path = WordApp.ActiveDocument.Path +
                "\\1、" + Path.GetFileName(WordApp.ActiveDocument.Name).Split('.')[0] + 
                "-修改日志.txt";
            //MessageBox.Show("日志路径： " + log_path);
            if (File.Exists(log_path))
            {
                Process.Start("NOTEPAD.exe", log_path);
            }
            else
            {
                MessageBox.Show("没有log文件！！");
            }
        }
    }
}
