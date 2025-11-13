namespace BT03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color newColor = GetRanDomColor();
            this.BackColor = newColor;
        }

        private Color GetRanDomColor()
        {
            Random rd = new Random();
            int r = rd.Next(256);
            int g = rd.Next(256);
            int b = rd.Next(256);

            return Color.FromArgb(r, g, b);
        }
    }
}
