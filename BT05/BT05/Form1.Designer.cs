namespace BT05
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
            label1 = new Label();
            label2 = new Label();
            TextBoxNum1 = new TextBox();
            TextBoxNum2 = new TextBox();
            CongButton = new Button();
            TruButton = new Button();
            NhanButton = new Button();
            ChiaButton = new Button();
            label3 = new Label();
            TextBoxResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 56);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(132, 115);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // TextBoxNum1
            // 
            TextBoxNum1.Location = new Point(234, 56);
            TextBoxNum1.Name = "TextBoxNum1";
            TextBoxNum1.Size = new Size(275, 27);
            TextBoxNum1.TabIndex = 2;
            // 
            // TextBoxNum2
            // 
            TextBoxNum2.Location = new Point(234, 112);
            TextBoxNum2.Name = "TextBoxNum2";
            TextBoxNum2.Size = new Size(275, 27);
            TextBoxNum2.TabIndex = 3;
            // 
            // CongButton
            // 
            CongButton.Location = new Point(138, 176);
            CongButton.Name = "CongButton";
            CongButton.Size = new Size(70, 30);
            CongButton.TabIndex = 4;
            CongButton.Text = "+";
            CongButton.UseVisualStyleBackColor = true;
            CongButton.Click += CongButton_Click;
            // 
            // TruButton
            // 
            TruButton.Location = new Point(235, 176);
            TruButton.Name = "TruButton";
            TruButton.Size = new Size(70, 30);
            TruButton.TabIndex = 5;
            TruButton.Text = "-";
            TruButton.UseVisualStyleBackColor = true;
            TruButton.Click += TruButton_Click;
            // 
            // NhanButton
            // 
            NhanButton.Location = new Point(330, 176);
            NhanButton.Name = "NhanButton";
            NhanButton.Size = new Size(70, 30);
            NhanButton.TabIndex = 6;
            NhanButton.Text = "*";
            NhanButton.UseVisualStyleBackColor = true;
            NhanButton.Click += NhanButton_Click;
            // 
            // ChiaButton
            // 
            ChiaButton.Location = new Point(425, 176);
            ChiaButton.Name = "ChiaButton";
            ChiaButton.Size = new Size(70, 30);
            ChiaButton.TabIndex = 7;
            ChiaButton.Text = "/";
            ChiaButton.UseVisualStyleBackColor = true;
            ChiaButton.Click += ChiaButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 261);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 8;
            label3.Text = "Kết quả tính toán";
            // 
            // TextBoxResult
            // 
            TextBoxResult.Location = new Point(235, 258);
            TextBoxResult.Name = "TextBoxResult";
            TextBoxResult.Size = new Size(274, 27);
            TextBoxResult.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 353);
            Controls.Add(TextBoxResult);
            Controls.Add(label3);
            Controls.Add(ChiaButton);
            Controls.Add(NhanButton);
            Controls.Add(TruButton);
            Controls.Add(CongButton);
            Controls.Add(TextBoxNum2);
            Controls.Add(TextBoxNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính toán cơ bản";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextBoxNum1;
        private TextBox TextBoxNum2;
        private Button CongButton;
        private Button TruButton;
        private Button NhanButton;
        private Button ChiaButton;
        private Label label3;
        private TextBox TextBoxResult;
    }
}
