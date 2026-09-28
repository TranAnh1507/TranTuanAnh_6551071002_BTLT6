using System;
using System.Windows.Forms;

namespace QuanLiCongViec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CapNhatSoGhiChu();
        }

        // =====================================================
        // MỞ GHI CHÚ MỚI
        // =====================================================
        private void mnuMoGhiChuMoi_Click(
            object sender,
            EventArgs e)
        {
            FormGhiChu frm = new FormGhiChu();

            // Đặt FormGhiChu thành Form con MDI
            frm.MdiParent = this;

            // Khi Form con đóng thì cập nhật số lượng
            frm.FormClosed += FormGhiChu_FormClosed;

            frm.Show();

            CapNhatSoGhiChu();
        }

        // =====================================================
        // KHI FORM GHI CHÚ ĐÓNG
        // =====================================================
        private void FormGhiChu_FormClosed(
            object? sender,
            FormClosedEventArgs e)
        {
            CapNhatSoGhiChu();
        }

        // =====================================================
        // SẮP XẾP CỬA SỔ
        // =====================================================
        private void mnuSapXepCuaSo_Click(
            object sender,
            EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        // =====================================================
        // XẾP TẦNG
        // =====================================================
        private void mnuXepTang_Click(
            object sender,
            EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        // =====================================================
        // XẾP NGANG
        // =====================================================
        private void mnuXepNgang_Click(
            object sender,
            EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        // =====================================================
        // XẾP DỌC
        // =====================================================
        private void mnuXepDoc_Click(
            object sender,
            EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        // =====================================================
        // THOÁT
        // =====================================================
        private void mnuThoat_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        // =====================================================
        // CẬP NHẬT SỐ GHI CHÚ
        // =====================================================
        private void CapNhatSoGhiChu()
        {
            lblSoGhiChu.Text =
                "Số ghi chú đang mở: "
                + MdiChildren.Length;
        }
    }
}