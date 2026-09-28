using System;
using System.Windows.Forms;

namespace FormDangKy
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();

            txtMatKhau.PasswordChar = '*';
            txtXacNhanMK.PasswordChar = '*';

            btnHuy.CausesValidation = false;
        }

        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // 1. Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống");
                hopLe = false;
            }
            else if (txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên phải có ít nhất 3 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // 2. Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không được để trống");
                hopLe = false;
            }
            else if (txtSDT.Text.Length != 10 ||
                     !txtSDT.Text.StartsWith("0") ||
                     !long.TryParse(txtSDT.Text, out _))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải có 10 chữ số và bắt đầu bằng 0");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // 3. Kiểm tra Email
            string email = txtEmail.Text.Trim();
            int viTriA = email.IndexOf("@");

            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(txtEmail, "Email không được để trống");
                hopLe = false;
            }
            else if (viTriA == -1 ||
                     email.IndexOf(".", viTriA + 1) == -1)
            {
                errorProvider1.SetError(txtEmail, "Email phải chứa @ và có dấu . phía sau @");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // 4. Kiểm tra mật khẩu
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu không được để trống");
                hopLe = false;
            }
            else if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có ít nhất 6 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // 5. Kiểm tra xác nhận mật khẩu
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(
                    txtXacNhanMK,
                    "Mật khẩu xác nhận không khớp"
                );

                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;

            errorProvider1.Clear();

            this.Close();
        }
    }
}