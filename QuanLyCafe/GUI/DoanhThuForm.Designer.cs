namespace QuanLyCafe.GUI
{
    partial class DoanhThuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThuForm));
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.btnTaoBaoCao = new ReaLTaiizor.Controls.MaterialButton();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DATBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VOUCHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHANVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIENGIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIAN_TAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIAN_THANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHACHTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENTHUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new ReaLTaiizor.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlThongTinDoanhThu = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.pnlDoanhThu = new System.Windows.Forms.Panel();
            this.dtpThoiGianKetThuc = new System.Windows.Forms.DateTimePicker();
            this.picDoanhThu = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.pnlThongTinDoanhThu.SuspendLayout();
            this.pnlDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoanhThu)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl.Location = new System.Drawing.Point(24, 27);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(143, 21);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Tổng hóa đơn: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doanh thu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(24, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Từ ngày:";
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.AutoSize = true;
            this.lblTongHoaDon.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTongHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTongHoaDon.Location = new System.Drawing.Point(273, 27);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(20, 21);
            this.lblTongHoaDon.TabIndex = 2;
            this.lblTongHoaDon.Text = "0";
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.AutoSize = false;
            this.btnTaoBaoCao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaoBaoCao.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnTaoBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoBaoCao.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTaoBaoCao.Depth = 0;
            this.btnTaoBaoCao.HighEmphasis = true;
            this.btnTaoBaoCao.Icon = null;
            this.btnTaoBaoCao.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnTaoBaoCao.Location = new System.Drawing.Point(28, 172);
            this.btnTaoBaoCao.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnTaoBaoCao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTaoBaoCao.Size = new System.Drawing.Size(362, 44);
            this.btnTaoBaoCao.TabIndex = 9;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTaoBaoCao.UseAccentColor = false;
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTuNgay.Location = new System.Drawing.Point(273, 59);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(100, 21);
            this.lblTuNgay.TabIndex = 2;
            this.lblTuNgay.Text = "01/01/2022";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblDoanhThu.Location = new System.Drawing.Point(273, 124);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(64, 21);
            this.lblDoanhThu.TabIndex = 2;
            this.lblDoanhThu.Text = "0 VNĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông Tin";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_DATBAN,
            this.VOUCHER,
            this.NHANVIEN,
            this.THANHTIEN,
            this.THANHTIENGIAMGIA,
            this.THANHTOAN,
            this.THOIGIAN_TAO,
            this.THOIGIAN_THANHTOAN,
            this.KHACHTRA,
            this.TIENTHUA});
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 83);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(557, 297);
            this.dgvHoaDon.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // ID_DATBAN
            // 
            this.ID_DATBAN.DataPropertyName = "ID_DATBAN";
            this.ID_DATBAN.HeaderText = "ID Bàn đặt";
            this.ID_DATBAN.MinimumWidth = 6;
            this.ID_DATBAN.Name = "ID_DATBAN";
            this.ID_DATBAN.ReadOnly = true;
            this.ID_DATBAN.Width = 125;
            // 
            // VOUCHER
            // 
            this.VOUCHER.DataPropertyName = "VOUCHER";
            this.VOUCHER.HeaderText = "Voucher";
            this.VOUCHER.MinimumWidth = 6;
            this.VOUCHER.Name = "VOUCHER";
            this.VOUCHER.ReadOnly = true;
            this.VOUCHER.Width = 125;
            // 
            // NHANVIEN
            // 
            this.NHANVIEN.DataPropertyName = "NHANVIEN";
            this.NHANVIEN.HeaderText = "Nhân viên";
            this.NHANVIEN.MinimumWidth = 6;
            this.NHANVIEN.Name = "NHANVIEN";
            this.NHANVIEN.ReadOnly = true;
            this.NHANVIEN.Width = 125;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            this.THANHTIEN.Width = 125;
            // 
            // THANHTIENGIAMGIA
            // 
            this.THANHTIENGIAMGIA.DataPropertyName = "THANHTIENGIAMGIA";
            this.THANHTIENGIAMGIA.HeaderText = "Thành tiền giảm giá";
            this.THANHTIENGIAMGIA.MinimumWidth = 6;
            this.THANHTIENGIAMGIA.Name = "THANHTIENGIAMGIA";
            this.THANHTIENGIAMGIA.ReadOnly = true;
            this.THANHTIENGIAMGIA.Width = 125;
            // 
            // THANHTOAN
            // 
            this.THANHTOAN.DataPropertyName = "THANHTOAN";
            this.THANHTOAN.HeaderText = "Thanh toán";
            this.THANHTOAN.MinimumWidth = 6;
            this.THANHTOAN.Name = "THANHTOAN";
            this.THANHTOAN.ReadOnly = true;
            this.THANHTOAN.Width = 125;
            // 
            // THOIGIAN_TAO
            // 
            this.THOIGIAN_TAO.DataPropertyName = "THOIGIAN_TAO";
            this.THOIGIAN_TAO.HeaderText = "Thời gian tạo";
            this.THOIGIAN_TAO.MinimumWidth = 6;
            this.THOIGIAN_TAO.Name = "THOIGIAN_TAO";
            this.THOIGIAN_TAO.ReadOnly = true;
            this.THOIGIAN_TAO.Width = 125;
            // 
            // THOIGIAN_THANHTOAN
            // 
            this.THOIGIAN_THANHTOAN.DataPropertyName = "THOIGIAN_THANHTOAN";
            this.THOIGIAN_THANHTOAN.HeaderText = "Thời gian thanh toán";
            this.THOIGIAN_THANHTOAN.MinimumWidth = 6;
            this.THOIGIAN_THANHTOAN.Name = "THOIGIAN_THANHTOAN";
            this.THOIGIAN_THANHTOAN.ReadOnly = true;
            this.THOIGIAN_THANHTOAN.Width = 125;
            // 
            // KHACHTRA
            // 
            this.KHACHTRA.DataPropertyName = "KHACHTRA";
            this.KHACHTRA.HeaderText = "Khách trả";
            this.KHACHTRA.MinimumWidth = 6;
            this.KHACHTRA.Name = "KHACHTRA";
            this.KHACHTRA.ReadOnly = true;
            this.KHACHTRA.Width = 125;
            // 
            // TIENTHUA
            // 
            this.TIENTHUA.DataPropertyName = "TIENTHUA";
            this.TIENTHUA.HeaderText = "Tiền thừa";
            this.TIENTHUA.MinimumWidth = 6;
            this.TIENTHUA.Name = "TIENTHUA";
            this.TIENTHUA.ReadOnly = true;
            this.TIENTHUA.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doanh Thu Hóa Đơn";
            // 
            // dtpThoiGianBatDau
            // 
            this.dtpThoiGianBatDau.Font = new System.Drawing.Font("Arial", 10.8F);
            this.dtpThoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianBatDau.Location = new System.Drawing.Point(160, 198);
            this.dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
            this.dtpThoiGianBatDau.Size = new System.Drawing.Size(230, 28);
            this.dtpThoiGianBatDau.TabIndex = 12;
            // 
            // btnXem
            // 
            this.btnXem.AutoSize = false;
            this.btnXem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXem.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXem.Depth = 0;
            this.btnXem.HighEmphasis = true;
            this.btnXem.Icon = null;
            this.btnXem.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnXem.Location = new System.Drawing.Point(28, 346);
            this.btnXem.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnXem.Name = "btnXem";
            this.btnXem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXem.Size = new System.Drawing.Size(362, 44);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXem.UseAccentColor = false;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(24, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Từ ngày:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(23, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 27);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Doanh Thu";
            // 
            // pnlThongTinDoanhThu
            // 
            this.pnlThongTinDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.pnlThongTinDoanhThu.Controls.Add(this.lbl);
            this.pnlThongTinDoanhThu.Controls.Add(this.label3);
            this.pnlThongTinDoanhThu.Controls.Add(this.label8);
            this.pnlThongTinDoanhThu.Controls.Add(this.label5);
            this.pnlThongTinDoanhThu.Controls.Add(this.lblTongHoaDon);
            this.pnlThongTinDoanhThu.Controls.Add(this.btnTaoBaoCao);
            this.pnlThongTinDoanhThu.Controls.Add(this.lblDenNgay);
            this.pnlThongTinDoanhThu.Controls.Add(this.lblTuNgay);
            this.pnlThongTinDoanhThu.Controls.Add(this.lblDoanhThu);
            this.pnlThongTinDoanhThu.Location = new System.Drawing.Point(80, 436);
            this.pnlThongTinDoanhThu.Name = "pnlThongTinDoanhThu";
            this.pnlThongTinDoanhThu.Size = new System.Drawing.Size(425, 235);
            this.pnlThongTinDoanhThu.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(24, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Đến ngày:";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblDenNgay.Location = new System.Drawing.Point(273, 91);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(100, 21);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "01/01/2022";
            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlDoanhThu.Controls.Add(this.dtpThoiGianKetThuc);
            this.pnlDoanhThu.Controls.Add(this.dtpThoiGianBatDau);
            this.pnlDoanhThu.Controls.Add(this.picDoanhThu);
            this.pnlDoanhThu.Controls.Add(this.label6);
            this.pnlDoanhThu.Controls.Add(this.btnXem);
            this.pnlDoanhThu.Controls.Add(this.label4);
            this.pnlDoanhThu.Controls.Add(this.lblTitle);
            this.pnlDoanhThu.Location = new System.Drawing.Point(590, 31);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Size = new System.Drawing.Size(414, 640);
            this.pnlDoanhThu.TabIndex = 7;
            // 
            // dtpThoiGianKetThuc
            // 
            this.dtpThoiGianKetThuc.Font = new System.Drawing.Font("Arial", 10.8F);
            this.dtpThoiGianKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianKetThuc.Location = new System.Drawing.Point(160, 246);
            this.dtpThoiGianKetThuc.Name = "dtpThoiGianKetThuc";
            this.dtpThoiGianKetThuc.Size = new System.Drawing.Size(230, 28);
            this.dtpThoiGianKetThuc.TabIndex = 12;
            // 
            // picDoanhThu
            // 
            this.picDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.picDoanhThu.Image = global::QuanLyCafe.Properties.Resources.money;
            this.picDoanhThu.Location = new System.Drawing.Point(160, 57);
            this.picDoanhThu.Name = "picDoanhThu";
            this.picDoanhThu.Padding = new System.Windows.Forms.Padding(5);
            this.picDoanhThu.Size = new System.Drawing.Size(113, 104);
            this.picDoanhThu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoanhThu.TabIndex = 10;
            this.picDoanhThu.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(24, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đến ngày:";
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.pnlThongTinDoanhThu);
            this.pnlForm.Controls.Add(this.dgvHoaDon);
            this.pnlForm.Controls.Add(this.pnlDoanhThu);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(3, 64);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1027, 700);
            this.pnlForm.TabIndex = 1;
            // 
            // DoanhThuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1033, 806);
            this.Controls.Add(this.pnlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoanhThuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DoanhThuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.pnlThongTinDoanhThu.ResumeLayout(false);
            this.pnlThongTinDoanhThu.PerformLayout();
            this.pnlDoanhThu.ResumeLayout(false);
            this.pnlDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoanhThu)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongHoaDon;
        private ReaLTaiizor.Controls.MaterialButton btnTaoBaoCao;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThoiGianBatDau;
        private System.Windows.Forms.PictureBox picDoanhThu;
        private ReaLTaiizor.Controls.MaterialButton btnXem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlThongTinDoanhThu;
        private System.Windows.Forms.Panel pnlDoanhThu;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DATBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn VOUCHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHANVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIENGIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIAN_TAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIAN_THANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHACHTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENTHUA;
        private System.Windows.Forms.DateTimePicker dtpThoiGianKetThuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDenNgay;
    }
}