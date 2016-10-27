using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DAO
{
    public class DAO_PHANQUYEN
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static string Xacthuc(string username, string pass)
        {
            con = DAO_DATABASE.OpenConnect();
            string role = "";
            con = DAO_DATABASE.OpenConnect();
            dt = SqlHelper.ExecuteDataset(con, "PR_XACTHUC", username, pass).Tables[0];
            if (dt.Rows.Count > 0)
                role = (string)dt.Rows[0][0];
            DAO_DATABASE.CloseConnect(con);
            return role;
        }
        public static void Them_TaiKhoan(PhanQuyenInfo nv)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_TAIKHOAN_THEM", nv.MaQuyen, nv.MaNV, nv.MatKhau, nv.TenDangNhap);
            DAO_DATABASE.CloseConnect(con);

        }
        public static void Sua_TaiKhoan(PhanQuyenInfo nv)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_TAIKHOAN_SUA", nv.MaQuyen, nv.MaNV, nv.MatKhau, nv.TenDangNhap);
            DAO_DATABASE.CloseConnect(con);

        }
        public static void XOA_TaiKhoan(string MaNV)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_TAIKHOAN_XOA", MaNV);
            DAO_DATABASE.CloseConnect(con);

        }
        public static DataTable HienThi_All()
        {
            con = DAO_DATABASE.OpenConnect();

            dt = SqlHelper.ExecuteDataset(con, "PR_HIENTHI_TAIKHOAN_ALL").Tables[0];
            DAO_DATABASE.CloseConnect(con);
            return dt; 
        }
    }
}
