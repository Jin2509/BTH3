namespace BT08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class TaiKhoan
        {
            public string STT { get; set; }
            public string MaTaiKhoan { get; set; }

            public string TenKhachHang { get; set; }

            public string DiaChi { get; set; }

            public double SoTien { get; set; }
        }

        List<TaiKhoan> danhsachTaiKhoan = new List<TaiKhoan>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = TbSTK.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!int.TryParse(text, out int value))
            {
                MessageBox.Show("Dữ liệu không phù hợp yêu cầu", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTKH_TextChanged(object sender, EventArgs e)
        {
            string text = tbTKH.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {
            string text = tbDiaChi.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbTien_TextChanged(object sender, EventArgs e)
        {
            string text = tbTien.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Dữ liệu không được để trống", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!double.TryParse(text, out double value))
            {
                MessageBox.Show("Dữ liệu không phù hợp yêu cầu", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            string maTK = TbSTK.Text;

            TaiKhoan tkTonTai = danhsachTaiKhoan.Find(tk => tk.MaTaiKhoan == maTK);
            TaiKhoan taikhoanMoi = new TaiKhoan
            {
                MaTaiKhoan = maTK,
                TenKhachHang = tbTKH.Text,
                DiaChi = tbDiaChi.Text,
                SoTien = double.Parse(tbTien.Text)
            };

            if (tkTonTai != null)
            {
                tkTonTai.TenKhachHang = taikhoanMoi.TenKhachHang;
                tkTonTai.DiaChi = taikhoanMoi.DiaChi;
                tkTonTai.SoTien = taikhoanMoi.SoTien;

                TinhVaHienThiTongTien();
                CapNhatDataListView();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                danhsachTaiKhoan.Add(taikhoanMoi);

                TinhVaHienThiTongTien();
                CapNhatDataListView();
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TinhVaHienThiTongTien()
        {
            double TongTien = danhsachTaiKhoan.Sum(tk => tk.SoTien);
            TextBoxTongTien.Text = TongTien.ToString();
        }

        private void CapNhatDataListView()
        {
            for (int i = 0; i < danhsachTaiKhoan.Count; i++)
            {
                danhsachTaiKhoan[i].STT = (i + 1).ToString();
            }

            ListViewHThi.Items.Clear();
            foreach (TaiKhoan tk in danhsachTaiKhoan)
            {
                ListViewItem item = new ListViewItem(tk.STT);

                item.SubItems.Add(tk.MaTaiKhoan);
                item.SubItems.Add(tk.TenKhachHang);
                item.SubItems.Add(tk.DiaChi);
                item.SubItems.Add(tk.SoTien.ToString());

                item.Tag = tk;

                ListViewHThi.Items.Add(item);
            }
            TinhVaHienThiTongTien();
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            string MTK_xoa = TbSTK.Text.Trim();

            if (string.IsNullOrEmpty(MTK_xoa))
            {
                MessageBox.Show("Hãy nhập mã tài khoản cần xoá nào !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiKhoan tkCanXoa = danhsachTaiKhoan.Find(tk => tk.MaTaiKhoan == MTK_xoa);

            if (tkCanXoa != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá tài khoản này không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    danhsachTaiKhoan.Remove(tkCanXoa);
                    CapNhatDataListView();
                    XoaDuLieuNhap();
                    MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản cần xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XoaDuLieuNhap()
        {
            TbSTK.Clear();
            tbTKH.Clear();
            tbDiaChi.Clear();
            tbTien.Clear();
            TbSTK.Focus();
        }

        private void ListViewHThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewHThi.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ListViewHThi.SelectedItems[0];

                TaiKhoan tk = selectedItem.Tag as TaiKhoan;
                if (tk != null)
                {
                    TbSTK.Text = tk.MaTaiKhoan;
                    tbDiaChi.Text = tk.DiaChi;
                    tbTKH.Text = tk.TenKhachHang;
                    tbTien.Text = tk.SoTien.ToString();
                }
            }
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
