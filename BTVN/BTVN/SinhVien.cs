using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    public class SinhVien
    {
        public int MSSV { get; set; }
        public string TenSV { get; set; }
        public int MaLop { get; set; }
        public SinhVien()
        {

        }
        public SinhVien(DataRow datarow)
        {
            this.MSSV = Convert.ToInt32(datarow["ID"]);
            this.TenSV = datarow["HoTen"].ToString();
            this.MaLop = Convert.ToInt32(datarow["MaLop"]);

        }
    }

}
