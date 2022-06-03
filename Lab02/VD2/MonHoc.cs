using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD2
{
    public class MonHoc
    {
        public int Id { get; set; }
        public string TenMH { get; set; }
        public int SoTC { get; set; }
        public MonHoc()
        {

        }
        public MonHoc(string ten)
        {
            this.TenMH = ten;
        }
        public MonHoc(int id, string ten, int tc)
        {
            this.Id = id;
            this.TenMH = ten;
            this.SoTC = tc;
        }
        public override string ToString()
        {
            return TenMH;
        }
    }
    public class DanhMucMH
    {
        public ArrayList ds;
        public DanhMucMH()
        {
            ds = new ArrayList();
        }
        public MonHoc this[int index]
        {
            get { return ds[index] as MonHoc; }
            set { ds[index] = value; }
        }
        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh sach mon hoc";
            foreach (object mh in ds)
            {
                s += mh as MonHoc + ";";
            }
            return s;
        }

    }

}
