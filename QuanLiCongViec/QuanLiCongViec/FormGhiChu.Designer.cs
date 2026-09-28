namespace QuanLiCongViec
{
    partial class FormGhiChu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDeForm;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.Label lblUuTien;

        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtNoiDung;

        private System.Windows.Forms.ComboBox cboMucDoUuTien;

        private System.Windows.Forms.Button btnLuuGhiChu;

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

            lblTieuDeForm =
                new System.Windows.Forms.Label();

            lblNoiDung =
                new System.Windows.Forms.Label();

            lblUuTien =
                new System.Windows.Forms.Label();

            txtTieuDe =
                new System.Windows.Forms.TextBox();

            txtNoiDung =
                new System.Windows.Forms.TextBox();

            cboMucDoUuTien =
                new System.Windows.Forms.ComboBox();

            btnLuuGhiChu =
                new System.Windows.Forms.Button();

            errorProvider1 =
                new System.Windows.Forms.ErrorProvider(
                    components
                );

            ((System.ComponentModel.ISupportInitialize)
                errorProvider1).BeginInit();

            SuspendLayout();

            // =====================================================
            // LABEL TIÊU ĐỀ
            // =====================================================
            lblTieuDeForm.AutoSize = true;

            lblTieuDeForm.Location =
                new System.Drawing.Point(15, 20);

            lblTieuDeForm.Name =
                "lblTieuDeForm";

            lblTieuDeForm.Size =
                new System.Drawing.Size(44, 15);

            lblTieuDeForm.Text =
                "Tiêu đề";

            lblTieuDeForm.MouseDoubleClick +=
                new System.Windows.Forms.MouseEventHandler(
                    lblTieuDeForm_MouseDoubleClick
                );

            // =====================================================
            // TEXTBOX TIÊU ĐỀ
            // =====================================================
            txtTieuDe.Location =
                new System.Drawing.Point(75, 16);

            txtTieuDe.Name =
                "txtTieuDe";

            txtTieuDe.Size =
                new System.Drawing.Size(255, 23);

            txtTieuDe.TabIndex = 0;

            txtTieuDe.Validating +=
                new System.ComponentModel.CancelEventHandler(
                    txtTieuDe_Validating
                );

            txtTieuDe.Validated +=
                new System.EventHandler(
                    txtTieuDe_Validated
                );

            // =====================================================
            // LABEL NỘI DUNG
            // =====================================================
            lblNoiDung.AutoSize = true;

            lblNoiDung.Location =
                new System.Drawing.Point(15, 55);

            lblNoiDung.Name =
                "lblNoiDung";

            lblNoiDung.Size =
                new System.Drawing.Size(58, 15);

            lblNoiDung.Text =
                "Nội dung";

            // =====================================================
            // TEXTBOX NỘI DUNG
            // =====================================================
            txtNoiDung.Location =
                new System.Drawing.Point(15, 75);

            txtNoiDung.Multiline = true;

            txtNoiDung.Name =
                "txtNoiDung";

            txtNoiDung.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            txtNoiDung.Size =
                new System.Drawing.Size(315, 125);

            txtNoiDung.TabIndex = 1;

            txtNoiDung.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(
                    txtNoiDung_KeyPress
                );

            // =====================================================
            // PRIORITY
            // =====================================================
            lblUuTien.AutoSize = true;

            lblUuTien.Location =
                new System.Drawing.Point(15, 215);

            lblUuTien.Name =
                "lblUuTien";

            lblUuTien.Size =
                new System.Drawing.Size(45, 15);

            lblUuTien.Text =
                "Priority:";

            cboMucDoUuTien.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            cboMucDoUuTien.FormattingEnabled = true;

            cboMucDoUuTien.Items.AddRange(
                new object[]
                {
                    "Thấp",
                    "Trung bình",
                    "Cao"
                }
            );

            cboMucDoUuTien.Location =
                new System.Drawing.Point(15, 235);

            cboMucDoUuTien.Name =
                "cboMucDoUuTien";

            cboMucDoUuTien.Size =
                new System.Drawing.Size(130, 23);

            cboMucDoUuTien.TabIndex = 2;

            // =====================================================
            // BUTTON LƯU
            // =====================================================
            btnLuuGhiChu.Location =
                new System.Drawing.Point(250, 230);

            btnLuuGhiChu.Name =
                "btnLuuGhiChu";

            btnLuuGhiChu.Size =
                new System.Drawing.Size(80, 30);

            btnLuuGhiChu.TabIndex = 3;

            btnLuuGhiChu.Text =
                "Lưu";

            btnLuuGhiChu.UseVisualStyleBackColor = true;

            btnLuuGhiChu.Click +=
                new System.EventHandler(
                    btnLuuGhiChu_Click
                );

            btnLuuGhiChu.MouseEnter +=
                new System.EventHandler(
                    btnLuuGhiChu_MouseEnter
                );

            btnLuuGhiChu.MouseLeave +=
                new System.EventHandler(
                    btnLuuGhiChu_MouseLeave
                );

            // =====================================================
            // ERROR PROVIDER
            // =====================================================
            errorProvider1.ContainerControl = this;

            errorProvider1.BlinkStyle =
                System.Windows.Forms.ErrorBlinkStyle
                    .BlinkIfDifferentError;

            // =====================================================
            // FORM GHI CHÚ
            // =====================================================
            AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            BackColor =
                System.Drawing.Color.WhiteSmoke;

            ClientSize =
                new System.Drawing.Size(350, 280);

            Controls.Add(lblTieuDeForm);
            Controls.Add(txtTieuDe);

            Controls.Add(lblNoiDung);
            Controls.Add(txtNoiDung);

            Controls.Add(lblUuTien);
            Controls.Add(cboMucDoUuTien);

            Controls.Add(btnLuuGhiChu);

            Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F
                );

            KeyPreview = true;

            Name =
                "FormGhiChu";

            StartPosition =
                System.Windows.Forms.FormStartPosition.Manual;

            Text =
                "Ghi chú mới";

            KeyDown +=
                new System.Windows.Forms.KeyEventHandler(
                    FormGhiChu_KeyDown
                );

            ((System.ComponentModel.ISupportInitialize)
                errorProvider1).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}