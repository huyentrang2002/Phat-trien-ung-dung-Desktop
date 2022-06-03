using System.Windows.Forms;

namespace VD2
{
    public partial class frmTBGV : Form
    {
        public frmTBGV()
        {
            InitializeComponent();
        }
        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }
    }
}
