namespace QuanLyCafe.GUI
{
    partial class ReportViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewForm));
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnTaoBaoCao = new ReaLTaiizor.Controls.MaterialButton();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvBaoCao
            // 
            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "QuanLyCafe.rptBaoCaoDoanhThuHoaDon.rdlc";
            this.rpvBaoCao.Location = new System.Drawing.Point(23, 110);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.ServerReport.BearerToken = null;
            this.rpvBaoCao.Size = new System.Drawing.Size(794, 281);
            this.rpvBaoCao.TabIndex = 0;
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
            this.btnTaoBaoCao.Location = new System.Drawing.Point(236, 26);
            this.btnTaoBaoCao.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnTaoBaoCao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTaoBaoCao.Size = new System.Drawing.Size(362, 44);
            this.btnTaoBaoCao.TabIndex = 10;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTaoBaoCao.UseAccentColor = false;
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlForm.Controls.Add(this.rpvBaoCao);
            this.pnlForm.Controls.Add(this.btnTaoBaoCao);
            this.pnlForm.Location = new System.Drawing.Point(54, 79);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(844, 408);
            this.pnlForm.TabIndex = 11;
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 510);
            this.Controls.Add(this.pnlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportViewForm_FormClosing);
            this.Load += new System.EventHandler(this.ReportViewForm_Load);
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
        private ReaLTaiizor.Controls.MaterialButton btnTaoBaoCao;
        private System.Windows.Forms.Panel pnlForm;
    }
}