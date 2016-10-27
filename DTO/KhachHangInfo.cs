using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhachHangInfo
    {
        public KhachHangInfo()
        {
        }

        private String m_MaKH;
        public String MaKH
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }

        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
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
        public KhachHangInfo(string _MaKH, string _HoTen, string _DiaChi, string _DienThoai)
        {
            this.MaKH = _MaKH;
            this.HoTen = _HoTen;
            this.DiaChi = _DiaChi;
            this.DienThoai = _DienThoai;
        }

    }
}
