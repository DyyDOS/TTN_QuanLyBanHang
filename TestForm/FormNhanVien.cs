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
    public partial class FormNhanVien : Form
    {
        public DataTable dt;
        public FormNhanVien()
        {
            InitializeComponent();
        }
        private void loadata()
        {
            dt = BUS_NHANVIEN.HienThi_NhanVien_All();
            grcNhanVien.DataSource = dt;
        }
        private void bindings()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text",grcNhanVien.DataSource,"MaNV");
            txtHoTenNV.DataBindings.Clear();
            txtHoTenNV.DataBindings.Add("Text", grcNhanVien.DataSource, "HoTenNV");
           txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", grcNhanVien.DataSource, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text",grcNhanVien.DataSource,"DiaChi");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", grcNhanVien.DataSource, "DienThoai");
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadata();
            bindings();

        }

        private void btnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                NhanVienInfo nv = new NhanVienInfo(txtMaNV.Text, txtHoTenNV.Text, txtDiaChi.Text, txtDienThoai.Text,txtGioiTinh.Text);
                BUS_NHANVIEN.Them_NhanVien(nv);
                 DialogResult dr= MessageBox.Show("Thêm thành công");
                 if (dr == DialogResult.OK)
                 {
                     loadata();
                 }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi"+ex.ToString());
            }
        }

        private void btnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                NhanVienInfo nv = new NhanVienInfo(txtMaNV.Text, txtHoTenNV.Text, txtDiaChi.Text, txtDienThoai.Text, txtGioiTinh.Text);
                BUS_NHANVIEN.Sua_NhanVien(nv);
                DialogResult dr = MessageBox.Show("Sửa thành công");
                if (dr == DialogResult.OK)
                {
                    loadata();
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
               
                BUS_NHANVIEN.Xoa_NhanVien(txtMaNV.Text);
                DialogResult dr = MessageBox.Show("Xoa thành công");
                if (dr == DialogResult.OK)
                {
                    loadata();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grcNhanVien_Click(object sender, EventArgs e)
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

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarGroupControlContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
