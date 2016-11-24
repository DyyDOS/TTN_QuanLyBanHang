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
   public class BUS_NHANVIEN
    {
       public static DataTable HienThi_NhanVien_All()
       {
           return DAO_NHANVIEN.HienThi_NhanVien_All();
       }
       public static void Them_NhanVien(NhanVienInfo nv)
       {
           DAO_NHANVIEN.Them_NhanVien(nv);
       }
       public static void Sua_NhanVien(NhanVienInfo nv)
       {
           DAO_NHANVIEN.Sua_NhanVien(nv);
       }
       public static void Xoa_NhanVien(string MaNV)
       {
           DAO_NHANVIEN.Xoa_NhanVien(MaNV);
       }

    }
}
