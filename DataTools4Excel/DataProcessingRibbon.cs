using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ycResearchTools
{
    public partial class DataProcessingRibbon
    {
        public Excel.Application ExcelApp;

        private void Ribbon_ycResearch_Load(object sender, RibbonUIEventArgs e)
        {
            ExcelApp = Globals.ThisAddIn.Application;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Form longMean = new forms.longdataMean();
            longMean.Show();
        }

        private void taxNameSetButton_Click(object sender, RibbonControlEventArgs e)
        {
            //utils.lianChuanBio lc = new utils.lianChuanBio();
            utils.lianChuanBio.reformTaxonomyFromQiime2(ExcelApp.ActiveSheet);
            MessageBox.Show("执行完成，请检查结果！！！");
        }

 

        private void tableReformBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Form tableReform1 = new forms.Table_Reform();
            tableReform1.Show();
        }

        private void tableSummarizer(object sender, RibbonControlEventArgs e)
        {
            if (utils.lianChuanBio.tableSummary(ExcelApp.ActiveSheet))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "表总结完成，请选择保存位置！！！";
                saveFileDialog.InitialDirectory = ExcelApp.ActiveWorkbook.Path;
                saveFileDialog.FileName = "table-summarized.xlsx";
                saveFileDialog.Filter = "xlsx文件 (*.xlsx)|*.xlsx|tsv文件(*.tsv)|*.tsv|All files(*.*)|*.*";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelApp.ActiveWorkbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook);
                }
            }
            //MessageBox.Show("执行完成，请检查结果！！！");
        }
    }
}
