namespace QuanLyCafe.GUI
{
    partial class ChiTietBanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietBanForm));
            this.btnMoBan = new ReaLTaiizor.Controls.MaterialButton();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.flpDanhSachSanPhamOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlChonChucNang = new System.Windows.Forms.Panel();
            this.btnOrders = new ReaLTaiizor.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlThongTinBanDat = new System.Windows.Forms.Panel();
            this.lblThoiGianVaoBan = new System.Windows.Forms.Label();
            this.btnXemHoaDon = new ReaLTaiizor.Controls.MaterialButton();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblSoMon = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongTien2 = new System.Windows.Forms.Label();
            this.lblTinhTrangBan = new System.Windows.Forms.Label();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.pnlForm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlChonChucNang.SuspendLayout();
            this.pnlThongTinBanDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoBan
            // 
            this.btnMoBan.AutoSize = false;
            this.btnMoBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMoBan.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnMoBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoBan.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMoBan.Depth = 0;
            this.btnMoBan.HighEmphasis = true;
            this.btnMoBan.Icon = null;
            this.btnMoBan.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnMoBan.Location = new System.Drawing.Point(22, 49);
            this.btnMoBan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnMoBan.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnMoBan.Name = "btnMoBan";
            this.btnMoBan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMoBan.Size = new System.Drawing.Size(325, 44);
            this.btnMoBan.TabIndex = 69;
            this.btnMoBan.Text = "Mở Bàn";
            this.btnMoBan.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMoBan.UseAccentColor = false;
            this.btnMoBan.UseVisualStyleBackColor = true;
            this.btnMoBan.Click += new System.EventHandler(this.btnMoBan_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlForm.Controls.Add(this.flpDanhSachSanPhamOrder);
            this.pnlForm.Controls.Add(this.panel3);
            this.pnlForm.Controls.Add(this.lblTinhTrangBan);
            this.pnlForm.Controls.Add(this.lblTenBan);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(3, 64);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1170, 640);
            this.pnlForm.TabIndex = 69;
            // 
            // flpDanhSachSanPhamOrder
            // 
            this.flpDanhSachSanPhamOrder.AutoScroll = true;
            this.flpDanhSachSanPhamOrder.BackColor = System.Drawing.Color.Transparent;
            this.flpDanhSachSanPhamOrder.Location = new System.Drawing.Point(28, 101);
            this.flpDanhSachSanPhamOrder.Name = "flpDanhSachSanPhamOrder";
            this.flpDanhSachSanPhamOrder.Size = new System.Drawing.Size(704, 484);
            this.flpDanhSachSanPhamOrder.TabIndex = 76;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pnlChonChucNang);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pnlThongTinBanDat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(762, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 640);
            this.panel3.TabIndex = 75;
            // 
            // pnlChonChucNang
            // 
            this.pnlChonChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlChonChucNang.Controls.Add(this.btnMoBan);
            this.pnlChonChucNang.Controls.Add(this.btnOrders);
            this.pnlChonChucNang.Location = new System.Drawing.Point(22, 101);
            this.pnlChonChucNang.Name = "pnlChonChucNang";
            this.pnlChonChucNang.Size = new System.Drawing.Size(369, 147);
            this.pnlChonChucNang.TabIndex = 75;
            // 
            // btnOrders
            // 
            this.btnOrders.AutoSize = false;
            this.btnOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrders.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOrders.Depth = 0;
            this.btnOrders.HighEmphasis = true;
            this.btnOrders.Icon = null;
            this.btnOrders.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnOrders.Location = new System.Drawing.Point(22, 49);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnOrders.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOrders.Size = new System.Drawing.Size(325, 44);
            this.btnOrders.TabIndex = 69;
            this.btnOrders.Text = "Orders";
            this.btnOrders.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOrders.UseAccentColor = false;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tổng Quan";
            // 
            // pnlThongTinBanDat
            // 
            this.pnlThongTinBanDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlThongTinBanDat.Controls.Add(this.lblThoiGianVaoBan);
            this.pnlThongTinBanDat.Controls.Add(this.btnXemHoaDon);
            this.pnlThongTinBanDat.Controls.Add(this.lblThanhTien);
            this.pnlThongTinBanDat.Controls.Add(this.lblSoMon);
            this.pnlThongTinBanDat.Controls.Add(this.lblTongTien);
            this.pnlThongTinBanDat.Controls.Add(this.label2);
            this.pnlThongTinBanDat.Controls.Add(this.label3);
            this.pnlThongTinBanDat.Controls.Add(this.lblTongTien2);
            this.pnlThongTinBanDat.Location = new System.Drawing.Point(22, 277);
            this.pnlThongTinBanDat.Name = "pnlThongTinBanDat";
            this.pnlThongTinBanDat.Size = new System.Drawing.Size(369, 308);
            this.pnlThongTinBanDat.TabIndex = 74;
            // 
            // lblThoiGianVaoBan
            // 
            this.lblThoiGianVaoBan.AutoSize = true;
            this.lblThoiGianVaoBan.Font = new System.Drawing.Font("Arial", 10.8F);
            this.lblThoiGianVaoBan.Location = new System.Drawing.Point(18, 10);
            this.lblThoiGianVaoBan.Name = "lblThoiGianVaoBan";
            this.lblThoiGianVaoBan.Size = new System.Drawing.Size(161, 21);
            this.lblThoiGianVaoBan.TabIndex = 71;
            this.lblThoiGianVaoBan.Text = "Thời gian vào bàn:";
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.AutoSize = false;
            this.btnXemHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXemHoaDon.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnXemHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemHoaDon.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnXemHoaDon.Depth = 0;
            this.btnXemHoaDon.HighEmphasis = true;
            this.btnXemHoaDon.Icon = null;
            this.btnXemHoaDon.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnXemHoaDon.Location = new System.Drawing.Point(21, 180);
            this.btnXemHoaDon.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnXemHoaDon.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnXemHoaDon.Size = new System.Drawing.Size(325, 44);
            this.btnXemHoaDon.TabIndex = 69;
            this.btnXemHoaDon.Text = "Xem Hóa Đơn";
            this.btnXemHoaDon.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXemHoaDon.UseAccentColor = false;
            this.btnXemHoaDon.UseVisualStyleBackColor = true;
            this.btnXemHoaDon.Click += new System.EventHandler(this.btnXemHoaDon_Click);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Arial", 10.8F);
            this.lblThanhTien.Location = new System.Drawing.Point(232, 123);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(57, 21);
            this.lblThanhTien.TabIndex = 71;
            this.lblThanhTien.Text = "0VNĐ";
            // 
            // lblSoMon
            // 
            this.lblSoMon.AutoSize = true;
            this.lblSoMon.Font = new System.Drawing.Font("Arial", 10.8F);
            this.lblSoMon.Location = new System.Drawing.Point(232, 83);
            this.lblSoMon.Name = "lblSoMon";
            this.lblSoMon.Size = new System.Drawing.Size(20, 21);
            this.lblSoMon.TabIndex = 71;
            this.lblSoMon.Text = "0";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Arial", 10.8F);
            this.lblTongTien.Location = new System.Drawing.Point(233, 46);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(57, 21);
            this.lblTongTien.TabIndex = 71;
            this.lblTongTien.Text = "0VNĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F);
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "Số món:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F);
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 71;
            this.label3.Text = "Thành tiền: ";
            // 
            // lblTongTien2
            // 
            this.lblTongTien2.AutoSize = true;
            this.lblTongTien2.Font = new System.Drawing.Font("Arial", 10.8F);
            this.lblTongTien2.Location = new System.Drawing.Point(18, 46);
            this.lblTongTien2.Name = "lblTongTien2";
            this.lblTongTien2.Size = new System.Drawing.Size(96, 21);
            this.lblTongTien2.TabIndex = 71;
            this.lblTongTien2.Text = "Tổng tiền: ";
            // 
            // lblTinhTrangBan
            // 
            this.lblTinhTrangBan.AutoSize = true;
            this.lblTinhTrangBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrangBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.lblTinhTrangBan.Location = new System.Drawing.Point(24, 63);
            this.lblTinhTrangBan.Name = "lblTinhTrangBan";
            this.lblTinhTrangBan.Size = new System.Drawing.Size(205, 23);
            this.lblTinhTrangBan.TabIndex = 71;
            this.lblTinhTrangBan.Text = "Tình trạng: đang trống";
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblTenBan.Location = new System.Drawing.Point(20, 27);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(183, 27);
            this.lblTenBan.TabIndex = 70;
            this.lblTenBan.Text = "Tên Bàn: Bàn 1";
            // 
            // ChiTietBanForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1176, 710);
            this.Controls.Add(this.pnlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChiTietBanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChiTietBanForm_FormClosing);
            this.Load += new System.EventHandler(this.ChiTietBanForm_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlChonChucNang.ResumeLayout(false);
            this.pnlThongTinBanDat.ResumeLayout(false);
            this.pnlThongTinBanDat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton btnMoBan;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThoiGianVaoBan;
        private ReaLTaiizor.Controls.MaterialButton btnXemHoaDon;
        private ReaLTaiizor.Controls.MaterialButton btnOrders;
        private System.Windows.Forms.Label lblTongTien2;
        private System.Windows.Forms.Panel pnlThongTinBanDat;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTinhTrangBan;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSoMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSachSanPhamOrder;
        private System.Windows.Forms.Panel pnlChonChucNang;
    }
}