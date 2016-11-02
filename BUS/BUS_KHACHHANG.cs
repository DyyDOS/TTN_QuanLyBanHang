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
    public class BUS_KHACHHANG
    {
        public static DataTable HienThi_KhachHang_All()
        {
            return DAO_KHACHHANG.HienThi_KhachHanh_All();
        }
        public static void Them_KhachHang(KhachHangInfo kh )
        {
            DAO_KHACHHANG.Them_KhachHang(kh);
        }
        public static void Sua_KhachHang(KhachHangInfo kh)
        {
            DAO_KHACHHANG.Sua_KhachHang(kh);
        }
        public static void Xoa_KhachHang(string MaKH)
        {
            DAO_KHACHHANG.Xoa_KhachHang(MaKH);
        }
    }
}
