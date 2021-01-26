using Microsoft.Office.Interop.Excel;
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
    public partial class longdataMean : Form
    {
        public Excel.Application ExcelApp;

        public longdataMean()
        {
            InitializeComponent();
            ExcelApp = Globals.ThisAddIn.Application;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancelForDest();
            cancelForSource();
            this.Dispose();
        }

        private void longdataMean_Load(object sender, EventArgs e)
        {
            this.replicate.SelectedIndex = 0;
            this.resAccurancy1.SelectedIndex = 0;
            this.resAccurancy2.SelectedIndex = 0;

            //直接委托选择数据
            //Excel.Worksheet wks = ExcelApp.ActiveSheet;
            //Excel.Range sourceArea = wks.Range[ExcelApp.Selection.Address[0, 0]];
            //MessageBox.Show(sourceArea.Cells.Count.ToString());

            if (ExcelApp.Range[ExcelApp.Selection.Address[0, 0]].Cells.Count > 1)
            {
                dest.TabIndex = 0;
                this.source.Text = ExcelApp.Selection.Address[0, 0];
                ExcelApp.SheetSelectionChange += new Excel.AppEvents_SheetSelectionChangeEventHandler(getAddrForDest);
                this.destLabel.ForeColor = Color.Red;
                this.sourceLabel.ForeColor = Color.Black;
            }
            else
            {
                ExcelApp.SheetSelectionChange += new Excel.AppEvents_SheetSelectionChangeEventHandler(getAddrForSource);
                this.destLabel.ForeColor = Color.Black;
                this.sourceLabel.ForeColor = Color.Red;
            }
        }

        private void getAddrForSource(object Sh, Range Target)
        {
            this.Invoke(new System.Action(() =>
            {
                this.source.Text = Target.Cells.get_Address(0,0);
            }));
        }

        private void cancelForSource()
        {
            this.sourceLabel.ForeColor = Color.Black;
            ExcelApp.SheetSelectionChange -= new Excel.AppEvents_SheetSelectionChangeEventHandler(getAddrForSource);
        }




        private void selFinish_Click(object sender, EventArgs e)
        {
            cancelForSource();
            cancelForDest();
        }

        private bool hzFunction()
        {

            cancelForDest();
            cancelForSource();


            //MessageBox.Show(wkbList.SelectedItem.ToString());
            //MessageBox.Show(this.wksList.SelectedItem.ToString());
            Excel.Worksheet wks = ExcelApp.ActiveSheet;
            Excel.Range sourceArea;
            Excel.Range destStart;

            try
            {
                sourceArea = wks.Range[source.Text];
                destStart = wks.Range[dest.Text];
            }
            catch
            {
                MessageBox.Show("你的参数有点问题哦，请重新打开功能");
                return false;
            }



            //取得重复数
            int repli;
            int.TryParse(replicate.Text, out repli);

            //指标个数
            int zhibiao = sourceArea.Columns.Count - 1;
            //MessageBox.Show("指标个数" + zhibiao);
            int treatments = (sourceArea.Rows.Count - 1) / repli;
            //MessageBox.Show("处理：" + treatments);


            //取得小数点表示
            string resAcc1 = "#0.00";
            switch (resAccurancy1.Text)
            {
                case "0.00":
                    resAcc1 = "#0.00";
                    break;
                case "0.0":
                    resAcc1 = "#0.0";
                    break;
                case "0.000":
                    resAcc1 = "#0.000";
                    break;
                case "0.":
                    resAcc1 = "#0";
                    break;
            }

            string resAcc2 = "#0.00";
            switch (resAccurancy2.Text)
            {
                case "0.00":
                    resAcc2 = "#0.00";
                    break;
                case "0.0":
                    resAcc2 = "#0.0";
                    break;
                case "0.000":
                    resAcc2 = "#0.000";
                    break;
                case "0.":
                    resAcc2 = "#0";
                    break;
            }

            int round_dig = resAccurancy1.Text.Length - 2;
            //MessageBox.Show(round_dig.ToString());


            Excel.Range biaozimuArea;
            Excel.Range toWordArea;
            Excel.Range meanArea;


            if (onlyXzx.Checked)
            {
                biaozimuArea = wks.Range[destStart, destStart.Offset[treatments, zhibiao * 2]];
                toWordArea = wks.Range[destStart.Offset[treatments + 2, 0], destStart.Offset[2 * treatments + 2, zhibiao]];

                if (isAreaFilled(biaozimuArea) | isAreaFilled(toWordArea))
                {
                    MessageBox.Show("放置区域有数据，请重新选择放置区域");
                    EventArgs ea = new EventArgs();
                    dest_Click(Type.Missing, ea);
                    return false;
                }

                //复制列标题
                for (int i = 2; i <= sourceArea.Columns.Count; i++)
                {
                    Excel.Range sourceP = sourceArea[1].offset[0, i - 1];
                    //操作标字母区域
                    biaozimuArea.Cells[1].Offset[0, (i - 2) * 2 + 1].formula = "=" + sourceP.Address[0, 0];
                    biaozimuArea.Cells[1].Offset[0, (i - 2) * 2 + 2].value = "sig.";
                    //操作到word区域
                    toWordArea[1].offset[0, i - 1].Formula = "=" + sourceP.Address[0, 0];
                }
                //复制行标题
                for (int i = 1; i <= treatments; i++)
                {
                    Excel.Range sourceP = sourceArea[1].offset[repli * (i - 1) + 1, 0];

                    //操作标字母区域
                    biaozimuArea.Cells[1].Offset[i, 0].formula = "= " + sourceP.Address[0, 0];
                    //操作到word区域
                    toWordArea.Cells[1].Offset[i, 0].formula = "= " + sourceP.Address[0, 0];
                }


                //填入数据
                //列循环
                for (int j = 1; j <= zhibiao; j++)
                {
                    //行循环
                    for (int i = 1; i <= treatments; i++)
                    {
                        //操作标字母区域
                        Excel.Range destP = biaozimuArea.Cells[1].offset[i, (j - 1) * 2 + 1];
                        Excel.Range sourceP = wks.Range[sourceArea.Cells[1].offset[(i - 1) * repli + 1, j], sourceArea.Cells[1].offset[(i - 1) * repli + repli, j]];

                        destP.Formula = "= CONCATENATE(TEXT(AVERAGE(" + sourceP.Address[0, 0] + "), \"" + resAcc1 + "\"), \" ± \", TEXT(STDEV.P(" + sourceP.Address[0, 0] + "), \"" + resAcc2 + "\"))";
                        destP.Cells.BorderAround2(XlLineStyle.xlContinuous);
                        //操作到word区域
                        toWordArea.Cells[1].offset[i, j].formula = "= CONCATENATE(TEXT(AVERAGE(" + sourceP.Address[0, 0] + "), \"" + resAcc1 + "\"), \" ± \", TEXT(STDEV.P(" + sourceP.Address[0, 0] + "), \"" + resAcc2 + "\")," + destP.Offset[0, 1].Address[0, 0] + ")";

                    }
                }

                biaozimuArea[1].Value = "字母标记";
                toWordArea[1] = "到word";
            
                if (useValue.Checked)
                {
                    biaozimuArea.Copy();
                    biaozimuArea.PasteSpecial(XlPasteType.xlPasteValues, XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
                    Clipboard.Clear();
                }

                return true;
            }


            if (onlyMean.Checked)
            {
                meanArea = wks.Range[destStart, destStart.Offset[treatments, zhibiao]];

                if (isAreaFilled(meanArea))
                {
                    MessageBox.Show("放置区域有数据，请重新选择放置区域");
                    EventArgs ea = new EventArgs();
                    dest_Click(Type.Missing, ea);
                    return false;
                }

                //复制列标题
                for (int i = 2; i <= sourceArea.Columns.Count; i++)
                {
                    Excel.Range sourceP = sourceArea[1].offset[0, i - 1];
                    //操作均值区域
                    meanArea[1].offset[0, i - 1].Formula = "=" + sourceP.Address[0, 0];
                }
                //复制行标题
                for (int i = 1; i <= treatments; i++)
                {
                    Excel.Range sourceP = sourceArea[1].offset[repli * (i - 1) + 1, 0];
                    meanArea.Cells[1].Offset[i, 0].formula = "= " + sourceP.Address[0, 0];
                }
                //填入数据
                //列循环
                for (int j = 1; j <= zhibiao; j++)
                {
                    //行循环
                    for (int i = 1; i <= treatments; i++)
                    {
                        //操作标字母区域
                        Excel.Range sourceP = wks.Range[sourceArea.Cells[1].offset[(i - 1) * repli + 1, j], sourceArea.Cells[1].offset[(i - 1) * repli + repli, j]];
                        //操作均值区域
                        meanArea.Cells[1].offset[i, j].formula = "=round(average(" + sourceP.Address[0, 0] + ")," + round_dig.ToString() + ")";
                    }
                }
                meanArea[1] = "均值";
                wks.Range[meanArea.Cells[1].Offset[1, 1], meanArea.Cells[1].Offset[meanArea.Rows.Count - 1, meanArea.Columns.Count - 1]].NumberFormat = resAcc1;

                if (useValue.Checked)
                {
                    meanArea.Copy();
                    meanArea.PasteSpecial(XlPasteType.xlPasteValues, XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
                    Clipboard.Clear();
                }

                return true;
            }

            if (xzxMean.Checked)
            {
                biaozimuArea = wks.Range[destStart, destStart.Offset[treatments, zhibiao * 2]];
                toWordArea = wks.Range[destStart.Offset[treatments + 2, 0], destStart.Offset[2 * treatments + 2, zhibiao]];
                meanArea = wks.Range[destStart.Offset[treatments + 2, zhibiao + 2], destStart.Offset[2 * treatments + 2, 2 * zhibiao + 2]];

                if (isAreaFilled(biaozimuArea) | isAreaFilled(toWordArea) | isAreaFilled(meanArea))
                {
                    MessageBox.Show("放置区域有数据，请重新选择放置区域");
                    EventArgs ea = new EventArgs();
                    dest_Click(Type.Missing, ea);
                    return false;
                }

                //复制列标题
                for (int i = 2; i <= sourceArea.Columns.Count; i++)
                {
                    Excel.Range sourceP = sourceArea[1].offset[0, i - 1];
                    //操作标字母区域
                    biaozimuArea.Cells[1].Offset[0, (i - 2) * 2 + 1].formula = "=" + sourceP.Address[0, 0];
                    biaozimuArea.Cells[1].Offset[0, (i - 2) * 2 + 2].value = "sig.";
                    //操作到word区域
                    toWordArea[1].offset[0, i - 1].Formula = "=" + sourceP.Address[0, 0];
                    //操作均值区域
                    meanArea[1].offset[0, i - 1].Formula = "=" + sourceP.Address[0, 0];
                }
                //复制行标题
                for (int i = 1; i <= treatments; i++)
                {
                    Excel.Range sourceP = sourceArea[1].offset[repli * (i - 1) + 1, 0];

                    //操作标字母区域
                    biaozimuArea.Cells[1].Offset[i, 0].formula = "= " + sourceP.Address[0, 0];
                    //操作到word区域
                    toWordArea.Cells[1].Offset[i, 0].formula = "= " + sourceP.Address[0, 0];
                    //操作均值区域
                    meanArea.Cells[1].Offset[i, 0].formula = "= " + sourceP.Address[0, 0];
                }


                //填入数据
                //列循环
                for (int j = 1; j <= zhibiao; j++)
                {
                    //行循环
                    for (int i = 1; i <= treatments; i++)
                    {
                        //操作标字母区域
                        Excel.Range destP = biaozimuArea.Cells[1].offset[i, (j - 1) * 2 + 1];
                        Excel.Range sourceP = wks.Range[sourceArea.Cells[1].offset[(i - 1) * repli + 1, j], sourceArea.Cells[1].offset[(i - 1) * repli + repli, j]];

                        destP.Formula = "= CONCATENATE(TEXT(AVERAGE(" + sourceP.Address[0, 0] + "), \"" + resAcc1 + "\"), \" ± \", TEXT(STDEV.P(" + sourceP.Address[0, 0] + "), \"" + resAcc2 + "\"))";
                        destP.Cells.BorderAround2(XlLineStyle.xlContinuous);
                        //操作到word区域
                        toWordArea.Cells[1].offset[i, j].formula = "= CONCATENATE(TEXT(AVERAGE(" + sourceP.Address[0, 0] + "), \"" + resAcc1 + "\"), \" ± \", TEXT(STDEV.P(" + sourceP.Address[0, 0] + "), \"" + resAcc2 + "\")," + destP.Offset[0, 1].Address[0, 0] + ")";

                        //操作均值区域
                        meanArea.Cells[1].offset[i, j].formula = "=round(average(" + sourceP.Address[0, 0] + ")," + round_dig.ToString() + ")";
                    }
                }

                biaozimuArea[1].Value = "字母标记";
                toWordArea[1] = "到word";
                meanArea[1] = "均值";
                wks.Range[meanArea.Cells[1].Offset[1, 1], meanArea.Cells[1].Offset[meanArea.Rows.Count - 1, meanArea.Columns.Count - 1]].NumberFormat = resAcc1;

                if (useValue.Checked)
                {
                    biaozimuArea.Copy();
                    biaozimuArea.PasteSpecial(XlPasteType.xlPasteValues, XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
                    meanArea.Copy();
                    meanArea.PasteSpecial(XlPasteType.xlPasteValues, XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
                    Clipboard.Clear();
                }

                return true;
            }

            return false;
        }

        private bool isAreaFilled(Excel.Range rg)
        {
            double count = ExcelApp.WorksheetFunction.CountA(
                rg.Cells, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing
               );
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void source_Click(object sender, EventArgs e)
        {
            cancelForDest();
            cancelForSource();
            if (this.sourceLabel.ForeColor != Color.Red)
            {
                //不重复添加
                string possibleP = ExcelApp.Selection.Address[0, 0];
                if (this.source.Text != possibleP)
                {
                    this.source.Text = possibleP;
                }

                ExcelApp.SheetSelectionChange += new Excel.AppEvents_SheetSelectionChangeEventHandler(getAddrForSource);
                this.destLabel.ForeColor = Color.Black;
                this.sourceLabel.ForeColor = Color.Red;
            }
                
        }

        private void dest_Click(object sender, EventArgs e)
        {
            cancelForDest();
            cancelForSource();
            
            if (this.destLabel.ForeColor != Color.Red)
            {
                string possibleP = ExcelApp.Range[ExcelApp.Selection.Address[0, 0]].Cells[1].Address[0, 0];
                if (this.dest.Text != possibleP)
                {
                    this.dest.Text = possibleP;
                }
                ExcelApp.SheetSelectionChange += new Excel.AppEvents_SheetSelectionChangeEventHandler(getAddrForDest);
                this.destLabel.ForeColor = Color.Red;
                this.sourceLabel.ForeColor = Color.Black;
            }
        }

        private void getAddrForDest(object Sh, Range Target)
        {
            this.Invoke(new System.Action(() =>
            {
                this.dest.Text = Target.Cells[1].address[0, 0];
            }));
        }

        private void cancelForDest()
        {
            ExcelApp.SheetSelectionChange -= new Excel.AppEvents_SheetSelectionChangeEventHandler(getAddrForDest);
            this.destLabel.ForeColor = Color.Black;
        }

        private void longdataMean_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancelForSource();
            cancelForDest();
        }

        private void resAccurancy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //System.Text.RegularExpressions.Regex.Replace(source.Text, @"\s", "")
        
        private void source_TextChanged(object sender, EventArgs e)
        {
            if (source.Text == "" | source.Text == null)
            {
                MessageBox.Show("不执行");
                return;
            }
            //MessageBox.Show(source.Visible.ToString());
            Excel.Worksheet wks = ExcelApp.ActiveSheet;
            Excel.Range sourceArea = wks.Range[source.Text];

            //计算一共有几个重复
            int repli = 0;
            foreach (Excel.Range rg in wks.Range[sourceArea.Columns[1].Cells[2], sourceArea.Columns[1].Cells[sourceArea.Rows.Count]])
            {
                //MessageBox.Show(rg.Address + "   " + rg.Value);
                //MessageBox.Show(sourceArea.Columns[1].Cells[2].Address + "   " + sourceArea.Columns[1].Cells[2].Value);
                if (rg.Text == sourceArea.Columns[1].Cells[2].Text)
                {
                    repli++;
                }
                else
                {
                    break;
                }
            }
            replicate.Text = repli.ToString();
        }

        private void splitButton1_Click(object sender, EventArgs e)
        {
            if (hzFunction())
            {
                this.Dispose();
            }
        }

        private void hzStayButton_Click(object sender, EventArgs e)
        {
            hzFunction();
        }
    }
}
