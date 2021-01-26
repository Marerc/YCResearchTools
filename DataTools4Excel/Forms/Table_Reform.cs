using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace ycResearchTools.forms
{
    public partial class Table_Reform : Form
    {
        public Excel.Application ExcelApp;
        Excel.Workbook wkb;
        Excel.Worksheet wks;


        public Table_Reform()
        {
            InitializeComponent();
            ExcelApp = Globals.ThisAddIn.Application;
        }

        private void Table_Reform_Load(object sender, EventArgs e)
        {
            updateUsableWkb();
            wks = ExcelApp.ActiveSheet;
            wkb = ExcelApp.ActiveWorkbook;
        }

        private void updateUsableWkb()
        {
            targetWorkbookTxt.Items.Add("taxonomy.tsv");
            foreach (Excel.Workbook wkb in ExcelApp.Workbooks)
            {
                targetWorkbookTxt.Items.Add(wkb.Name);
            }
            targetWorkbookTxt.Text = "taxonomy.tsv";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ExcelApp.ActiveWorkbook.Path);
            //MessageBox.Show(ExcelApp.ActiveWorkbook.FullName);
            

            Excel.Worksheet target_wks;
            try
            {
                target_wks = ExcelApp.Workbooks[targetWorkbookTxt.Text].ActiveSheet;
                //MessageBox.Show(target_wks.Cells[2, 2].Text + (!target_wks.Cells[2, 2].Text.Contains("D_0")) + (!target_wks.Cells[2, 2].Text.Contains("k__"))+ (!target_wks.Cells[2, 2].Text.Contains("d__")));
                
                if ((!target_wks.Cells[2,2].Text.Contains("D_0")) & (!target_wks.Cells[2, 2].Text.Contains("k__")) & (!target_wks.Cells[2, 2].Text.Contains("d__")))
                {
                    MessageBox.Show("目标工作簿不包含需要的分类数据，请检查。");
                    return;
                }
            }
            catch (Exception)
            {
                if (MessageBox.Show("目标工作簿没有打开，请手动打开！！\n点击确定直接退出功能，点击取消重新选择目标工作簿", "目标工作簿没有打开？", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    this.Dispose();
                }
                return;
            }

            if (sortTargetCKB.Checked)
            {
                utils.lianChuanBio.reformTaxonomyFromQiime2(target_wks);
            }
            Excel.Range target_last = target_wks.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range target_area = target_wks.Range[target_wks.Cells[1, 1], target_wks.Cells[target_last.Row, 2]];

            wks.Activate();
            wks.Rows[1].delete();
            //找到最后一行和最后列
            Excel.Range last = wks.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);


            //Excel.Range rgs = wks.Range[wks.Range["b2"], wks.Cells[last.Row, 2]];
            //MessageBox.Show(last.Address);

            Excel.Range rgs = wks.Range[wks.Cells[2, last.Column + 1], last.Offset[0, 1]];
            //MessageBox.Show(rgs.Address);
            foreach (Excel.Range rg in rgs)
            {
                //= VLOOKUP(F1, taxonomy.tsv!$A$28:$B$32, 2, 0)
                //=[taxonomy.tsv]taxonomy!$A$2:$B$5
                Excel.Range refCell = rg.Offset[0, -(rg.Column - 1)];
                if(refCell.Text != "")
                {
                    rg.Formula = "= vlookup(" + refCell.Address[0, 0] + ", [" + targetWorkbookTxt.Text + "]" + target_wks.Name + "!" + target_area.Address + ", 2, 0)";
                }
            }
            rgs.Copy();
            rgs.PasteSpecial(Excel.XlPasteType.xlPasteValues, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
            Clipboard.Clear();
            wks.Cells[1, last.Column + 1].value = "Taxonomy";
            wks.Cells[1, 1].value = "feature ID";

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "修改已经完成，请选择保存位置";
            saveFile.RestoreDirectory = true;
            saveFile.InitialDirectory = ExcelApp.ActiveWorkbook.Path;
            saveFile.Filter = "xlsx文件 (*.xlsx)|*.xlsx|tsv文件(*.tsv)|*.tsv|All files(*.*)|*.*";
            saveFile.FileName = "table-with-taxonomy";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                ExcelApp.Workbooks[targetWorkbookTxt.Text].Close(0);
                //MessageBox.Show(saveFile.FileName + "\n" + saveFile.CheckPathExists);
                //System.IO.FileStream myStream;
                //if ((myStream = saveFile.OpenFile()) != null)
                //{
                //    // Code to write the stream goes here.
                //    myStream.Close();
                //}

                wkb.SaveAs(saveFile.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook);
                this.Dispose();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
