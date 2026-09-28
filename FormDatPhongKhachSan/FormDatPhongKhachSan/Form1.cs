using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace FormDatPhongKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ==========================================
        // HÀM BÁO LỖI
        // ==========================================
        private void BaoLoi(
            TextBox txt,
            CancelEventArgs e,
            string thongBao)
        {
            e.Cancel = true;

            errorProvider1.SetError(txt, thongBao);

            txt.BackColor = Color.MistyRose;
        }

        // ==========================================
        // HÀM XÁC NHẬN HỢP LỆ
        // ==========================================
        private void HopLe(TextBox txt)
        {
            errorProvider1.SetError(txt, "");

            txt.BackColor = Color.Honeydew;
        }

        // ==========================================
        // 1. KIỂM TRA HỌ TÊN
        // ==========================================
        private void txtHoTen_Validating(
            object sender,
            CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                BaoLoi(
                    txtHoTen,
                    e,
                    "Họ tên không được để trống"
                );
            }
            else
            {
                HopLe(txtHoTen);
            }
        }

        // ==========================================
        // 2. KIỂM TRA CCCD
        // ==========================================
        private void txtCCCD_Validating(
            object sender,
            CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();

            if (cccd.Length != 12 ||
                !long.TryParse(cccd, out _))
            {
                BaoLoi(
                    txtCCCD,
                    e,
                    "CCCD phải gồm đúng 12 chữ số"
                );
            }
            else
            {
                HopLe(txtCCCD);
            }
        }

        // ==========================================
        // 3. KIỂM TRA NGÀY NHẬN
        // ==========================================
        private void txtNgayNhan_Validating(
            object sender,
            CancelEventArgs e)
        {
            bool thanhCong = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime ngayNhan
            );

            if (!thanhCong)
            {
                BaoLoi(
                    txtNgayNhan,
                    e,
                    "Ngày nhận phải có dạng dd/MM/yyyy"
                );
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                BaoLoi(
                    txtNgayNhan,
                    e,
                    "Ngày nhận không được nhỏ hơn hôm nay"
                );
            }
            else
            {
                HopLe(txtNgayNhan);
            }
        }

        // ==========================================
        // 4. KIỂM TRA NGÀY TRẢ
        // ==========================================
        private void txtNgayTra_Validating(
            object sender,
            CancelEventArgs e)
        {
            bool nhanHopLe = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime ngayNhan
            );

            bool traHopLe = DateTime.TryParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime ngayTra
            );

            if (!traHopLe)
            {
                BaoLoi(
                    txtNgayTra,
                    e,
                    "Ngày trả phải có dạng dd/MM/yyyy"
                );
            }
            else if (!nhanHopLe)
            {
                BaoLoi(
                    txtNgayTra,
                    e,
                    "Ngày nhận chưa hợp lệ"
                );
            }
            else if (ngayTra.Date <= ngayNhan.Date)
            {
                BaoLoi(
                    txtNgayTra,
                    e,
                    "Ngày trả phải sau ngày nhận"
                );
            }
            else
            {
                HopLe(txtNgayTra);
            }
        }

        // ==========================================
        // 5. KIỂM TRA SỐ NGƯỜI LỚN
        // ==========================================
        private void txtSoNguoiLon_Validating(
            object sender,
            CancelEventArgs e)
        {
            if (!int.TryParse(
                    txtSoNguoiLon.Text.Trim(),
                    out int soNguoiLon) ||
                soNguoiLon < 1 ||
                soNguoiLon > 4)
            {
                BaoLoi(
                    txtSoNguoiLon,
                    e,
                    "Số người lớn phải từ 1 đến 4"
                );
            }
            else
            {
                HopLe(txtSoNguoiLon);
            }
        }

        // ==========================================
        // 6. KIỂM TRA SỐ TRẺ EM
        // ==========================================
        private void txtSoTreEm_Validating(
            object sender,
            CancelEventArgs e)
        {
            if (!int.TryParse(
                    txtSoTreEm.Text.Trim(),
                    out int soTreEm) ||
                soTreEm < 0 ||
                soTreEm > 3)
            {
                BaoLoi(
                    txtSoTreEm,
                    e,
                    "Số trẻ em phải từ 0 đến 3"
                );
            }
            else
            {
                HopLe(txtSoTreEm);
            }
        }

        // ==========================================
        // VALIDATED
        // ==========================================
        private void TextBox_Validated(
            object sender,
            EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.BackColor = Color.Honeydew;

            errorProvider1.SetError(txt, "");
        }

        // ==========================================
        // NÚT ĐẶT PHÒNG
        // ==========================================
        private void btnDatPhong_Click(
            object sender,
            EventArgs e)
        {
            // Chạy tất cả validation
            if (!ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );

            DateTime ngayTra = DateTime.ParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );

            int soDem = (ngayTra - ngayNhan).Days;

            MessageBox.Show(
                "Đặt phòng thành công!\n\n" +
                "Khách hàng: " + txtHoTen.Text.Trim() + "\n" +
                "Số đêm: " + soDem + "\n" +
                "Số người lớn: " + txtSoNguoiLon.Text + "\n" +
                "Số trẻ em: " + txtSoTreEm.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}