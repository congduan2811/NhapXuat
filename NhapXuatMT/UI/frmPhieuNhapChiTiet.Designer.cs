
namespace NhapXuatMT.UI
{
    partial class frmPhieuNhapChiTiet
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
            this.dtpkNgayDuTru = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNguoiLapPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNVgiao = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.txtIDPhieuNhap = new System.Windows.Forms.TextBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChiTietPhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpkNgayDuTru
            // 
            this.dtpkNgayDuTru.Location = new System.Drawing.Point(104, 59);
            this.dtpkNgayDuTru.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkNgayDuTru.Name = "dtpkNgayDuTru";
            this.dtpkNgayDuTru.Size = new System.Drawing.Size(122, 20);
            this.dtpkNgayDuTru.TabIndex = 14;
            // 
            // dtpkNgayNhap
            // 
            this.dtpkNgayNhap.Location = new System.Drawing.Point(104, 32);
            this.dtpkNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkNgayNhap.Name = "dtpkNgayNhap";
            this.dtpkNgayNhap.Size = new System.Drawing.Size(122, 20);
            this.dtpkNgayNhap.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(894, 64);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(58, 25);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNguoiLapPhieu
            // 
            this.txtNguoiLapPhieu.Location = new System.Drawing.Point(358, 57);
            this.txtNguoiLapPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtNguoiLapPhieu.MaxLength = 50;
            this.txtNguoiLapPhieu.Name = "txtNguoiLapPhieu";
            this.txtNguoiLapPhieu.Size = new System.Drawing.Size(122, 20);
            this.txtNguoiLapPhieu.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Người lập phiếu:";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(358, 34);
            this.txtNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtNCC.MaxLength = 50;
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(122, 20);
            this.txtNCC.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên nhà cung cấp:";
            // 
            // txtNVgiao
            // 
            this.txtNVgiao.Location = new System.Drawing.Point(358, 11);
            this.txtNVgiao.Margin = new System.Windows.Forms.Padding(2);
            this.txtNVgiao.MaxLength = 50;
            this.txtNVgiao.Name = "txtNVgiao";
            this.txtNVgiao.Size = new System.Drawing.Size(122, 20);
            this.txtNVgiao.TabIndex = 7;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(20, 57);
            this.txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(65, 13);
            this.txt.TabIndex = 4;
            this.txt.Text = "Ngày dự trù:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhân viên giao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày Nhập:";
            // 
            // dgrvChiTietPhieuNhap
            // 
            this.dgrvChiTietPhieuNhap.AllowUserToOrderColumns = true;
            this.dgrvChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvChiTietPhieuNhap.Location = new System.Drawing.Point(0, 93);
            this.dgrvChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgrvChiTietPhieuNhap.Name = "dgrvChiTietPhieuNhap";
            this.dgrvChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dgrvChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvChiTietPhieuNhap.Size = new System.Drawing.Size(1060, 460);
            this.dgrvChiTietPhieuNhap.TabIndex = 0;
            // 
            // txtIDPhieuNhap
            // 
            this.txtIDPhieuNhap.Location = new System.Drawing.Point(104, 9);
            this.txtIDPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDPhieuNhap.MaxLength = 10;
            this.txtIDPhieuNhap.Name = "txtIDPhieuNhap";
            this.txtIDPhieuNhap.ReadOnly = true;
            this.txtIDPhieuNhap.Size = new System.Drawing.Size(122, 20);
            this.txtIDPhieuNhap.TabIndex = 1;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.AutoSize = true;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(20, 11);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(77, 13);
            this.txtMaPhieuNhap.TabIndex = 0;
            this.txtMaPhieuNhap.Text = "ID phiếu nhập:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dtpkNgayDuTru);
            this.panel1.Controls.Add(this.dtpkNgayNhap);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtNguoiLapPhieu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNCC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNVgiao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIDPhieuNhap);
            this.panel1.Controls.Add(this.txtMaPhieuNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 93);
            this.panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1000, 64);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 25);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPhieuNhapChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 553);
            this.Controls.Add(this.dgrvChiTietPhieuNhap);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhieuNhapChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPhieuNhapChiTiet";
            this.Load += new System.EventHandler(this.frmPhieuNhapChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChiTietPhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpkNgayDuTru;
        private System.Windows.Forms.DateTimePicker dtpkNgayNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNguoiLapPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNVgiao;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrvChiTietPhieuNhap;
        private System.Windows.Forms.TextBox txtIDPhieuNhap;
        private System.Windows.Forms.Label txtMaPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
    }
}