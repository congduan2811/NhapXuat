﻿namespace NhapXuatMT.UI
{
    partial class fmThongke
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
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.grpthongke = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.btnThongke = new System.Windows.Forms.Button();
            this.rdbPN = new System.Windows.Forms.RadioButton();
            this.txtTongSL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.grpthongke.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTK
            // 
            this.dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Location = new System.Drawing.Point(1, 247);
            this.dgvTK.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.ReadOnly = true;
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.Size = new System.Drawing.Size(962, 236);
            this.dgvTK.TabIndex = 50;
            // 
            // grpthongke
            // 
            this.grpthongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpthongke.Controls.Add(this.label4);
            this.grpthongke.Controls.Add(this.txtTongSL);
            this.grpthongke.Controls.Add(this.panel1);
            this.grpthongke.Controls.Add(this.btnThongke);
            this.grpthongke.Controls.Add(this.rdbPN);
            this.grpthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpthongke.Location = new System.Drawing.Point(1, 2);
            this.grpthongke.Margin = new System.Windows.Forms.Padding(4);
            this.grpthongke.Name = "grpthongke";
            this.grpthongke.Padding = new System.Windows.Forms.Padding(4);
            this.grpthongke.Size = new System.Drawing.Size(962, 247);
            this.grpthongke.TabIndex = 49;
            this.grpthongke.TabStop = false;
            this.grpthongke.Text = "Thống kê";
            this.grpthongke.Enter += new System.EventHandler(this.grpthongke_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp2);
            this.panel1.Location = new System.Drawing.Point(7, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 118);
            this.panel1.TabIndex = 48;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "dd-MM-yyyy";
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(257, 14);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(121, 27);
            this.dtp1.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(142, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(142, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Kết thúc";
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "dd-MM-yyyy";
            this.dtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(257, 74);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(121, 27);
            this.dtp2.TabIndex = 45;
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.LightBlue;
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThongke.Location = new System.Drawing.Point(145, 181);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(121, 42);
            this.btnThongke.TabIndex = 18;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click_1);
            // 
            // rdbPN
            // 
            this.rdbPN.AutoSize = true;
            this.rdbPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdbPN.Location = new System.Drawing.Point(651, 55);
            this.rdbPN.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPN.Name = "rdbPN";
            this.rdbPN.Size = new System.Drawing.Size(128, 28);
            this.rdbPN.TabIndex = 28;
            this.rdbPN.TabStop = true;
            this.rdbPN.Text = "Phiếu nhập";
            this.rdbPN.UseVisualStyleBackColor = true;
            // 
            // txtTongSL
            // 
            this.txtTongSL.Location = new System.Drawing.Point(812, 204);
            this.txtTongSL.Name = "txtTongSL";
            this.txtTongSL.Size = new System.Drawing.Size(100, 34);
            this.txtTongSL.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tong sl:";
            // 
            // fmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 484);
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.grpthongke);
            this.Name = "fmThongke";
            this.Text = "fmThongke";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.grpthongke.ResumeLayout(false);
            this.grpthongke.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.GroupBox grpthongke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.RadioButton rdbPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongSL;
    }
}