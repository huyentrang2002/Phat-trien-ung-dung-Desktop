namespace VD2
{
    partial class frmGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.Heading = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.Label();
            this.cbMaSo = new System.Windows.Forms.ComboBox();
            this.txtGioiTinh = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNgaysinh = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.lbNgoaiNgu = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.lblDSMonHoc = new System.Windows.Forms.Label();
            this.lbDSMH = new System.Windows.Forms.ListBox();
            this.lblMHDay = new System.Windows.Forms.Label();
            this.lbMHDay = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.linklblLienHe = new System.Windows.Forms.LinkLabel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.Color.DarkViolet;
            this.Heading.Location = new System.Drawing.Point(46, 18);
            this.Heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(597, 37);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "THÔNG TIN GIÁO VIÊN KHOA CNTT";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMaSo
            // 
            this.txtMaSo.AutoSize = true;
            this.txtMaSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSo.Location = new System.Drawing.Point(23, 80);
            this.txtMaSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(64, 23);
            this.txtMaSo.TabIndex = 0;
            this.txtMaSo.Text = "Mã Số";
            // 
            // cbMaSo
            // 
            this.cbMaSo.FormattingEnabled = true;
            this.cbMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.cbMaSo.Location = new System.Drawing.Point(126, 79);
            this.cbMaSo.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaSo.Name = "cbMaSo";
            this.cbMaSo.Size = new System.Drawing.Size(121, 24);
            this.cbMaSo.TabIndex = 1;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.AutoSize = true;
            this.txtGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(374, 77);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(91, 23);
            this.txtGioiTinh.TabIndex = 0;
            this.txtGioiTinh.Text = "Giới Tính";
            this.txtGioiTinh.Click += new System.EventHandler(this.txtGioiTinh_Click);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(511, 80);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(66, 25);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(585, 80);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(54, 25);
            this.rdNu.TabIndex = 3;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(23, 118);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(72, 23);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(126, 120);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(240, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.AutoSize = true;
            this.txtNgaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaysinh.Location = new System.Drawing.Point(23, 156);
            this.txtNgaysinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(95, 23);
            this.txtNgaysinh.TabIndex = 0;
            this.txtNgaysinh.Text = "Ngày Sinh";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(374, 118);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(63, 23);
            this.txtSDT.TabIndex = 0;
            this.txtSDT.Text = "Số ĐT";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(374, 158);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(121, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Địa chỉ Email";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(512, 160);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(194, 22);
            this.txtMail.TabIndex = 7;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(512, 120);
            this.mtxtSDT.Mask = "(\\0633).000.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(194, 22);
            this.mtxtSDT.TabIndex = 5;
            // 
            // lbNgoaiNgu
            // 
            this.lbNgoaiNgu.AutoSize = true;
            this.lbNgoaiNgu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgoaiNgu.Location = new System.Drawing.Point(23, 208);
            this.lbNgoaiNgu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgoaiNgu.Name = "lbNgoaiNgu";
            this.lbNgoaiNgu.Size = new System.Drawing.Size(100, 23);
            this.lbNgoaiNgu.TabIndex = 0;
            this.lbNgoaiNgu.Text = "Ngoại Ngữ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(126, 156);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(240, 22);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // cklbNgoaiNgu
            // 
            this.cklbNgoaiNgu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklbNgoaiNgu.FormattingEnabled = true;
            this.cklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật ",
            "Tiếng Nga"});
            this.cklbNgoaiNgu.Location = new System.Drawing.Point(126, 208);
            this.cklbNgoaiNgu.Name = "cklbNgoaiNgu";
            this.cklbNgoaiNgu.Size = new System.Drawing.Size(142, 92);
            this.cklbNgoaiNgu.TabIndex = 8;
            // 
            // lblDSMonHoc
            // 
            this.lblDSMonHoc.AutoSize = true;
            this.lblDSMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSMonHoc.Location = new System.Drawing.Point(122, 321);
            this.lblDSMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDSMonHoc.Name = "lblDSMonHoc";
            this.lblDSMonHoc.Size = new System.Drawing.Size(170, 23);
            this.lblDSMonHoc.TabIndex = 0;
            this.lblDSMonHoc.Text = "Danh sách môn học\r\n";
            // 
            // lbDSMH
            // 
            this.lbDSMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSMH.FormattingEnabled = true;
            this.lbDSMH.ItemHeight = 19;
            this.lbDSMH.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình cấu trúc C/C++",
            "Cơ sở dữ liệu ",
            "Tiếng anh B1 ",
            "Tiếng anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích TKHDT"});
            this.lbDSMH.Location = new System.Drawing.Point(126, 347);
            this.lbDSMH.Name = "lbDSMH";
            this.lbDSMH.Size = new System.Drawing.Size(210, 194);
            this.lbDSMH.TabIndex = 9;
            // 
            // lblMHDay
            // 
            this.lblMHDay.AutoSize = true;
            this.lblMHDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMHDay.Location = new System.Drawing.Point(428, 321);
            this.lblMHDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMHDay.Name = "lblMHDay";
            this.lblMHDay.Size = new System.Drawing.Size(196, 46);
            this.lblMHDay.TabIndex = 0;
            this.lblMHDay.Text = "Môn học giáo viên dạy\r\n\r\n";
            // 
            // lbMHDay
            // 
            this.lbMHDay.FormattingEnabled = true;
            this.lbMHDay.ItemHeight = 16;
            this.lbMHDay.Location = new System.Drawing.Point(432, 347);
            this.lbMHDay.Name = "lbMHDay";
            this.lbMHDay.Size = new System.Drawing.Size(207, 180);
            this.lbMHDay.TabIndex = 10;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(363, 366);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(44, 45);
            this.btnChon.TabIndex = 11;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(363, 417);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(44, 45);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.Location = new System.Drawing.Point(550, 558);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 42);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(423, 558);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 42);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.Location = new System.Drawing.Point(297, 558);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 42);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 604);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Website";
            // 
            // linklblLienHe
            // 
            this.linklblLienHe.AutoSize = true;
            this.linklblLienHe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLienHe.Location = new System.Drawing.Point(631, 606);
            this.linklblLienHe.Name = "linklblLienHe";
            this.linklblLienHe.Size = new System.Drawing.Size(63, 20);
            this.linklblLienHe.TabIndex = 16;
            this.linklblLienHe.TabStop = true;
            this.linklblLienHe.Text = "Liên hệ";
            this.linklblLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLienHe_LinkClicked);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.Location = new System.Drawing.Point(171, 558);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 42);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnTim.Location = new System.Drawing.Point(45, 558);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(118, 42);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 636);
            this.Controls.Add(this.linklblLienHe);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lbMHDay);
            this.Controls.Add(this.lbDSMH);
            this.Controls.Add(this.cklbNgoaiNgu);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMHDay);
            this.Controls.Add(this.lblDSMonHoc);
            this.Controls.Add(this.lbNgoaiNgu);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.cbMaSo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.Heading);
            this.Name = "frmGiaoVien";
            this.Text = "GiaoVien";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label txtMaSo;
        private System.Windows.Forms.ComboBox cbMaSo;
        private System.Windows.Forms.Label txtGioiTinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label txtNgaysinh;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.Label lbNgoaiNgu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckedListBox cklbNgoaiNgu;
        private System.Windows.Forms.Label lblDSMonHoc;
        private System.Windows.Forms.ListBox lbDSMH;
        private System.Windows.Forms.Label lblMHDay;
        private System.Windows.Forms.ListBox lbMHDay;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linklblLienHe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
    }
}

