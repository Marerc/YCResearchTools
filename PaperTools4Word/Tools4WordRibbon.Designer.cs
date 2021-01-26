
namespace PaperTools4Word
{
    partial class tools4Word : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public tools4Word()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonTab formator;
            this.tableData = this.Factory.CreateRibbonGroup();
            this.superscriptCase = this.Factory.CreateRibbonButton();
            this.tableStandardizer = this.Factory.CreateRibbonButton();
            this.mySave = this.Factory.CreateRibbonSplitButton();
            this.mySaveSetting = this.Factory.CreateRibbonButton();
            this.tst = this.Factory.CreateRibbonButton();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.viewLogs = this.Factory.CreateRibbonButton();
            formator = this.Factory.CreateRibbonTab();
            formator.SuspendLayout();
            this.tableData.SuspendLayout();
            this.SuspendLayout();
            // 
            // formator
            // 
            formator.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            formator.ControlId.OfficeId = "TabHome";
            formator.Groups.Add(this.tableData);
            formator.Groups.Add(this.group1);
            formator.Label = "TabHome";
            formator.Name = "formator";
            // 
            // tableData
            // 
            this.tableData.Items.Add(this.superscriptCase);
            this.tableData.Items.Add(this.tableStandardizer);
            this.tableData.Items.Add(this.mySave);
            this.tableData.Items.Add(this.tst);
            this.tableData.Label = "表格数据";
            this.tableData.Name = "tableData";
            // 
            // superscriptCase
            // 
            this.superscriptCase.Image = global::PaperTools4Word.Properties.Resources.上标;
            this.superscriptCase.Label = "字母标";
            this.superscriptCase.Name = "superscriptCase";
            this.superscriptCase.ShowImage = true;
            this.superscriptCase.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.superscriptCase_Click);
            // 
            // tableStandardizer
            // 
            this.tableStandardizer.Image = global::PaperTools4Word.Properties.Resources.表格;
            this.tableStandardizer.Label = "三线表";
            this.tableStandardizer.Name = "tableStandardizer";
            this.tableStandardizer.ShowImage = true;
            this.tableStandardizer.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tableStandardizer_Click);
            // 
            // mySave
            // 
            this.mySave.Image = global::PaperTools4Word.Properties.Resources.git;
            this.mySave.Items.Add(this.mySaveSetting);
            this.mySave.Items.Add(this.viewLogs);
            this.mySave.Label = "版本保存";
            this.mySave.Name = "mySave";
            this.mySave.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.mySave_Click);
            // 
            // mySaveSetting
            // 
            this.mySaveSetting.Label = "高级保存(设置)";
            this.mySaveSetting.Name = "mySaveSetting";
            this.mySaveSetting.ShowImage = true;
            this.mySaveSetting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.mySaveSetting_Click);
            // 
            // tst
            // 
            this.tst.Label = "生成测试表格";
            this.tst.Name = "tst";
            this.tst.Visible = false;
            this.tst.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tst_Click);
            // 
            // group1
            // 
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // viewLogs
            // 
            this.viewLogs.Label = "查看日志";
            this.viewLogs.Name = "viewLogs";
            this.viewLogs.ShowImage = true;
            this.viewLogs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.viewLogs_Click);
            // 
            // tools4Word
            // 
            this.Name = "tools4Word";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(formator);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            formator.ResumeLayout(false);
            formator.PerformLayout();
            this.tableData.ResumeLayout(false);
            this.tableData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup tableData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton superscriptCase;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton tst;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton tableStandardizer;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton mySave;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton mySaveSetting;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton viewLogs;
    }

    partial class ThisRibbonCollection
    {
        internal tools4Word Ribbon1
        {
            get { return this.GetRibbon<tools4Word>(); }
        }
    }
}
