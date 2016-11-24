using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
namespace TestForm
{
    public partial class FormNhaCungCap : Form
    {
        public DataTable dt;
        public FormNhaCungCap()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            dt = BUS_NHACUNGCAP.HienThi_NCC_All();
            grcNCC.DataSource = dt;
        }
        private void bindings()
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", grcNCC.DataSource, "MaNCC");
            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", grcNCC.DataSource, "TenNCC");
           txtFax.DataBindings.Clear();
           txtFax.DataBindings.Add("Text", grcNCC.DataSource, "Fax");
            txtDiaChi.DataBindings.Clear();  
            txtDiaChi.DataBindings.Add("Text", grcNCC.DataSource, "DiaChi");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", grcNCC.DataSource, "Email");
          
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", grcNCC.DataSource, "DienThoai");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", grcNCC.DataSource, "GhiChu");
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                NhaCungCapInfo nv = new NhaCungCapInfo(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtFax.Text, txtEmail.Text, txtDienThoai.Text, txtGhiChu.Text);
                BUS_NHACUNGCAP.Them_NCC(nv);
                DialogResult dr = MessageBox.Show("Thêm thành công");
                if (dr == DialogResult.OK)
                {
                    loaddata();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }

        private void grcNCC_Click(object sender, EventArgs e)
        {
            try
            {
                bindings();

                //loaddata();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                NhaCungCapInfo nv = new NhaCungCapInfo(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtFax.Text, txtEmail.Text, txtDienThoai.Text, txtGhiChu.Text);
                BUS_NHACUNGCAP.Sua_NCC(nv);
                DialogResult dr = MessageBox.Show("Thêm thành công");
                if (dr == DialogResult.OK)
                {
                    loaddata();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }

        private void btnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                BUS_NHANVIEN.Xoa_NhanVien(txtMaNCC.Text);
                DialogResult dr = MessageBox.Show("Xoa thành công");
                if (dr == DialogResult.OK)
                {
                    loaddata();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }
    }
}
