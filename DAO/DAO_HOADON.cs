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
    public class DAO_HOADON
    {
        public static SqlConnection con;
        public static DataSet ds;
        public static DataTable dt;
        public static DataTable HienThi_HoaDon_All()
        {
            con = DAO_DATABASE.OpenConnect();

            dt = SqlHelper.ExecuteDataset(con, "PR_HOADON_HIENTHITATCA").Tables[0];
            DAO_DATABASE.CloseConnect(con);
            return dt;
        }
    }
}
