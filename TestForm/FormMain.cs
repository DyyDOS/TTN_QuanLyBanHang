using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
namespace TestForm
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Add clsAddTab = new Add();
        public FormMain()
        {
            InitializeComponent();

        }
        FormDangNhap m_FrmDangNhap = null;


        #region form Main
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void xtraTabControl1_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = xtraTabControl1.TabPages.Count - 1;
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl1.TabPages.RemoveAt(xtraTabControl1.SelectedTabPageIndex);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Default();
        }
        public void Default()
        {
            btnBanhang.Enabled = false;
            btnMatHang.Enabled = false;
            btnQLKH.Enabled = false;
            btnQLNV.Enabled = false;
            btnQLQGD.Enabled = false;
            btnPhanQuyen.Enabled = false;
            btnDangXuat.Enabled = false;
            btnDangNhapLai.Enabled = false;
        }
        /// <summary>
        /// ////////////////dang nhap
        /// 
        /// </summary>
        /// 
     
        private void btnQLKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnQLQGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
          
        }
        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            
        }
        #endregion
        #region Dang nhap
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_FrmDangNhap = new FormDangNhap();
            DangNhap();
        }
        public void DangNhap()
        {

            if (m_FrmDangNhap == null || m_FrmDangNhap.IsDisposed)
                m_FrmDangNhap = new FormDangNhap();
            if (m_FrmDangNhap.ShowDialog() == DialogResult.OK)
            {
                string kq = BUS_PHANQUYEN.DangNhap(m_FrmDangNhap.txtUser.Text.ToString(), m_FrmDangNhap.txtPass.Text.ToString());
                if (kq == "MQ001")
                {
                    Admin();
                }
                else
                {
                    if (kq == "MQ002")
                    {
                        User();
                    }
                    else
                    {
                        m_FrmDangNhap.Hide();
                        if (MessageBox.Show("Đăng nhập không thành công", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK) ;
                        {
                            m_FrmDangNhap = new FormDangNhap();
                            DangNhap();
                        }
                    }
                }

            }
        }

        public void Admin()
        {
            btnBanhang.Enabled = true;
            btnMatHang.Enabled = true;
            btnQLKH.Enabled = true;
            btnQLNV.Enabled = true;
            btnQLQGD.Enabled = true;
            btnPhanQuyen.Enabled = true;
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDangNhapLai.Enabled = true;

        }
        public void User()
        {
            btnBanhang.Enabled = true;
            btnQLKH.Enabled = true;
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDangNhapLai.Enabled = true;
        }
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

      

        private void btnDangNhapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MessageBox.Show("Đăng nhập lại","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                int x = xtraTabControl1.TabPages.Count;
                for (int i = 0; i < x; i++)
                {
                    xtraTabControl1.TabPages.RemoveAt(0);
                }
                m_FrmDangNhap = new FormDangNhap();
                FormMain_Load(sender, e);
                DangNhap();
            }
           
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int x = xtraTabControl1.TabPages.Count;
            for (int i = 0; i < x; i++)
            {
                xtraTabControl1.TabPages.RemoveAt(0);
            }
            m_FrmDangNhap = new FormDangNhap();
            FormMain_Load(sender, e);
            btnDangNhap.Enabled = true;
        }
        #endregion

      



        private void ribbonControl1_SelectedPageChanging(object sender, DevExpress.XtraBars.Ribbon.RibbonPageChangingEventArgs e)
        {
            int x = xtraTabControl1.TabPages.Count;
            for(int i=0;i<x;i++)
            {
                xtraTabControl1.TabPages.RemoveAt(0);
            }
            
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

     

    }
}
