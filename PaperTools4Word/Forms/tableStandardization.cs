using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace PaperTools4Word.Forms
{
    public partial class tableStandardization : Form
    {

        Word.Application WordApp;
        object missing = System.Reflection.Missing.Value;

        public tableStandardization()
        {
            InitializeComponent();
            WordApp = Globals.ThisAddIn.Application;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (tableStandization())
            {
                this.Dispose();
            }
        }

        private bool tableStandization()
        {

            //循环所有选中表
            foreach ( Word.Table table in WordApp.Selection.Tables)
            {


                //MessageBox.Show(table.Rows.Count.ToString() + "X" + table.Columns.Count.ToString());
                int rowCount = table.Rows.Count;
                int colCount = table.Columns.Count;
 

                //操作列标题内容
                if (!ignoreColHeadmodify.Checked)
                {
                    foreach (Word.Cell cell in table.Rows[1].Cells)
                    {
                        //MessageBox.Show("列标题当前列：" + cell.ColumnIndex.ToString());
                        if (columnHeadSentenceFisrt.Checked)
                        {
                            //cell.Range.Text = Utils.Words.capFirst(cell.Range.Text);
                        }
                        if (columnHeadWordFirst.Checked)
                        {
                            cell.Range.Text = Utils.Words.titleCase(cell.Range.Text);
                        }
                        if (columnHeadWordAll.Checked)
                        {
                            cell.Range.Text = Utils.Words.capAll(cell.Range.Text);
                        }

                        switch (columnHeadPosition.Text)
                        {
                            case "居中":
                                cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                                break;
                            case "靠左":
                                cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                                break;
                            default:
                                break;
                        }

                    }
                }


                //操作行标题
                if (!ignoreRowHeadmodify.Checked)
                {
                    for (int i = 1; i < rowCount; i++)
                    {
                        Word.Cell cell = table.Cell(i, 1);

                        //MessageBox.Show("航标题当前行：" + cell.RowIndex.ToString());
                        if (rowHeadSentenceFisrt.Checked)
                        {
                            cell.Range.Text = Utils.Words.capFirst(cell.Range.Text);
                        }
                        if (rowHeadWordFirst.Checked)
                        {
                            cell.Range.Text = Utils.Words.titleCase(cell.Range.Text);
                        }
                        if (rowHeadWordAll.Checked)
                        {
                            //cell.Range.Text = Utils.Words.capAll(cell.Range.Text);
                        }

                    }
                }

                

                switch (rowHeadPosition.Text)
                {
                    case "居中":
                        WordApp.ActiveDocument.Range(table.Cell(2, 1).Range.Start, table.Cell(table.Rows.Count, 1).Range.End).ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        break;
                    case "靠左":
                        WordApp.ActiveDocument.Range(table.Cell(2, 1).Range.Start, table.Cell(table.Rows.Count, 1).Range.End).ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        break;
                    default:
                        break;
                }



                //操作数据内容
                Word.Range dataArea = WordApp.ActiveDocument.Range(table.Cell(2, 2).Range.Start,
                    table.Cell(table.Rows.Count, table.Columns.Count).Range.End);
                switch (dataPosition.SelectedItem)
                {
                    case "居中":
                        dataArea.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        break;
                    case "靠左":
                        dataArea.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                        break;
                    default:
                        break;
                }


                Globals.ThisAddIn.searchRangeReplaceSigSign(dataArea);

                if (columnFitWord.Checked)
                {
                    for (int i = 2; i <= table.Columns.Count; i++)
                    {
                        //MessageBox.Show("适应列：" + i.ToString());
                        table.Columns[i].AutoFit();
                    }
                }


                //设置三线表
                if (addThreeWire.Checked)
                {
                    table.Rows[1].Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    table.Rows[1].Borders[Word.WdBorderType.wdBorderBottom].LineWidth = Word.WdLineWidth.wdLineWidth050pt;

                    table.Rows[1].Borders[Word.WdBorderType.wdBorderTop].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    table.Rows[1].Borders[Word.WdBorderType.wdBorderBottom].LineWidth = Word.WdLineWidth.wdLineWidth050pt;

                    table.Rows[table.Rows.Count].Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    table.Rows[table.Rows.Count].Borders[Word.WdBorderType.wdBorderBottom].LineWidth = Word.WdLineWidth.wdLineWidth050pt;
                }

                //垂直居中
                if (verticalCenter.Checked)
                {
                    for (int i = 1; i <= table.Rows.Count; i++)
                    {
                        //MessageBox.Show("垂直居中，行好：" + i.ToString());
                        table.Rows[i].Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    }
                }
                return true;
            }


            return false;
        }



        private void tableStandardization_Load(object sender, EventArgs e)
        {
            //界面初始化
            columnHeadPosition.SelectedIndex = 0;
            rowHeadPosition.SelectedIndex = 0;
            dataPosition.SelectedIndex = 0;



            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 300;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.processAllTables, "取消勾选将只操作选中的第一个表格");



            // Set up the ToolTip text for the Button and Checkbox.
            //if (processAllTables.Visible)
            //{
            //    toolTip1.SetToolTip(this.processAllTables, "取消勾选将只操作选中的第一个表格");
            //}








        }


        private void ignoreColHeadmodify_CheckedChanged(object sender, EventArgs e)
        {
            if (ignoreColHeadmodify.Checked)
            {
                columnHead.Enabled = false;
            }
            else
            {
                columnHead.Enabled = true;
            }
        }

        private void ignoreRowHeadmodify_CheckedChanged(object sender, EventArgs e)
        {
            if (ignoreRowHeadmodify.Checked)
            {
                rowHead.Enabled = false;
            }
            else
            {
                rowHead.Enabled = true;
            }
        }

        private void fontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                fontInfo.Text = "";
                fontInfo.Text = fontInfo.Text + "字体：" + fd.Font;
                fontInfo.Text = fontInfo.Text + "颜色：" + fd.Color;
            }
        }

        private void paraBtn_Click(object sender, EventArgs e)
        {
            paraInfo.Text = "功能还没做呢";
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
