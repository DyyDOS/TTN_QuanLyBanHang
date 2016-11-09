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
    public partial class FormThongKeHangTon : Form
    {
        public FormThongKeHangTon()
        {
            InitializeComponent();
        }

        private void FormThongKeHangTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet1.PR_THONGKE_SOLUONGCON' table. You can move, or remove it, as needed.
            this.pR_THONGKE_SOLUONGCONTableAdapter.Fill(this.quanLyBanHangDataSet1.PR_THONGKE_SOLUONGCON);

        }
    }
}
