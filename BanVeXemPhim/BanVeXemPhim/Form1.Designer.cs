namespace BanVeXemPhim
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.Label lblSuatChieu;
        private System.Windows.Forms.Label lblGheDaChon;

        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.ComboBox cboSuatChieu;
        private System.Windows.Forms.TextBox txtGheDaChon;

        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnHuy;

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
            components = new System.ComponentModel.Container();

            lblTenKhach = new System.Windows.Forms.Label();
            lblPhim = new System.Windows.Forms.Label();
            lblSuatChieu = new System.Windows.Forms.Label();
            lblGheDaChon = new System.Windows.Forms.Label();

            txtTenKhach = new System.Windows.Forms.TextBox();

            cboPhim = new System.Windows.Forms.ComboBox();
            cboSuatChieu = new System.Windows.Forms.ComboBox();

            txtGheDaChon = new System.Windows.Forms.TextBox();

            btnChonGhe = new System.Windows.Forms.Button();
            btnDatVe = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();

            SuspendLayout();

            // TÊN KHÁCH
            lblTenKhach.AutoSize = true;

            lblTenKhach.Location =
                new System.Drawing.Point(20, 30);

            lblTenKhach.Name =
                "lblTenKhach";

            lblTenKhach.Text =
                "Tên khách:";

            txtTenKhach.Location =
                new System.Drawing.Point(20, 50);

            txtTenKhach.Name =
                "txtTenKhach";

            txtTenKhach.Size =
                new System.Drawing.Size(245, 23);

            txtTenKhach.TabIndex = 0;

            // PHIM
            lblPhim.AutoSize = true;

            lblPhim.Location =
                new System.Drawing.Point(20, 88);

            lblPhim.Name =
                "lblPhim";

            lblPhim.Text =
                "Phim:";

            cboPhim.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            cboPhim.Location =
                new System.Drawing.Point(20, 108);

            cboPhim.Name =
                "cboPhim";

            cboPhim.Size =
                new System.Drawing.Size(245, 23);

            cboPhim.TabIndex = 1;

            // SUẤT CHIẾU
            lblSuatChieu.AutoSize = true;

            lblSuatChieu.Location =
                new System.Drawing.Point(20, 145);

            lblSuatChieu.Name =
                "lblSuatChieu";

            lblSuatChieu.Text =
                "Suất chiếu:";

            cboSuatChieu.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            cboSuatChieu.Location =
                new System.Drawing.Point(20, 165);

            cboSuatChieu.Name =
                "cboSuatChieu";

            cboSuatChieu.Size =
                new System.Drawing.Size(245, 23);

            cboSuatChieu.TabIndex = 2;

            // GHẾ ĐÃ CHỌN
            lblGheDaChon.AutoSize = true;

            lblGheDaChon.Location =
                new System.Drawing.Point(20, 202);

            lblGheDaChon.Name =
                "lblGheDaChon";

            lblGheDaChon.Text =
                "Ghế đã chọn:";

            txtGheDaChon.Location =
                new System.Drawing.Point(20, 222);

            txtGheDaChon.Name =
                "txtGheDaChon";

            txtGheDaChon.ReadOnly = true;

            txtGheDaChon.Size =
                new System.Drawing.Size(245, 23);

            txtGheDaChon.TabStop = false;

            // CHỌN GHẾ
            btnChonGhe.Location =
                new System.Drawing.Point(76, 275);

            btnChonGhe.Name =
                "btnChonGhe";

            btnChonGhe.Size =
                new System.Drawing.Size(90, 32);

            btnChonGhe.TabIndex = 3;

            btnChonGhe.Text =
                "Chọn ghế";

            btnChonGhe.UseVisualStyleBackColor = true;

            btnChonGhe.Click +=
                new System.EventHandler(
                    btnChonGhe_Click
                );

            // ĐẶT VÉ
            btnDatVe.Location =
                new System.Drawing.Point(175, 275);

            btnDatVe.Name =
                "btnDatVe";

            btnDatVe.Size =
                new System.Drawing.Size(80, 32);

            btnDatVe.TabIndex = 4;

            btnDatVe.Text =
                "Đặt vé";

            btnDatVe.UseVisualStyleBackColor = true;

            btnDatVe.Click +=
                new System.EventHandler(
                    btnDatVe_Click
                );

            // HỦY
            btnHuy.Location =
                new System.Drawing.Point(264, 275);

            btnHuy.Name =
                "btnHuy";

            btnHuy.Size =
                new System.Drawing.Size(75, 32);

            btnHuy.TabIndex = 5;

            btnHuy.Text =
                "Hủy";

            btnHuy.UseVisualStyleBackColor = true;

            btnHuy.Click +=
                new System.EventHandler(
                    btnHuy_Click
                );

            // FORM CHÍNH
            AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            BackColor =
                System.Drawing.Color.WhiteSmoke;

            ClientSize =
                new System.Drawing.Size(430, 335);

            Controls.Add(lblTenKhach);
            Controls.Add(txtTenKhach);

            Controls.Add(lblPhim);
            Controls.Add(cboPhim);

            Controls.Add(lblSuatChieu);
            Controls.Add(cboSuatChieu);

            Controls.Add(lblGheDaChon);
            Controls.Add(txtGheDaChon);

            Controls.Add(btnChonGhe);
            Controls.Add(btnDatVe);
            Controls.Add(btnHuy);

            Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F
                );

            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            Name = "Form1";

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            Text =
                "Bán vé xem phim";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}