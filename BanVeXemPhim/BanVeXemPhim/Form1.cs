using System;
using System.Windows.Forms;

namespace BanVeXemPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Danh sách phim
            cboPhim.Items.AddRange(new object[]
            {
                "Chiến binh cuối cùng",
                "Avengers: Endgame",
                "Spider-Man",
                "Doraemon"
            });

            // Danh sách suất chiếu
            cboSuatChieu.Items.AddRange(new object[]
            {
                "09:00",
                "14:00",
                "19:00",
                "21:30"
            });

            cboPhim.SelectedIndex = 0;
            cboSuatChieu.SelectedIndex = 0;
        }

        // NÚT CHỌN GHẾ
        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg =
                   new FormChonGhe(txtGheDaChon.Text))
            {
                DialogResult ketQua =
                    dlg.ShowDialog(this);

                if (ketQua == DialogResult.OK)
                {
                    txtGheDaChon.Text =
                        dlg.GheChon;
                }
            }
        }
        // NÚT ĐẶT VÉ
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên khách.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn phim.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cboSuatChieu.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn suất chiếu.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn ghế.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            MessageBox.Show(
                "Đặt vé thành công!\n\n" +
                "Tên khách: " + txtTenKhach.Text.Trim() + "\n" +
                "Phim: " + cboPhim.SelectedItem + "\n" +
                "Suất chiếu: " + cboSuatChieu.SelectedItem + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá vé: 75.000đ/vé",
                "Thông tin đặt vé",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // NÚT HỦY
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}