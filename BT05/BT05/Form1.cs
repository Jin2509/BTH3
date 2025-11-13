namespace BT05
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

        private bool KiemTraKieuDuLieu(string t1, string t2)
        {
            double num1, num2;

            if(!double.TryParse(t1, out num1))
            {
                MessageBox.Show("Dữ liệu nhập vào của số thứ nhất không phải là số thực. Vui lòng nhập lại","Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(! double.TryParse(t2, out num2))
            {
                MessageBox.Show("Dữ liệu nhập vào của số thứ nhất không phải là số thực. Vui lòng nhập lại","lỗi nhập liệu",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CongButton_Click(object sender, EventArgs e)
        {
            string input1 = TextBoxNum1.Text;
            string input2 = TextBoxNum2.Text;

            if (KiemTraKieuDuLieu(input1, input2))
            {
                TextBoxResult.Text = (double.Parse(input1) + double.Parse(input2)).ToString();
                TextBoxResult.Text = Math.Round(double.Parse(TextBoxResult.Text), 4, MidpointRounding.AwayFromZero).ToString();
            }
        }

        private void TruButton_Click(object sender, EventArgs e)
        {
            if(KiemTraKieuDuLieu(TextBoxNum1.Text , TextBoxNum2.Text))
            {
                TextBoxResult.Text = (double.Parse(TextBoxNum1.Text) - double.Parse(TextBoxNum2.Text)).ToString();
                TextBoxResult.Text = Math.Round(double.Parse(TextBoxResult.Text), 4, MidpointRounding.AwayFromZero).ToString();
            }
        }

        private void NhanButton_Click(object sender, EventArgs e)
        {
            if (KiemTraKieuDuLieu(TextBoxNum1.Text, TextBoxNum2.Text))
            {
                TextBoxResult.Text = (double.Parse(TextBoxNum1.Text) * double.Parse(TextBoxNum2.Text)).ToString();
                TextBoxResult.Text = Math.Round(double.Parse(TextBoxResult.Text), 4, MidpointRounding.AwayFromZero).ToString();
            }
        }

        private void ChiaButton_Click(object sender, EventArgs e)
        {
            if (KiemTraKieuDuLieu(TextBoxNum1.Text, TextBoxNum2.Text))
            {
                if (double.Parse(TextBoxNum2.Text) ==0 ) { 
                    MessageBox.Show("Lỗi : Không thể chia cho 0. Vui lòng nhập lại", "Lỗi phép tính", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TextBoxResult.Text = (double.Parse(TextBoxNum1.Text) / double.Parse(TextBoxNum2.Text)).ToString();
                TextBoxResult.Text = Math.Round(double.Parse(TextBoxResult.Text), 4, MidpointRounding.AwayFromZero).ToString();
            }
        }
    }
}
