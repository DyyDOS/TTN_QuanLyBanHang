using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class MatHangInfo
    {
        public MatHangInfo(string _MaMH,string _TenMH,float _SoLuong, float _DonGia,float _GiaBan,string _MaNCC,DateTime _NgayNhap,string _MaLoaiTien)
        {
            this.MaMH = _MaMH;
            this.TenMH = _TenMH;
            this.SoLuong = _SoLuong;
            this.DonGia = _DonGia;
            this.GiaBan = _GiaBan;
            this.MaNCC = _MaNCC;
            this.NgayNhap = _NgayNhap;
            this.MaLoaiTien = _MaLoaiTien;
           
        }

               private String m_MaMH;
        public String MaMH
        {
            get { return m_MaMH; }
            set { m_MaMH = value; }
        }

        private String m_TenMH;
        public String TenMH
        {
            get { return m_TenMH; }
            set { m_TenMH = value; }
        }

        private String m_MaNCC;

        public String MaNCC
        {
            get { return m_MaNCC; }
            set { m_MaNCC = value; }
        }
       


        private string m_MaLoaiTien;

        public string MaLoaiTien
        {
            get { return m_MaLoaiTien; }
            set { m_MaLoaiTien = value; }
        }
        
        private DateTime m_NgayNhap;
        public DateTime NgayNhap
        {
            get { return m_NgayNhap; }
            set { m_NgayNhap = value; }
        }

        private float m_SoLuong;
        public float SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }

        private float m_DonGia;
        public float DonGia
        {
            get { return m_DonGia; }
            set { m_DonGia = value; }
        }

        private float m_GiaBan;
        public float GiaBan
        {
            get { return m_GiaBan; }
            set { m_GiaBan = value; }
        }
        private float m_SoLuongCon;

        public float SoLuongCon
        {
            get { return m_SoLuongCon; }
            set { m_SoLuongCon = value; }
        }
        

    }
}
