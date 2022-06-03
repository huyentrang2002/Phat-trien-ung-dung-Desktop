using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD2
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "";
            this.linklblLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cbMaSo.SelectedItem = this.cbMaSo.Items[0];
        }
        private void txtGioiTinh_Click(object sender, EventArgs e)
        {

        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDSMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMHDay.Items.Add(lbDSMH.SelectedItems[i]);
                this.lbDSMH.Items.Remove(lbDSMH.SelectedItems[i]);
                i--;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMHDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDSMH.Items.Add(lbMHDay.SelectedItems[i]);
                this.lbMHDay.Items.Remove(lbMHDay.SelectedItems[i]);
                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            this.cbMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSDT.Text = "";
            this.rdNam.Checked = true;
            // bỏ chọn trên cklbNgoaiNgu
            for (int i = 0; i < cklbNgoaiNgu.Items.Count - 1; i++)
                cklbNgoaiNgu.SetItemChecked(i, false);
            //chuyển các môn từ lbMHDay sang lbDSMN
            foreach (object ob in this.lbMHDay.Items)
                this.lbDSMH.Items.Add(ob);
            this.lbMHDay.Items.Clear();
        }
        private void linklblLienHe_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTBGV frm = new frmTBGV();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }
        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam"; 
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cbMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.soDT = this.txtSDT.Text;
            string ngoaingu = "";
            for (int i = 0; i < cklbNgoaiNgu.Items.Count - 1; i++)
                if (cklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += cklbNgoaiNgu.Items[i] + ";";
            gv.NgoaiNgu = ngoaingu.Split(';');
            DanhMucMH mh = new DanhMucMH();
            foreach (object ob in lbMHDay.Items)
                mh.Them(new MonHoc(ob.ToString()));
            gv.dsMonHoc = mh;
            return gv;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {           
            Application.Exit();            
        }
    }
}
