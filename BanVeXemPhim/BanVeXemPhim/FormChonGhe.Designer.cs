namespace BanVeXemPhim
{
    partial class FormChonGhe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox lstGhe;

        private System.Windows.Forms.Label lblGheDaChon;

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnBoQua;

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

            lstGhe =
                new System.Windows.Forms.ListBox();

            lblGheDaChon =
                new System.Windows.Forms.Label();

            btnXacNhan =
                new System.Windows.Forms.Button();

            btnBoQua =
                new System.Windows.Forms.Button();

            SuspendLayout();

            // ==============================================
            // DANH SÁCH GHẾ
            // ==============================================
            lstGhe.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F
                );

            lstGhe.FormattingEnabled = true;

            lstGhe.ItemHeight = 21;

            lstGhe.Location =
                new System.Drawing.Point(18, 18);

            lstGhe.Name =
                "lstGhe";

            // 5 cột giống ảnh mẫu
            lstGhe.MultiColumn = true;

            lstGhe.ColumnWidth = 42;

            lstGhe.Size =
                new System.Drawing.Size(215, 88);

            lstGhe.TabIndex = 0;

            lstGhe.SelectedIndexChanged +=
                new System.EventHandler(
                    lstGhe_SelectedIndexChanged
                );

            // ==============================================
            // GHẾ ĐANG CHỌN
            // ==============================================
            lblGheDaChon.AutoSize = true;

            lblGheDaChon.Location =
                new System.Drawing.Point(18, 125);

            lblGheDaChon.Name =
                "lblGheDaChon";

            lblGheDaChon.Size =
                new System.Drawing.Size(70, 15);

            lblGheDaChon.Text =
                "Đang chọn:";

            // ==============================================
            // XÁC NHẬN
            // ==============================================
            btnXacNhan.Location =
                new System.Drawing.Point(72, 155);

            btnXacNhan.Name =
                "btnXacNhan";

            btnXacNhan.Size =
                new System.Drawing.Size(85, 30);

            btnXacNhan.TabIndex = 1;

            btnXacNhan.Text =
                "Xác nhận";

            btnXacNhan.UseVisualStyleBackColor = true;

            btnXacNhan.Click +=
                new System.EventHandler(
                    btnXacNhan_Click
                );

            // ==============================================
            // BỎ QUA
            // ==============================================
            btnBoQua.Location =
                new System.Drawing.Point(163, 155);

            btnBoQua.Name =
                "btnBoQua";

            btnBoQua.Size =
                new System.Drawing.Size(70, 30);

            btnBoQua.TabIndex = 2;

            btnBoQua.Text =
                "Bỏ qua";

            btnBoQua.UseVisualStyleBackColor = true;

            btnBoQua.Click +=
                new System.EventHandler(
                    btnBoQua_Click
                );

            // ==============================================
            // FORM CHỌN GHẾ
            // ==============================================
            AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            BackColor =
                System.Drawing.Color.WhiteSmoke;

            ClientSize =
                new System.Drawing.Size(255, 205);

            Controls.Add(lstGhe);
            Controls.Add(lblGheDaChon);

            Controls.Add(btnXacNhan);
            Controls.Add(btnBoQua);

            Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F
                );

            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;

            MaximizeBox = false;
            MinimizeBox = false;

            Name =
                "FormChonGhe";

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            Text =
                "Chọn ghế";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}