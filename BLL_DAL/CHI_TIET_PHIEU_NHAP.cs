using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public partial class CHI_TIET_PHIEU_NHAP
    {
        ChiTietPhieuNhapBLL ct = new ChiTietPhieuNhapBLL();
        SanPhamBLL sp = new SanPhamBLL();
        PhieuNhapBLL pn = new PhieuNhapBLL();
        public string _stt;

        public string STT
        {
            get { return _stt; }
            set { _stt = value; }
        }

        public string TenSP
        {
            get { return sp.TimKiemSanPham(MaSP).TenSP; }
            set { }
        }
        //int GiamGia = new PhieuNhapBLL().TimPhieuNhapTheoMaPN(MaPN
        public double? ThanhTien
        {
            
            get
            {
                if (GiaNhap != null && SoLuong != null)
                    return Convert.ToDouble(Convert.ToInt64(GiaNhap) * SoLuong * (1 - Convert.ToDouble(new PhieuNhapBLL().TimPhieuNhapTheoMaPN(MaPN).GiamGia) / 100));
                return Convert.ToInt64(GiaNhap) * SoLuong;
            }
            set { }
        }

        public string DonViTinh
        {
            get
            {
                return sp.TimKiemSanPham(MaSP).DonViTinh;
            }
            set { }
        }
    }
}
