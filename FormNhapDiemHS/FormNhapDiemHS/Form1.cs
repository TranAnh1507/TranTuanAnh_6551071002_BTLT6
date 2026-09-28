using System;
using System.Globalization;
using System.Windows.Forms;

namespace FormNhapDiemHS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DangKyEnterChuyenField();
        }

        // =====================================================
        // ĐĂNG KÝ ENTER CHUYỂN FIELD
        // =====================================================
        private void DangKyEnterChuyenField()
        {
            txtMaHS.KeyPress += TextBox_KeyPress;
            txtHoTen.KeyPress += TextBox_KeyPress;
            txtToan.KeyPress += TextBox_KeyPress;
            txtVan.KeyPress += TextBox_KeyPress;
            txtAnh.KeyPress += TextBox_KeyPress;
        }

        // =====================================================
        // ENTER:
        // - Các ô bình thường: chuyển sang control tiếp theo
        // - txtAnh: tự động bấm Lưu
        // =====================================================
        private void TextBox_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                // Riêng ô Điểm Anh
                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl(
                        (Control)sender,
                        true,
                        true,
                        true,
                        true
                    );
                }
            }
        }

        // =====================================================
        // KHI FOCUS VÀO Ô ĐIỂM
        // Bôi xanh toàn bộ nội dung
        // =====================================================
        private void TextBoxDiem_Enter(
            object sender,
            EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.SelectAll();
        }

        // =====================================================
        // HÀM KIỂM TRA ĐIỂM
        // =====================================================
        private bool KiemTraDiem(
            TextBox txt,
            string tenMon,
            out decimal diem)
        {
            string duLieu = txt.Text.Trim();

            // Cho phép nhập 9.0 hoặc 9,0
            duLieu = duLieu.Replace(',', '.');

            bool thanhCong =
                decimal.TryParse(
                    duLieu,
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out diem
                );

            if (!thanhCong)
            {
                errorProvider1.SetError(
                    txt,
                    "Điểm " + tenMon + " phải là số."
                );

                return false;
            }

            if (diem < 0 || diem > 10)
            {
                errorProvider1.SetError(
                    txt,
                    "Điểm " + tenMon + " phải từ 0 đến 10."
                );

                return false;
            }

            errorProvider1.SetError(
                txt,
                ""
            );

            return true;
        }

        // =====================================================
        // NÚT LƯU
        // =====================================================
        private void btnLuu_Click(
            object sender,
            EventArgs e)
        {
            bool toanHopLe =
                KiemTraDiem(
                    txtToan,
                    "Toán",
                    out decimal toan
                );

            bool vanHopLe =
                KiemTraDiem(
                    txtVan,
                    "Văn",
                    out decimal van
                );

            bool anhHopLe =
                KiemTraDiem(
                    txtAnh,
                    "Anh",
                    out decimal anh
                );

            // Có ít nhất 1 điểm sai thì không lưu
            if (!toanHopLe ||
                !vanHopLe ||
                !anhHopLe)
            {
                return;
            }

            // Tạo dòng theo đúng định dạng đề bài
            string dong =
                txtMaHS.Text.Trim()
                + " | "
                + txtHoTen.Text.Trim()
                + " | T:"
                + toan
                + " V:"
                + van
                + " A:"
                + anh;

            lstDanhSach.Items.Add(dong);

            // Xóa dữ liệu sau khi lưu
            XoaTrang();
        }

        // =====================================================
        // NÚT XÓA TRẮNG
        // =====================================================
        private void btnXoaTrang_Click(
            object sender,
            EventArgs e)
        {
            XoaTrang();
        }

        // =====================================================
        // HÀM XÓA TRẮNG FORM
        // =====================================================
        private void XoaTrang()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();

            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider1.Clear();

            // Quay lại ô đầu tiên
            txtMaHS.Focus();
        }
    }
}