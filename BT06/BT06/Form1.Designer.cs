namespace BT06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            txtDisplay = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ButtonMC = new Button();
            ButtonMR = new Button();
            ButtonMS = new Button();
            ButtonM = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ButtonNhan = new Button();
            ButtonDu = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            ButtonTru = new Button();
            ButtonDao = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            ButtonCong = new Button();
            ButtonBang = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            ButtonChia = new Button();
            ButtonCan = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            ButtonBackspace = new Button();
            ButtonCE = new Button();
            ButtonC = new Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(642, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(34, 43);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(575, 28);
            txtDisplay.TabIndex = 1;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.20635F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.79365F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Controls.Add(ButtonMC, 0, 0);
            tableLayoutPanel1.Controls.Add(ButtonMR, 0, 1);
            tableLayoutPanel1.Controls.Add(ButtonMS, 0, 2);
            tableLayoutPanel1.Controls.Add(ButtonM, 0, 3);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Controls.Add(button7, 3, 1);
            tableLayoutPanel1.Controls.Add(ButtonNhan, 4, 1);
            tableLayoutPanel1.Controls.Add(ButtonDu, 5, 1);
            tableLayoutPanel1.Controls.Add(button10, 1, 2);
            tableLayoutPanel1.Controls.Add(button11, 2, 2);
            tableLayoutPanel1.Controls.Add(button12, 3, 2);
            tableLayoutPanel1.Controls.Add(ButtonTru, 4, 2);
            tableLayoutPanel1.Controls.Add(ButtonDao, 5, 2);
            tableLayoutPanel1.Controls.Add(button15, 1, 3);
            tableLayoutPanel1.Controls.Add(button16, 2, 3);
            tableLayoutPanel1.Controls.Add(button17, 3, 3);
            tableLayoutPanel1.Controls.Add(ButtonCong, 4, 3);
            tableLayoutPanel1.Controls.Add(ButtonBang, 5, 3);
            tableLayoutPanel1.Controls.Add(button20, 1, 0);
            tableLayoutPanel1.Controls.Add(button21, 2, 0);
            tableLayoutPanel1.Controls.Add(button22, 3, 0);
            tableLayoutPanel1.Controls.Add(ButtonChia, 4, 0);
            tableLayoutPanel1.Controls.Add(ButtonCan, 5, 0);
            tableLayoutPanel1.Location = new Point(34, 146);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.7804871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.2195129F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(575, 197);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // ButtonMC
            // 
            ButtonMC.ForeColor = Color.Red;
            ButtonMC.Location = new Point(3, 3);
            ButtonMC.Name = "ButtonMC";
            ButtonMC.Size = new Size(87, 29);
            ButtonMC.TabIndex = 0;
            ButtonMC.Text = "MC";
            ButtonMC.UseVisualStyleBackColor = true;
            ButtonMC.Click += ButtonMC_Click;
            // 
            // ButtonMR
            // 
            ButtonMR.ForeColor = Color.Red;
            ButtonMR.Location = new Point(3, 49);
            ButtonMR.Name = "ButtonMR";
            ButtonMR.Size = new Size(87, 29);
            ButtonMR.TabIndex = 1;
            ButtonMR.Text = "MR";
            ButtonMR.UseVisualStyleBackColor = true;
            ButtonMR.Click += ButtonMR_Click;
            // 
            // ButtonMS
            // 
            ButtonMS.ForeColor = Color.Red;
            ButtonMS.Location = new Point(3, 98);
            ButtonMS.Name = "ButtonMS";
            ButtonMS.Size = new Size(87, 29);
            ButtonMS.TabIndex = 2;
            ButtonMS.Text = "MS";
            ButtonMS.UseVisualStyleBackColor = true;
            ButtonMS.Click += ButtonMS_Click;
            // 
            // ButtonM
            // 
            ButtonM.ForeColor = Color.Red;
            ButtonM.Location = new Point(3, 151);
            ButtonM.Name = "ButtonM";
            ButtonM.Size = new Size(87, 29);
            ButtonM.TabIndex = 3;
            ButtonM.Text = "M+";
            ButtonM.UseVisualStyleBackColor = true;
            ButtonM.Click += ButtonM_Click;
            // 
            // button5
            // 
            button5.Location = new Point(96, 49);
            button5.Name = "button5";
            button5.Size = new Size(90, 29);
            button5.TabIndex = 4;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnNumber_Click;
            // 
            // button6
            // 
            button6.Location = new Point(192, 49);
            button6.Name = "button6";
            button6.Size = new Size(91, 29);
            button6.TabIndex = 5;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnNumber_Click;
            // 
            // button7
            // 
            button7.Location = new Point(289, 49);
            button7.Name = "button7";
            button7.Size = new Size(93, 29);
            button7.TabIndex = 6;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnNumber_Click;
            // 
            // ButtonNhan
            // 
            ButtonNhan.ForeColor = Color.Red;
            ButtonNhan.Location = new Point(388, 49);
            ButtonNhan.Name = "ButtonNhan";
            ButtonNhan.Size = new Size(94, 29);
            ButtonNhan.TabIndex = 7;
            ButtonNhan.Text = "*";
            ButtonNhan.UseVisualStyleBackColor = true;
            ButtonNhan.Click += btnOperation_Click;
            // 
            // ButtonDu
            // 
            ButtonDu.Location = new Point(492, 49);
            ButtonDu.Name = "ButtonDu";
            ButtonDu.Size = new Size(80, 29);
            ButtonDu.TabIndex = 8;
            ButtonDu.Text = "%";
            ButtonDu.UseVisualStyleBackColor = true;
            ButtonDu.Click += ButtonDu_Click;
            // 
            // button10
            // 
            button10.Location = new Point(96, 98);
            button10.Name = "button10";
            button10.Size = new Size(90, 29);
            button10.TabIndex = 9;
            button10.Text = "1";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnNumber_Click;
            // 
            // button11
            // 
            button11.Location = new Point(192, 98);
            button11.Name = "button11";
            button11.Size = new Size(91, 29);
            button11.TabIndex = 10;
            button11.Text = "2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnNumber_Click;
            // 
            // button12
            // 
            button12.Location = new Point(289, 98);
            button12.Name = "button12";
            button12.Size = new Size(93, 29);
            button12.TabIndex = 11;
            button12.Text = "3";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnNumber_Click;
            // 
            // ButtonTru
            // 
            ButtonTru.ForeColor = Color.Red;
            ButtonTru.Location = new Point(388, 98);
            ButtonTru.Name = "ButtonTru";
            ButtonTru.Size = new Size(94, 29);
            ButtonTru.TabIndex = 12;
            ButtonTru.Text = "-";
            ButtonTru.UseVisualStyleBackColor = true;
            ButtonTru.Click += btnOperation_Click;
            // 
            // ButtonDao
            // 
            ButtonDao.Location = new Point(492, 98);
            ButtonDao.Name = "ButtonDao";
            ButtonDao.Size = new Size(80, 29);
            ButtonDao.TabIndex = 13;
            ButtonDao.Text = "1/x";
            ButtonDao.UseVisualStyleBackColor = true;
            ButtonDao.Click += ButtonDao_Click;
            // 
            // button15
            // 
            button15.Location = new Point(96, 151);
            button15.Name = "button15";
            button15.Size = new Size(90, 29);
            button15.TabIndex = 14;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = true;
            button15.Click += btnNumber_Click;
            // 
            // button16
            // 
            button16.Location = new Point(192, 151);
            button16.Name = "button16";
            button16.Size = new Size(91, 29);
            button16.TabIndex = 15;
            button16.Text = "+/-";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Location = new Point(289, 151);
            button17.Name = "button17";
            button17.Size = new Size(93, 29);
            button17.TabIndex = 16;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // ButtonCong
            // 
            ButtonCong.ForeColor = Color.Red;
            ButtonCong.Location = new Point(388, 151);
            ButtonCong.Name = "ButtonCong";
            ButtonCong.Size = new Size(94, 29);
            ButtonCong.TabIndex = 17;
            ButtonCong.Text = "+";
            ButtonCong.UseVisualStyleBackColor = true;
            ButtonCong.Click += btnOperation_Click;
            // 
            // ButtonBang
            // 
            ButtonBang.ForeColor = Color.Red;
            ButtonBang.Location = new Point(492, 151);
            ButtonBang.Name = "ButtonBang";
            ButtonBang.Size = new Size(80, 29);
            ButtonBang.TabIndex = 18;
            ButtonBang.Text = "=";
            ButtonBang.UseVisualStyleBackColor = true;
            ButtonBang.Click += ButtonBang_Click;
            // 
            // button20
            // 
            button20.Location = new Point(96, 3);
            button20.Name = "button20";
            button20.Size = new Size(90, 29);
            button20.TabIndex = 19;
            button20.Text = "7";
            button20.UseVisualStyleBackColor = true;
            button20.Click += btnNumber_Click;
            // 
            // button21
            // 
            button21.Location = new Point(192, 3);
            button21.Name = "button21";
            button21.Size = new Size(91, 29);
            button21.TabIndex = 20;
            button21.Text = "8";
            button21.UseVisualStyleBackColor = true;
            button21.Click += btnNumber_Click;
            // 
            // button22
            // 
            button22.Location = new Point(289, 3);
            button22.Name = "button22";
            button22.Size = new Size(93, 29);
            button22.TabIndex = 21;
            button22.Text = "9";
            button22.UseVisualStyleBackColor = true;
            button22.Click += btnNumber_Click;
            // 
            // ButtonChia
            // 
            ButtonChia.ForeColor = Color.Red;
            ButtonChia.Location = new Point(388, 3);
            ButtonChia.Name = "ButtonChia";
            ButtonChia.Size = new Size(94, 29);
            ButtonChia.TabIndex = 22;
            ButtonChia.Text = "/";
            ButtonChia.UseVisualStyleBackColor = true;
            ButtonChia.Click += btnOperation_Click;
            // 
            // ButtonCan
            // 
            ButtonCan.Location = new Point(492, 3);
            ButtonCan.Name = "ButtonCan";
            ButtonCan.Size = new Size(80, 29);
            ButtonCan.TabIndex = 23;
            ButtonCan.Text = "sqrt";
            ButtonCan.UseVisualStyleBackColor = true;
            ButtonCan.Click += ButtonCan_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.0689659F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.9310341F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutPanel2.Controls.Add(ButtonBackspace, 1, 0);
            tableLayoutPanel2.Controls.Add(ButtonCE, 2, 0);
            tableLayoutPanel2.Controls.Add(ButtonC, 3, 0);
            tableLayoutPanel2.Location = new Point(44, 89);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(518, 42);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // ButtonBackspace
            // 
            ButtonBackspace.ForeColor = Color.Red;
            ButtonBackspace.Location = new Point(118, 3);
            ButtonBackspace.Name = "ButtonBackspace";
            ButtonBackspace.Size = new Size(153, 29);
            ButtonBackspace.TabIndex = 0;
            ButtonBackspace.Text = "Backspace";
            ButtonBackspace.UseVisualStyleBackColor = true;
            ButtonBackspace.Click += ButtonBackspace_Click;
            // 
            // ButtonCE
            // 
            ButtonCE.ForeColor = Color.Red;
            ButtonCE.Location = new Point(277, 3);
            ButtonCE.Name = "ButtonCE";
            ButtonCE.Size = new Size(115, 29);
            ButtonCE.TabIndex = 1;
            ButtonCE.Text = "CE";
            ButtonCE.UseVisualStyleBackColor = true;
            ButtonCE.Click += ButtonCE_Click;
            // 
            // ButtonC
            // 
            ButtonC.ForeColor = Color.Red;
            ButtonC.Location = new Point(398, 3);
            ButtonC.Name = "ButtonC";
            ButtonC.Size = new Size(109, 29);
            ButtonC.TabIndex = 2;
            ButtonC.Text = "C";
            ButtonC.UseVisualStyleBackColor = true;
            ButtonC.Click += ButtonC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 381);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtDisplay);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy tính đơn giản";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TextBox txtDisplay;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ButtonMC;
        private Button ButtonMR;
        private Button ButtonMS;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ButtonM;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button ButtonNhan;
        private Button ButtonDu;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button ButtonTru;
        private Button ButtonDao;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button ButtonCong;
        private Button ButtonBang;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button ButtonChia;
        private Button ButtonCan;
        private Button ButtonBackspace;
        private Button ButtonCE;
        private Button ButtonC;
    }
}
