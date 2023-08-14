namespace QuanLyCafe.GUI
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.lblBanChuaDat = new System.Windows.Forms.Label();
            this.dgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAISANPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE_PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EVENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label233 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlChiTietSanPham = new System.Windows.Forms.Panel();
            this.picHienThiSanPham = new System.Windows.Forms.PictureBox();
            this.btnXoaOrder = new ReaLTaiizor.Controls.MaterialButton();
            this.btnCapNhatOrder = new ReaLTaiizor.Controls.MaterialButton();
            this.btnXacNhanOrder = new ReaLTaiizor.Controls.MaterialButton();
            this.txtSoLuongSanPham = new System.Windows.Forms.TextBox();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblSuKien = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSauGiamGia = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.btnTimKiemSanPham = new ReaLTaiizor.Controls.MaterialButton();
            this.txtTimKiemSanPham = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLichSuOrder = new System.Windows.Forms.DataGridView();
            this.ID_DATBAN_LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_HOADON_LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SANPHAM_LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SANPHAM_LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA_LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIAGIAM_LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG_LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN_LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIAN_LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblThongTinBanDat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).BeginInit();
            this.pnlChiTietSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHienThiSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBanChuaDat
            // 
            this.lblBanChuaDat.AutoSize = true;
            this.lblBanChuaDat.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblBanChuaDat.Location = new System.Drawing.Point(12, 27);
            this.lblBanChuaDat.Name = "lblBanChuaDat";
            this.lblBanChuaDat.Size = new System.Drawing.Size(129, 27);
            this.lblBanChuaDat.TabIndex = 2;
            this.lblBanChuaDat.Text = "Order Món";
            // 
            // dgvDanhSachSanPham
            // 
            this.dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LOAISANPHAM,
            this.TEN,
            this.GIATIEN,
            this.MOTA,
            this.IMAGE_PATH,
            this.EVENT});
            this.dgvDanhSachSanPham.Location = new System.Drawing.Point(16, 152);
            this.dgvDanhSachSanPham.MultiSelect = false;
            this.dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            this.dgvDanhSachSanPham.ReadOnly = true;
            this.dgvDanhSachSanPham.RowHeadersWidth = 51;
            this.dgvDanhSachSanPham.RowTemplate.Height = 24;
            this.dgvDanhSachSanPham.Size = new System.Drawing.Size(590, 223);
            this.dgvDanhSachSanPham.TabIndex = 3;
            this.dgvDanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSanPham_CellClick);
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
            // LOAISANPHAM
            // 
            this.LOAISANPHAM.DataPropertyName = "LOAISANPHAM";
            this.LOAISANPHAM.HeaderText = "Loại sản phẩm";
            this.LOAISANPHAM.MinimumWidth = 6;
            this.LOAISANPHAM.Name = "LOAISANPHAM";
            this.LOAISANPHAM.ReadOnly = true;
            this.LOAISANPHAM.Width = 125;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên sản phẩm";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            this.TEN.Width = 125;
            // 
            // GIATIEN
            // 
            this.GIATIEN.DataPropertyName = "GIATIEN";
            this.GIATIEN.HeaderText = "Giá tiền";
            this.GIATIEN.MinimumWidth = 6;
            this.GIATIEN.Name = "GIATIEN";
            this.GIATIEN.ReadOnly = true;
            this.GIATIEN.Width = 125;
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
            // IMAGE_PATH
            // 
            this.IMAGE_PATH.DataPropertyName = "IMAGE_PATH";
            this.IMAGE_PATH.HeaderText = "Hình ảnh";
            this.IMAGE_PATH.MinimumWidth = 6;
            this.IMAGE_PATH.Name = "IMAGE_PATH";
            this.IMAGE_PATH.ReadOnly = true;
            this.IMAGE_PATH.Visible = false;
            this.IMAGE_PATH.Width = 125;
            // 
            // EVENT
            // 
            this.EVENT.DataPropertyName = "EVENT";
            this.EVENT.HeaderText = "Event";
            this.EVENT.MinimumWidth = 6;
            this.EVENT.Name = "EVENT";
            this.EVENT.ReadOnly = true;
            this.EVENT.Width = 125;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(23, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 27);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Tổng quan";
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label233.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label233.Location = new System.Drawing.Point(24, 200);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(139, 21);
            this.label233.TabIndex = 2;
            this.label233.Text = "Tên sản phẩm:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label.Location = new System.Drawing.Point(24, 282);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 21);
            this.label.TabIndex = 2;
            this.label.Text = "Giá tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(24, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sau giảm giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(24, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng:";
            // 
            // pnlChiTietSanPham
            // 
            this.pnlChiTietSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlChiTietSanPham.Controls.Add(this.picHienThiSanPham);
            this.pnlChiTietSanPham.Controls.Add(this.btnXoaOrder);
            this.pnlChiTietSanPham.Controls.Add(this.btnCapNhatOrder);
            this.pnlChiTietSanPham.Controls.Add(this.btnXacNhanOrder);
            this.pnlChiTietSanPham.Controls.Add(this.txtSoLuongSanPham);
            this.pnlChiTietSanPham.Controls.Add(this.lblTitle);
            this.pnlChiTietSanPham.Controls.Add(this.lblTenSanPham);
            this.pnlChiTietSanPham.Controls.Add(this.label233);
            this.pnlChiTietSanPham.Controls.Add(this.lblTongTien);
            this.pnlChiTietSanPham.Controls.Add(this.lblSuKien);
            this.pnlChiTietSanPham.Controls.Add(this.lblGiamGia);
            this.pnlChiTietSanPham.Controls.Add(this.label6);
            this.pnlChiTietSanPham.Controls.Add(this.label5);
            this.pnlChiTietSanPham.Controls.Add(this.lblSauGiamGia);
            this.pnlChiTietSanPham.Controls.Add(this.lblGiaTien);
            this.pnlChiTietSanPham.Controls.Add(this.label);
            this.pnlChiTietSanPham.Controls.Add(this.label4);
            this.pnlChiTietSanPham.Location = new System.Drawing.Point(627, 27);
            this.pnlChiTietSanPham.Name = "pnlChiTietSanPham";
            this.pnlChiTietSanPham.Size = new System.Drawing.Size(414, 564);
            this.pnlChiTietSanPham.TabIndex = 4;
            this.pnlChiTietSanPham.Visible = false;
            // 
            // picHienThiSanPham
            // 
            this.picHienThiSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.picHienThiSanPham.Location = new System.Drawing.Point(91, 51);
            this.picHienThiSanPham.Name = "picHienThiSanPham";
            this.picHienThiSanPham.Size = new System.Drawing.Size(236, 125);
            this.picHienThiSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHienThiSanPham.TabIndex = 10;
            this.picHienThiSanPham.TabStop = false;
            // 
            // btnXoaOrder
            // 
            this.btnXoaOrder.AutoSize = false;
            this.btnXoaOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaOrder.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnXoaOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaOrder.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXoaOrder.Depth = 0;
            this.btnXoaOrder.HighEmphasis = true;
            this.btnXoaOrder.Icon = null;
            this.btnXoaOrder.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnXoaOrder.Location = new System.Drawing.Point(217, 494);
            this.btnXoaOrder.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXoaOrder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnXoaOrder.Name = "btnXoaOrder";
            this.btnXoaOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXoaOrder.Size = new System.Drawing.Size(162, 44);
            this.btnXoaOrder.TabIndex = 9;
            this.btnXoaOrder.Text = "Xóa order";
            this.btnXoaOrder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoaOrder.UseAccentColor = false;
            this.btnXoaOrder.UseVisualStyleBackColor = true;
            this.btnXoaOrder.Visible = false;
            this.btnXoaOrder.Click += new System.EventHandler(this.btnXoaOrder_Click);
            // 
            // btnCapNhatOrder
            // 
            this.btnCapNhatOrder.AutoSize = false;
            this.btnCapNhatOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapNhatOrder.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnCapNhatOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatOrder.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCapNhatOrder.Depth = 0;
            this.btnCapNhatOrder.HighEmphasis = true;
            this.btnCapNhatOrder.Icon = null;
            this.btnCapNhatOrder.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCapNhatOrder.Location = new System.Drawing.Point(27, 494);
            this.btnCapNhatOrder.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnCapNhatOrder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCapNhatOrder.Name = "btnCapNhatOrder";
            this.btnCapNhatOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCapNhatOrder.Size = new System.Drawing.Size(162, 44);
            this.btnCapNhatOrder.TabIndex = 9;
            this.btnCapNhatOrder.Text = "Cập nhật";
            this.btnCapNhatOrder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCapNhatOrder.UseAccentColor = false;
            this.btnCapNhatOrder.UseVisualStyleBackColor = true;
            this.btnCapNhatOrder.Visible = false;
            this.btnCapNhatOrder.Click += new System.EventHandler(this.btnCapNhatOrder_Click);
            // 
            // btnXacNhanOrder
            // 
            this.btnXacNhanOrder.AutoSize = false;
            this.btnXacNhanOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXacNhanOrder.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnXacNhanOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhanOrder.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXacNhanOrder.Depth = 0;
            this.btnXacNhanOrder.HighEmphasis = true;
            this.btnXacNhanOrder.Icon = null;
            this.btnXacNhanOrder.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnXacNhanOrder.Location = new System.Drawing.Point(27, 494);
            this.btnXacNhanOrder.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXacNhanOrder.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnXacNhanOrder.Name = "btnXacNhanOrder";
            this.btnXacNhanOrder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXacNhanOrder.Size = new System.Drawing.Size(162, 44);
            this.btnXacNhanOrder.TabIndex = 9;
            this.btnXacNhanOrder.Text = "Xác nhận";
            this.btnXacNhanOrder.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXacNhanOrder.UseAccentColor = false;
            this.btnXacNhanOrder.UseVisualStyleBackColor = true;
            this.btnXacNhanOrder.Click += new System.EventHandler(this.btnXacNhanOrder_Click);
            // 
            // txtSoLuongSanPham
            // 
            this.txtSoLuongSanPham.Location = new System.Drawing.Point(182, 238);
            this.txtSoLuongSanPham.Name = "txtSoLuongSanPham";
            this.txtSoLuongSanPham.Size = new System.Drawing.Size(41, 22);
            this.txtSoLuongSanPham.TabIndex = 3;
            this.txtSoLuongSanPham.Text = "1";
            this.txtSoLuongSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongSanPham_KeyPress);
            this.txtSoLuongSanPham.Leave += new System.EventHandler(this.txtSoLuongSanPham_Leave);
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTenSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTenSanPham.Location = new System.Drawing.Point(178, 200);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(58, 21);
            this.lblTenSanPham.TabIndex = 2;
            this.lblTenSanPham.Text = "NULL";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblTongTien.Location = new System.Drawing.Point(178, 355);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(58, 21);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "NULL";
            // 
            // lblSuKien
            // 
            this.lblSuKien.AutoSize = true;
            this.lblSuKien.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSuKien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblSuKien.Location = new System.Drawing.Point(27, 422);
            this.lblSuKien.Name = "lblSuKien";
            this.lblSuKien.Size = new System.Drawing.Size(89, 21);
            this.lblSuKien.TabIndex = 2;
            this.lblSuKien.Text = "Sự kiện: ";
            this.lblSuKien.Visible = false;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblGiamGia.Location = new System.Drawing.Point(26, 387);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(136, 21);
            this.lblGiamGia.TabIndex = 2;
            this.lblGiamGia.Text = "Giảm giá: 10%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(24, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng tiền:";
            // 
            // lblSauGiamGia
            // 
            this.lblSauGiamGia.AutoSize = true;
            this.lblSauGiamGia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSauGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblSauGiamGia.Location = new System.Drawing.Point(178, 319);
            this.lblSauGiamGia.Name = "lblSauGiamGia";
            this.lblSauGiamGia.Size = new System.Drawing.Size(58, 21);
            this.lblSauGiamGia.TabIndex = 2;
            this.lblSauGiamGia.Text = "NULL";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblGiaTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblGiaTien.Location = new System.Drawing.Point(178, 282);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(58, 21);
            this.lblGiaTien.TabIndex = 2;
            this.lblGiaTien.Text = "NULL";
            // 
            // btnTimKiemSanPham
            // 
            this.btnTimKiemSanPham.AutoSize = false;
            this.btnTimKiemSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiemSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemSanPham.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnTimKiemSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemSanPham.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiemSanPham.Depth = 0;
            this.btnTimKiemSanPham.HighEmphasis = false;
            this.btnTimKiemSanPham.Icon = global::QuanLyCafe.Properties.Resources.search;
            this.btnTimKiemSanPham.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnTimKiemSanPham.Location = new System.Drawing.Point(488, 85);
            this.btnTimKiemSanPham.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnTimKiemSanPham.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnTimKiemSanPham.Name = "btnTimKiemSanPham";
            this.btnTimKiemSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiemSanPham.Size = new System.Drawing.Size(118, 48);
            this.btnTimKiemSanPham.TabIndex = 13;
            this.btnTimKiemSanPham.Text = "Tìm kiếm";
            this.btnTimKiemSanPham.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiemSanPham.UseAccentColor = false;
            this.btnTimKiemSanPham.UseVisualStyleBackColor = false;
            this.btnTimKiemSanPham.Click += new System.EventHandler(this.btnTimKiemSanPham_Click);
            // 
            // txtTimKiemSanPham
            // 
            this.txtTimKiemSanPham.AnimateReadOnly = false;
            this.txtTimKiemSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTimKiemSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTimKiemSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTimKiemSanPham.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemSanPham.Depth = 0;
            this.txtTimKiemSanPham.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtTimKiemSanPham.HideSelection = true;
            this.txtTimKiemSanPham.Hint = "Nhập tên món";
            this.txtTimKiemSanPham.LeadingIcon = null;
            this.txtTimKiemSanPham.Location = new System.Drawing.Point(205, 85);
            this.txtTimKiemSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemSanPham.MaxLength = 50;
            this.txtTimKiemSanPham.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTimKiemSanPham.Name = "txtTimKiemSanPham";
            this.txtTimKiemSanPham.PasswordChar = '\0';
            this.txtTimKiemSanPham.PrefixSuffixText = null;
            this.txtTimKiemSanPham.ReadOnly = false;
            this.txtTimKiemSanPham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimKiemSanPham.SelectedText = "";
            this.txtTimKiemSanPham.SelectionLength = 0;
            this.txtTimKiemSanPham.SelectionStart = 0;
            this.txtTimKiemSanPham.ShortcutsEnabled = true;
            this.txtTimKiemSanPham.Size = new System.Drawing.Size(266, 48);
            this.txtTimKiemSanPham.TabIndex = 12;
            this.txtTimKiemSanPham.TabStop = false;
            this.txtTimKiemSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemSanPham.TrailingIcon = null;
            this.txtTimKiemSanPham.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lịch sử order";
            // 
            // dgvLichSuOrder
            // 
            this.dgvLichSuOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DATBAN_LS,
            this.ID_HOADON_LS,
            this.ID_SANPHAM_LS,
            this.TEN_SANPHAM_LS,
            this.DONGIA_LS,
            this.DONGIAGIAM_LS,
            this.SOLUONG_LS,
            this.THANHTIEN_LS,
            this.THOIGIAN_LS});
            this.dgvLichSuOrder.Location = new System.Drawing.Point(16, 427);
            this.dgvLichSuOrder.MultiSelect = false;
            this.dgvLichSuOrder.Name = "dgvLichSuOrder";
            this.dgvLichSuOrder.ReadOnly = true;
            this.dgvLichSuOrder.RowHeadersWidth = 51;
            this.dgvLichSuOrder.RowTemplate.Height = 24;
            this.dgvLichSuOrder.Size = new System.Drawing.Size(590, 164);
            this.dgvLichSuOrder.TabIndex = 3;
            this.dgvLichSuOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSuOrder_CellClick);
            // 
            // ID_DATBAN_LS
            // 
            this.ID_DATBAN_LS.DataPropertyName = "ID_DATBAN_LS";
            this.ID_DATBAN_LS.HeaderText = "ID Đặt bàn";
            this.ID_DATBAN_LS.MinimumWidth = 6;
            this.ID_DATBAN_LS.Name = "ID_DATBAN_LS";
            this.ID_DATBAN_LS.ReadOnly = true;
            this.ID_DATBAN_LS.Width = 125;
            // 
            // ID_HOADON_LS
            // 
            this.ID_HOADON_LS.DataPropertyName = "ID_HOADON_LS";
            this.ID_HOADON_LS.HeaderText = "ID Hóa đơn";
            this.ID_HOADON_LS.MinimumWidth = 6;
            this.ID_HOADON_LS.Name = "ID_HOADON_LS";
            this.ID_HOADON_LS.ReadOnly = true;
            this.ID_HOADON_LS.Width = 125;
            // 
            // ID_SANPHAM_LS
            // 
            this.ID_SANPHAM_LS.DataPropertyName = "ID_SANPHAM_LS";
            this.ID_SANPHAM_LS.HeaderText = "ID Sản phẩm";
            this.ID_SANPHAM_LS.MinimumWidth = 6;
            this.ID_SANPHAM_LS.Name = "ID_SANPHAM_LS";
            this.ID_SANPHAM_LS.ReadOnly = true;
            this.ID_SANPHAM_LS.Width = 125;
            // 
            // TEN_SANPHAM_LS
            // 
            this.TEN_SANPHAM_LS.DataPropertyName = "TEN_SANPHAM_LS";
            this.TEN_SANPHAM_LS.HeaderText = "Tên sản phẩm";
            this.TEN_SANPHAM_LS.MinimumWidth = 6;
            this.TEN_SANPHAM_LS.Name = "TEN_SANPHAM_LS";
            this.TEN_SANPHAM_LS.ReadOnly = true;
            this.TEN_SANPHAM_LS.Width = 125;
            // 
            // DONGIA_LS
            // 
            this.DONGIA_LS.DataPropertyName = "DONGIA_LS";
            this.DONGIA_LS.HeaderText = "Đơn giá";
            this.DONGIA_LS.MinimumWidth = 6;
            this.DONGIA_LS.Name = "DONGIA_LS";
            this.DONGIA_LS.ReadOnly = true;
            this.DONGIA_LS.Width = 125;
            // 
            // DONGIAGIAM_LS
            // 
            this.DONGIAGIAM_LS.DataPropertyName = "DONGIAGIAM_LS";
            this.DONGIAGIAM_LS.HeaderText = "Đơn giá giảm";
            this.DONGIAGIAM_LS.MinimumWidth = 6;
            this.DONGIAGIAM_LS.Name = "DONGIAGIAM_LS";
            this.DONGIAGIAM_LS.ReadOnly = true;
            this.DONGIAGIAM_LS.Width = 125;
            // 
            // SOLUONG_LS
            // 
            this.SOLUONG_LS.DataPropertyName = "SOLUONG_LS";
            this.SOLUONG_LS.HeaderText = "Số lượng";
            this.SOLUONG_LS.MinimumWidth = 6;
            this.SOLUONG_LS.Name = "SOLUONG_LS";
            this.SOLUONG_LS.ReadOnly = true;
            this.SOLUONG_LS.Width = 125;
            // 
            // THANHTIEN_LS
            // 
            this.THANHTIEN_LS.DataPropertyName = "THANHTIEN_LS";
            this.THANHTIEN_LS.HeaderText = "Thành tiền";
            this.THANHTIEN_LS.MinimumWidth = 6;
            this.THANHTIEN_LS.Name = "THANHTIEN_LS";
            this.THANHTIEN_LS.ReadOnly = true;
            this.THANHTIEN_LS.Width = 125;
            // 
            // THOIGIAN_LS
            // 
            this.THOIGIAN_LS.DataPropertyName = "THOIGIAN_LS";
            this.THOIGIAN_LS.HeaderText = "Thời gian";
            this.THOIGIAN_LS.MinimumWidth = 6;
            this.THOIGIAN_LS.Name = "THOIGIAN_LS";
            this.THOIGIAN_LS.ReadOnly = true;
            this.THOIGIAN_LS.Width = 125;
            // 
            // lblThongTinBanDat
            // 
            this.lblThongTinBanDat.AutoSize = true;
            this.lblThongTinBanDat.Font = new System.Drawing.Font("Arial", 12F);
            this.lblThongTinBanDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.lblThongTinBanDat.Location = new System.Drawing.Point(13, 63);
            this.lblThongTinBanDat.Name = "lblThongTinBanDat";
            this.lblThongTinBanDat.Size = new System.Drawing.Size(133, 23);
            this.lblThongTinBanDat.TabIndex = 2;
            this.lblThongTinBanDat.Text = "Mã bàn đặt: 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlChiTietSanPham);
            this.panel1.Controls.Add(this.dgvLichSuOrder);
            this.panel1.Controls.Add(this.btnTimKiemSanPham);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblBanChuaDat);
            this.panel1.Controls.Add(this.dgvDanhSachSanPham);
            this.panel1.Controls.Add(this.txtTimKiemSanPham);
            this.panel1.Controls.Add(this.lblThongTinBanDat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 612);
            this.panel1.TabIndex = 14;
            // 
            // OrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1069, 683);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).EndInit();
            this.pnlChiTietSanPham.ResumeLayout(false);
            this.pnlChiTietSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHienThiSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBanChuaDat;
        private System.Windows.Forms.DataGridView dgvDanhSachSanPham;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlChiTietSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuongSanPham;
        private ReaLTaiizor.Controls.MaterialButton btnXacNhanOrder;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSauGiamGia;
        private System.Windows.Forms.Label label;
        private ReaLTaiizor.Controls.MaterialButton btnTimKiemSanPham;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTimKiemSanPham;
        private System.Windows.Forms.PictureBox picHienThiSanPham;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLichSuOrder;
        private ReaLTaiizor.Controls.MaterialButton btnCapNhatOrder;
        private ReaLTaiizor.Controls.MaterialButton btnXoaOrder;
        private System.Windows.Forms.Label lblThongTinBanDat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAISANPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE_PATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EVENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DATBAN_LS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HOADON_LS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SANPHAM_LS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SANPHAM_LS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA_LS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIAGIAM_LS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG_LS;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN_LS;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIAN_LS;
    }
}