
namespace ycResearchTools.forms
{
    partial class Table_Reform
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
            this.targetWorkbookTxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.sortTargetCKB = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // targetWorkbookTxt
            // 
            this.targetWorkbookTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetWorkbookTxt.FormattingEnabled = true;
            this.targetWorkbookTxt.Location = new System.Drawing.Point(92, 22);
            this.targetWorkbookTxt.Name = "targetWorkbookTxt";
            this.targetWorkbookTxt.Size = new System.Drawing.Size(183, 20);
            this.targetWorkbookTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "目标工作簿";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(229, 68);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(58, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "开  始";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // sortTargetCKB
            // 
            this.sortTargetCKB.AutoSize = true;
            this.sortTargetCKB.Checked = true;
            this.sortTargetCKB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortTargetCKB.Location = new System.Drawing.Point(23, 72);
            this.sortTargetCKB.Name = "sortTargetCKB";
            this.sortTargetCKB.Size = new System.Drawing.Size(120, 16);
            this.sortTargetCKB.TabIndex = 3;
            this.sortTargetCKB.Text = "先整理目标工作簿";
            this.sortTargetCKB.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(162, 68);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(56, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "放  弃";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Table_Reform
            // 
            this.AcceptButton = this.startBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(300, 123);
            this.Controls.Add(this.sortTargetCKB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetWorkbookTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Table_Reform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Table_Reform";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Table_Reform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox targetWorkbookTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.CheckBox sortTargetCKB;
        private System.Windows.Forms.Button cancelBtn;
    }
}