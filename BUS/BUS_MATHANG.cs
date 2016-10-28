using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
     public class BUS_MATHANG
    {
         public static void Them_MatHang(MatHangInfo mh)
         {
             DAO_MATHANG.Them_MatHang(mh);
         }
         public static void Sua_MatHang(MatHangInfo mh)
         {
             DAO_MATHANG.Sua_MatHang(mh);
         }
         public static void Xoa_MatHang ( string MaMH)
         {
             DAO_MATHANG.Xoa_MatHang(MaMH);
         }
         public static DataTable HienThi_All()
         {
             return DAO_MATHANG.HienThi_MatHang_All();
         }

    }
}
