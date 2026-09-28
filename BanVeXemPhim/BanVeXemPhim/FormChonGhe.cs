using System;
using System.Windows.Forms;

namespace BanVeXemPhim
{
    public partial class FormChonGhe : Form
    {
        // Form chính đọc được
        // nhưng không tự sửa được
        public string GheChon { get; private set; } = "";

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            TaoDanhSachGhe();

            // Nếu trước đó đã chọn ghế
            // thì khi mở lại sẽ chọn sẵn
            if (!string.IsNullOrWhiteSpace(gheHienTai) &&
                lstGhe.Items.Contains(gheHienTai))
            {
                lstGhe.SelectedItem =
                    gheHienTai;
            }
        }

        // =====================================================
        // TẠO GHẾ A1-A5, B1-B5, C1-C5
        // =====================================================
        private void TaoDanhSachGhe()
        {
            string[] hang =
            {
                "A",
                "B",
                "C"
            };

            foreach (string h in hang)
            {
                for (int i = 1; i <= 5; i++)
                {
                    lstGhe.Items.Add(
                        h + i
                    );
                }
            }
        }

        // =====================================================
        // KHI CHỌN GHẾ
        // =====================================================
        private void lstGhe_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text =
                    "Đang chọn: "
                    + lstGhe.SelectedItem;
            }
            else
            {
                lblGheDaChon.Text =
                    "Đang chọn:";
            }
        }

        // =====================================================
        // XÁC NHẬN
        // =====================================================
        private void btnXacNhan_Click(
            object sender,
            EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một ghế.",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            GheChon =
                lstGhe.SelectedItem.ToString()!;

            DialogResult =
                DialogResult.OK;

            Close();
        }

        // =====================================================
        // BỎ QUA
        // =====================================================
        private void btnBoQua_Click(
            object sender,
            EventArgs e)
        {
            DialogResult =
                DialogResult.Cancel;

            Close();
        }
    }
}