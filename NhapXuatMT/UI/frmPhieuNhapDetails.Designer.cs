
namespace NhapXuatMT.UI
{
    partial class frmPhieuNhapDetails
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
            this.txtIDCTPN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtIDSP = new System.Windows.Forms.TextBox();
            this.txtSLTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSLDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThemCTPN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIDCTPN
            // 
            this.txtIDCTPN.Location = new System.Drawing.Point(220, 25);
            this.txtIDCTPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDCTPN.MaxLength = 9;
            this.txtIDCTPN.Name = "txtIDCTPN";
            this.txtIDCTPN.ReadOnly = true;
            this.txtIDCTPN.Size = new System.Drawing.Size(267, 22);
            this.txtIDCTPN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID phiếu nhập:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(220, 59);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.MaxLength = 50;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(267, 22);
            this.txtTenSP.TabIndex = 2;
            // 
            // txtIDSP
            // 
            this.txtIDSP.Location = new System.Drawing.Point(220, 90);
            this.txtIDSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDSP.MaxLength = 9;
            this.txtIDSP.Name = "txtIDSP";
            this.txtIDSP.Size = new System.Drawing.Size(267, 22);
            this.txtIDSP.TabIndex = 3;
            // 
            // txtSLTT
            // 
            this.txtSLTT.Location = new System.Drawing.Point(220, 182);
            this.txtSLTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSLTT.MaxLength = 9;
            this.txtSLTT.Name = "txtSLTT";
            this.txtSLTT.Size = new System.Drawing.Size(267, 22);
            this.txtSLTT.TabIndex = 6;
            this.txtSLTT.TextChanged += new System.EventHandler(this.txtSLTT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số lượng thực tế:";
            // 
            // txtSLDT
            // 
            this.txtSLDT.Location = new System.Drawing.Point(220, 154);
            this.txtSLDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSLDT.MaxLength = 9;
            this.txtSLDT.Name = "txtSLDT";
            this.txtSLDT.Size = new System.Drawing.Size(267, 22);
            this.txtSLDT.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Số lượng dự trù:";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(220, 126);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDVT.MaxLength = 50;
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(267, 22);
            this.txtDVT.TabIndex = 4;
            this.txtDVT.TextChanged += new System.EventHandler(this.txtDVT_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Đơn vị tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên sản phẩm:";
            // 
            // btnThemCTPN
            // 
            this.btnThemCTPN.Location = new System.Drawing.Point(389, 228);
            this.btnThemCTPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCTPN.Name = "btnThemCTPN";
            this.btnThemCTPN.Size = new System.Drawing.Size(77, 31);
            this.btnThemCTPN.TabIndex = 7;
            this.btnThemCTPN.Text = "Thêm";
            this.btnThemCTPN.UseVisualStyleBackColor = true;
            this.btnThemCTPN.Click += new System.EventHandler(this.btnThemCTPN_Click);
            // 
            // frmPhieuNhapDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 343);
            this.Controls.Add(this.btnThemCTPN);
            this.Controls.Add(this.txtIDCTPN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtIDSP);
            this.Controls.Add(this.txtSLTT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSLDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuNhapDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPhieuNhapDetails";
            this.Load += new System.EventHandler(this.frmPhieuNhapDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDCTPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtIDSP;
        private System.Windows.Forms.TextBox txtSLTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSLDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThemCTPN;
    }
}