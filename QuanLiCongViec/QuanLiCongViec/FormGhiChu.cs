using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiCongViec
{
    public partial class FormGhiChu : Form
    {
        private bool _daThayDoi = false;

        public FormGhiChu()
        {
            InitializeComponent();

            // Mặc định chọn mức Cao giống ảnh mẫu
            cboMucDoUuTien.SelectedIndex = 2;

            // Đăng ký theo dõi thay đổi
            txtTieuDe.TextChanged += DuLieuDaThayDoi;
            txtNoiDung.TextChanged += DuLieuDaThayDoi;
            cboMucDoUuTien.SelectedIndexChanged += DuLieuDaThayDoi;

            // Khi vừa mở form chưa tính là thay đổi
            _daThayDoi = false;
        }

        // =====================================================
        // THEO DÕI DỮ LIỆU CÓ THAY ĐỔI
        // =====================================================
        private void DuLieuDaThayDoi(
            object? sender,
            EventArgs e)
        {
            _daThayDoi = true;
        }

        // =====================================================
        // CTRL + S và ESC
        // =====================================================
        private void FormGhiChu_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            // Ctrl + S
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;

                btnLuuGhiChu.PerformClick();

                return;
            }

            // Escape
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;

                if (_daThayDoi)
                {
                    DialogResult ketQua =
                        MessageBox.Show(
                            "Nội dung ghi chú đã thay đổi.\n"
                            + "Bạn có muốn đóng ghi chú không?",
                            "Xác nhận",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                    if (ketQua == DialogResult.Yes)
                    {
                        // Cho phép đóng kể cả tiêu đề đang sai
                        this.AutoValidate =
                            System.Windows.Forms.AutoValidate.Disable;

                        Close();
                    }
                }
                else
                {
                    this.AutoValidate =
                        System.Windows.Forms.AutoValidate.Disable;

                    Close();
                }
            }
        }

        // =====================================================
        // GIỚI HẠN NỘI DUNG 500 KÝ TỰ
        // =====================================================
        private void txtNoiDung_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (txtNoiDung.TextLength >= 500 &&
                txtNoiDung.SelectionLength == 0 &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // =====================================================
        // DOUBLE CLICK VÀO CHỮ "TIÊU ĐỀ"
        // PHÓNG TO / THU NHỎ
        // =====================================================
        private void lblTieuDeForm_MouseDoubleClick(
            object sender,
            MouseEventArgs e)
        {
            if (WindowState ==
                FormWindowState.Maximized)
            {
                WindowState =
                    FormWindowState.Normal;
            }
            else
            {
                WindowState =
                    FormWindowState.Maximized;
            }
        }

        // =====================================================
        // HOVER BUTTON LƯU
        // =====================================================
        private void btnLuuGhiChu_MouseEnter(
            object sender,
            EventArgs e)
        {
            btnLuuGhiChu.BackColor =
                Color.LightSkyBlue;
        }

        private void btnLuuGhiChu_MouseLeave(
            object sender,
            EventArgs e)
        {
            btnLuuGhiChu.BackColor =
                SystemColors.Control;
        }

        // =====================================================
        // VALIDATING TIÊU ĐỀ
        // =====================================================
        private void txtTieuDe_Validating(
            object sender,
            CancelEventArgs e)
        {
            string tieuDe =
                txtTieuDe.Text.Trim();

            if (string.IsNullOrWhiteSpace(tieuDe))
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được để trống."
                );

                txtTieuDe.BackColor =
                    Color.MistyRose;

                return;
            }

            if (tieuDe.Length > 50)
            {
                e.Cancel = true;

                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề tối đa 50 ký tự."
                );

                txtTieuDe.BackColor =
                    Color.MistyRose;

                return;
            }

            errorProvider1.SetError(
                txtTieuDe,
                ""
            );
        }

        // =====================================================
        // VALIDATED
        // =====================================================
        private void txtTieuDe_Validated(
            object sender,
            EventArgs e)
        {
            txtTieuDe.BackColor =
                Color.White;

            errorProvider1.SetError(
                txtTieuDe,
                ""
            );
        }

        // =====================================================
        // NÚT LƯU
        // =====================================================
        private void btnLuuGhiChu_Click(
            object sender,
            EventArgs e)
        {
            // Trigger tất cả Validating
            if (!ValidateChildren())
            {
                return;
            }

            // Đổi tiêu đề cửa sổ
            Text =
                txtTieuDe.Text.Trim();

            _daThayDoi = false;

            MessageBox.Show(
                "Đã lưu ghi chú",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}