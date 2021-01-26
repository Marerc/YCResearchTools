
namespace ycResearchTools
{
    partial class DataProcessingRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DataProcessingRibbon()
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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.taxNameSetButton = this.Factory.CreateRibbonButton();
            this.tableReformBtn = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabHome";
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "TabHome";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Label = "类SPSS数据";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = global::ycResearchTools.Properties.Resources.average;
            this.button1.Label = "快速均值";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.taxNameSetButton);
            this.group3.Items.Add(this.tableReformBtn);
            this.group3.Items.Add(this.button2);
            this.group3.Label = "联川生物前处理";
            this.group3.Name = "group3";
            // 
            // taxNameSetButton
            // 
            this.taxNameSetButton.Image = global::ycResearchTools.Properties.Resources.分类;
            this.taxNameSetButton.Label = "物种注释表按照lcsw表示";
            this.taxNameSetButton.Name = "taxNameSetButton";
            this.taxNameSetButton.ShowImage = true;
            this.taxNameSetButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.taxNameSetButton_Click);
            // 
            // tableReformBtn
            // 
            this.tableReformBtn.Image = global::ycResearchTools.Properties.Resources.table;
            this.tableReformBtn.Label = "特征表添加物种注释";
            this.tableReformBtn.Name = "tableReformBtn";
            this.tableReformBtn.ShowImage = true;
            this.tableReformBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tableReformBtn_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ycResearchTools.Properties.Resources.table;
            this.button2.Label = "特征表加总结信息";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tableSummarizer);
            // 
            // DataProcessingRibbon
            // 
            this.Name = "DataProcessingRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_ycResearch_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        private Microsoft.Office.Tools.Ribbon.RibbonButton taxNameSetButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton tableReformBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
    }

    partial class ThisRibbonCollection
    {
        internal DataProcessingRibbon Ribbon_ycResearch
        {
            get { return this.GetRibbon<DataProcessingRibbon>(); }
        }
    }
}
