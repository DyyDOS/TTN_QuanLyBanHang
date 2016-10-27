using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhanQuyenInfo
    {
        public PhanQuyenInfo( string _MaQuyen,string _MaNV,string _MatKhau,string _TenDN)
        {
            this.MaQuyen = _MaQuyen;
            this.MaNV = _MaNV;
            this.MatKhau = _MatKhau;
            this.TenDangNhap = _TenDN;
        }
      

        private string m_MaNV;
        public string MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }
        private String m_MaQuyen;

        public String MaQuyen
        {
            get { return m_MaQuyen; }
            set { m_MaQuyen = value; }
        }
        private String m_TenDangNhap;
        public String TenDangNhap
        {
            get { return m_TenDangNhap; }
            set { m_TenDangNhap = value; }
        }

        private String m_MatKhau;
        public String MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }


    }
}
