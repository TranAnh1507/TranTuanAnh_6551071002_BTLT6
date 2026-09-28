using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PhanMemQuanLyDT
{
    public partial class Form1 : Form
    {
        // -1 nghĩa là hiện tại không sửa liên hệ nào
        private int _indexDangSua = -1;

        public Form1()
        {
            InitializeComponent();

            // Dữ liệu mẫu để giao diện giống hình trong đề
            lstLienHe.Items.Add("Nguyễn Văn A - 0901234567");
            lstLienHe.Items.Add("Trần Thị B - 0912345678");
            lstLienHe.Items.Add("Lê Văn C - 0987654321");
            lstLienHe.Items.Add("Phạm Thị D - 0911223344");
            lstLienHe.Items.Add("Hoàng Văn E - 0922334455");
        }

        // =====================================================
        // NÚT THÊM
        // Nếu _indexDangSua == -1: thêm mới
        // Nếu _indexDangSua >= 0: cập nhật liên hệ đang sửa
        // =====================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra dữ liệu rỗng
            if (string.IsNullOrWhiteSpace(ten) ||
                string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên và số điện thoại.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string lienHe = ten + " - " + sdt;

            // Đang sửa
            if (_indexDangSua >= 0)
            {
                lstLienHe.Items[_indexDangSua] = lienHe;

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Kết thúc chế độ sửa
                _indexDangSua = -1;

                btnThem.Text = "Thêm";
            }
            else
            {
                // Thêm mới
                lstLienHe.Items.Add(lienHe);

                MessageBox.Show(
                    "Thêm thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            XoaONhap();
        }

        // =====================================================
        // NÚT SỬA
        // =====================================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Lưu index đang sửa
            _indexDangSua = lstLienHe.SelectedIndex;

            string lienHe =
                lstLienHe.SelectedItem!.ToString()!;

            // Tách Tên và SĐT
            int viTri =
                lienHe.LastIndexOf(" - ");

            if (viTri != -1)
            {
                txtTen.Text =
                    lienHe.Substring(0, viTri);

                txtSDT.Text =
                    lienHe.Substring(viTri + 3);
            }

            // Theo đề:
            // bấm Sửa -> đưa dữ liệu lên TextBox
            // bấm lại nút Thêm để cập nhật
            btnThem.Text = "Cập nhật";

            txtTen.Focus();
            txtTen.SelectAll();
        }

        // =====================================================
        // NÚT XÓA
        // =====================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Chưa chọn liên hệ
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int indexCanXoa =
                lstLienHe.SelectedIndex;

            string lienHe =
                lstLienHe.SelectedItem!.ToString()!;

            // Lấy tên
            int viTri =
                lienHe.LastIndexOf(" - ");

            string ten;

            if (viTri != -1)
            {
                ten = lienHe.Substring(0, viTri);
            }
            else
            {
                ten = lienHe;
            }

            DialogResult ketQua =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa liên hệ "
                    + ten
                    + "?\n"
                    + "Thao tác này không thể hoàn tác!",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (ketQua == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(indexCanXoa);

                // Nếu đang sửa đúng liên hệ vừa xóa
                if (_indexDangSua == indexCanXoa)
                {
                    _indexDangSua = -1;

                    txtTen.Clear();
                    txtSDT.Clear();

                    btnThem.Text = "Thêm";
                }

                MessageBox.Show(
                    "Xóa liên hệ thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // =====================================================
        // NÚT THOÁT
        // =====================================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =====================================================
        // FORM CLOSING
        // Nếu có dữ liệu chưa lưu -> hỏi xác nhận
        // =====================================================
        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            bool coDuLieuChuaLuu =
                !string.IsNullOrWhiteSpace(txtTen.Text) ||
                !string.IsNullOrWhiteSpace(txtSDT.Text);

            // Không có dữ liệu chưa lưu -> thoát luôn
            if (!coDuLieuChuaLuu)
            {
                return;
            }

            DialogResult ketQua =
                MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu.\n"
                    + "Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

            if (ketQua == DialogResult.Yes)
            {
                // Yes -> thoát luôn
                e.Cancel = false;
            }
            else if (ketQua == DialogResult.No)
            {
                // No -> xóa dữ liệu rồi thoát
                txtTen.Clear();
                txtSDT.Clear();

                _indexDangSua = -1;

                e.Cancel = false;
            }
            else
            {
                // Cancel -> không đóng Form
                e.Cancel = true;
            }
        }

        // =====================================================
        // HÀM XÓA Ô NHẬP
        // =====================================================
        private void XoaONhap()
        {
            txtTen.Clear();
            txtSDT.Clear();

            txtTen.Focus();
        }
    }
}