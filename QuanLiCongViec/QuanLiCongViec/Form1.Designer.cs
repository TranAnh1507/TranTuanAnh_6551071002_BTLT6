namespace QuanLiCongViec
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripMenuItem mnuTep;
        private System.Windows.Forms.ToolStripMenuItem mnuMoGhiChuMoi;
        private System.Windows.Forms.ToolStripMenuItem mnuSapXepCuaSo;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;

        private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem mnuXepTang;
        private System.Windows.Forms.ToolStripMenuItem mnuXepNgang;
        private System.Windows.Forms.ToolStripMenuItem mnuXepDoc;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSoGhiChu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            menuStrip1 =
                new System.Windows.Forms.MenuStrip();

            mnuTep =
                new System.Windows.Forms.ToolStripMenuItem();

            mnuMoGhiChuMoi =
                new System.Windows.Forms.ToolStripMenuItem();

            mnuSapXepCuaSo =
                new System.Windows.Forms.ToolStripMenuItem();

            mnuThoat =
                new System.Windows.Forms.ToolStripMenuItem();

            mnuCuaSo =
                new System.Windows.Forms.ToolStripMenuItem();

            mnuXepTang =
                new System.Windows.Forms.ToolStripMenuItem();

            mnuXepNgang =
                new System.Windows.Forms.ToolStripMenuItem();

            mnuXepDoc =
                new System.Windows.Forms.ToolStripMenuItem();

            statusStrip1 =
                new System.Windows.Forms.StatusStrip();

            lblSoGhiChu =
                new System.Windows.Forms.ToolStripStatusLabel();

            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();

            SuspendLayout();

            // =====================================================
            // MENU TỆP
            // =====================================================
            mnuTep.Name = "mnuTep";
            mnuTep.Size =
                new System.Drawing.Size(37, 20);

            mnuTep.Text = "Tệp";

            mnuTep.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    mnuMoGhiChuMoi,
                    mnuSapXepCuaSo,
                    mnuThoat
                }
            );

            // =====================================================
            // MỞ GHI CHÚ MỚI
            // =====================================================
            mnuMoGhiChuMoi.Name =
                "mnuMoGhiChuMoi";

            mnuMoGhiChuMoi.Size =
                new System.Drawing.Size(180, 22);

            mnuMoGhiChuMoi.Text =
                "Mở ghi chú mới";

            mnuMoGhiChuMoi.ShortcutKeys =
                System.Windows.Forms.Keys.Control |
                System.Windows.Forms.Keys.N;

            mnuMoGhiChuMoi.Click +=
                new System.EventHandler(
                    mnuMoGhiChuMoi_Click
                );

            // =====================================================
            // SẮP XẾP CỬA SỔ
            // =====================================================
            mnuSapXepCuaSo.Name =
                "mnuSapXepCuaSo";

            mnuSapXepCuaSo.Size =
                new System.Drawing.Size(180, 22);

            mnuSapXepCuaSo.Text =
                "Sắp xếp cửa sổ";

            mnuSapXepCuaSo.Click +=
                new System.EventHandler(
                    mnuSapXepCuaSo_Click
                );

            // =====================================================
            // THOÁT
            // =====================================================
            mnuThoat.Name =
                "mnuThoat";

            mnuThoat.Size =
                new System.Drawing.Size(180, 22);

            mnuThoat.Text =
                "Thoát";

            mnuThoat.Click +=
                new System.EventHandler(
                    mnuThoat_Click
                );

            // =====================================================
            // MENU CỬA SỔ
            // =====================================================
            mnuCuaSo.Name =
                "mnuCuaSo";

            mnuCuaSo.Size =
                new System.Drawing.Size(57, 20);

            mnuCuaSo.Text =
                "Cửa sổ";

            mnuCuaSo.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    mnuXepTang,
                    mnuXepNgang,
                    mnuXepDoc
                }
            );

            // =====================================================
            // XẾP TẦNG
            // =====================================================
            mnuXepTang.Name =
                "mnuXepTang";

            mnuXepTang.Size =
                new System.Drawing.Size(134, 22);

            mnuXepTang.Text =
                "Xếp tầng";

            mnuXepTang.Click +=
                new System.EventHandler(
                    mnuXepTang_Click
                );

            // =====================================================
            // XẾP NGANG
            // =====================================================
            mnuXepNgang.Name =
                "mnuXepNgang";

            mnuXepNgang.Size =
                new System.Drawing.Size(134, 22);

            mnuXepNgang.Text =
                "Xếp ngang";

            mnuXepNgang.Click +=
                new System.EventHandler(
                    mnuXepNgang_Click
                );

            // =====================================================
            // XẾP DỌC
            // =====================================================
            mnuXepDoc.Name =
                "mnuXepDoc";

            mnuXepDoc.Size =
                new System.Drawing.Size(134, 22);

            mnuXepDoc.Text =
                "Xếp dọc";

            mnuXepDoc.Click +=
                new System.EventHandler(
                    mnuXepDoc_Click
                );

            // =====================================================
            // MENU STRIP
            // =====================================================
            menuStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    mnuTep,
                    mnuCuaSo
                }
            );

            menuStrip1.Location =
                new System.Drawing.Point(0, 0);

            menuStrip1.Name =
                "menuStrip1";

            menuStrip1.Size =
                new System.Drawing.Size(900, 24);

            // =====================================================
            // STATUS
            // =====================================================
            lblSoGhiChu.Name =
                "lblSoGhiChu";

            lblSoGhiChu.Size =
                new System.Drawing.Size(125, 17);

            lblSoGhiChu.Text =
                "Số ghi chú đang mở: 0";

            statusStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    lblSoGhiChu
                }
            );

            statusStrip1.Location =
                new System.Drawing.Point(0, 528);

            statusStrip1.Name =
                "statusStrip1";

            statusStrip1.Size =
                new System.Drawing.Size(900, 22);

            // =====================================================
            // FORM CHÍNH
            // =====================================================
            AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            ClientSize =
                new System.Drawing.Size(900, 550);

            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);

            IsMdiContainer = true;

            MainMenuStrip =
                menuStrip1;

            Name =
                "Form1";

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            Text =
                "Quản lý ghi chú công việc";

            WindowState =
                System.Windows.Forms.FormWindowState.Maximized;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();

            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}