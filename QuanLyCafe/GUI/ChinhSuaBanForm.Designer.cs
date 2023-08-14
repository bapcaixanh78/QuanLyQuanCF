namespace QuanLyCafe.GUI
{
    partial class ChinhSuaBanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSuaBanForm));
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.pnlThemBan = new System.Windows.Forms.Panel();
            this.txtTenBanThem = new System.Windows.Forms.TextBox();
            this.txtIDBanThem = new System.Windows.Forms.TextBox();
            this.picHienThiBanThem = new System.Windows.Forms.PictureBox();
            this.btnThemBan = new ReaLTaiizor.Controls.MaterialButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtIDBan = new System.Windows.Forms.TextBox();
            this.picHienThiBan = new System.Windows.Forms.PictureBox();
            this.btnXoa = new ReaLTaiizor.Controls.MaterialButton();
            this.tabForm = new ReaLTaiizor.Controls.MaterialTabControl();
            this.tpChinhSua = new System.Windows.Forms.TabPage();
            this.btnTimKiemBan = new ReaLTaiizor.Controls.MaterialButton();
            this.txtTimKiemBan = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlTongQuanBan = new System.Windows.Forms.Panel();
            this.btnLuu = new ReaLTaiizor.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label233 = new System.Windows.Forms.Label();
            this.dgvDanhSachBan = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HIENTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpThem = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new ReaLTaiizor.Controls.MaterialTabSelector();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlThemBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHienThiBanThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHienThiBan)).BeginInit();
            this.tabForm.SuspendLayout();
            this.tpChinhSua.SuspendLayout();
            this.pnlTongQuanBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).BeginInit();
            this.tpThem.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtTinhTrang.Location = new System.Drawing.Point(160, 271);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(230, 28);
            this.txtTinhTrang.TabIndex = 11;
            // 
            // pnlThemBan
            // 
            this.pnlThemBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlThemBan.Controls.Add(this.txtTenBanThem);
            this.pnlThemBan.Controls.Add(this.txtIDBanThem);
            this.pnlThemBan.Controls.Add(this.picHienThiBanThem);
            this.pnlThemBan.Controls.Add(this.btnThemBan);
            this.pnlThemBan.Controls.Add(this.label12);
            this.pnlThemBan.Controls.Add(this.label13);
            this.pnlThemBan.Controls.Add(this.label14);
            this.pnlThemBan.Location = new System.Drawing.Point(320, 23);
            this.pnlThemBan.Name = "pnlThemBan";
            this.pnlThemBan.Size = new System.Drawing.Size(414, 547);
            this.pnlThemBan.TabIndex = 7;
            // 
            // txtTenBanThem
            // 
            this.txtTenBanThem.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtTenBanThem.Location = new System.Drawing.Point(160, 233);
            this.txtTenBanThem.Name = "txtTenBanThem";
            this.txtTenBanThem.Size = new System.Drawing.Size(230, 28);
            this.txtTenBanThem.TabIndex = 11;
            // 
            // txtIDBanThem
            // 
            this.txtIDBanThem.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtIDBanThem.Location = new System.Drawing.Point(160, 200);
            this.txtIDBanThem.Name = "txtIDBanThem";
            this.txtIDBanThem.Size = new System.Drawing.Size(230, 28);
            this.txtIDBanThem.TabIndex = 11;
            this.txtIDBanThem.Leave += new System.EventHandler(this.txtIDBanThem_Leave);
            // 
            // picHienThiBanThem
            // 
            this.picHienThiBanThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.picHienThiBanThem.Image = global::QuanLyCafe.Properties.Resources.table_chuadat;
            this.picHienThiBanThem.Location = new System.Drawing.Point(91, 62);
            this.picHienThiBanThem.Name = "picHienThiBanThem";
            this.picHienThiBanThem.Padding = new System.Windows.Forms.Padding(5);
            this.picHienThiBanThem.Size = new System.Drawing.Size(236, 104);
            this.picHienThiBanThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHienThiBanThem.TabIndex = 10;
            this.picHienThiBanThem.TabStop = false;
            // 
            // btnThemBan
            // 
            this.btnThemBan.AutoSize = false;
            this.btnThemBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemBan.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnThemBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemBan.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemBan.Depth = 0;
            this.btnThemBan.HighEmphasis = true;
            this.btnThemBan.Icon = null;
            this.btnThemBan.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnThemBan.Location = new System.Drawing.Point(28, 482);
            this.btnThemBan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThemBan.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemBan.Size = new System.Drawing.Size(362, 44);
            this.btnThemBan.TabIndex = 9;
            this.btnThemBan.Text = "Thêm";
            this.btnThemBan.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemBan.UseAccentColor = false;
            this.btnThemBan.UseVisualStyleBackColor = true;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(24, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 27);
            this.label12.TabIndex = 2;
            this.label12.Text = "Thêm Bàn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label13.Location = new System.Drawing.Point(24, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tên bàn:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label14.Location = new System.Drawing.Point(24, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "ID:";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtTenBan.Location = new System.Drawing.Point(160, 233);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(230, 28);
            this.txtTenBan.TabIndex = 11;
            // 
            // txtIDBan
            // 
            this.txtIDBan.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtIDBan.Location = new System.Drawing.Point(160, 200);
            this.txtIDBan.Name = "txtIDBan";
            this.txtIDBan.ReadOnly = true;
            this.txtIDBan.Size = new System.Drawing.Size(230, 28);
            this.txtIDBan.TabIndex = 11;
            // 
            // picHienThiBan
            // 
            this.picHienThiBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(248)))));
            this.picHienThiBan.Location = new System.Drawing.Point(89, 58);
            this.picHienThiBan.Name = "picHienThiBan";
            this.picHienThiBan.Padding = new System.Windows.Forms.Padding(5);
            this.picHienThiBan.Size = new System.Drawing.Size(236, 104);
            this.picHienThiBan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHienThiBan.TabIndex = 10;
            this.picHienThiBan.TabStop = false;
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
            this.btnXoa.Location = new System.Drawing.Point(228, 482);
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
            this.tabForm.Size = new System.Drawing.Size(1060, 622);
            this.tabForm.TabIndex = 28;
            this.tabForm.SelectedIndexChanged += new System.EventHandler(this.tabForm_SelectedIndexChanged);
            // 
            // tpChinhSua
            // 
            this.tpChinhSua.BackColor = System.Drawing.Color.White;
            this.tpChinhSua.Controls.Add(this.btnTimKiemBan);
            this.tpChinhSua.Controls.Add(this.txtTimKiemBan);
            this.tpChinhSua.Controls.Add(this.label15);
            this.tpChinhSua.Controls.Add(this.pnlTongQuanBan);
            this.tpChinhSua.Controls.Add(this.dgvDanhSachBan);
            this.tpChinhSua.Location = new System.Drawing.Point(4, 25);
            this.tpChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.tpChinhSua.Name = "tpChinhSua";
            this.tpChinhSua.Padding = new System.Windows.Forms.Padding(4);
            this.tpChinhSua.Size = new System.Drawing.Size(1052, 593);
            this.tpChinhSua.TabIndex = 0;
            this.tpChinhSua.Text = "Chỉnh sửa";
            // 
            // btnTimKiemBan
            // 
            this.btnTimKiemBan.AutoSize = false;
            this.btnTimKiemBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiemBan.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemBan.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnTimKiemBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemBan.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiemBan.Depth = 0;
            this.btnTimKiemBan.HighEmphasis = false;
            this.btnTimKiemBan.Icon = global::QuanLyCafe.Properties.Resources.search;
            this.btnTimKiemBan.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnTimKiemBan.Location = new System.Drawing.Point(451, 55);
            this.btnTimKiemBan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnTimKiemBan.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnTimKiemBan.Name = "btnTimKiemBan";
            this.btnTimKiemBan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiemBan.Size = new System.Drawing.Size(118, 48);
            this.btnTimKiemBan.TabIndex = 37;
            this.btnTimKiemBan.Text = "Tìm kiếm";
            this.btnTimKiemBan.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiemBan.UseAccentColor = false;
            this.btnTimKiemBan.UseVisualStyleBackColor = false;
            this.btnTimKiemBan.Click += new System.EventHandler(this.btnTimKiemBan_Click);
            // 
            // txtTimKiemBan
            // 
            this.txtTimKiemBan.AnimateReadOnly = false;
            this.txtTimKiemBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTimKiemBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTimKiemBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTimKiemBan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiemBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemBan.Depth = 0;
            this.txtTimKiemBan.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtTimKiemBan.HideSelection = true;
            this.txtTimKiemBan.Hint = "Nhập tên bàn";
            this.txtTimKiemBan.LeadingIcon = null;
            this.txtTimKiemBan.Location = new System.Drawing.Point(168, 55);
            this.txtTimKiemBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemBan.MaxLength = 50;
            this.txtTimKiemBan.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTimKiemBan.Name = "txtTimKiemBan";
            this.txtTimKiemBan.PasswordChar = '\0';
            this.txtTimKiemBan.PrefixSuffixText = null;
            this.txtTimKiemBan.ReadOnly = false;
            this.txtTimKiemBan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimKiemBan.SelectedText = "";
            this.txtTimKiemBan.SelectionLength = 0;
            this.txtTimKiemBan.SelectionStart = 0;
            this.txtTimKiemBan.ShortcutsEnabled = true;
            this.txtTimKiemBan.Size = new System.Drawing.Size(266, 48);
            this.txtTimKiemBan.TabIndex = 36;
            this.txtTimKiemBan.TabStop = false;
            this.txtTimKiemBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiemBan.TrailingIcon = null;
            this.txtTimKiemBan.UseSystemPasswordChar = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(19, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 27);
            this.label15.TabIndex = 7;
            this.label15.Text = "Danh Sách Bàn";
            // 
            // pnlTongQuanBan
            // 
            this.pnlTongQuanBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlTongQuanBan.Controls.Add(this.txtTinhTrang);
            this.pnlTongQuanBan.Controls.Add(this.txtTenBan);
            this.pnlTongQuanBan.Controls.Add(this.txtIDBan);
            this.pnlTongQuanBan.Controls.Add(this.picHienThiBan);
            this.pnlTongQuanBan.Controls.Add(this.btnXoa);
            this.pnlTongQuanBan.Controls.Add(this.btnLuu);
            this.pnlTongQuanBan.Controls.Add(this.label2);
            this.pnlTongQuanBan.Controls.Add(this.lblTitle);
            this.pnlTongQuanBan.Controls.Add(this.label1);
            this.pnlTongQuanBan.Controls.Add(this.label233);
            this.pnlTongQuanBan.Location = new System.Drawing.Point(589, 24);
            this.pnlTongQuanBan.Name = "pnlTongQuanBan";
            this.pnlTongQuanBan.Size = new System.Drawing.Size(414, 547);
            this.pnlTongQuanBan.TabIndex = 6;
            this.pnlTongQuanBan.Visible = false;
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
            this.btnLuu.Location = new System.Drawing.Point(28, 482);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(24, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tình trạng:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(14, 11);
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
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bàn:";
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label233.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label233.Location = new System.Drawing.Point(24, 200);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(35, 21);
            this.label233.TabIndex = 2;
            this.label233.Text = "ID:";
            // 
            // dgvDanhSachBan
            // 
            this.dgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TEN,
            this.TINHTRANG,
            this.HIENTHI});
            this.dgvDanhSachBan.Location = new System.Drawing.Point(22, 120);
            this.dgvDanhSachBan.MultiSelect = false;
            this.dgvDanhSachBan.Name = "dgvDanhSachBan";
            this.dgvDanhSachBan.ReadOnly = true;
            this.dgvDanhSachBan.RowHeadersWidth = 51;
            this.dgvDanhSachBan.RowTemplate.Height = 24;
            this.dgvDanhSachBan.Size = new System.Drawing.Size(547, 451);
            this.dgvDanhSachBan.TabIndex = 5;
            this.dgvDanhSachBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBan_CellClick);
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
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "Tên bàn";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            this.TEN.Width = 125;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.DataPropertyName = "TINHTRANG";
            this.TINHTRANG.HeaderText = "Tình trạng";
            this.TINHTRANG.MinimumWidth = 6;
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.ReadOnly = true;
            this.TINHTRANG.Width = 125;
            // 
            // HIENTHI
            // 
            this.HIENTHI.DataPropertyName = "HIENTHI";
            this.HIENTHI.HeaderText = "Hiển thị";
            this.HIENTHI.MinimumWidth = 6;
            this.HIENTHI.Name = "HIENTHI";
            this.HIENTHI.ReadOnly = true;
            this.HIENTHI.Width = 125;
            // 
            // tpThem
            // 
            this.tpThem.BackColor = System.Drawing.Color.Transparent;
            this.tpThem.Controls.Add(this.pnlThemBan);
            this.tpThem.Location = new System.Drawing.Point(4, 25);
            this.tpThem.Margin = new System.Windows.Forms.Padding(4);
            this.tpThem.Name = "tpThem";
            this.tpThem.Padding = new System.Windows.Forms.Padding(4);
            this.tpThem.Size = new System.Drawing.Size(1052, 593);
            this.tpThem.TabIndex = 1;
            this.tpThem.Text = "Thêm";
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1063, 47);
            this.materialTabSelector1.TabIndex = 27;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.tabForm);
            this.pnlForm.Location = new System.Drawing.Point(6, 126);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1060, 620);
            this.pnlForm.TabIndex = 29;
            // 
            // ChinhSuaBanForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1069, 752);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChinhSuaBanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChinhSuaBanForm_Load);
            this.pnlThemBan.ResumeLayout(false);
            this.pnlThemBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHienThiBanThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHienThiBan)).EndInit();
            this.tabForm.ResumeLayout(false);
            this.tpChinhSua.ResumeLayout(false);
            this.tpChinhSua.PerformLayout();
            this.pnlTongQuanBan.ResumeLayout(false);
            this.pnlTongQuanBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).EndInit();
            this.tpThem.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Panel pnlThemBan;
        private System.Windows.Forms.TextBox txtTenBanThem;
        private System.Windows.Forms.TextBox txtIDBanThem;
        private System.Windows.Forms.PictureBox picHienThiBanThem;
        private ReaLTaiizor.Controls.MaterialButton btnThemBan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.TextBox txtIDBan;
        private System.Windows.Forms.PictureBox picHienThiBan;
        private ReaLTaiizor.Controls.MaterialButton btnXoa;
        private ReaLTaiizor.Controls.MaterialTabControl tabForm;
        private System.Windows.Forms.TabPage tpChinhSua;
        private System.Windows.Forms.Panel pnlTongQuanBan;
        private ReaLTaiizor.Controls.MaterialButton btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.DataGridView dgvDanhSachBan;
        private System.Windows.Forms.TabPage tpThem;
        private ReaLTaiizor.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label label15;
        private ReaLTaiizor.Controls.MaterialButton btnTimKiemBan;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTimKiemBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HIENTHI;
    }
}