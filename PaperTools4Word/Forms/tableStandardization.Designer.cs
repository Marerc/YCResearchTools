
namespace PaperTools4Word.Forms
{
    partial class tableStandardization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sigUpperscript = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.processAllTables = new System.Windows.Forms.CheckBox();
            this.addThreeWire = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rowHeadPosition = new System.Windows.Forms.ComboBox();
            this.columnHead = new System.Windows.Forms.Panel();
            this.columnHeadWordFirst = new System.Windows.Forms.RadioButton();
            this.columnHeadWordAll = new System.Windows.Forms.RadioButton();
            this.columnHeadSentenceFisrt = new System.Windows.Forms.RadioButton();
            this.rowHead = new System.Windows.Forms.Panel();
            this.rowHeadWordFirst = new System.Windows.Forms.RadioButton();
            this.rowHeadWordAll = new System.Windows.Forms.RadioButton();
            this.rowHeadSentenceFisrt = new System.Windows.Forms.RadioButton();
            this.columnHeadPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ignoreRowHeadmodify = new System.Windows.Forms.CheckBox();
            this.ignoreColHeadmodify = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fontBtn = new System.Windows.Forms.Button();
            this.paraBtn = new System.Windows.Forms.Button();
            this.fontInfo = new System.Windows.Forms.TextBox();
            this.paraInfo = new System.Windows.Forms.TextBox();
            this.columnFitWord = new System.Windows.Forms.CheckBox();
            this.verticalCenter = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.columnHead.SuspendLayout();
            this.rowHead.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sigUpperscript
            // 
            this.sigUpperscript.AutoSize = true;
            this.sigUpperscript.Checked = true;
            this.sigUpperscript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sigUpperscript.Location = new System.Drawing.Point(95, 31);
            this.sigUpperscript.Name = "sigUpperscript";
            this.sigUpperscript.Size = new System.Drawing.Size(186, 16);
            this.sigUpperscript.TabIndex = 0;
            this.sigUpperscript.Text = "上标显著性字母/星号(如果有)";
            this.sigUpperscript.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "显著性字母：";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(292, 407);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 3;
            this.ok.Text = "确  定";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // no
            // 
            this.no.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.no.Location = new System.Drawing.Point(199, 407);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(75, 23);
            this.no.TabIndex = 3;
            this.no.Text = "取  消";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // processAllTables
            // 
            this.processAllTables.AutoSize = true;
            this.processAllTables.Checked = true;
            this.processAllTables.CheckState = System.Windows.Forms.CheckState.Checked;
            this.processAllTables.Location = new System.Drawing.Point(20, 411);
            this.processAllTables.Name = "processAllTables";
            this.processAllTables.Size = new System.Drawing.Size(150, 16);
            this.processAllTables.TabIndex = 0;
            this.processAllTables.Text = "操作选中的所有表(1个)";
            this.processAllTables.UseVisualStyleBackColor = true;
            // 
            // addThreeWire
            // 
            this.addThreeWire.AutoSize = true;
            this.addThreeWire.Checked = true;
            this.addThreeWire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addThreeWire.Location = new System.Drawing.Point(268, 89);
            this.addThreeWire.Name = "addThreeWire";
            this.addThreeWire.Size = new System.Drawing.Size(84, 16);
            this.addThreeWire.TabIndex = 0;
            this.addThreeWire.Text = "设置三线表";
            this.addThreeWire.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "宽度自适应：";
            // 
            // dataPosition
            // 
            this.dataPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataPosition.FormattingEnabled = true;
            this.dataPosition.Items.AddRange(new object[] {
            "居中",
            "靠左"});
            this.dataPosition.Location = new System.Drawing.Point(271, 73);
            this.dataPosition.Name = "dataPosition";
            this.dataPosition.Size = new System.Drawing.Size(75, 20);
            this.dataPosition.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "位置：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rowHeadPosition);
            this.groupBox1.Controls.Add(this.columnHead);
            this.groupBox1.Controls.Add(this.rowHead);
            this.groupBox1.Controls.Add(this.columnHeadPosition);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ignoreRowHeadmodify);
            this.groupBox1.Controls.Add(this.ignoreColHeadmodify);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "表头设置：";
            // 
            // rowHeadPosition
            // 
            this.rowHeadPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rowHeadPosition.FormattingEnabled = true;
            this.rowHeadPosition.Items.AddRange(new object[] {
            "居中",
            "靠左"});
            this.rowHeadPosition.Location = new System.Drawing.Point(141, 89);
            this.rowHeadPosition.Name = "rowHeadPosition";
            this.rowHeadPosition.Size = new System.Drawing.Size(75, 20);
            this.rowHeadPosition.TabIndex = 12;
            // 
            // columnHead
            // 
            this.columnHead.Controls.Add(this.columnHeadWordFirst);
            this.columnHead.Controls.Add(this.columnHeadWordAll);
            this.columnHead.Controls.Add(this.columnHeadSentenceFisrt);
            this.columnHead.Location = new System.Drawing.Point(29, 50);
            this.columnHead.Name = "columnHead";
            this.columnHead.Size = new System.Drawing.Size(323, 24);
            this.columnHead.TabIndex = 7;
            // 
            // columnHeadWordFirst
            // 
            this.columnHeadWordFirst.AutoSize = true;
            this.columnHeadWordFirst.Location = new System.Drawing.Point(112, 4);
            this.columnHeadWordFirst.Name = "columnHeadWordFirst";
            this.columnHeadWordFirst.Size = new System.Drawing.Size(107, 16);
            this.columnHeadWordFirst.TabIndex = 0;
            this.columnHeadWordFirst.Text = "单词首字母大写";
            this.columnHeadWordFirst.UseVisualStyleBackColor = true;
            // 
            // columnHeadWordAll
            // 
            this.columnHeadWordAll.AutoSize = true;
            this.columnHeadWordAll.Location = new System.Drawing.Point(237, 4);
            this.columnHeadWordAll.Name = "columnHeadWordAll";
            this.columnHeadWordAll.Size = new System.Drawing.Size(83, 16);
            this.columnHeadWordAll.TabIndex = 0;
            this.columnHeadWordAll.Text = "全字母大写";
            this.columnHeadWordAll.UseVisualStyleBackColor = true;
            // 
            // columnHeadSentenceFisrt
            // 
            this.columnHeadSentenceFisrt.AutoSize = true;
            this.columnHeadSentenceFisrt.Checked = true;
            this.columnHeadSentenceFisrt.Location = new System.Drawing.Point(3, 4);
            this.columnHeadSentenceFisrt.Name = "columnHeadSentenceFisrt";
            this.columnHeadSentenceFisrt.Size = new System.Drawing.Size(95, 16);
            this.columnHeadSentenceFisrt.TabIndex = 0;
            this.columnHeadSentenceFisrt.TabStop = true;
            this.columnHeadSentenceFisrt.Text = "句首字母大写";
            this.columnHeadSentenceFisrt.UseVisualStyleBackColor = true;
            // 
            // rowHead
            // 
            this.rowHead.Controls.Add(this.rowHeadWordFirst);
            this.rowHead.Controls.Add(this.rowHeadWordAll);
            this.rowHead.Controls.Add(this.rowHeadSentenceFisrt);
            this.rowHead.Location = new System.Drawing.Point(29, 120);
            this.rowHead.Name = "rowHead";
            this.rowHead.Size = new System.Drawing.Size(323, 24);
            this.rowHead.TabIndex = 6;
            // 
            // rowHeadWordFirst
            // 
            this.rowHeadWordFirst.AutoSize = true;
            this.rowHeadWordFirst.Location = new System.Drawing.Point(112, 4);
            this.rowHeadWordFirst.Name = "rowHeadWordFirst";
            this.rowHeadWordFirst.Size = new System.Drawing.Size(107, 16);
            this.rowHeadWordFirst.TabIndex = 0;
            this.rowHeadWordFirst.Text = "单词首字母大写";
            this.rowHeadWordFirst.UseVisualStyleBackColor = true;
            // 
            // rowHeadWordAll
            // 
            this.rowHeadWordAll.AutoSize = true;
            this.rowHeadWordAll.Checked = true;
            this.rowHeadWordAll.Location = new System.Drawing.Point(237, 4);
            this.rowHeadWordAll.Name = "rowHeadWordAll";
            this.rowHeadWordAll.Size = new System.Drawing.Size(83, 16);
            this.rowHeadWordAll.TabIndex = 0;
            this.rowHeadWordAll.TabStop = true;
            this.rowHeadWordAll.Text = "全字母大写";
            this.rowHeadWordAll.UseVisualStyleBackColor = true;
            // 
            // rowHeadSentenceFisrt
            // 
            this.rowHeadSentenceFisrt.AutoSize = true;
            this.rowHeadSentenceFisrt.Location = new System.Drawing.Point(3, 4);
            this.rowHeadSentenceFisrt.Name = "rowHeadSentenceFisrt";
            this.rowHeadSentenceFisrt.Size = new System.Drawing.Size(95, 16);
            this.rowHeadSentenceFisrt.TabIndex = 0;
            this.rowHeadSentenceFisrt.Text = "句首字母大写";
            this.rowHeadSentenceFisrt.UseVisualStyleBackColor = true;
            // 
            // columnHeadPosition
            // 
            this.columnHeadPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnHeadPosition.FormattingEnabled = true;
            this.columnHeadPosition.Items.AddRange(new object[] {
            "居中",
            "靠左"});
            this.columnHeadPosition.Location = new System.Drawing.Point(141, 16);
            this.columnHeadPosition.Name = "columnHeadPosition";
            this.columnHeadPosition.Size = new System.Drawing.Size(75, 20);
            this.columnHeadPosition.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "列标题(中文会被忽略)：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "行标题(中文会被忽略)：";
            // 
            // ignoreRowHeadmodify
            // 
            this.ignoreRowHeadmodify.AutoSize = true;
            this.ignoreRowHeadmodify.Location = new System.Drawing.Point(231, 91);
            this.ignoreRowHeadmodify.Name = "ignoreRowHeadmodify";
            this.ignoreRowHeadmodify.Size = new System.Drawing.Size(120, 16);
            this.ignoreRowHeadmodify.TabIndex = 10;
            this.ignoreRowHeadmodify.Text = "不修改行标大小写";
            this.ignoreRowHeadmodify.UseVisualStyleBackColor = true;
            this.ignoreRowHeadmodify.CheckedChanged += new System.EventHandler(this.ignoreRowHeadmodify_CheckedChanged);
            // 
            // ignoreColHeadmodify
            // 
            this.ignoreColHeadmodify.AutoSize = true;
            this.ignoreColHeadmodify.Location = new System.Drawing.Point(229, 18);
            this.ignoreColHeadmodify.Name = "ignoreColHeadmodify";
            this.ignoreColHeadmodify.Size = new System.Drawing.Size(120, 16);
            this.ignoreColHeadmodify.TabIndex = 11;
            this.ignoreColHeadmodify.Text = "不修改列标大小写";
            this.ignoreColHeadmodify.UseVisualStyleBackColor = true;
            this.ignoreColHeadmodify.CheckedChanged += new System.EventHandler(this.ignoreColHeadmodify_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.columnFitWord);
            this.groupBox2.Controls.Add(this.sigUpperscript);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataPosition);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 118);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据区域设置：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.paraInfo);
            this.groupBox3.Controls.Add(this.fontInfo);
            this.groupBox3.Controls.Add(this.paraBtn);
            this.groupBox3.Controls.Add(this.fontBtn);
            this.groupBox3.Controls.Add(this.verticalCenter);
            this.groupBox3.Controls.Add(this.addThreeWire);
            this.groupBox3.Location = new System.Drawing.Point(12, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 111);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "表格整体设置：冲突部分以此为准";
            // 
            // fontBtn
            // 
            this.fontBtn.Location = new System.Drawing.Point(11, 24);
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(71, 23);
            this.fontBtn.TabIndex = 1;
            this.fontBtn.Text = "字体设置";
            this.fontBtn.UseVisualStyleBackColor = true;
            this.fontBtn.Click += new System.EventHandler(this.fontBtn_Click);
            // 
            // paraBtn
            // 
            this.paraBtn.Location = new System.Drawing.Point(12, 78);
            this.paraBtn.Name = "paraBtn";
            this.paraBtn.Size = new System.Drawing.Size(71, 23);
            this.paraBtn.TabIndex = 1;
            this.paraBtn.Text = "段落设置";
            this.paraBtn.UseVisualStyleBackColor = true;
            this.paraBtn.Click += new System.EventHandler(this.paraBtn_Click);
            // 
            // fontInfo
            // 
            this.fontInfo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fontInfo.Location = new System.Drawing.Point(91, 18);
            this.fontInfo.Multiline = true;
            this.fontInfo.Name = "fontInfo";
            this.fontInfo.Size = new System.Drawing.Size(260, 39);
            this.fontInfo.TabIndex = 3;
            this.fontInfo.Text = "未设置：使用原来的字体";
            // 
            // paraInfo
            // 
            this.paraInfo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.paraInfo.Location = new System.Drawing.Point(92, 63);
            this.paraInfo.Multiline = true;
            this.paraInfo.Name = "paraInfo";
            this.paraInfo.Size = new System.Drawing.Size(170, 42);
            this.paraInfo.TabIndex = 3;
            this.paraInfo.Text = "未设置：使用原来的段落格式";
            // 
            // columnFitWord
            // 
            this.columnFitWord.AutoSize = true;
            this.columnFitWord.Location = new System.Drawing.Point(94, 76);
            this.columnFitWord.Name = "columnFitWord";
            this.columnFitWord.Size = new System.Drawing.Size(120, 16);
            this.columnFitWord.TabIndex = 0;
            this.columnFitWord.Text = "列宽适应文本长度";
            this.columnFitWord.UseVisualStyleBackColor = true;
            // 
            // verticalCenter
            // 
            this.verticalCenter.AutoSize = true;
            this.verticalCenter.Checked = true;
            this.verticalCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verticalCenter.Location = new System.Drawing.Point(269, 67);
            this.verticalCenter.Name = "verticalCenter";
            this.verticalCenter.Size = new System.Drawing.Size(72, 16);
            this.verticalCenter.TabIndex = 0;
            this.verticalCenter.Text = "垂直居中";
            this.verticalCenter.UseVisualStyleBackColor = true;
            // 
            // tableStandardization
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.no;
            this.ClientSize = new System.Drawing.Size(383, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.no);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.processAllTables);
            this.Name = "tableStandardization";
            this.Text = "表格标准化";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.tableStandardization_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.columnHead.ResumeLayout(false);
            this.columnHead.PerformLayout();
            this.rowHead.ResumeLayout(false);
            this.rowHead.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox sigUpperscript;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button no;
        public System.Windows.Forms.CheckBox processAllTables;
        private System.Windows.Forms.CheckBox addThreeWire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dataPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox rowHeadPosition;
        private System.Windows.Forms.Panel columnHead;
        private System.Windows.Forms.RadioButton columnHeadWordFirst;
        private System.Windows.Forms.RadioButton columnHeadWordAll;
        private System.Windows.Forms.RadioButton columnHeadSentenceFisrt;
        private System.Windows.Forms.Panel rowHead;
        private System.Windows.Forms.RadioButton rowHeadWordFirst;
        private System.Windows.Forms.RadioButton rowHeadWordAll;
        private System.Windows.Forms.RadioButton rowHeadSentenceFisrt;
        private System.Windows.Forms.ComboBox columnHeadPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ignoreRowHeadmodify;
        private System.Windows.Forms.CheckBox ignoreColHeadmodify;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button paraBtn;
        private System.Windows.Forms.Button fontBtn;
        private System.Windows.Forms.TextBox fontInfo;
        private System.Windows.Forms.TextBox paraInfo;
        private System.Windows.Forms.CheckBox columnFitWord;
        private System.Windows.Forms.CheckBox verticalCenter;
    }
}