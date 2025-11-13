using System.Configuration;

namespace BT06
{
    public partial class Form1 : Form
    {
        double number1, number2, result;
        string operation;
        bool isOperationClicked = false;
        double memory = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void ButtonCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (-double.Parse(txtDisplay.Text)).ToString();
        }

        private void ButtonCan_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);

            if (value < 0)
            {
                MessageBox.Show("Căn bậc hai phải là số không âm", "Lỗi tính toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtDisplay.Text = (Math.Sqrt(value)).ToString();
        }

        private void ButtonDao_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);

            if (value == 0)
            {
                MessageBox.Show("Phép nghịch đảo phải có mẫu lớn hơn không", "Lỗi tính toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtDisplay.Text = (1 / (double)value).ToString();
        }

        private void ButtonDu_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            if (value == 0)
            {
                MessageBox.Show("Phép chia lấy dư phải có mẫu khác không", "Lỗi tính toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isOperationClicked)
            {
                txtDisplay.Text = "";
                isOperationClicked = false;
            }

            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
                txtDisplay.Text += btn.Text;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            number1 = double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isOperationClicked = true;
        }

        private void ButtonBang_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(txtDisplay.Text);

            switch (operation)
            {
                case "+": result = number1 + number2; break;
                case "-": result = number1 - number2; break;
                case "*":
                    result = number1 * number2;
                    result = Math.Round(result, 4);
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        MessageBox.Show("Phép chia phải có mẫu khác không", "Lỗi tính toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    result = number1 / number2;
                    break;
                case "%":
                    if (number2 == 0)
                    {
                        MessageBox.Show("Phép chia phải có mẫu khác không", "Lỗi tính toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    result = (int)(number1 % number2);
                    break;
            }
            txtDisplay.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            number1 = number2 = result = 0;
            operation = "";
        }

        private void ButtonMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void ButtonMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memory.ToString();
        }

        private void ButtonMS_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double val))
                memory = val;
        }

        private void ButtonM_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtDisplay.Text, out double val))
                memory += val;
        }

        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }
    }
}

