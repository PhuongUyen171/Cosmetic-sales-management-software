using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BLL_DAL;
using BLL;
using DevExpress.XtraReports.UI;

namespace DoAn
{
    public partial class frmPOS : Office2007Form
    {
        public NHAN_VIEN NhanVien;

        
        KhachHangBLL kh = new KhachHangBLL();
        LoaiKhachHangBLL l = new LoaiKhachHangBLL();
        BLL_DAL.HoaDonBLL h = new BLL_DAL.HoaDonBLL();
        BLL.HoaDonBLL hd = new BLL.HoaDonBLL();
        //BLL.ChiTietHoaDonBLL c = new ChiTietHoaDonBLL();
        SanPhamBLL s = new SanPhamBLL();

        public frmPOS()
        {
            InitializeComponent();
        }

        private void txtMaKH_ButtonCustomClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = kh.TimKiemKhachHang(txtMaKH.Text);
                if (dr != null)
                {
                    lbKH.Text = dr["TenKH"].ToString();
                    DataRow dr2 = l.TimLoaiKH((dr["MaLoaiKH"].ToString()));
                    lbGiamGia.Text = dr2["GiamGia"].ToString() + " %";
                    lbLoaiThe.Text = dr2["TenLoaiKH"].ToString();
                }
            }
            catch (Exception)
            {
                lbKH.Text = "Không có";
                lbGiamGia.Text = "0 %";
                lbLoaiThe.Text = "Đồng";
            }
            
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            lbThoiGian.Text = "Thời gian: " + DateTime.Now;
            lbNhanVien.Text = "Nhân viên bán hàng: " + NhanVien.TenNV;
            //LoadDTGV(24);
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtMaKH_ButtonCustomClick(sender, e);
        }

        private void lbTongTien_TextChanged(object sender, EventArgs e)
        {
            lbCanTra.Text = string.Format("{0:0,0}", hd.GetThanhTien(maHD));
        }

        private void lbGiamGia_TextChanged(object sender, EventArgs e)
        {
            lbCanTra.Text = string.Format("{0:0,0}", hd.GetThanhTien(maHD));
        }

        private void txtThanhToan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //string kq = textBox1.Text.Replace;
                int canTra = Convert.ToInt32(string.Format("{0:0}",lbCanTra.Text.Replace(",", "")));
                lbTienThua.Text = string.Format("{0:0,0}", int.Parse(txtThanhToan.Text) - canTra);
            }
        }
        int maHD;
        private void btnTaoMoiHD_Click(object sender, EventArgs e)
        {
            TaoMoi();
        }
        public void TaoMoi()
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng.", "FAILED");
                return;
            }
            try
            {
                maHD = h.ThemHoaDon(txtMaKH.Text, NhanVien.MaNV, DateTime.Now, int.Parse(lbGiamGia.Text.Remove(lbGiamGia.Text.Length - 1, 1)));
                MessageBox.Show("Tạo mới thành công.", "SUCEED");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi", "FAILED");
            }
        }
        public void LoadDTGV(int maHD)
        {
            //dtgvDonHang.Rows.Clear();
            //DataSet ds = new DataSet();
            //DataTable dt = hd.GetCTHD(maHD);
            //ds.Tables.Add(dt);
            //ds.EnforceConstraints = false;
            ////var dst = hd.GetCTHD(maHD);
            ////dst.EnforceConstraints = false;
            //dtgvDonHang.DataSource = ds;
            dtgvDonHang.DataSource = hd.GetCTHD(maHD);
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!s.KiemTraKhoaChinh(Convert.ToInt32(txtMaSP.Text))){
                    MessageBox.Show("Sản phẩm không tồn tại.","FAILED");
                    return;
                }
                if (maHD == 0)
                {
                    TaoMoi();
                }
                try
                {

                    if (hd.KiemTraKhoaChinh(maHD, txtMaSP.Text))
                    {
                        hd.SuaCTHD(maHD, txtMaSP.Text, Convert.ToInt32(txtSL.Text));
                    }
                    else
                    {
                        hd.ThemCTHD(maHD, txtMaSP.Text, Convert.ToInt32(txtSL.Text));
                    }
                    LoadDTGV(maHD);
                    lbTongTien.Text = string.Format("{0:0,0}", h.GetTongTien(maHD));
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            rptHoaDon r = new rptHoaDon();
            //r.DataSource = "select* from CHI_TIET_HOA_DON,HOA_DON where CHI_TIET_HOA_DON.MaHD =24"+maHD+" and CHI_TIET_HOA_DON.MaHD = HOA_DON.MaHD";
            r.DataSource = "select* from CHI_TIET_HOA_DON where MaHD =24";
            //maHD = 0;
            r.ShowPreview();
            maHD = 0;
        }

        private void txtSL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (hd.KiemTraKhoaChinh(maHD, txtMaSP.Text))
                {
                    hd.SuaCTHD(maHD, txtMaSP.Text, Convert.ToInt32(txtSL.Text));
                    
                }
                else
                {
                    hd.ThemCTHD(maHD, txtMaSP.Text, Convert.ToInt32(txtSL.Text));
                }
                LoadDTGV(maHD);
                lbTongTien.Text = string.Format("{0:0,0}", h.GetTongTien(maHD));
            }
        }
    }
}
