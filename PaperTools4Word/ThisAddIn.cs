using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
//using Microsoft.Office.Tools.Word;

namespace PaperTools4Word
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion





        //个人代码
        public bool searchSelReplaceSigSign()
        {
            Word.Find findObject = this.Application.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = @"[a-zA-z\*]";
            findObject.Font.Superscript = 0;
            findObject.MatchWildcards = true;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Font.Superscript = 1;
            findObject.Replacement.Font.Subscript = 0;

            object replaceAll = Word.WdReplace.wdReplaceAll;

            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);

            return false;
        }


        //个人代码
        public bool searchRangeReplaceSigSign(Word.Range range)
        {
            Word.Find findObject = range.Find;
            findObject.ClearFormatting();
            findObject.Text = "^$";
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Font.Superscript = 1;
            findObject.Replacement.Font.Subscript = 0;

            object replaceAll = Word.WdReplace.wdReplaceAll;

            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);

            return false;
        }


        //实例代码
        public void CreateDocumentPropertyTable()
        {
            object start = 0, end = 0;
            Word.Document document = this.Application.ActiveDocument;
            Word.Range rng = document.Range(ref start, ref end);

            // Insert a title for the table and paragraph marks. 
            rng.InsertBefore("Document Statistics");
            rng.Font.Name = "Verdana";
            rng.Font.Size = 16;
            rng.InsertParagraphAfter();
            rng.InsertParagraphAfter();
            rng.SetRange(rng.End, rng.End);

            // Add the table.
            rng.Tables.Add(document.Paragraphs[2].Range, 3, 2, ref missing, ref missing);

            // Format the table and apply a style. 
            Word.Table tbl = document.Tables[1];
            tbl.Range.Font.Size = 12;
            tbl.Columns.DistributeWidth();

            object styleName = "Table Professional";
            //tbl.set_Style(ref styleName);

            // Insert document properties into cells. 
            tbl.Cell(1, 1).Range.Text = "Document Property";
            tbl.Cell(1, 2).Range.Text = "Value";

            tbl.Cell(2, 1).Range.Text = "Subject";
            tbl.Cell(2, 2).Range.Text = ((Office.DocumentProperties)(document.BuiltInDocumentProperties))
                [Word.WdBuiltInProperty.wdPropertySubject].Value.ToString();

            tbl.Cell(3, 1).Range.Text = "Author";
            tbl.Cell(3, 2).Range.Text = ((Office.DocumentProperties)(document.BuiltInDocumentProperties))
                [Word.WdBuiltInProperty.wdPropertyAuthor].Value.ToString();
        }



    }
}
