namespace QuanLyCafe.GUI
{
    partial class LichSuCaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichSuCaForm));
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlThongTinThanhToan = new System.Windows.Forms.Panel();
            this.lblDaThanhToan = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongGioLam = new System.Windows.Forms.Label();
            this.btnThanhToan = new ReaLTaiizor.Controls.MaterialButton();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANVAOCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANRACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGGIOLAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLichSuCaLam = new System.Windows.Forms.Panel();
            this.cboTaiKhoan = new System.Windows.Forms.ComboBox();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new ReaLTaiizor.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label233 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picSuKien = new System.Windows.Forms.PictureBox();
            this.pnlForm.SuspendLayout();
            this.pnlThongTinThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.pnlLichSuCaLam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.pnlThongTinThanhToan);
            this.pnlForm.Controls.Add(this.dgvLichSu);
            this.pnlForm.Controls.Add(this.pnlLichSuCaLam);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(3, 64);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1027, 585);
            this.pnlForm.TabIndex = 0;
            // 
            // pnlThongTinThanhToan
            // 
            this.pnlThongTinThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.pnlThongTinThanhToan.Controls.Add(this.lblDaThanhToan);
            this.pnlThongTinThanhToan.Controls.Add(this.lbl);
            this.pnlThongTinThanhToan.Controls.Add(this.label3);
            this.pnlThongTinThanhToan.Controls.Add(this.label5);
            this.pnlThongTinThanhToan.Controls.Add(this.lblTongGioLam);
            this.pnlThongTinThanhToan.Controls.Add(this.btnThanhToan);
            this.pnlThongTinThanhToan.Controls.Add(this.lblNgay);
            this.pnlThongTinThanhToan.Controls.Add(this.lblTongTien);
            this.pnlThongTinThanhToan.Location = new System.Drawing.Point(75, 296);
            this.pnlThongTinThanhToan.Name = "pnlThongTinThanhToan";
            this.pnlThongTinThanhToan.Size = new System.Drawing.Size(425, 235);
            this.pnlThongTinThanhToan.TabIndex = 10;
            // 
            // lblDaThanhToan
            // 
            this.lblDaThanhToan.AutoSize = true;
            this.lblDaThanhToan.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(189)))), ((int)(((byte)(166)))));
            this.lblDaThanhToan.Location = new System.Drawing.Point(103, 130);
            this.lblDaThanhToan.Name = "lblDaThanhToan";
            this.lblDaThanhToan.Size = new System.Drawing.Size(214, 35);
            this.lblDaThanhToan.TabIndex = 75;
            this.lblDaThanhToan.Text = "Đã thanh toán";
            this.lblDaThanhToan.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl.Location = new System.Drawing.Point(24, 27);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(137, 21);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Tổng giờ làm: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(24, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày:";
            // 
            // lblTongGioLam
            // 
            this.lblTongGioLam.AutoSize = true;
            this.lblTongGioLam.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTongGioLam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTongGioLam.Location = new System.Drawing.Point(273, 27);
            this.lblTongGioLam.Name = "lblTongGioLam";
            this.lblTongGioLam.Size = new System.Drawing.Size(20, 21);
            this.lblTongGioLam.TabIndex = 2;
            this.lblTongGioLam.Text = "0";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AutoSize = false;
            this.btnThanhToan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThanhToan.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThanhToan.Depth = 0;
            this.btnThanhToan.HighEmphasis = true;
            this.btnThanhToan.Icon = null;
            this.btnThanhToan.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnThanhToan.Location = new System.Drawing.Point(28, 172);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThanhToan.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThanhToan.Size = new System.Drawing.Size(362, 44);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnThanhToan.UseAccentColor = false;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblNgay.Location = new System.Drawing.Point(273, 59);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(100, 21);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "01/01/2022";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTongTien.Location = new System.Drawing.Point(273, 91);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(64, 21);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.USERNAME,
            this.THOIGIANVAOCA,
            this.THOIGIANRACA,
            this.TONGGIOLAM});
            this.dgvLichSu.Location = new System.Drawing.Point(3, 83);
            this.dgvLichSu.MultiSelect = false;
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.RowTemplate.Height = 24;
            this.dgvLichSu.Size = new System.Drawing.Size(557, 144);
            this.dgvLichSu.TabIndex = 8;
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
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "USERNAME";
            this.USERNAME.HeaderText = "Tài khoản";
            this.USERNAME.MinimumWidth = 6;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            this.USERNAME.Width = 125;
            // 
            // THOIGIANVAOCA
            // 
            this.THOIGIANVAOCA.DataPropertyName = "THOIGIANVAOCA";
            this.THOIGIANVAOCA.HeaderText = "Thời gian vào ca";
            this.THOIGIANVAOCA.MinimumWidth = 6;
            this.THOIGIANVAOCA.Name = "THOIGIANVAOCA";
            this.THOIGIANVAOCA.ReadOnly = true;
            this.THOIGIANVAOCA.Width = 125;
            // 
            // THOIGIANRACA
            // 
            this.THOIGIANRACA.DataPropertyName = "THOIGIANRACA";
            this.THOIGIANRACA.HeaderText = "Thời gian ra ca";
            this.THOIGIANRACA.MinimumWidth = 6;
            this.THOIGIANRACA.Name = "THOIGIANRACA";
            this.THOIGIANRACA.ReadOnly = true;
            this.THOIGIANRACA.Width = 125;
            // 
            // TONGGIOLAM
            // 
            this.TONGGIOLAM.DataPropertyName = "TONGGIOLAM";
            this.TONGGIOLAM.HeaderText = "Tổng giờ làm";
            this.TONGGIOLAM.MinimumWidth = 6;
            this.TONGGIOLAM.Name = "TONGGIOLAM";
            this.TONGGIOLAM.ReadOnly = true;
            this.TONGGIOLAM.Width = 125;
            // 
            // pnlLichSuCaLam
            // 
            this.pnlLichSuCaLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlLichSuCaLam.Controls.Add(this.cboTaiKhoan);
            this.pnlLichSuCaLam.Controls.Add(this.dtpThoiGian);
            this.pnlLichSuCaLam.Controls.Add(this.picSuKien);
            this.pnlLichSuCaLam.Controls.Add(this.btnXem);
            this.pnlLichSuCaLam.Controls.Add(this.label4);
            this.pnlLichSuCaLam.Controls.Add(this.lblTitle);
            this.pnlLichSuCaLam.Controls.Add(this.label233);
            this.pnlLichSuCaLam.Location = new System.Drawing.Point(590, 31);
            this.pnlLichSuCaLam.Name = "pnlLichSuCaLam";
            this.pnlLichSuCaLam.Size = new System.Drawing.Size(414, 500);
            this.pnlLichSuCaLam.TabIndex = 7;
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cboTaiKhoan.FormattingEnabled = true;
            this.cboTaiKhoan.Location = new System.Drawing.Point(160, 200);
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            this.cboTaiKhoan.Size = new System.Drawing.Size(230, 29);
            this.cboTaiKhoan.TabIndex = 13;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Font = new System.Drawing.Font("Arial", 10.8F);
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(160, 249);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(230, 28);
            this.dtpThoiGian.TabIndex = 12;
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
            this.btnXem.Location = new System.Drawing.Point(28, 297);
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
            this.label4.Location = new System.Drawing.Point(24, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời gian:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(23, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 27);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Lịch Sử Ca Làm";
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label233.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label233.Location = new System.Drawing.Point(24, 200);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(101, 21);
            this.label233.TabIndex = 2;
            this.label233.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thanh Toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch Sử";
            // 
            // picSuKien
            // 
            this.picSuKien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.picSuKien.Image = global::QuanLyCafe.Properties.Resources.UserVest4;
            this.picSuKien.Location = new System.Drawing.Point(160, 57);
            this.picSuKien.Name = "picSuKien";
            this.picSuKien.Padding = new System.Windows.Forms.Padding(5);
            this.picSuKien.Size = new System.Drawing.Size(113, 104);
            this.picSuKien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSuKien.TabIndex = 10;
            this.picSuKien.TabStop = false;
            // 
            // LichSuCaForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1033, 697);
            this.Controls.Add(this.pnlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LichSuCaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LichSuCaForm_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlThongTinThanhToan.ResumeLayout(false);
            this.pnlThongTinThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.pnlLichSuCaLam.ResumeLayout(false);
            this.pnlLichSuCaLam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuKien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlLichSuCaLam;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.PictureBox picSuKien;
        private ReaLTaiizor.Controls.MaterialButton btnXem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.ComboBox cboTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANVAOCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANRACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGGIOLAM;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.MaterialButton btnThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTongGioLam;
        private System.Windows.Forms.Panel pnlThongTinThanhToan;
        private System.Windows.Forms.Label lblDaThanhToan;
    }
}