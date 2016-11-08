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
 public class DAO_KHACHHANG
    {
     public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
     public static DataTable HienThi_KhachHanh_All()
     {
         con = DAO_DATABASE.OpenConnect();

         dt = SqlHelper.ExecuteDataset(con, "PR_KHACHHANG_HIENTHITATCA").Tables[0];
         DAO_DATABASE.CloseConnect(con);
         return dt; 
     }
     public static void Xoa_KhachHang(string MaKH)
     {
         con = DAO_DATABASE.OpenConnect();
         SqlHelper.ExecuteNonQuery(con, "PR_KH_XOA", MaKH);
         DAO_DATABASE.CloseConnect(con);
     }
     public static void Them_KhachHang(KhachHangInfo kh)
     {
         con = DAO_DATABASE.OpenConnect();
         SqlHelper.ExecuteNonQuery(con, "PR_KH_SUA", kh.MaKH,kh.HoTen,kh.DiaChi,kh.DienThoai);
         DAO_DATABASE.CloseConnect(con);
     }
     public static void Sua_KhachHang(KhachHangInfo kh)
     {

         con = DAO_DATABASE.OpenConnect();
         SqlHelper.ExecuteNonQuery(con, "PR_KH_XOA", kh.MaKH, kh.HoTen, kh.DiaChi, kh.DienThoai);
         DAO_DATABASE.CloseConnect(con);
     }
    }
}
