namespace BT07
{
    public partial class Form1 : Form
    {
        const int GIA_A = 5000;
        const int GIA_B = 6500;
        const int GIA_C = 8000;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TongTien = 0;
            foreach (Control ctl in table11.Controls)
            {
                if (ctl is Button)
                {
                    Button btn = (Button)ctl;

                    if (btn.BackColor == Color.LightBlue)
                    {
                        btn.BackColor = Color.Yellow;

                        int soGhe = int.Parse(btn.Text);
                        int gia = 0;

                        if (soGhe <= 5) gia = 5000;
                        else if (soGhe > 5 && soGhe <= 10) gia = 6500;
                        else gia = 8000;
                        TongTien += gia;
                    }
                }
            }
            textBox1.Text = TongTien.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonGhe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btn.BackColor == Color.WhiteSmoke)
            {
                btn.BackColor = Color.LightBlue;
            }
            else if (btn.BackColor == Color.LightBlue)
            {
                btn.BackColor = Color.WhiteSmoke;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control  ctl in table11.Controls)
            {
                if( ctl is Button)
                {
                    Button btn = (Button)ctl;

                    if(btn.BackColor == Color.LightBlue)
                    {
                        btn.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            textBox1.Text = "0";
        }
    }
}
