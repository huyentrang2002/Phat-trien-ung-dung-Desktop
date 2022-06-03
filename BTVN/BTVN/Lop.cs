using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    public class Lop
    {
        public int ID { get; set; }
        public string TenLop { get; set; }
        public Lop()
        {

        }
        //Phương thức tạo lặp
        //Datarow là kiểu dữ diệu 1 hàng ở nhiều cột
        public Lop(DataRow row)
        {
            this.ID = Convert.ToInt32(row["ID"]);
            this.TenLop = row["TenLop"].ToString();
        }
    }
}
