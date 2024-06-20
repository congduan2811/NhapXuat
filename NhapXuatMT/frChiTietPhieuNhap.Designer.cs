namespace NhapXuatMT
{
    partial class frChiTietPhieuNhap
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaPhieuNhap = new System.Windows.Forms.Label();
            this.txtIDPhieuNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.txtNVgiao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNguoiLapPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgrvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.nHAPXUATMAYTINHDataSet = new NhapXuatMT.NHAPXUATMAYTINHDataSet();
            this.cHITIETPHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETPHIEUNHAPTableAdapter = new NhapXuatMT.NHAPXUATMAYTINHDataSetTableAdapters.CHITIETPHIEUNHAPTableAdapter();
            this.iDPHIEUNHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSANPHAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONVITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDUTRUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGTHUCTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpkNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgayDuTru = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPXUATMAYTINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETPHIEUNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 114);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgrvChiTietPhieuNhap);
            this.panel2.Location = new System.Drawing.Point(2, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 236);
            this.panel2.TabIndex = 1;
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
            // txtIDPhieuNhap
            // 
            this.txtIDPhieuNhap.Location = new System.Drawing.Point(139, 11);
            this.txtIDPhieuNhap.Name = "txtIDPhieuNhap";
            this.txtIDPhieuNhap.Size = new System.Drawing.Size(162, 22);
            this.txtIDPhieuNhap.TabIndex = 1;
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
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(27, 70);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(86, 17);
            this.txt.TabIndex = 4;
            this.txt.Text = "Ngày dự trù:";
            // 
            // txtNVgiao
            // 
            this.txtNVgiao.Location = new System.Drawing.Point(478, 14);
            this.txtNVgiao.Name = "txtNVgiao";
            this.txtNVgiao.Size = new System.Drawing.Size(162, 22);
            this.txtNVgiao.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên nhân viên giao:";
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(478, 42);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(162, 22);
            this.txtNCC.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên nhà cung cấp:";
            // 
            // txtNguoiLapPhieu
            // 
            this.txtNguoiLapPhieu.Location = new System.Drawing.Point(478, 70);
            this.txtNguoiLapPhieu.Name = "txtNguoiLapPhieu";
            this.txtNguoiLapPhieu.Size = new System.Drawing.Size(162, 22);
            this.txtNguoiLapPhieu.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Người lập phiếu:";
            // 
            // dgrvChiTietPhieuNhap
            // 
            this.dgrvChiTietPhieuNhap.AutoGenerateColumns = false;
            this.dgrvChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPHIEUNHAPDataGridViewTextBoxColumn,
            this.tENSANPHAMDataGridViewTextBoxColumn,
            this.iDSANPHAMDataGridViewTextBoxColumn,
            this.dONVITINHDataGridViewTextBoxColumn,
            this.sOLUONGDUTRUDataGridViewTextBoxColumn,
            this.sOLUONGTHUCTEDataGridViewTextBoxColumn});
            this.dgrvChiTietPhieuNhap.DataSource = this.cHITIETPHIEUNHAPBindingSource;
            this.dgrvChiTietPhieuNhap.Location = new System.Drawing.Point(0, 3);
            this.dgrvChiTietPhieuNhap.Name = "dgrvChiTietPhieuNhap";
            this.dgrvChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dgrvChiTietPhieuNhap.Size = new System.Drawing.Size(794, 230);
            this.dgrvChiTietPhieuNhap.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(661, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 31);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nHAPXUATMAYTINHDataSet
            // 
            this.nHAPXUATMAYTINHDataSet.DataSetName = "NHAPXUATMAYTINHDataSet";
            this.nHAPXUATMAYTINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHITIETPHIEUNHAPBindingSource
            // 
            this.cHITIETPHIEUNHAPBindingSource.DataMember = "CHITIETPHIEUNHAP";
            this.cHITIETPHIEUNHAPBindingSource.DataSource = this.nHAPXUATMAYTINHDataSet;
            // 
            // cHITIETPHIEUNHAPTableAdapter
            // 
            this.cHITIETPHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // iDPHIEUNHAPDataGridViewTextBoxColumn
            // 
            this.iDPHIEUNHAPDataGridViewTextBoxColumn.DataPropertyName = "IDPHIEUNHAP";
            this.iDPHIEUNHAPDataGridViewTextBoxColumn.HeaderText = "IDPHIEUNHAP";
            this.iDPHIEUNHAPDataGridViewTextBoxColumn.Name = "iDPHIEUNHAPDataGridViewTextBoxColumn";
            // 
            // tENSANPHAMDataGridViewTextBoxColumn
            // 
            this.tENSANPHAMDataGridViewTextBoxColumn.DataPropertyName = "TENSANPHAM";
            this.tENSANPHAMDataGridViewTextBoxColumn.HeaderText = "TENSANPHAM";
            this.tENSANPHAMDataGridViewTextBoxColumn.Name = "tENSANPHAMDataGridViewTextBoxColumn";
            // 
            // iDSANPHAMDataGridViewTextBoxColumn
            // 
            this.iDSANPHAMDataGridViewTextBoxColumn.DataPropertyName = "IDSANPHAM";
            this.iDSANPHAMDataGridViewTextBoxColumn.HeaderText = "IDSANPHAM";
            this.iDSANPHAMDataGridViewTextBoxColumn.Name = "iDSANPHAMDataGridViewTextBoxColumn";
            // 
            // dONVITINHDataGridViewTextBoxColumn
            // 
            this.dONVITINHDataGridViewTextBoxColumn.DataPropertyName = "DONVITINH";
            this.dONVITINHDataGridViewTextBoxColumn.HeaderText = "DONVITINH";
            this.dONVITINHDataGridViewTextBoxColumn.Name = "dONVITINHDataGridViewTextBoxColumn";
            // 
            // sOLUONGDUTRUDataGridViewTextBoxColumn
            // 
            this.sOLUONGDUTRUDataGridViewTextBoxColumn.DataPropertyName = "SOLUONGDUTRU";
            this.sOLUONGDUTRUDataGridViewTextBoxColumn.HeaderText = "SOLUONGDUTRU";
            this.sOLUONGDUTRUDataGridViewTextBoxColumn.Name = "sOLUONGDUTRUDataGridViewTextBoxColumn";
            // 
            // sOLUONGTHUCTEDataGridViewTextBoxColumn
            // 
            this.sOLUONGTHUCTEDataGridViewTextBoxColumn.DataPropertyName = "SOLUONGTHUCTE";
            this.sOLUONGTHUCTEDataGridViewTextBoxColumn.HeaderText = "SOLUONGTHUCTE";
            this.sOLUONGTHUCTEDataGridViewTextBoxColumn.Name = "sOLUONGTHUCTEDataGridViewTextBoxColumn";
            // 
            // dtpkNgayNhap
            // 
            this.dtpkNgayNhap.Location = new System.Drawing.Point(139, 40);
            this.dtpkNgayNhap.Name = "dtpkNgayNhap";
            this.dtpkNgayNhap.Size = new System.Drawing.Size(162, 22);
            this.dtpkNgayNhap.TabIndex = 13;
            // 
            // dtpkNgayDuTru
            // 
            this.dtpkNgayDuTru.Location = new System.Drawing.Point(139, 73);
            this.dtpkNgayDuTru.Name = "dtpkNgayDuTru";
            this.dtpkNgayDuTru.Size = new System.Drawing.Size(162, 22);
            this.dtpkNgayDuTru.TabIndex = 14;
            // 
            // frChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frChiTietPhieuNhap";
            this.Text = "frChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.frChiTietPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPXUATMAYTINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETPHIEUNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNguoiLapPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNVgiao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDPhieuNhap;
        private System.Windows.Forms.Label txtMaPhieuNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgrvChiTietPhieuNhap;
        private System.Windows.Forms.Button btnThem;
        private NHAPXUATMAYTINHDataSet nHAPXUATMAYTINHDataSet;
        private System.Windows.Forms.BindingSource cHITIETPHIEUNHAPBindingSource;
        private NHAPXUATMAYTINHDataSetTableAdapters.CHITIETPHIEUNHAPTableAdapter cHITIETPHIEUNHAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPHIEUNHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSANPHAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONVITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDUTRUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGTHUCTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpkNgayDuTru;
        private System.Windows.Forms.DateTimePicker dtpkNgayNhap;
    }
}