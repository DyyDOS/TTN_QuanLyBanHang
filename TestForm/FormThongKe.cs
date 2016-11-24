using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.PR_THONGKE_MATHANG' table. You can move, or remove it, as needed.
            this.pR_THONGKE_MATHANGTableAdapter.Fill(this.quanLyBanHangDataSet.PR_THONGKE_MATHANG);

        }
    }
}
