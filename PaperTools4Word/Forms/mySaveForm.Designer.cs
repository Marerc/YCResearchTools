
namespace PaperTools4Word.Forms
{
    partial class mySaveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noteInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thesisName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ves1before = new System.Windows.Forms.ComboBox();
            this.ves1after = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ves2before = new System.Windows.Forms.ComboBox();
            this.ves2after = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.finaFilename = new System.Windows.Forms.TextBox();
            this.mySaveButton = new System.Windows.Forms.Button();
            this.noTimestamp = new System.Windows.Forms.CheckBox();
            this.useDefeatSave = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.verName = new System.Windows.Forms.TextBox();
            this.saveOrigin = new System.Windows.Forms.Button();
            this.saveDir = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "论文*：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "正在编辑版本*：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "打算保存版本*：";
            // 
            // noteInput
            // 
            this.noteInput.Location = new System.Drawing.Point(12, 249);
            this.noteInput.Multiline = true;
            this.noteInput.Name = "noteInput";
            this.noteInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteInput.Size = new System.Drawing.Size(310, 125);
            this.noteInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "修改日志（会被以【修改日志.txt】文件保存到文件目录）";
            // 
            // thesisName
            // 
            this.thesisName.Location = new System.Drawing.Point(61, 109);
            this.thesisName.Name = "thesisName";
            this.thesisName.Size = new System.Drawing.Size(261, 21);
            this.thesisName.TabIndex = 1;
            this.thesisName.TextChanged += new System.EventHandler(this.thesisName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "大版本(Afer Review)";
            // 
            // ves1before
            // 
            this.ves1before.FormattingEnabled = true;
            this.ves1before.Location = new System.Drawing.Point(115, 175);
            this.ves1before.Name = "ves1before";
            this.ves1before.Size = new System.Drawing.Size(84, 20);
            this.ves1before.TabIndex = 3;
            this.ves1before.SelectedIndexChanged += new System.EventHandler(this.ves1before_SelectedIndexChanged);
            // 
            // ves1after
            // 
            this.ves1after.FormattingEnabled = true;
            this.ves1after.Location = new System.Drawing.Point(115, 199);
            this.ves1after.Name = "ves1after";
            this.ves1after.Size = new System.Drawing.Size(84, 20);
            this.ves1after.TabIndex = 5;
            this.ves1after.SelectedIndexChanged += new System.EventHandler(this.ves1after_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "小版本(Afer Revise)";
            // 
            // ves2before
            // 
            this.ves2before.FormattingEnabled = true;
            this.ves2before.Location = new System.Drawing.Point(213, 175);
            this.ves2before.Name = "ves2before";
            this.ves2before.Size = new System.Drawing.Size(84, 20);
            this.ves2before.TabIndex = 4;
            this.ves2before.SelectedIndexChanged += new System.EventHandler(this.ves2before_SelectedIndexChanged);
            // 
            // ves2after
            // 
            this.ves2after.FormattingEnabled = true;
            this.ves2after.Location = new System.Drawing.Point(213, 199);
            this.ves2after.Name = "ves2after";
            this.ves2after.Size = new System.Drawing.Size(84, 20);
            this.ves2after.TabIndex = 6;
            this.ves2after.SelectedIndexChanged += new System.EventHandler(this.ves2after_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(198, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(198, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "文件将会以文件名：";
            // 
            // finaFilename
            // 
            this.finaFilename.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.finaFilename.Location = new System.Drawing.Point(10, 439);
            this.finaFilename.Multiline = true;
            this.finaFilename.Name = "finaFilename";
            this.finaFilename.Size = new System.Drawing.Size(237, 50);
            this.finaFilename.TabIndex = 9;
            // 
            // mySaveButton
            // 
            this.mySaveButton.Location = new System.Drawing.Point(253, 460);
            this.mySaveButton.Name = "mySaveButton";
            this.mySaveButton.Size = new System.Drawing.Size(68, 29);
            this.mySaveButton.TabIndex = 10;
            this.mySaveButton.Text = "版本保存";
            this.mySaveButton.UseVisualStyleBackColor = true;
            this.mySaveButton.Click += new System.EventHandler(this.mySaveButton_Click);
            // 
            // noTimestamp
            // 
            this.noTimestamp.AutoSize = true;
            this.noTimestamp.Location = new System.Drawing.Point(127, 417);
            this.noTimestamp.Name = "noTimestamp";
            this.noTimestamp.Size = new System.Drawing.Size(84, 16);
            this.noTimestamp.TabIndex = 8;
            this.noTimestamp.Text = "不需要时间";
            this.noTimestamp.UseVisualStyleBackColor = true;
            this.noTimestamp.CheckedChanged += new System.EventHandler(this.noTimestamp_CheckedChanged);
            // 
            // useDefeatSave
            // 
            this.useDefeatSave.AutoSize = true;
            this.useDefeatSave.Location = new System.Drawing.Point(11, 496);
            this.useDefeatSave.Name = "useDefeatSave";
            this.useDefeatSave.Size = new System.Drawing.Size(312, 16);
            this.useDefeatSave.TabIndex = 29;
            this.useDefeatSave.Text = "以后默认小版本加一后直接保存(在下拉菜单中可设置)";
            this.useDefeatSave.UseVisualStyleBackColor = true;
            this.useDefeatSave.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "版本名称*：";
            // 
            // verName
            // 
            this.verName.Location = new System.Drawing.Point(79, 136);
            this.verName.Name = "verName";
            this.verName.Size = new System.Drawing.Size(243, 21);
            this.verName.TabIndex = 2;
            this.verName.TextChanged += new System.EventHandler(this.verName_TextChanged);
            // 
            // saveOrigin
            // 
            this.saveOrigin.Location = new System.Drawing.Point(253, 420);
            this.saveOrigin.Name = "saveOrigin";
            this.saveOrigin.Size = new System.Drawing.Size(68, 34);
            this.saveOrigin.TabIndex = 10;
            this.saveOrigin.Text = "添加备注后保存";
            this.saveOrigin.UseVisualStyleBackColor = true;
            this.saveOrigin.Click += new System.EventHandler(this.saveOrigin_Click);
            // 
            // saveDir
            // 
            this.saveDir.Enabled = false;
            this.saveDir.Location = new System.Drawing.Point(61, 380);
            this.saveDir.Multiline = true;
            this.saveDir.Name = "saveDir";
            this.saveDir.Size = new System.Drawing.Size(261, 31);
            this.saveDir.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "路径：";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::PaperTools4Word.Properties.Resources.微信截图_20210118095543;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 99);
            this.panel1.TabIndex = 25;
            // 
            // mySaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 518);
            this.Controls.Add(this.useDefeatSave);
            this.Controls.Add(this.noTimestamp);
            this.Controls.Add(this.saveOrigin);
            this.Controls.Add(this.mySaveButton);
            this.Controls.Add(this.ves2after);
            this.Controls.Add(this.ves1after);
            this.Controls.Add(this.ves2before);
            this.Controls.Add(this.ves1before);
            this.Controls.Add(this.saveDir);
            this.Controls.Add(this.finaFilename);
            this.Controls.Add(this.verName);
            this.Controls.Add(this.thesisName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.noteInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "mySaveForm";
            this.Text = "版本保存";
            this.Load += new System.EventHandler(this.mySaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox noteInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox thesisName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ves1before;
        private System.Windows.Forms.ComboBox ves1after;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ves2before;
        private System.Windows.Forms.ComboBox ves2after;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox finaFilename;
        private System.Windows.Forms.Button mySaveButton;
        private System.Windows.Forms.CheckBox noTimestamp;
        private System.Windows.Forms.CheckBox useDefeatSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox verName;
        private System.Windows.Forms.Button saveOrigin;
        private System.Windows.Forms.TextBox saveDir;
        private System.Windows.Forms.Label label11;
    }
}