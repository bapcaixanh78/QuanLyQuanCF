namespace QuanLyCafe.GUI
{
    partial class ChinhSuaHeThongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSuaHeThongForm));
            this.pnlForm = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlChinhSuaHeThong = new System.Windows.Forms.Panel();
            this.btnLuu = new ReaLTaiizor.Controls.MaterialButton();
            this.txtLuongPartTime = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDiaChiCuaHang = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtTenCuaHang = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlForm.SuspendLayout();
            this.pnlChinhSuaHeThong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.label15);
            this.pnlForm.Controls.Add(this.pnlChinhSuaHeThong);
            this.pnlForm.Location = new System.Drawing.Point(37, 86);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(728, 628);
            this.pnlForm.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(16, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(247, 27);
            this.label15.TabIndex = 75;
            this.label15.Text = "Chỉnh Sửa Hệ Thống";
            // 
            // pnlChinhSuaHeThong
            // 
            this.pnlChinhSuaHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlChinhSuaHeThong.Controls.Add(this.btnLuu);
            this.pnlChinhSuaHeThong.Controls.Add(this.txtLuongPartTime);
            this.pnlChinhSuaHeThong.Controls.Add(this.txtDiaChiCuaHang);
            this.pnlChinhSuaHeThong.Controls.Add(this.txtTenCuaHang);
            this.pnlChinhSuaHeThong.Controls.Add(this.label10);
            this.pnlChinhSuaHeThong.Controls.Add(this.label9);
            this.pnlChinhSuaHeThong.Controls.Add(this.label8);
            this.pnlChinhSuaHeThong.Location = new System.Drawing.Point(94, 82);
            this.pnlChinhSuaHeThong.Name = "pnlChinhSuaHeThong";
            this.pnlChinhSuaHeThong.Size = new System.Drawing.Size(557, 517);
            this.pnlChinhSuaHeThong.TabIndex = 74;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = false;
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.BackColor = System.Drawing.Color.DimGray;
            this.btnLuu.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnLuu.Location = new System.Drawing.Point(30, 333);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnLuu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(504, 44);
            this.btnLuu.TabIndex = 74;
            this.btnLuu.Text = "Save changes";
            this.btnLuu.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtLuongPartTime
            // 
            this.txtLuongPartTime.AnimateReadOnly = false;
            this.txtLuongPartTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLuongPartTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLuongPartTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLuongPartTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLuongPartTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuongPartTime.Depth = 0;
            this.txtLuongPartTime.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtLuongPartTime.HideSelection = true;
            this.txtLuongPartTime.LeadingIcon = null;
            this.txtLuongPartTime.Location = new System.Drawing.Point(28, 267);
            this.txtLuongPartTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuongPartTime.MaxLength = 50;
            this.txtLuongPartTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtLuongPartTime.Name = "txtLuongPartTime";
            this.txtLuongPartTime.PasswordChar = '\0';
            this.txtLuongPartTime.PrefixSuffixText = null;
            this.txtLuongPartTime.ReadOnly = false;
            this.txtLuongPartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLuongPartTime.SelectedText = "";
            this.txtLuongPartTime.SelectionLength = 0;
            this.txtLuongPartTime.SelectionStart = 0;
            this.txtLuongPartTime.ShortcutsEnabled = true;
            this.txtLuongPartTime.Size = new System.Drawing.Size(505, 36);
            this.txtLuongPartTime.TabIndex = 73;
            this.txtLuongPartTime.TabStop = false;
            this.txtLuongPartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLuongPartTime.TrailingIcon = null;
            this.txtLuongPartTime.UseSystemPasswordChar = false;
            this.txtLuongPartTime.UseTallSize = false;
            this.txtLuongPartTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongPartTime_KeyPress);
            // 
            // txtDiaChiCuaHang
            // 
            this.txtDiaChiCuaHang.AnimateReadOnly = false;
            this.txtDiaChiCuaHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDiaChiCuaHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDiaChiCuaHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDiaChiCuaHang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiaChiCuaHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiCuaHang.Depth = 0;
            this.txtDiaChiCuaHang.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtDiaChiCuaHang.HideSelection = true;
            this.txtDiaChiCuaHang.LeadingIcon = null;
            this.txtDiaChiCuaHang.Location = new System.Drawing.Point(28, 179);
            this.txtDiaChiCuaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiCuaHang.MaxLength = 50;
            this.txtDiaChiCuaHang.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDiaChiCuaHang.Name = "txtDiaChiCuaHang";
            this.txtDiaChiCuaHang.PasswordChar = '\0';
            this.txtDiaChiCuaHang.PrefixSuffixText = null;
            this.txtDiaChiCuaHang.ReadOnly = false;
            this.txtDiaChiCuaHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiaChiCuaHang.SelectedText = "";
            this.txtDiaChiCuaHang.SelectionLength = 0;
            this.txtDiaChiCuaHang.SelectionStart = 0;
            this.txtDiaChiCuaHang.ShortcutsEnabled = true;
            this.txtDiaChiCuaHang.Size = new System.Drawing.Size(505, 36);
            this.txtDiaChiCuaHang.TabIndex = 73;
            this.txtDiaChiCuaHang.TabStop = false;
            this.txtDiaChiCuaHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiaChiCuaHang.TrailingIcon = null;
            this.txtDiaChiCuaHang.UseSystemPasswordChar = false;
            this.txtDiaChiCuaHang.UseTallSize = false;
            // 
            // txtTenCuaHang
            // 
            this.txtTenCuaHang.AnimateReadOnly = false;
            this.txtTenCuaHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenCuaHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenCuaHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenCuaHang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenCuaHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenCuaHang.Depth = 0;
            this.txtTenCuaHang.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtTenCuaHang.HideSelection = true;
            this.txtTenCuaHang.LeadingIcon = null;
            this.txtTenCuaHang.Location = new System.Drawing.Point(28, 104);
            this.txtTenCuaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCuaHang.MaxLength = 50;
            this.txtTenCuaHang.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTenCuaHang.Name = "txtTenCuaHang";
            this.txtTenCuaHang.PasswordChar = '\0';
            this.txtTenCuaHang.PrefixSuffixText = null;
            this.txtTenCuaHang.ReadOnly = false;
            this.txtTenCuaHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenCuaHang.SelectedText = "";
            this.txtTenCuaHang.SelectionLength = 0;
            this.txtTenCuaHang.SelectionStart = 0;
            this.txtTenCuaHang.ShortcutsEnabled = true;
            this.txtTenCuaHang.Size = new System.Drawing.Size(505, 36);
            this.txtTenCuaHang.TabIndex = 73;
            this.txtTenCuaHang.TabStop = false;
            this.txtTenCuaHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenCuaHang.TrailingIcon = null;
            this.txtTenCuaHang.UseSystemPasswordChar = false;
            this.txtTenCuaHang.UseTallSize = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(25, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 21);
            this.label10.TabIndex = 71;
            this.label10.Text = "Lương part time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(24, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 21);
            this.label9.TabIndex = 71;
            this.label9.Text = "Địa chỉ cửa hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 21);
            this.label8.TabIndex = 71;
            this.label8.Text = "Tên cửa hàng";
            // 
            // ChinhSuaHeThongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 766);
            this.Controls.Add(this.pnlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChinhSuaHeThongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChinhSuaHeThongForm_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlChinhSuaHeThong.ResumeLayout(false);
            this.pnlChinhSuaHeThong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlChinhSuaHeThong;
        private ReaLTaiizor.Controls.MaterialButton btnLuu;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDiaChiCuaHang;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTenCuaHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLuongPartTime;
    }
}