using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN
{
    public partial class frmSV : Form
    {
        List<SinhVien> dssv = new List<SinhVien>();
        List<Lop> dslop = new List<Lop>();
        //lien ket database 
        string connectionSTR = "Data Source=WIN-66V7T6VAQ7F;Initial Catalog=QLSinhVien;Integrated Security=True";
        public frmSV()
        {
            InitializeComponent();
        }
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            cbLop.Text = "";
            txtID.Text = "";
            txtHoTen.Text = "";       
        }
        //ham lay du lieu tu sql
        private DataTable getData(string query)
        {
            //query = "select * from SinhVien";
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionSTR);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            connection.Close();

            return dt;

        }
        //lay tat ca cac lop
        private void getAllLop()
        {
            string query = "select * from Lop";
            DataTable dt = getData(query);
            foreach (DataRow row in dt.Rows)
            {
                dslop.Add(new Lop(row));
            }
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "ID";
            cbLop.DataSource = dslop;
        }
        private void getAllSinhVien()
        {
            dssv = new List<SinhVien>();
            string query = "select * from SinhVien";
            DataTable dt = getData(query);
            //Laay hang trong bang roi them sinh vien
            foreach (DataRow row in dt.Rows)
            {
                dssv.Add(new SinhVien(row));
            }
        }

        private void loadDSSV(List<SinhVien> list)
        {
            listView1.Items.Clear();

            foreach (SinhVien sv in list)
            {
                addSVToLV(sv);
            }
        }

        private void addSVToLV(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.MSSV.ToString());
            item.SubItems.Add(sv.TenSV);
            item.SubItems.Add(sv.MaLop.ToString());
            listView1.Items.Add(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAllSinhVien();
            loadDSSV(dssv);
            getAllLop();
        }
        private SinhVien getSinhVien()
        {
            var sv = new SinhVien();
            if (!string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                sv.TenSV = txtHoTen.Text;
                sv.MSSV = string.IsNullOrWhiteSpace(txtID.Text) ? -1 : int.Parse(txtID.Text);
                sv.MaLop = Convert.ToInt32(cbLop.SelectedValue);
            }
            return sv;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = getSinhVien();
            if (sv == null)
            {
                MessageBox.Show("Xin hãy nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (sv.MSSV < 0)
                {
                    string query = $"exec InsertStudent N'" + sv.TenSV + "', " + sv.MaLop + "";
                    if (saveSinhVien(sv, query) == 1)
                        MessageBox.Show("Bạn đã thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = $"update SinhVien set HoTen = N'" + sv.TenSV + "' where ID =" + sv.MSSV + "";
                    if (saveSinhVien(sv, query) == 1)
                        MessageBox.Show("Bạn đã thay đổi thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnTaiLai.PerformClick();
            }
        }

        private int saveSinhVien(SinhVien sv, string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            connection.Open();

            int i = command.ExecuteNonQuery();

            connection.Close();
            return i;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            getAllSinhVien();
            loadDSSV(dssv);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                cbLop.SelectedIndex = int.Parse(item.SubItems[2].Text) - 1;
                txtHoTen.Text = item.SubItems[1].Text;
                txtID.Text = item.SubItems[0].Text;
            }
        }
    }
}
