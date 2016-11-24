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
     public class DAO_NHACUNGCAP
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static DataTable HienThi_NCC_All()
        {
            con = DAO_DATABASE.OpenConnect();

            dt = SqlHelper.ExecuteDataset(con, "PR_NHACUNGCAP_HIENTHITATCA").Tables[0];
            DAO_DATABASE.CloseConnect(con);
            return dt;
        }
        public static void Them_NCC(NhaCungCapInfo a)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_NHACUNGCAP_THEM", a.MaNCC,a.TenNCC,a.DiaChi,a.Fax,a.Email,a.GhiChu);
            DAO_DATABASE.CloseConnect(con);

        }
        public static void Sua_NCC(NhaCungCapInfo a)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_NHACUNGCAP_SUA", a.MaNCC, a.TenNCC, a.DiaChi, a.Fax, a.Email, a.GhiChu);
            DAO_DATABASE.CloseConnect(con);

        }
        public static void Xoa_NCC(string MaNV)
        {
            con = DAO_DATABASE.OpenConnect();
            SqlHelper.ExecuteNonQuery(con, "PR_NHACUNGCAP_XOA", MaNV);
            DAO_DATABASE.CloseConnect(con);

        }
    }
}
