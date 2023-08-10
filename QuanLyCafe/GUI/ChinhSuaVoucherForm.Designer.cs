namespace QuanLyCafe.GUI
{
    partial class ChinhSuaVoucherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSuaVoucherForm));
            this.materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            this.tabForm = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tpChinhSua = new System.Windows.Forms.TabPage();
            this.btnTimKiemVoucher = new ReaLTaiizor.Controls.MaterialButton();
            this.pnlTongQuanVoucher = new System.Windows.Forms.Panel();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtLuotNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.picVoucher = new System.Windows.Forms.PictureBox();
            this.btnXoa = new ReaLTaiizor.Controls.MaterialButton();
            this.btnLuu = new ReaLTaiizor.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label233 = new System.Windows.Forms.Label();
            this.txtTimKiemVoucher = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDanhSachVoucher = new System.Windows.Forms.DataGridView();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUOTNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpThem = new System.Windows.Forms.TabPage();
            this.pnlThemVoucher = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMoTaThem = new System.Windows.Forms.TextBox();
            this.txtSoLuongThem = new System.Windows.Forms.TextBox();
            this.txtGiamGiaThem = new System.Windows.Forms.TextBox();
            this.txtMaThem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picVoucherThem = new System.Windows.Forms.PictureBox();
            this.btnThemVoucher = new ReaLTaiizor.Controls.MaterialButton();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.tabForm.SuspendLayout();
            this.tpChinhSua.SuspendLayout();
            this.pnlTongQuanVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachVoucher)).BeginInit();
            this.tpThem.SuspendLayout();
            this.pnlThemVoucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoucherThem)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabForm;
            this.materialTabSelector1.CharacterCasing = ReaLTaiizor.Controls.MaterialTabSelector.CustomCharacterCasing.Proper;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Center;
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 64);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.SelectorHideTabName = new string[0];
            this.materialTabSelector1.SelectorNonClickTabPage = new System.Windows.Forms.TabPage[0];
            this.materialTabSelector1.Size = new System.Drawing.Size(1334, 47);
            this.materialTabSelector1.TabIndex = 29;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.tpChinhSua);
            this.tabForm.Controls.Add(this.tpThem);
            this.tabForm.Depth = 0;
            this.tabForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabForm.Location = new System.Drawing.Point(0, 0);
            this.tabForm.Margin = new System.Windows.Forms.Padding(0);
            this.tabForm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.tabForm.Multiline = true;
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(1270, 551);
            this.tabForm.TabIndex = 30;
            this.tabForm.SelectedIndexChanged += new System.EventHandler(this.tabForm_SelectedIndexChanged);
            // 
            // tpChinhSua
            // 
            this.tpChinhSua.BackColor = System.Drawing.Color.Transparent;
            this.tpChinhSua.Controls.Add(this.btnTimKiemVoucher);
            this.tpChinhSua.Controls.Add(this.pnlTongQuanVoucher);
            this.tpChinhSua.Controls.Add(this.txtTimKiemVoucher);
            this.tpChinhSua.Controls.Add(this.label9);
            this.tpChinhSua.Controls.Add(this.dgvDanhSachVoucher);
            this.tpChinhSua.Location = new System.Drawing.Point(4, 25);
            this.tpChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.tpChinhSua.Name = "tpChinhSua";
            this.tpChinhSua.Padding = new System.Windows.Forms.Padding(4);
            this.tpChinhSua.Size = new System.Drawing.Size(1262, 522);
            this.tpChinhSua.TabIndex = 0;
            this.tpChinhSua.Text = "Chỉnh sửa";
            // 
            // btnTimKiemVoucher
            // 
            this.btnTimKiemVoucher.AutoSize = false;
            this.btnTimKiemVoucher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiemVoucher.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemVoucher.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnTimKiemVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemVoucher.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiemVoucher.Depth = 0;
            this.btnTimKiemVoucher.HighEmphasis = false;
            this.btnTimKiemVoucher.Icon = global::QuanLyCafe.Properties.Resources.search;
            this.btnTimKiemVoucher.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnTimKiemVoucher.Location = new System.Drawing.Point(651, 40);
            this.btnTimKiemVoucher.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnTimKiemVoucher.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnTimKiemVoucher.Name = "btnTimKiemVoucher";
            this.btnTimKiemVoucher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiemVoucher.Size = new System.Drawing.Size(118, 48);
            this.btnTimKiemVoucher.TabIndex = 33;
            this.btnTimKiemVoucher.Text = "Tìm kiếm";
            this.btnTimKiemVoucher.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiemVoucher.UseAccentColor = false;
            this.btnTimKiemVoucher.UseVisualStyleBackColor = false;
            this.btnTimKiemVoucher.Click += new System.EventHandler(this.btnTimKiemVoucher_Click);
            // 
            // pnlTongQuanVoucher
            // 
            this.pnlTongQuanVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlTongQuanVoucher.Controls.Add(this.txtMoTa);
            this.pnlTongQuanVoucher.Controls.Add(this.txtLuotNhap);
            this.pnlTongQuanVoucher.Controls.Add(this.txtSoLuong);
            this.pnlTongQuanVoucher.Controls.Add(this.txtGiamGia);
            this.pnlTongQuanVoucher.Controls.Add(this.txtMa);
            this.pnlTongQuanVoucher.Controls.Add(this.picVoucher);
            this.pnlTongQuanVoucher.Controls.Add(this.btnXoa);
            this.pnlTongQuanVoucher.Controls.Add(this.btnLuu);
            this.pnlTongQuanVoucher.Controls.Add(this.label4);
            this.pnlTongQuanVoucher.Controls.Add(this.label2);
            this.pnlTongQuanVoucher.Controls.Add(this.label3);
            this.pnlTongQuanVoucher.Controls.Add(this.lblTitle);
            this.pnlTongQuanVoucher.Controls.Add(this.label1);
            this.pnlTongQuanVoucher.Controls.Add(this.label233);
            this.pnlTongQuanVoucher.Location = new System.Drawing.Point(794, 23);
            this.pnlTongQuanVoucher.Name = "pnlTongQuanVoucher";
            this.pnlTongQuanVoucher.Size = new System.Drawing.Size(414, 464);
            this.pnlTongQuanVoucher.TabIndex = 6;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtMoTa.Location = new System.Drawing.Point(160, 271);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(230, 28);
            this.txtMoTa.TabIndex = 11;
            // 
            // txtLuotNhap
            // 
            this.txtLuotNhap.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtLuotNhap.Location = new System.Drawing.Point(160, 350);
            this.txtLuotNhap.Name = "txtLuotNhap";
            this.txtLuotNhap.ReadOnly = true;
            this.txtLuotNhap.Size = new System.Drawing.Size(230, 28);
            this.txtLuotNhap.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtSoLuong.Location = new System.Drawing.Point(160, 311);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(230, 28);
            this.txtSoLuong.TabIndex = 11;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtGiamGia.Location = new System.Drawing.Point(160, 233);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(230, 28);
            this.txtGiamGia.TabIndex = 11;
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtMa.Location = new System.Drawing.Point(160, 200);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(230, 28);
            this.txtMa.TabIndex = 11;
            // 
            // picVoucher
            // 
            this.picVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.picVoucher.Image = global::QuanLyCafe.Properties.Resources.coupon;
            this.picVoucher.Location = new System.Drawing.Point(145, 57);
            this.picVoucher.Name = "picVoucher";
            this.picVoucher.Size = new System.Drawing.Size(134, 104);
            this.picVoucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVoucher.TabIndex = 10;
            this.picVoucher.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = false;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoa.Depth = 0;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = null;
            this.btnXoa.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnXoa.Location = new System.Drawing.Point(228, 402);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXoa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoa.Size = new System.Drawing.Size(162, 44);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Ẩn";
            this.btnXoa.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = false;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnLuu.Location = new System.Drawing.Point(28, 402);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLuu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(162, 44);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(24, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lượt nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(24, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(24, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(23, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 27);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Tổng Quan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(24, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giảm giá (%):";
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label233.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label233.Location = new System.Drawing.Point(24, 200);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(42, 21);
            this.label233.TabIndex = 2;
            this.label233.Text = "Mã:";
            // 
            // txtTimKiemVoucher
            // 
            this.txtTimKiemVoucher.AnimateReadOnly = false;
            this.txtTimKiemVoucher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTimKiemVoucher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTimKiemVoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTimKiemVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemVoucher.Depth = 0;
            this.txtTimKiemVoucher.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtTimKiemVoucher.HideSelection = true;
            this.txtTimKiemVoucher.Hint = "Nhập mã voucher";
            this.txtTimKiemVoucher.LeadingIcon = null;
            this.txtTimKiemVoucher.Location = new System.Drawing.Point(368, 40);
            this.txtTimKiemVoucher.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemVoucher.MaxLength = 50;
            this.txtTimKiemVoucher.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTimKiemVoucher.Name = "txtTimKiemVoucher";
            this.txtTimKiemVoucher.PasswordChar = '\0';
            this.txtTimKiemVoucher.PrefixSuffixText = null;
            this.txtTimKiemVoucher.ReadOnly = false;
            this.txtTimKiemVoucher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimKiemVoucher.SelectedText = "";
            this.txtTimKiemVoucher.SelectionLength = 0;
            this.txtTimKiemVoucher.SelectionStart = 0;
            this.txtTimKiemVoucher.ShortcutsEnabled = true;
            this.txtTimKiemVoucher.Size = new System.Drawing.Size(266, 48);
            this.txtTimKiemVoucher.TabIndex = 32;
            this.txtTimKiemVoucher.TabStop = false;
            this.txtTimKiemVoucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemVoucher.TrailingIcon = null;
            this.txtTimKiemVoucher.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(19, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "Chỉnh Sửa Voucher";
            // 
            // dgvDanhSachVoucher
            // 
            this.dgvDanhSachVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA,
            this.GIAMGIA,
            this.MOTA,
            this.SOLUONG,
            this.LUOTNHAP});
            this.dgvDanhSachVoucher.Location = new System.Drawing.Point(43, 108);
            this.dgvDanhSachVoucher.MultiSelect = false;
            this.dgvDanhSachVoucher.Name = "dgvDanhSachVoucher";
            this.dgvDanhSachVoucher.ReadOnly = true;
            this.dgvDanhSachVoucher.RowHeadersWidth = 51;
            this.dgvDanhSachVoucher.RowTemplate.Height = 24;
            this.dgvDanhSachVoucher.Size = new System.Drawing.Size(726, 379);
            this.dgvDanhSachVoucher.TabIndex = 5;
            this.dgvDanhSachVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachVoucher_CellClick);
            // 
            // MA
            // 
            this.MA.DataPropertyName = "MA";
            this.MA.HeaderText = "Mã";
            this.MA.MinimumWidth = 6;
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            this.MA.Width = 125;
            // 
            // GIAMGIA
            // 
            this.GIAMGIA.DataPropertyName = "GIAMGIA";
            this.GIAMGIA.HeaderText = "Giảm giá (%)";
            this.GIAMGIA.MinimumWidth = 6;
            this.GIAMGIA.Name = "GIAMGIA";
            this.GIAMGIA.ReadOnly = true;
            this.GIAMGIA.Width = 125;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.MinimumWidth = 6;
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            this.MOTA.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 125;
            // 
            // LUOTNHAP
            // 
            this.LUOTNHAP.DataPropertyName = "LUOTNHAP";
            this.LUOTNHAP.HeaderText = "Lượt nhập";
            this.LUOTNHAP.MinimumWidth = 6;
            this.LUOTNHAP.Name = "LUOTNHAP";
            this.LUOTNHAP.ReadOnly = true;
            this.LUOTNHAP.Width = 125;
            // 
            // tpThem
            // 
            this.tpThem.BackColor = System.Drawing.Color.Transparent;
            this.tpThem.Controls.Add(this.pnlThemVoucher);
            this.tpThem.Location = new System.Drawing.Point(4, 25);
            this.tpThem.Margin = new System.Windows.Forms.Padding(4);
            this.tpThem.Name = "tpThem";
            this.tpThem.Padding = new System.Windows.Forms.Padding(4);
            this.tpThem.Size = new System.Drawing.Size(1262, 522);
            this.tpThem.TabIndex = 1;
            this.tpThem.Text = "Thêm";
            // 
            // pnlThemVoucher
            // 
            this.pnlThemVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlThemVoucher.Controls.Add(this.label10);
            this.pnlThemVoucher.Controls.Add(this.txtMoTaThem);
            this.pnlThemVoucher.Controls.Add(this.txtSoLuongThem);
            this.pnlThemVoucher.Controls.Add(this.txtGiamGiaThem);
            this.pnlThemVoucher.Controls.Add(this.txtMaThem);
            this.pnlThemVoucher.Controls.Add(this.label5);
            this.pnlThemVoucher.Controls.Add(this.label6);
            this.pnlThemVoucher.Controls.Add(this.label7);
            this.pnlThemVoucher.Controls.Add(this.label8);
            this.pnlThemVoucher.Controls.Add(this.picVoucherThem);
            this.pnlThemVoucher.Controls.Add(this.btnThemVoucher);
            this.pnlThemVoucher.Location = new System.Drawing.Point(435, 25);
            this.pnlThemVoucher.Name = "pnlThemVoucher";
            this.pnlThemVoucher.Size = new System.Drawing.Size(414, 474);
            this.pnlThemVoucher.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(22, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 27);
            this.label10.TabIndex = 21;
            this.label10.Text = "Thêm Voucher";
            // 
            // txtMoTaThem
            // 
            this.txtMoTaThem.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtMoTaThem.Location = new System.Drawing.Point(159, 277);
            this.txtMoTaThem.Name = "txtMoTaThem";
            this.txtMoTaThem.Size = new System.Drawing.Size(230, 28);
            this.txtMoTaThem.TabIndex = 17;
            // 
            // txtSoLuongThem
            // 
            this.txtSoLuongThem.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtSoLuongThem.Location = new System.Drawing.Point(159, 317);
            this.txtSoLuongThem.Name = "txtSoLuongThem";
            this.txtSoLuongThem.Size = new System.Drawing.Size(230, 28);
            this.txtSoLuongThem.TabIndex = 18;
            this.txtSoLuongThem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongThem_KeyPress);
            // 
            // txtGiamGiaThem
            // 
            this.txtGiamGiaThem.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtGiamGiaThem.Location = new System.Drawing.Point(159, 239);
            this.txtGiamGiaThem.Name = "txtGiamGiaThem";
            this.txtGiamGiaThem.Size = new System.Drawing.Size(230, 28);
            this.txtGiamGiaThem.TabIndex = 19;
            this.txtGiamGiaThem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGiaThem_KeyPress);
            // 
            // txtMaThem
            // 
            this.txtMaThem.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtMaThem.Location = new System.Drawing.Point(159, 206);
            this.txtMaThem.Name = "txtMaThem";
            this.txtMaThem.Size = new System.Drawing.Size(230, 28);
            this.txtMaThem.TabIndex = 20;
            this.txtMaThem.Leave += new System.EventHandler(this.txtMaThem_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(23, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(23, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(23, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giảm giá (%):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(23, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã:";
            // 
            // picVoucherThem
            // 
            this.picVoucherThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.picVoucherThem.Image = global::QuanLyCafe.Properties.Resources.coupon;
            this.picVoucherThem.Location = new System.Drawing.Point(137, 53);
            this.picVoucherThem.Name = "picVoucherThem";
            this.picVoucherThem.Size = new System.Drawing.Size(134, 104);
            this.picVoucherThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVoucherThem.TabIndex = 12;
            this.picVoucherThem.TabStop = false;
            // 
            // btnThemVoucher
            // 
            this.btnThemVoucher.AutoSize = false;
            this.btnThemVoucher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemVoucher.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnThemVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVoucher.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemVoucher.Depth = 0;
            this.btnThemVoucher.HighEmphasis = true;
            this.btnThemVoucher.Icon = null;
            this.btnThemVoucher.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnThemVoucher.Location = new System.Drawing.Point(27, 384);
            this.btnThemVoucher.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThemVoucher.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnThemVoucher.Name = "btnThemVoucher";
            this.btnThemVoucher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemVoucher.Size = new System.Drawing.Size(362, 44);
            this.btnThemVoucher.TabIndex = 9;
            this.btnThemVoucher.Text = "Thêm";
            this.btnThemVoucher.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemVoucher.UseAccentColor = false;
            this.btnThemVoucher.UseVisualStyleBackColor = true;
            this.btnThemVoucher.Click += new System.EventHandler(this.btnThemVoucher_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.SystemColors.Control;
            this.pnlForm.Controls.Add(this.tabForm);
            this.pnlForm.Location = new System.Drawing.Point(3, 114);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1270, 577);
            this.pnlForm.TabIndex = 31;
            // 
            // ChinhSuaVoucherForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1340, 808);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.materialTabSelector1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChinhSuaVoucherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChinhSuaVoucherForm_Load);
            this.tabForm.ResumeLayout(false);
            this.tpChinhSua.ResumeLayout(false);
            this.tpChinhSua.PerformLayout();
            this.pnlTongQuanVoucher.ResumeLayout(false);
            this.pnlTongQuanVoucher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachVoucher)).EndInit();
            this.tpThem.ResumeLayout(false);
            this.pnlThemVoucher.ResumeLayout(false);
            this.pnlThemVoucher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVoucherThem)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabSelector materialTabSelector1;
        private ReaLTaiizor.Controls.MaterialTabControl tabForm;
        private System.Windows.Forms.TabPage tpChinhSua;
        private System.Windows.Forms.Panel pnlTongQuanVoucher;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.PictureBox picVoucher;
        private ReaLTaiizor.Controls.MaterialButton btnXoa;
        private ReaLTaiizor.Controls.MaterialButton btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.DataGridView dgvDanhSachVoucher;
        private System.Windows.Forms.TabPage tpThem;
        private System.Windows.Forms.Panel pnlThemVoucher;
        private ReaLTaiizor.Controls.MaterialButton btnThemVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUOTNHAP;
        private System.Windows.Forms.TextBox txtLuotNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoTaThem;
        private System.Windows.Forms.TextBox txtSoLuongThem;
        private System.Windows.Forms.TextBox txtGiamGiaThem;
        private System.Windows.Forms.TextBox txtMaThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picVoucherThem;
        private System.Windows.Forms.Panel pnlForm;
        private ReaLTaiizor.Controls.MaterialButton btnTimKiemVoucher;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTimKiemVoucher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label10;
    }
}