using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public partial class CHI_TIET_HOA_DON
    {
        public string TenSP
        {
            get 
            {
                return new SanPhamBLL().TimKiemSanPham(MaSP).TenSP;
            }
            set { }
        }
        public int? ThanhTien
        {
            get
            {
                return SoLuong * Convert.ToInt32( GiaBan);
            }
            set { }
        }

        public int? SL
        {
            get 
            { 
                    return SoLuong;
            }
            set { SoLuong = value; }
        }
    }
}
