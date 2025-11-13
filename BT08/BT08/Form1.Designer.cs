namespace BT08
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
            label3 = new Label();
            label4 = new Label();
            TbSTK = new TextBox();
            tbTKH = new TextBox();
            tbDiaChi = new TextBox();
            tbTien = new TextBox();
            ButtonThem = new Button();
            ButtonXoa = new Button();
            ButtonThoat = new Button();
            label5 = new Label();
            label6 = new Label();
            TextBoxTongTien = new TextBox();
            ListViewHThi = new ListView();
            cLSTT = new ColumnHeader();
            clMTK = new ColumnHeader();
            clTenKH = new ColumnHeader();
            clDiaChi = new ColumnHeader();
            clSoTien = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(118, 88);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 0;
            label1.Text = "Số tài khoản";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 124);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 168);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 215);
            label4.Name = "label4";
            label4.Size = new Size(196, 23);
            label4.TabIndex = 3;
            label4.Text = "Số tiền trong tài khoản";
            // 
            // TbSTK
            // 
            TbSTK.Location = new Point(251, 84);
            TbSTK.Name = "TbSTK";
            TbSTK.Size = new Size(487, 27);
            TbSTK.TabIndex = 4;
            TbSTK.TextChanged += textBox1_TextChanged;
            // 
            // tbTKH
            // 
            tbTKH.Location = new Point(251, 124);
            tbTKH.Name = "tbTKH";
            tbTKH.Size = new Size(487, 27);
            tbTKH.TabIndex = 5;
            tbTKH.TextChanged += tbTKH_TextChanged;
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(251, 168);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(487, 27);
            tbDiaChi.TabIndex = 6;
            tbDiaChi.TextChanged += tbDiaChi_TextChanged;
            // 
            // tbTien
            // 
            tbTien.Location = new Point(251, 211);
            tbTien.Name = "tbTien";
            tbTien.Size = new Size(487, 27);
            tbTien.TabIndex = 7;
            tbTien.TextChanged += tbTien_TextChanged;
            // 
            // ButtonThem
            // 
            ButtonThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonThem.Location = new Point(359, 255);
            ButtonThem.Name = "ButtonThem";
            ButtonThem.Size = new Size(126, 29);
            ButtonThem.TabIndex = 8;
            ButtonThem.Text = "Thêm/Cập nhật";
            ButtonThem.UseVisualStyleBackColor = true;
            ButtonThem.Click += ButtonThem_Click;
            // 
            // ButtonXoa
            // 
            ButtonXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonXoa.Location = new Point(509, 255);
            ButtonXoa.Name = "ButtonXoa";
            ButtonXoa.Size = new Size(94, 29);
            ButtonXoa.TabIndex = 9;
            ButtonXoa.Text = "Xoá";
            ButtonXoa.UseVisualStyleBackColor = true;
            ButtonXoa.Click += ButtonXoa_Click;
            // 
            // ButtonThoat
            // 
            ButtonThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonThoat.Location = new Point(635, 255);
            ButtonThoat.Name = "ButtonThoat";
            ButtonThoat.Size = new Size(94, 29);
            ButtonThoat.TabIndex = 10;
            ButtonThoat.Text = "Thoát";
            ButtonThoat.UseVisualStyleBackColor = true;
            ButtonThoat.Click += ButtonThoat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(151, 9);
            label5.Name = "label5";
            label5.Size = new Size(633, 54);
            label5.TabIndex = 12;
            label5.Text = "QUẢN LÍ THÔNG TIN TÀI KHOẢN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(560, 564);
            label6.Name = "label6";
            label6.Size = new Size(92, 23);
            label6.TabIndex = 13;
            label6.Text = "Tổng tiền:";
            // 
            // TextBoxTongTien
            // 
            TextBoxTongTien.Location = new Point(671, 560);
            TextBoxTongTien.Name = "TextBoxTongTien";
            TextBoxTongTien.Size = new Size(234, 27);
            TextBoxTongTien.TabIndex = 14;
            // 
            // ListViewHThi
            // 
            ListViewHThi.Columns.AddRange(new ColumnHeader[] { cLSTT, clMTK, clTenKH, clDiaChi, clSoTien });
            ListViewHThi.Location = new Point(47, 325);
            ListViewHThi.Name = "ListViewHThi";
            ListViewHThi.Size = new Size(839, 215);
            ListViewHThi.TabIndex = 15;
            ListViewHThi.UseCompatibleStateImageBehavior = false;
            ListViewHThi.View = View.Details;
            ListViewHThi.SelectedIndexChanged += ListViewHThi_SelectedIndexChanged;
            // 
            // cLSTT
            // 
            cLSTT.Text = "STT";
            // 
            // clMTK
            // 
            clMTK.Text = "Mã tài khoản";
            clMTK.Width = 120;
            // 
            // clTenKH
            // 
            clTenKH.Text = "Tên khách hàng";
            clTenKH.Width = 220;
            // 
            // clDiaChi
            // 
            clDiaChi.Text = "Địa chỉ";
            clDiaChi.Width = 320;
            // 
            // clSoTien
            // 
            clSoTien.Text = "Số tiền";
            clSoTien.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 617);
            Controls.Add(ListViewHThi);
            Controls.Add(TextBoxTongTien);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ButtonThoat);
            Controls.Add(ButtonXoa);
            Controls.Add(ButtonThem);
            Controls.Add(tbTien);
            Controls.Add(tbDiaChi);
            Controls.Add(tbTKH);
            Controls.Add(TbSTK);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TbSTK;
        private TextBox tbTKH;
        private TextBox tbDiaChi;
        private TextBox tbTien;
        private Button ButtonThem;
        private Button ButtonXoa;
        private Button ButtonThoat;
        private Label label5;
        private Label label6;
        private TextBox TextBoxTongTien;
        private ListView ListViewHThi;
        private ColumnHeader cLSTT;
        private ColumnHeader clMTK;
        private ColumnHeader clTenKH;
        private ColumnHeader clDiaChi;
        private ColumnHeader clSoTien;
    }
}
