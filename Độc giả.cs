using Quản_Lý_Thư_Viên.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viên
{
    public partial class Độc_giả : Form
    {
        XuLyDocGia xuly = new XuLyDocGia();
        private void hienthi()
        {
            dgvDG.DataSource = xuly.layDSDocGia();
        }
        public Độc_giả()
        {
            InitializeComponent();
        }



        private void BtnThem_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.MaNguoi = txbMa.Text;
            dg.HoTen = txbTen.Text;
            dg.NgaySinh = dtNgaySinh.Value;
            dg.soDienThoai = txbSDT.Text;
            dg.NgayDangKi = dtNgayDK.Value;
            dg.hanThe = dtHanThe.Value;
            dg.soSachMuonMua = int.Parse(txbSoSachMuonMua.Text);
            dg.diaChi = txbDiaChi.Text;
            if (rdNam.Checked == true)
                dg.gioiTinh = ("Nam");
            else if (rdNu.Checked == false)
                dg.gioiTinh = ("Nữ");
            if (xuly.tim(dg.MaNguoi) == null)
            {
                xuly.them(dg);
                hienthi();
            }
            else
                MessageBox.Show("Mã số bị trùng! Vui lòng nhập lại ");

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            if (xuly.tim(ma) != null)
            {
                xuly.xoa(ma);
                hienthi();
            }
            else
                MessageBox.Show("Không tìm thấy để xóa ");

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            dg.MaNguoi = txbMa.Text;
            dg.HoTen = txbTen.Text;
            dg.NgaySinh = dtNgaySinh.Value;
            dg.soDienThoai = txbSDT.Text;
            dg.NgayDangKi = dtNgayDK.Value;
            dg.hanThe = dtHanThe.Value;
            dg.soSachMuonMua = int.Parse(txbSoSachMuonMua.Text);
            dg.diaChi = txbDiaChi.Text;
            if (rdNam.Checked == true)
                dg.gioiTinh = ("Nam");
            else if (rdNu.Checked == false)
                dg.gioiTinh = ("Nữ");
            xuly.sua(dg);
            hienthi() ;

        }

        private void BtnGhiFile_Click(object sender, EventArgs e)
        {
            xuly.ghiFILE("dsDG.bin");
        }
        private void Độc_giả_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xuly.layDSDocGia();
            dgvDG.DataSource = bs;

        }

        private void BtnDocFile_Click(object sender, EventArgs e)
        {
            xuly.docFILE("dsDG.bin");
            hienthi();
            
        }
    }
}
