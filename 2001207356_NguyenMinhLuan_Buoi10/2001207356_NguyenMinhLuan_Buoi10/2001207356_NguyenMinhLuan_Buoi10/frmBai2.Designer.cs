namespace _2001207356_NguyenMinhLuan_Buoi10
{
    partial class frmBai2
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
            this.grSinhVien = new System.Windows.Forms.GroupBox();
            this.txtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grLop = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.ckThemLop = new System.Windows.Forms.CheckBox();
            this.trv_DS = new System.Windows.Forms.TreeView();
            this.grSinhVien.SuspendLayout();
            this.grLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // grSinhVien
            // 
            this.grSinhVien.Controls.Add(this.btnSua);
            this.grSinhVien.Controls.Add(this.btnXoa);
            this.grSinhVien.Controls.Add(this.btnThemSV);
            this.grSinhVien.Controls.Add(this.txtNgaySinh);
            this.grSinhVien.Controls.Add(this.txtHoTen);
            this.grSinhVien.Controls.Add(this.cboLop);
            this.grSinhVien.Controls.Add(this.txtMSSV);
            this.grSinhVien.Controls.Add(this.label4);
            this.grSinhVien.Controls.Add(this.label6);
            this.grSinhVien.Controls.Add(this.label5);
            this.grSinhVien.Controls.Add(this.label3);
            this.grSinhVien.Location = new System.Drawing.Point(458, 29);
            this.grSinhVien.Name = "grSinhVien";
            this.grSinhVien.Size = new System.Drawing.Size(521, 193);
            this.grSinhVien.TabIndex = 9;
            this.grSinhVien.TabStop = false;
            this.grSinhVien.Text = "Thông tin sinh viên";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(85, 90);
            this.txtNgaySinh.Mask = "00/00/0000";
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(122, 20);
            this.txtNgaySinh.TabIndex = 2;
            this.txtNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(335, 28);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(172, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(335, 90);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(172, 21);
            this.cboLop.TabIndex = 1;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(85, 35);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(122, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "MSSV";
            // 
            // grLop
            // 
            this.grLop.Controls.Add(this.label2);
            this.grLop.Controls.Add(this.txtLop);
            this.grLop.Controls.Add(this.btnThemLop);
            this.grLop.Location = new System.Drawing.Point(458, 282);
            this.grLop.Name = "grLop";
            this.grLop.Size = new System.Drawing.Size(521, 99);
            this.grLop.TabIndex = 9;
            this.grLop.TabStop = false;
            this.grLop.Text = "Thông tin lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lớp";
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(407, 44);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(75, 23);
            this.btnThemLop.TabIndex = 12;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(60, 46);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(320, 20);
            this.txtLop.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(358, 141);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(240, 141);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(98, 141);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(75, 23);
            this.btnThemSV.TabIndex = 15;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // ckThemLop
            // 
            this.ckThemLop.AutoSize = true;
            this.ckThemLop.Location = new System.Drawing.Point(458, 244);
            this.ckThemLop.Name = "ckThemLop";
            this.ckThemLop.Size = new System.Drawing.Size(70, 17);
            this.ckThemLop.TabIndex = 10;
            this.ckThemLop.Text = "Thêm lớp";
            this.ckThemLop.UseVisualStyleBackColor = true;
            // 
            // trv_DS
            // 
            this.trv_DS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trv_DS.Location = new System.Drawing.Point(24, 29);
            this.trv_DS.Name = "trv_DS";
            this.trv_DS.Size = new System.Drawing.Size(415, 595);
            this.trv_DS.TabIndex = 11;
            this.trv_DS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_DS_AfterSelect);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 655);
            this.Controls.Add(this.trv_DS);
            this.Controls.Add(this.ckThemLop);
            this.Controls.Add(this.grLop);
            this.Controls.Add(this.grSinhVien);
            this.Name = "frmBai2";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.grSinhVien.ResumeLayout(false);
            this.grSinhVien.PerformLayout();
            this.grLop.ResumeLayout(false);
            this.grLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grSinhVien;
        private System.Windows.Forms.MaskedTextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.CheckBox ckThemLop;
        private System.Windows.Forms.TreeView trv_DS;
    }
}

