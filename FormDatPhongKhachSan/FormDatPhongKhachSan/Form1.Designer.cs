namespace FormDatPhongKhachSan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblSoNguoiLon;
        private System.Windows.Forms.Label lblSoTreEm;

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.TextBox txtSoNguoiLon;
        private System.Windows.Forms.TextBox txtSoTreEm;

        private System.Windows.Forms.Button btnDatPhong;
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
            components = new System.ComponentModel.Container();
            lblHoTen = new Label();
            lblCCCD = new Label();
            lblNgayNhan = new Label();
            lblNgayTra = new Label();
            lblSoNguoiLon = new Label();
            lblSoTreEm = new Label();
            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtSoTreEm = new TextBox();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(207, 35);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(206, 100);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(68, 20);
            lblCCCD.TabIndex = 1;
            lblCCCD.Text = "Số CCCD";
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Location = new Point(206, 160);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new Size(127, 20);
            lblNgayNhan.TabIndex = 2;
            lblNgayNhan.Text = "Ngày nhận phòng";
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(207, 220);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(113, 20);
            lblNgayTra.TabIndex = 3;
            lblNgayTra.Text = "Ngày trả phòng";
            // 
            // lblSoNguoiLon
            // 
            lblSoNguoiLon.AutoSize = true;
            lblSoNguoiLon.Location = new Point(206, 280);
            lblSoNguoiLon.Name = "lblSoNguoiLon";
            lblSoNguoiLon.Size = new Size(94, 20);
            lblSoNguoiLon.TabIndex = 4;
            lblSoNguoiLon.Text = "Số người lớn";
            // 
            // lblSoTreEm
            // 
            lblSoTreEm.AutoSize = true;
            lblSoTreEm.Location = new Point(207, 340);
            lblSoTreEm.Name = "lblSoTreEm";
            lblSoTreEm.Size = new Size(73, 20);
            lblSoTreEm.TabIndex = 5;
            lblSoTreEm.Text = "Số trẻ em";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(207, 59);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(239, 27);
            txtHoTen.TabIndex = 0;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += TextBox_Validated;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(206, 124);
            txtCCCD.Margin = new Padding(3, 4, 3, 4);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(239, 27);
            txtCCCD.TabIndex = 1;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += TextBox_Validated;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(206, 184);
            txtNgayNhan.Margin = new Padding(3, 4, 3, 4);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(239, 27);
            txtNgayNhan.TabIndex = 2;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += TextBox_Validated;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(206, 244);
            txtNgayTra.Margin = new Padding(3, 4, 3, 4);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(239, 27);
            txtNgayTra.TabIndex = 3;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += TextBox_Validated;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(206, 304);
            txtSoNguoiLon.Margin = new Padding(3, 4, 3, 4);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(239, 27);
            txtSoNguoiLon.TabIndex = 4;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += TextBox_Validated;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(206, 364);
            txtSoTreEm.Margin = new Padding(3, 4, 3, 4);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(239, 27);
            txtSoTreEm.TabIndex = 5;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += TextBox_Validated;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.FromArgb(0, 120, 215);
            btnDatPhong.FlatAppearance.BorderSize = 0;
            btnDatPhong.FlatStyle = FlatStyle.Flat;
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(206, 420);
            btnDatPhong.Margin = new Padding(3, 4, 3, 4);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(240, 43);
            btnDatPhong.TabIndex = 6;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(634, 522);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblCCCD);
            Controls.Add(txtCCCD);
            Controls.Add(lblNgayNhan);
            Controls.Add(txtNgayNhan);
            Controls.Add(lblNgayTra);
            Controls.Add(txtNgayTra);
            Controls.Add(lblSoNguoiLon);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(lblSoTreEm);
            Controls.Add(txtSoTreEm);
            Controls.Add(btnDatPhong);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}