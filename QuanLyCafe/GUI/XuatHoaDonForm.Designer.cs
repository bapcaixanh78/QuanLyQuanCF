namespace QuanLyCafe.GUI
{
    partial class XuatHoaDonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuatHoaDonForm));
            this.lblXuatHoaDon = new System.Windows.Forms.Label();
            this.pdcHoaDon = new System.Drawing.Printing.PrintDocument();
            this.ppdXemTruocHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblXuatHoaDon
            // 
            this.lblXuatHoaDon.AutoSize = true;
            this.lblXuatHoaDon.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXuatHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(189)))), ((int)(((byte)(166)))));
            this.lblXuatHoaDon.Location = new System.Drawing.Point(277, 90);
            this.lblXuatHoaDon.Name = "lblXuatHoaDon";
            this.lblXuatHoaDon.Size = new System.Drawing.Size(206, 35);
            this.lblXuatHoaDon.TabIndex = 75;
            this.lblXuatHoaDon.Text = "Xuất hóa đơn";
            // 
            // pdcHoaDon
            // 
            this.pdcHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdcHoaDon_PrintPage);
            // 
            // ppdXemTruocHoaDon
            // 
            this.ppdXemTruocHoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdXemTruocHoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdXemTruocHoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdXemTruocHoaDon.Enabled = true;
            this.ppdXemTruocHoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdXemTruocHoaDon.Icon")));
            this.ppdXemTruocHoaDon.Name = "ppdXemTruocHoaDon";
            this.ppdXemTruocHoaDon.Visible = false;
            // 
            // XuatHoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblXuatHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XuatHoaDonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXuatHoaDon;
        private System.Drawing.Printing.PrintDocument pdcHoaDon;
        private System.Windows.Forms.PrintPreviewDialog ppdXemTruocHoaDon;
    }
}