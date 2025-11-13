using System;
using System.Drawing;
using System.Windows.Forms;

namespace BT02
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = rd.Next(0, this.ClientSize.Width - 100);
            int y = rd.Next(0, this.ClientSize.Height - 30);
            Color rdColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
            using (Brush br = new SolidBrush(rdColor))
            using (Font font = new Font("Times New Roman", 24, FontStyle.Bold))
            {
                g.DrawString("Paint Event", font, br,x, y);
            }
        }
    }
}
