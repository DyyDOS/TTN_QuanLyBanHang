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
   public class DAO_MATHANG
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static DataTable HienThi_MatHang_All()
        {
            con = DAO_DATABASE.OpenConnect();

            dt = SqlHelper.ExecuteDataset(con, "PR_MATHANG_HIENTHITATCA").Tables[0];
            DAO_DATABASE.CloseConnect(con);
            return dt;
        }
        public static void Them_MatHang(MatHangInfo a)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_MATHANG_THEM", a.MaMH,a.TenMH,a.SoLuong,a.DonGia,a.GiaBan,a.MaNCC,a.NgayNhap,a.MaLoaiTien);
            DAO_DATABASE.CloseConnect(con);
       }
        public static void Sua_MatHang(MatHangInfo a)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_MATHANG_SUA", a.MaMH, a.TenMH, a.SoLuong, a.DonGia, a.GiaBan, a.MaNCC, a.NgayNhap, a.MaLoaiTien);
            DAO_DATABASE.CloseConnect(con);
        }
        public static void Xoa_MatHang(string MaMH)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_MATHANG_XOA", MaMH);
            DAO_DATABASE.CloseConnect(con);
        }
    }
}
