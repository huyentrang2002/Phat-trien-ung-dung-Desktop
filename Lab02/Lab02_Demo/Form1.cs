using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Demo
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNgayDK_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (ckbTinA.Checked)
                s+= int.Parse(lblTienTHA.Text.Split('.')[0]);
            if (ckbTinB.Checked)
                s += int.Parse(lblTienTHB.Text.Split('.')[0]);
            if (ckbAnhA.Checked)
                s += int.Parse(lblTienTAA.Text.Split('.')[0]);
            if (ckbAnhB.Checked)
                s += int.Parse(lblTienTAB.Text.Split('.')[0]);
            this.txtTongTien.Text = s + ".000 đồng";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }
        private void ReSet()
        {
            this.cbMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.ckbAnhA.Checked = false;
            this.ckbAnhB.Checked = false;
            this.ckbTinA.Checked = false;  
            this.ckbTinB.Checked = false;
            this.txtTongTien.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
