namespace FormNhapDiemHS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblToan;
        private System.Windows.Forms.Label lblVan;
        private System.Windows.Forms.Label lblAnh;

        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtVan;
        private System.Windows.Forms.TextBox txtAnh;

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTrang;

        private System.Windows.Forms.ListBox lstDanhSach;

        private System.Windows.Forms.ErrorProvider errorProvider1;

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

            lblMaHS =
                new System.Windows.Forms.Label();

            lblHoTen =
                new System.Windows.Forms.Label();

            lblToan =
                new System.Windows.Forms.Label();

            lblVan =
                new System.Windows.Forms.Label();

            lblAnh =
                new System.Windows.Forms.Label();


            txtMaHS =
                new System.Windows.Forms.TextBox();

            txtHoTen =
                new System.Windows.Forms.TextBox();

            txtToan =
                new System.Windows.Forms.TextBox();

            txtVan =
                new System.Windows.Forms.TextBox();

            txtAnh =
                new System.Windows.Forms.TextBox();


            btnLuu =
                new System.Windows.Forms.Button();

            btnXoaTrang =
                new System.Windows.Forms.Button();


            lstDanhSach =
                new System.Windows.Forms.ListBox();


            errorProvider1 =
                new System.Windows.Forms.ErrorProvider(
                    components
                );


            ((System.ComponentModel.ISupportInitialize)
                errorProvider1).BeginInit();

            SuspendLayout();


            // ==================================================
            // LABEL MÃ HS
            // ==================================================
            lblMaHS.AutoSize = true;

            lblMaHS.Location =
                new System.Drawing.Point(
                    15,
                    18
                );

            lblMaHS.Name =
                "lblMaHS";

            lblMaHS.Size =
                new System.Drawing.Size(
                    40,
                    15
                );

            lblMaHS.TabStop = false;

            lblMaHS.Text =
                "Mã HS";


            // ==================================================
            // TXT MÃ HS
            // ==================================================
            txtMaHS.Location =
                new System.Drawing.Point(
                    15,
                    38
                );

            txtMaHS.Name =
                "txtMaHS";

            txtMaHS.Size =
                new System.Drawing.Size(
                    90,
                    23
                );

            txtMaHS.TabIndex = 0;


            // ==================================================
            // LABEL HỌ TÊN
            // ==================================================
            lblHoTen.AutoSize = true;

            lblHoTen.Location =
                new System.Drawing.Point(
                    125,
                    18
                );

            lblHoTen.Name =
                "lblHoTen";

            lblHoTen.Size =
                new System.Drawing.Size(
                    42,
                    15
                );

            lblHoTen.TabStop = false;

            lblHoTen.Text =
                "Họ tên";


            // ==================================================
            // TXT HỌ TÊN
            // ==================================================
            txtHoTen.Location =
                new System.Drawing.Point(
                    125,
                    38
                );

            txtHoTen.Name =
                "txtHoTen";

            txtHoTen.Size =
                new System.Drawing.Size(
                    120,
                    23
                );

            txtHoTen.TabIndex = 1;


            // ==================================================
            // LABEL TOÁN
            // ==================================================
            lblToan.AutoSize = true;

            lblToan.Location =
                new System.Drawing.Point(
                    265,
                    18
                );

            lblToan.Name =
                "lblToan";

            lblToan.Size =
                new System.Drawing.Size(
                    65,
                    15
                );

            lblToan.TabStop = false;

            lblToan.Text =
                "Điểm Toán";


            // ==================================================
            // TXT TOÁN
            // ==================================================
            txtToan.Location =
                new System.Drawing.Point(
                    265,
                    38
                );

            txtToan.Name =
                "txtToan";

            txtToan.Size =
                new System.Drawing.Size(
                    75,
                    23
                );

            txtToan.TabIndex = 2;

            txtToan.Enter +=
                new System.EventHandler(
                    TextBoxDiem_Enter
                );


            // ==================================================
            // LABEL VĂN
            // ==================================================
            lblVan.AutoSize = true;

            lblVan.Location =
                new System.Drawing.Point(
                    360,
                    18
                );

            lblVan.Name =
                "lblVan";

            lblVan.Size =
                new System.Drawing.Size(
                    57,
                    15
                );

            lblVan.TabStop = false;

            lblVan.Text =
                "Điểm Văn";


            // ==================================================
            // TXT VĂN
            // ==================================================
            txtVan.Location =
                new System.Drawing.Point(
                    360,
                    38
                );

            txtVan.Name =
                "txtVan";

            txtVan.Size =
                new System.Drawing.Size(
                    75,
                    23
                );

            txtVan.TabIndex = 3;

            txtVan.Enter +=
                new System.EventHandler(
                    TextBoxDiem_Enter
                );


            // ==================================================
            // LABEL ANH
            // ==================================================
            lblAnh.AutoSize = true;

            lblAnh.Location =
                new System.Drawing.Point(
                    455,
                    18
                );

            lblAnh.Name =
                "lblAnh";

            lblAnh.Size =
                new System.Drawing.Size(
                    58,
                    15
                );

            lblAnh.TabStop = false;

            lblAnh.Text =
                "Điểm Anh";


            // ==================================================
            // TXT ANH
            // ==================================================
            txtAnh.Location =
                new System.Drawing.Point(
                    455,
                    38
                );

            txtAnh.Name =
                "txtAnh";

            txtAnh.Size =
                new System.Drawing.Size(
                    75,
                    23
                );

            txtAnh.TabIndex = 4;

            txtAnh.Enter +=
                new System.EventHandler(
                    TextBoxDiem_Enter
                );


            // ==================================================
            // BUTTON LƯU
            // ==================================================
            btnLuu.BackColor =
                System.Drawing.Color.FromArgb(
                    65,
                    180,
                    80
                );

            btnLuu.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            btnLuu.FlatAppearance.BorderSize = 0;

            btnLuu.ForeColor =
                System.Drawing.Color.White;

            btnLuu.Location =
                new System.Drawing.Point(
                    15,
                    72
                );

            btnLuu.Name =
                "btnLuu";

            btnLuu.Size =
                new System.Drawing.Size(
                    85,
                    30
                );

            btnLuu.TabIndex = 5;

            btnLuu.Text =
                "Lưu";

            btnLuu.UseVisualStyleBackColor = false;

            btnLuu.Click +=
                new System.EventHandler(
                    btnLuu_Click
                );


            // ==================================================
            // BUTTON XÓA TRẮNG
            // ==================================================
            btnXoaTrang.BackColor =
                System.Drawing.Color.Gainsboro;

            btnXoaTrang.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            btnXoaTrang.FlatAppearance.BorderColor =
                System.Drawing.Color.Silver;

            btnXoaTrang.Location =
                new System.Drawing.Point(
                    108,
                    72
                );

            btnXoaTrang.Name =
                "btnXoaTrang";

            btnXoaTrang.Size =
                new System.Drawing.Size(
                    90,
                    30
                );

            btnXoaTrang.TabIndex = 6;

            btnXoaTrang.Text =
                "Xóa Trắng";

            btnXoaTrang.UseVisualStyleBackColor = false;

            btnXoaTrang.Click +=
                new System.EventHandler(
                    btnXoaTrang_Click
                );


            // ==================================================
            // LISTBOX DANH SÁCH
            // ==================================================
            lstDanhSach.FormattingEnabled = true;

            lstDanhSach.ItemHeight = 15;

            lstDanhSach.Location =
                new System.Drawing.Point(
                    15,
                    110
                );

            lstDanhSach.Name =
                "lstDanhSach";

            lstDanhSach.Size =
                new System.Drawing.Size(
                    515,
                    154
                );

            lstDanhSach.TabIndex = 7;


            // ==================================================
            // ERROR PROVIDER
            // ==================================================
            errorProvider1.ContainerControl = this;

            errorProvider1.BlinkStyle =
                System.Windows.Forms.ErrorBlinkStyle
                    .BlinkIfDifferentError;


            // ==================================================
            // FORM
            // ==================================================
            AutoScaleDimensions =
                new System.Drawing.SizeF(
                    7F,
                    15F
                );

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            BackColor =
                System.Drawing.Color.White;

            ClientSize =
                new System.Drawing.Size(
                    550,
                    285
                );


            Controls.Add(lblMaHS);
            Controls.Add(txtMaHS);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);

            Controls.Add(lblToan);
            Controls.Add(txtToan);

            Controls.Add(lblVan);
            Controls.Add(txtVan);

            Controls.Add(lblAnh);
            Controls.Add(txtAnh);

            Controls.Add(btnLuu);
            Controls.Add(btnXoaTrang);

            Controls.Add(lstDanhSach);


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
                "Nhập điểm học sinh";


            ((System.ComponentModel.ISupportInitialize)
                errorProvider1).EndInit();

            ResumeLayout(false);

            PerformLayout();
        }
    }
}