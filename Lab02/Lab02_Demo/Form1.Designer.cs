using System.Drawing;

namespace Lab02_Demo
{
    partial class frmTrungTam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrungTam));
            this.Heading = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.cbMaHV = new System.Windows.Forms.ComboBox();
            this.txtGioiTinh = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNgayDK = new System.Windows.Forms.Label();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.ckbTinA = new System.Windows.Forms.CheckBox();
            this.ckbTinB = new System.Windows.Forms.CheckBox();
            this.ckbAnhA = new System.Windows.Forms.CheckBox();
            this.ckbAnhB = new System.Windows.Forms.CheckBox();
            this.lblTienTHA = new System.Windows.Forms.Label();
            this.lblTienTHB = new System.Windows.Forms.Label();
            this.lblTienTAB = new System.Windows.Forms.Label();
            this.lblTienTAA = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.Color.Indigo;
            this.Heading.Location = new System.Drawing.Point(4, 11);
            this.Heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(580, 42);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "TÍNH TIỀN TIN HỌC TRUNG TÂM\r\n";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Heading.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaHV
            // 
            this.txtMaHV.AutoSize = true;
            this.txtMaHV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHV.Location = new System.Drawing.Point(16, 108);
            this.txtMaHV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(119, 23);
            this.txtMaHV.TabIndex = 2;
            this.txtMaHV.Text = "Mã Học Viên";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(16, 148);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(72, 23);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "Họ Tên";
            this.lbHoTen.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cbMaHV
            // 
            this.cbMaHV.FormattingEnabled = true;
            this.cbMaHV.Location = new System.Drawing.Point(169, 110);
            this.cbMaHV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaHV.Name = "cbMaHV";
            this.cbMaHV.Size = new System.Drawing.Size(121, 24);
            this.cbMaHV.TabIndex = 0;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.AutoSize = true;
            this.txtGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(300, 108);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(91, 23);
            this.txtGioiTinh.TabIndex = 2;
            this.txtGioiTinh.Text = "Giới Tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(404, 108);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(66, 25);
            this.rdNam.TabIndex = 1;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(485, 108);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(54, 25);
            this.rdNu.TabIndex = 2;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(169, 146);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(385, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.AutoSize = true;
            this.txtNgayDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDK.Location = new System.Drawing.Point(16, 183);
            this.txtNgayDK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(132, 23);
            this.txtNgayDK.TabIndex = 2;
            this.txtNgayDK.Text = "Ngày Đăng Ký";
            this.txtNgayDK.Click += new System.EventHandler(this.txtNgayDK_Click);
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Location = new System.Drawing.Point(169, 183);
            this.dtpNgayDangKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(265, 22);
            this.dtpNgayDangKy.TabIndex = 4;
            // 
            // ckbTinA
            // 
            this.ckbTinA.AutoSize = true;
            this.ckbTinA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTinA.Location = new System.Drawing.Point(89, 231);
            this.ckbTinA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbTinA.Name = "ckbTinA";
            this.ckbTinA.Size = new System.Drawing.Size(110, 25);
            this.ckbTinA.TabIndex = 5;
            this.ckbTinA.Text = "Tin Học A";
            this.ckbTinA.UseVisualStyleBackColor = true;
            // 
            // ckbTinB
            // 
            this.ckbTinB.AutoSize = true;
            this.ckbTinB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTinB.Location = new System.Drawing.Point(89, 265);
            this.ckbTinB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbTinB.Name = "ckbTinB";
            this.ckbTinB.Size = new System.Drawing.Size(110, 25);
            this.ckbTinB.TabIndex = 6;
            this.ckbTinB.Text = "Tin Học B";
            this.ckbTinB.UseVisualStyleBackColor = true;
            this.ckbTinB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbAnhA
            // 
            this.ckbAnhA.AutoSize = true;
            this.ckbAnhA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAnhA.Location = new System.Drawing.Point(89, 298);
            this.ckbAnhA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbAnhA.Name = "ckbAnhA";
            this.ckbAnhA.Size = new System.Drawing.Size(125, 25);
            this.ckbAnhA.TabIndex = 7;
            this.ckbAnhA.Text = "Tiếng Anh A";
            this.ckbAnhA.UseVisualStyleBackColor = true;
            this.ckbAnhA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbAnhB
            // 
            this.ckbAnhB.AutoSize = true;
            this.ckbAnhB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAnhB.Location = new System.Drawing.Point(89, 331);
            this.ckbAnhB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbAnhB.Name = "ckbAnhB";
            this.ckbAnhB.Size = new System.Drawing.Size(125, 25);
            this.ckbAnhB.TabIndex = 8;
            this.ckbAnhB.Text = "Tiếng Anh B";
            this.ckbAnhB.UseVisualStyleBackColor = true;
            this.ckbAnhB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblTienTHA
            // 
            this.lblTienTHA.AutoSize = true;
            this.lblTienTHA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTHA.Location = new System.Drawing.Point(400, 233);
            this.lblTienTHA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienTHA.Name = "lblTienTHA";
            this.lblTienTHA.Size = new System.Drawing.Size(112, 21);
            this.lblTienTHA.TabIndex = 2;
            this.lblTienTHA.Text = "300.000 đồng";
            // 
            // lblTienTHB
            // 
            this.lblTienTHB.AutoSize = true;
            this.lblTienTHB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTHB.Location = new System.Drawing.Point(400, 266);
            this.lblTienTHB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienTHB.Name = "lblTienTHB";
            this.lblTienTHB.Size = new System.Drawing.Size(112, 21);
            this.lblTienTHB.TabIndex = 2;
            this.lblTienTHB.Text = "500.000 đồng";
            // 
            // lblTienTAB
            // 
            this.lblTienTAB.AutoSize = true;
            this.lblTienTAB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTAB.Location = new System.Drawing.Point(400, 332);
            this.lblTienTAB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienTAB.Name = "lblTienTAB";
            this.lblTienTAB.Size = new System.Drawing.Size(112, 21);
            this.lblTienTAB.TabIndex = 2;
            this.lblTienTAB.Text = "600.000 đồng";
            // 
            // lblTienTAA
            // 
            this.lblTienTAA.AutoSize = true;
            this.lblTienTAA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTAA.Location = new System.Drawing.Point(400, 299);
            this.lblTienTAA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienTAA.Name = "lblTienTAA";
            this.lblTienTAA.Size = new System.Drawing.Size(112, 21);
            this.lblTienTAA.TabIndex = 2;
            this.lblTienTAA.Text = "400.000 đồng";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(121, 373);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(96, 23);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng Tiền";
            this.lblTongTien.Click += new System.EventHandler(this.txtNgayDK_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(280, 372);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(235, 22);
            this.txtTongTien.TabIndex = 9;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnTinhTien.Location = new System.Drawing.Point(145, 437);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(127, 48);
            this.btnTinhTien.TabIndex = 11;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(293, 437);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 48);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Location = new System.Drawing.Point(445, 437);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 48);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 543);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.lblTienTAA);
            this.Controls.Add(this.lblTienTAB);
            this.Controls.Add(this.lblTienTHB);
            this.Controls.Add(this.lblTienTHA);
            this.Controls.Add(this.ckbAnhB);
            this.Controls.Add(this.ckbAnhA);
            this.Controls.Add(this.ckbTinB);
            this.Controls.Add(this.ckbTinA);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.cbMaHV);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtNgayDK);
            this.Controls.Add(this.txtMaHV);
            this.Controls.Add(this.Heading);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTrungTam";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label txtMaHV;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.ComboBox cbMaHV;
        private System.Windows.Forms.Label txtGioiTinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label txtNgayDK;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.CheckBox ckbTinA;
        private System.Windows.Forms.CheckBox ckbTinB;
        private System.Windows.Forms.CheckBox ckbAnhA;
        private System.Windows.Forms.CheckBox ckbAnhB;
        private System.Windows.Forms.Label lblTienTHA;
        private System.Windows.Forms.Label lblTienTHB;
        private System.Windows.Forms.Label lblTienTAB;
        private System.Windows.Forms.Label lblTienTAA;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}

