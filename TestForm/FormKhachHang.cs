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
    public partial class FormKhachHang : Form
    {
        public DataTable dt;
        public FormKhachHang()
        {
            InitializeComponent();

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            loaddata();
            bindings();
        }
        public void loaddata()
        {
            dt = BUS_KHACHHANG.HienThi_KhachHang_All();
            grcKhachHang.DataSource = dt;
        }
        public void bindings()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", grcKhachHang.DataSource, "MaKH");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", grcKhachHang.DataSource, "HoTen");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", grcKhachHang.DataSource, "DiaChi");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", grcKhachHang.DataSource, "DienThoai");
        }

        private void btnThemKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                KhachHangInfo kh= new KhachHangInfo(txtMaKH.Text, txtHoTen.Text, txtDiaChi.Text, txtDienThoai.Text);
                BUS_KHACHHANG.Them_KhachHang(kh); 
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

        private void btnSuaKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                KhachHangInfo kh = new KhachHangInfo(txtMaKH.Text, txtHoTen.Text, txtDiaChi.Text, txtDienThoai.Text);
                BUS_KHACHHANG.Sua_KhachHang(kh);
                DialogResult dr = MessageBox.Show("Sua thành công");
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

        private void btnXoaKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                BUS_KHACHHANG.Xoa_KhachHang(txtMaKH.Text);
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

        private void grcKhachHang_Click(object sender, EventArgs e)
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

    }
}
