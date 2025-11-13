namespace BT09
{
    public partial class Form1 : Form
    {

        class SinhVien
        {
            public string HoTen { get; set; }
            public string MSSV { get; set; }
            public string GioiTinh { get; set; }

            public string ChuyenNganh { get; set; }

            public int SoMon { get; set; }
        }

        private List<SinhVien> ds = new List<SinhVien>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var itemToMove = new List<object>();

            foreach(var item in listBox2.SelectedItems)
            {
                itemToMove.Add(item);
            }

            foreach(var item in itemToMove)
            {
                listBox1.Items.Add(item);
            }

            foreach(var item in itemToMove) {
                listBox2.Items.Remove(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Danh sách môn học đã chọn đang trống. Vui lòng chọn môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                for(int i= listBox2.SelectedItems.Count -1; i >= 0; i--)
                {
                    object itemToRemove = listBox2.SelectedItems[i];
                    listBox1.Items.Add(itemToRemove);
                    listBox2.Items.Remove(itemToRemove);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int n;

            if (!int.TryParse(input, out n))
            {
                MessageBox.Show("Kiểu dữ liệu không phù hợp. Vui lòng nhập lại mã số sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }
        private int STT = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (checkBox1.Checked) gioitinh = "Nam";
            else if (checkBox2.Checked) gioitinh = "Nữ";

            List<string> Monhoc = new List<string>();
            int count = 0;
            foreach (var item in listBox2.Items)
            {
                Monhoc.Add(item.ToString());
                count++;
            }

            SinhVien svMoi = new SinhVien()
            {
                MSSV = textBox1.Text,
                HoTen = textBox2.Text,
                ChuyenNganh = comboBox1.SelectedItem.ToString(),
                GioiTinh = gioitinh,
                SoMon = count
            };

            STT++;
            ListViewItem items = new ListViewItem(STT.ToString());
            items.SubItems.Add(svMoi.MSSV);
            items.SubItems.Add(svMoi.HoTen);
            items.SubItems.Add(svMoi.ChuyenNganh);
            items.SubItems.Add(svMoi.GioiTinh);
            items.SubItems.Add((svMoi.SoMon).ToString());

            listView1.Items.Add(items);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var itemsToMove = new List<object>();
            foreach(var item in listBox1.SelectedItems)
            {
                itemsToMove.Add(item);
            }
            foreach (var item in itemsToMove)
            {
                listBox2.Items.Add(item);
            }

            foreach( var item in itemsToMove)
            {
                listBox1.Items.Remove(item);
            }
        }
    }
}
