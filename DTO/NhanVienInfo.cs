using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVienInfo
    {
        public NhanVienInfo()
        {
        }

        private String m_MaNV;
        public String MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

       

        private String m_GioiTinh;
        public String GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private String m_DienThoai;
       
        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }
        public NhanVienInfo(string _MaNV,string _HoTen,string _DiaChi, string _DienThoai,string _GioiTinh)
        {
            this.MaNV = _MaNV;
            this.HoTen = _HoTen;
            this.DiaChi = _DiaChi;
            this.DienThoai = _DienThoai;
            this.GioiTinh = _GioiTinh;

        }

      

      

    }
}
