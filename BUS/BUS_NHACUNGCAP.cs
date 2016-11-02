using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
   public class BUS_NHACUNGCAP
    {
        public static DataTable HienThi_NCC_All()
        {
            return DAO_NHACUNGCAP.HienThi_NCC_All();
        }
        public static void Them_NCC(NhaCungCapInfo nv)
        {
            DAO_NHACUNGCAP.Them_NCC(nv);
        }
        public static void Sua_NCC(NhaCungCapInfo nv)
        {
            DAO_NHACUNGCAP.Sua_NCC(nv);
        }
        public static void Xoa_NCC(string MaNV)
        {
            DAO_NHACUNGCAP.Xoa_NCC(MaNV);
        }

    }
}
