
namespace ycResearchTools.forms
{
    partial class longdataMean
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(longdataMean));
            this.replicate = new System.Windows.Forms.ComboBox();
            this.destLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.selFinish = new System.Windows.Forms.Button();
            this.dest = new System.Windows.Forms.TextBox();
            this.source = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onlyXzx = new System.Windows.Forms.RadioButton();
            this.onlyMean = new System.Windows.Forms.RadioButton();
            this.xzxMean = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.useFormula = new System.Windows.Forms.RadioButton();
            this.useValue = new System.Windows.Forms.RadioButton();
            this.judgeReplicate = new System.Windows.Forms.CheckBox();
            this.resAccurancy2 = new System.Windows.Forms.ComboBox();
            this.resAccurancy1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hzButton = new wyDay.Controls.SplitButton();
            this.hzExitButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hzStayButton = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.hzExitButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // replicate
            // 
            this.replicate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.replicate.FormattingEnabled = true;
            this.replicate.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.replicate.Location = new System.Drawing.Point(94, 297);
            this.replicate.Name = "replicate";
            this.replicate.Size = new System.Drawing.Size(150, 20);
            this.replicate.TabIndex = 4;
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(12, 262);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(77, 12);
            this.destLabel.TabIndex = 14;
            this.destLabel.Text = "结果放置区域";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "保留小数点";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "重复数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(29, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "第一行【指标名称】，第一列【分组】";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.ForeColor = System.Drawing.Color.Black;
            this.sourceLabel.Location = new System.Drawing.Point(21, 226);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(65, 12);
            this.sourceLabel.TabIndex = 19;
            this.sourceLabel.Text = "选择元数据";
            // 
            // selFinish
            // 
            this.selFinish.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selFinish.Location = new System.Drawing.Point(262, 217);
            this.selFinish.Name = "selFinish";
            this.selFinish.Size = new System.Drawing.Size(73, 63);
            this.selFinish.TabIndex = 3;
            this.selFinish.Text = "完成选择";
            this.selFinish.UseVisualStyleBackColor = true;
            this.selFinish.Click += new System.EventHandler(this.selFinish_Click);
            // 
            // dest
            // 
            this.dest.Location = new System.Drawing.Point(94, 259);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(150, 21);
            this.dest.TabIndex = 2;
            this.dest.Click += new System.EventHandler(this.dest_Click);
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(94, 221);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(150, 21);
            this.source.TabIndex = 1;
            this.source.Click += new System.EventHandler(this.source_Click);
            this.source.TextChanged += new System.EventHandler(this.source_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(259, 362);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 25);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "退    出";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(17, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 143);
            this.panel1.TabIndex = 24;
            // 
            // onlyXzx
            // 
            this.onlyXzx.AutoSize = true;
            this.onlyXzx.Location = new System.Drawing.Point(2, 3);
            this.onlyXzx.Name = "onlyXzx";
            this.onlyXzx.Size = new System.Drawing.Size(95, 16);
            this.onlyXzx.TabIndex = 25;
            this.onlyXzx.Text = "仅显著性标注";
            this.onlyXzx.UseVisualStyleBackColor = true;
            // 
            // onlyMean
            // 
            this.onlyMean.AutoSize = true;
            this.onlyMean.Location = new System.Drawing.Point(3, 23);
            this.onlyMean.Name = "onlyMean";
            this.onlyMean.Size = new System.Drawing.Size(71, 16);
            this.onlyMean.TabIndex = 25;
            this.onlyMean.Text = "仅仅均值";
            this.onlyMean.UseVisualStyleBackColor = true;
            // 
            // xzxMean
            // 
            this.xzxMean.AutoSize = true;
            this.xzxMean.Checked = true;
            this.xzxMean.Location = new System.Drawing.Point(3, 42);
            this.xzxMean.Name = "xzxMean";
            this.xzxMean.Size = new System.Drawing.Size(83, 16);
            this.xzxMean.TabIndex = 25;
            this.xzxMean.TabStop = true;
            this.xzxMean.Text = "两者都需要";
            this.xzxMean.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.onlyXzx);
            this.panel2.Controls.Add(this.xzxMean);
            this.panel2.Controls.Add(this.onlyMean);
            this.panel2.Location = new System.Drawing.Point(24, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 65);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.useFormula);
            this.panel3.Controls.Add(this.useValue);
            this.panel3.Location = new System.Drawing.Point(162, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 42);
            this.panel3.TabIndex = 26;
            // 
            // useFormula
            // 
            this.useFormula.AutoSize = true;
            this.useFormula.Checked = true;
            this.useFormula.Location = new System.Drawing.Point(3, 3);
            this.useFormula.Name = "useFormula";
            this.useFormula.Size = new System.Drawing.Size(71, 16);
            this.useFormula.TabIndex = 25;
            this.useFormula.TabStop = true;
            this.useFormula.Text = "使用公式";
            this.useFormula.UseVisualStyleBackColor = true;
            // 
            // useValue
            // 
            this.useValue.AutoSize = true;
            this.useValue.Location = new System.Drawing.Point(3, 23);
            this.useValue.Name = "useValue";
            this.useValue.Size = new System.Drawing.Size(59, 16);
            this.useValue.TabIndex = 25;
            this.useValue.Text = "使用值";
            this.useValue.UseVisualStyleBackColor = true;
            // 
            // judgeReplicate
            // 
            this.judgeReplicate.AutoSize = true;
            this.judgeReplicate.Location = new System.Drawing.Point(265, 300);
            this.judgeReplicate.Name = "judgeReplicate";
            this.judgeReplicate.Size = new System.Drawing.Size(72, 16);
            this.judgeReplicate.TabIndex = 27;
            this.judgeReplicate.Text = "自动判断";
            this.judgeReplicate.UseVisualStyleBackColor = true;
            this.judgeReplicate.Visible = false;
            // 
            // resAccurancy2
            // 
            this.resAccurancy2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resAccurancy2.FormattingEnabled = true;
            this.resAccurancy2.Items.AddRange(new object[] {
            "0.00",
            "0.0",
            "0.000",
            "0."});
            this.resAccurancy2.Location = new System.Drawing.Point(182, 402);
            this.resAccurancy2.Name = "resAccurancy2";
            this.resAccurancy2.Size = new System.Drawing.Size(57, 20);
            this.resAccurancy2.TabIndex = 21;
            // 
            // resAccurancy1
            // 
            this.resAccurancy1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resAccurancy1.FormattingEnabled = true;
            this.resAccurancy1.Items.AddRange(new object[] {
            "0.00",
            "0.0",
            "0.000",
            "0."});
            this.resAccurancy1.Location = new System.Drawing.Point(94, 403);
            this.resAccurancy1.Name = "resAccurancy1";
            this.resAccurancy1.Size = new System.Drawing.Size(64, 20);
            this.resAccurancy1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "±";
            // 
            // hzButton
            // 
            this.hzButton.AutoSize = true;
            this.hzButton.ContextMenuStrip = this.hzExitButton;
            this.hzButton.Location = new System.Drawing.Point(260, 397);
            this.hzButton.Name = "hzButton";
            this.hzButton.Size = new System.Drawing.Size(81, 25);
            this.hzButton.SplitMenuStrip = this.hzExitButton;
            this.hzButton.TabIndex = 28;
            this.hzButton.Text = "汇总退出";
            this.hzButton.UseVisualStyleBackColor = true;
            this.hzButton.Click += new System.EventHandler(this.splitButton1_Click);
            // 
            // hzExitButton
            // 
            this.hzExitButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hzStayButton});
            this.hzExitButton.Name = "hzExitButton";
            this.hzExitButton.Size = new System.Drawing.Size(137, 26);
            // 
            // hzStayButton
            // 
            this.hzStayButton.Name = "hzStayButton";
            this.hzStayButton.Size = new System.Drawing.Size(136, 22);
            this.hzStayButton.Text = "汇总不退出";
            this.hzStayButton.Click += new System.EventHandler(this.hzStayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(91, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "请先按照分组排序";
            // 
            // longdataMean
            // 
            this.AcceptButton = this.hzButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(349, 438);
            this.Controls.Add(this.hzButton);
            this.Controls.Add(this.judgeReplicate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.resAccurancy1);
            this.Controls.Add(this.resAccurancy2);
            this.Controls.Add(this.replicate);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.selFinish);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "longdataMean";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "快速均值：提前按分组排序";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.longdataMean_FormClosing);
            this.Load += new System.EventHandler(this.longdataMean_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.hzExitButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox replicate;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Button selFinish;
        private System.Windows.Forms.TextBox dest;
        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton onlyXzx;
        private System.Windows.Forms.RadioButton onlyMean;
        private System.Windows.Forms.RadioButton xzxMean;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton useFormula;
        private System.Windows.Forms.RadioButton useValue;
        private System.Windows.Forms.CheckBox judgeReplicate;
        private System.Windows.Forms.ComboBox resAccurancy2;
        private System.Windows.Forms.ComboBox resAccurancy1;
        private System.Windows.Forms.Label label4;
        private wyDay.Controls.SplitButton hzButton;
        private System.Windows.Forms.ContextMenuStrip hzExitButton;
        private System.Windows.Forms.ToolStripMenuItem hzStayButton;
        private System.Windows.Forms.Label label1;
    }
}