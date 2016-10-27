using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
   public static class BUS_PHANQUYEN
    {
        private static string m_PhanQuyen;
        public static string PhanQuyen
        {
            get { return m_PhanQuyen; }
            set { m_PhanQuyen = value; }
        }
        public static string DangNhap(string m_UserName, string m_Pass)
        {
            return DAO_PHANQUYEN.Xacthuc(m_UserName, m_Pass);
            
        }
        public static void Them_TaiKhoan(PhanQuyenInfo nv)
        {
            DAO_PHANQUYEN.Them_TaiKhoan(nv);
        }
        public static void Sua_TaiKhoan(PhanQuyenInfo nv)
        {
            DAO_PHANQUYEN.Sua_TaiKhoan(nv);
        }
        public static void Xoa_TaiKhoan(string MaNV)
        {
            DAO_PHANQUYEN.XOA_TaiKhoan(MaNV);
        }
        public static DataTable HienThi_All()
        {
            return DAO_PHANQUYEN.HienThi_All();
        }
    }
}
