using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
namespace BUS
{
  public  class BUS_HOADON
    {
      public static DataTable HienThi_HoaDon()
      {
          return DAO_HOADON.HienThi_HoaDon_All(); 
      }
    }
}
