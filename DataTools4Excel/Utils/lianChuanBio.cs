using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ycResearchTools.utils
{
    class lianChuanBio
    {
        public static void reformTaxonomyFromQiime2(Excel.Worksheet wks)
        {
            Excel.Range last = wks.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range rgs = wks.Range[wks.Range["b2"], wks.Cells[last.Row, 2]];
            //MessageBox.Show(rgs.Address);
            foreach (Excel.Range rg in rgs)
            {
                //MessageBox.Show(rg.Address + "只" + rg.Value + "!!");
                string s = rg.Text;

                if (s.Length < 1)
                {
                    continue;
                }

                string[] former_prefixs = { };

                switch (s.Substring(0, 3))
                {
                    case "D_0":
                        former_prefixs = new string[]{
                        "D_0__", "D_1__", "D_2__", "D_3__", "D_4__", "D_5__", "D_6__"
                        };
                        break;
                    case "k__":
                        former_prefixs = new string[]{
                        "k__", " p__", " c__", " o__", " f__", " g__", " s__"
                        };
                        break;
                    case "Una":
                        s = "k__Unassigned";
                        former_prefixs = new string[]{
                        "k__", " p__", " c__", " o__", " f__", " g__", " s__"
                        };
                        break;
                    default:
                        continue;
                }

                string[] sArr = s.Split(';');


                for (int j = 0; j < sArr.Length; j++)
                {
                    sArr[j] = sArr[j].Replace(former_prefixs[j], "");
                }

                for (int j = sArr.Length; j < 7; j++)
                {
                    List<string> tempL = sArr.ToList();
                    tempL.Add("");
                    sArr = tempL.ToArray();
                }

                string[] final_prefixs = new string[]{
                        "d__", " p__", " c__", " o__", " f__", " g__", " s__"
                    };

                for (int j = 0; j < 7; j++)
                {
                    //Console.WriteLine("数组1：" + sArr[j] + "      数组2：" + prefixs[j]);
                    if (sArr[j] == "")
                    {
                        sArr[j] = final_prefixs[j] + "unidentified";
                    }
                    else
                    {
                        sArr[j] = final_prefixs[j] + sArr[j];
                    }
                }

                rg.Value = string.Join(";", sArr);
            }
        }

        private string doSingleTaxonomyConvert(string s)
        {
            if(s.Length < 1)
            {
                return "";
            }

            string[] former_prefixs = {};

            switch (s.Substring(0, 3))
            {
                case "D_0":
                    former_prefixs = new string[]{
                        "D_0__", "D_1__", "D_2__", "D_3__", "D_4__", "D_5__", "D_6__"
                    };
                    break;
                case "k__":
                    former_prefixs = new string[]{
                        "k__", " p__", " c__", " o__", " f__", " g__", " s__"
                    };
                    break;
                default:
                    return "";
            }

            string[] sArr = s.Split(';');


            for (int j = 0; j < sArr.Length; j++)
            {
                sArr[j] = sArr[j].Replace(former_prefixs[j], "");
            }

            for (int j = sArr.Length; j < 7; j++)
            {
                List<string> tempL = sArr.ToList();
                tempL.Add("");
                sArr = tempL.ToArray();
            }

            string[] final_prefixs = new string[]{
                        "d__", " p__", " c__", " o__", " f__", " g__", " s__"
                    };

            for (int j = 0; j < 7; j++)
            {
                //Console.WriteLine("数组1：" + sArr[j] + "      数组2：" + prefixs[j]);
                if (sArr[j] == "")
                {
                    sArr[j] = final_prefixs[j] + "unidentified";
                }
                else
                {
                    sArr[j] = final_prefixs[j] + sArr[j];
                }
            }

            return string.Join(";", sArr);
        }

        public static bool tableSummary(Excel.Worksheet wks)
        {
            //在第二行后加入三行
            //这一步在调用函数之前完成。
            //MessageBox.Show("kaishi");
            //wks.Rows["3:5"].Insert();

            //读取一共有几行
            Excel.Range last = wks.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            //Excel.Range rgs = wks.Range[wks.Range["b2"], wks.Cells[last.Row, 2]];
            //rgs.

            //统计每个OTU的信息，也就是每行的信息


            for (int i = 3; i <= last.Row; i++)
            {
                wks.Cells[i, last.Column + 1].Value =
                    wks.Application.WorksheetFunction.CountIf(
                        wks.Range[wks.Cells[i, 2], wks.Cells[i, last.Column]], ">0");
                wks.Cells[i, last.Column + 2].Value =
                    wks.Application.WorksheetFunction.Sum(
                        wks.Range[wks.Cells[i, 2], wks.Cells[i, last.Column]]);
            }

            //MessageBox.Show("行处理");
            //行处理
            //MessageBox.Show(wks.Cells[last.Row + 1, 1].Address);
            wks.Cells[last.Row + 1, 1].Value = "样本中OTU数量";
            wks.Cells[last.Row + 1, 1].WrapText = true;

            wks.Cells[last.Row + 2, 1].Value = "样本中OTU总数";
            wks.Cells[last.Row + 2, 1].WrapText = true;

            wks.Cells[last.Row + 3, 1].Value = "OTU总数占比";
            wks.Cells[last.Row + 3, 1].WrapText = true;

            //wks.Application.ActiveWindow.ScrollRow = last.Row + 5;

            for (int i = 2; i <= last.Column; i++)
            {
                //第三行
                //MessageBox.Show(wks.Cells[last.Row + 1, i].address);
                wks.Cells[last.Row + 1, i].Value = wks.Application.WorksheetFunction.CountIf(
                    wks.Range[wks.Cells[3, i], wks.Cells[last.Row , i]], ">0");
                //第四行
                wks.Cells[last.Row + 2, i].Value = wks.Application.WorksheetFunction.Sum(
                    wks.Range[wks.Cells[3, i], wks.Cells[last.Row, i]]);
                
                //第五行
                wks.Cells[last.Row + 3, i].Formula = 
                    "=" + wks.Cells[last.Row + 2, i].Address[0, 0] + " / SUM(" + 
                    wks.Range[wks.Cells[last.Row + 2, 2], wks.Cells[last.Row + 2, last.Column]].Address[0,1] + ") * 100";
            }

            wks.Rows[(last.Row + 1).ToString() + ":" + (last.Row + 3).ToString()].Cut();

            //wks.Application.ActiveWindow.ScrollRow = 1;

            wks.Rows["3:3"].Insert();

            wks.Cells[5, last.Column + 1].Value = "OTU出现在样本数";
            wks.Cells[5, last.Column + 1].WrapText = true;
            wks.Cells[5, last.Column + 2].Value = "OTU出现的总次数";
            wks.Cells[5, last.Column + 2].WrapText = true;

            wks.Cells[2, last.Column + 1].Value = "OTU总数";

            wks.Cells[2, last.Column + 2].Value = wks.Application.WorksheetFunction.CountIf(
                    wks.Range[wks.Cells[6, last.Column + 1], wks.Cells[last.Row + 3, last.Column + 1]], ">0");

            wks.Cells[3, last.Column + 1].Value = "非single数";

            wks.Cells[3, last.Column + 2].Value = wks.Application.WorksheetFunction.CountIf(
                    wks.Range[wks.Cells[6, last.Column + 1], wks.Cells[last.Row + 3, last.Column + 1]], ">1");


            return true;
        }



    }
}
