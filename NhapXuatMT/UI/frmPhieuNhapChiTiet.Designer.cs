
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNVgiao = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.txtIDPhieuNhap = new System.Windows.Forms.TextBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNLP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChiTietPhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpkNgayDuTru
            // 
            this.dtpkNgayDuTru.Location = new System.Drawing.Point(139, 73);
            this.dtpkNgayDuTru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkNgayDuTru.Name = "dtpkNgayDuTru";
            this.dtpkNgayDuTru.Size = new System.Drawing.Size(161, 22);
            this.dtpkNgayDuTru.TabIndex = 14;
            // 
            // dtpkNgayNhap
            // 
            this.dtpkNgayNhap.Location = new System.Drawing.Point(139, 39);
            this.dtpkNgayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkNgayNhap.Name = "dtpkNgayNhap";
            this.dtpkNgayNhap.Size = new System.Drawing.Size(161, 22);
            this.dtpkNgayNhap.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1192, 79);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 31);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Người lập phiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên nhà cung cấp:";
            // 
            // txtNVgiao
            // 
            this.txtNVgiao.Location = new System.Drawing.Point(477, 14);
            this.txtNVgiao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNVgiao.MaxLength = 50;
            this.txtNVgiao.Name = "txtNVgiao";
            this.txtNVgiao.Size = new System.Drawing.Size(161, 22);
            this.txtNVgiao.TabIndex = 7;
            this.txtNVgiao.TextChanged += new System.EventHandler(this.txtNVgiao_TextChanged);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(27, 70);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(86, 17);
            this.txt.TabIndex = 4;
            this.txt.Text = "Ngày dự trù:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhân viên giao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày Nhập:";
            // 
            // dgrvChiTietPhieuNhap
            // 
            this.dgrvChiTietPhieuNhap.AllowUserToOrderColumns = true;
            this.dgrvChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvChiTietPhieuNhap.Location = new System.Drawing.Point(0, 114);
            this.dgrvChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrvChiTietPhieuNhap.Name = "dgrvChiTietPhieuNhap";
            this.dgrvChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dgrvChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvChiTietPhieuNhap.Size = new System.Drawing.Size(1413, 567);
            this.dgrvChiTietPhieuNhap.TabIndex = 0;
            this.dgrvChiTietPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvChiTietPhieuNhap_CellContentClick);
            // 
            // txtIDPhieuNhap
            // 
            this.txtIDPhieuNhap.Location = new System.Drawing.Point(139, 11);
            this.txtIDPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDPhieuNhap.MaxLength = 10;
            this.txtIDPhieuNhap.Name = "txtIDPhieuNhap";
            this.txtIDPhieuNhap.ReadOnly = true;
            this.txtIDPhieuNhap.Size = new System.Drawing.Size(161, 22);
            this.txtIDPhieuNhap.TabIndex = 1;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.AutoSize = true;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(27, 14);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(100, 17);
            this.txtMaPhieuNhap.TabIndex = 0;
            this.txtMaPhieuNhap.Text = "ID phiếu nhập:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNLP);
            this.panel1.Controls.Add(this.cbNhaCungCap);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dtpkNgayDuTru);
            this.panel1.Controls.Add(this.dtpkNgayNhap);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNVgiao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIDPhieuNhap);
            this.panel1.Controls.Add(this.txtMaPhieuNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 114);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(477, 41);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(161, 24);
            this.cbNhaCungCap.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1333, 79);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNLP
            // 
            this.txtNLP.Location = new System.Drawing.Point(477, 70);
            this.txtNLP.Name = "txtNLP";
            this.txtNLP.Size = new System.Drawing.Size(161, 22);
            this.txtNLP.TabIndex = 17;
            // 
            // frmPhieuNhapChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 681);
            this.Controls.Add(this.dgrvChiTietPhieuNhap);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.TextBox txtNLP;
    }
}