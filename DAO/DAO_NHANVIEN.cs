using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using DTO;
namespace DAO
{
   public class DAO_NHANVIEN
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static DataTable HienThi_NhanVien_All()
        {
            con = DAO_DATABASE.OpenConnect();

            dt = SqlHelper.ExecuteDataset(con, "PR_NHANVIEN_HIENTHITATCA").Tables[0];
            DAO_DATABASE.CloseConnect(con);
            return dt; 
        }
        public static void Them_NhanVien(NhanVienInfo nv)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con,"PR_NHANVIEN_THEM" ,nv.MaNV, nv.HoTen, nv.DiaChi, nv.DienThoai,nv.GioiTinh);
            DAO_DATABASE.CloseConnect(con);
            
        }
        public static void Sua_NhanVien( NhanVienInfo nv)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con,"PR_NHANVIEN_SUA", nv.MaNV, nv.HoTen, nv.DiaChi, nv.DienThoai,nv.GioiTinh);
            DAO_DATABASE.CloseConnect(con);
            
        }
        public static void Xoa_NhanVien(string MaNV)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_NHANVIEN_XOA", MaNV);
            DAO_DATABASE.CloseConnect(con);
            
        }
    }
}
