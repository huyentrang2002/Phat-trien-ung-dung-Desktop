using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD2
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMH dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string soDT;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhMucMH();
            NgoaiNgu = new string[10];
        }
        public GiaoVien(string maso, string hoten, DateTime ngaysinh,
           DanhMucMH ds, string gt, string[] nn,
           string sdt, string email)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsMonHoc = ds;
            this.GioiTinh = gt;
            this.NgoaiNgu = nn;
            this.soDT = sdt;
            this.Mail = email;
        }
        public override string ToString()
        {
            string s = "Mã số" + MaSo + "\n" + "Họ tên" + HoTen + "\n"
                + "Ngày sinh" + NgaySinh.ToString() + "\n"
                + "Giới tính" + GioiTinh + "\n"
                + "Số điện thoại" + soDT + "\n"
                + "Mail" + Mail + "\n";
            string sngoaingu = "Ngoại Ngữ";
            foreach (string t in NgoaiNgu)
                sngoaingu += t + ";";
            string Monday = "Danh sách các môn dạy";
            foreach (MonHoc mh in dsMonHoc.ds)
                Monday += mh + ";";
            s += "\n" + sngoaingu + "\n" + Monday;
            return s;
        }
    }
}