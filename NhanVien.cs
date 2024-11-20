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
    public partial class frmNV : Form
    {
        xuLyNV xuly = new xuLyNV();
        private void hienthi()
        {
            dgvNV.DataSource = xuly.layDSnhanvien();
        }

        public frmNV()
        {
            InitializeComponent();
        }

     

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtManv.Text;
            if(xuly.tim(ma)!= null)
            {
                xuly.xoa(ma);
                hienthi();
            }
            else
            {
                MessageBox.Show("Không tìm thấy để xóa ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Nhân_Viên nv = new Nhân_Viên();
            nv.MaNhanVien = txtManv.Text;
            nv.HoTen = txtHoten.Text;
            nv.NgaySinh = dtNgaySinh.Value;
            nv.GioiTinh = null;
            if (RdNam.Checked == true)
                nv.GioiTinh = ("Nam");
            else if (RdNam.Checked == false)
                nv.GioiTinh = ("Nữ");
            nv.ChucVu = txtChucvu.Text;
            nv.NgayBD = dtNgayBD.Value;
            nv.Luong = double.Parse(txtLuong.Text);
            nv.SoDienThoai = txtSDT.Text;
            nv.DiaChi = txtDiachi.Text;
            xuly.sua(nv);
            hienthi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            BindingSource bs = new BindingSource();
            bs.DataSource = xuly.layDSnhanvien();
            dgvNV.DataSource = bs;

        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            xuly.docFILE("dsNV.bin");
            hienthi();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Nhân_Viên nv = new Nhân_Viên();
            nv.MaNhanVien = txtManv.Text;
            nv.HoTen = txtHoten.Text;
            nv.NgaySinh = dtNgaySinh.Value;
            nv.GioiTinh = null;
            if (RdNam.Checked == true)
                nv.GioiTinh = ("Nam");
            else if (RdNam.Checked == false)
                nv.GioiTinh = ("Nữ");
            nv.ChucVu = txtChucvu.Text;
            nv.NgayBD = dtNgayBD.Value;
            nv.Luong = double.Parse(txtLuong.Text);
            nv.SoDienThoai = txtSDT.Text;
            nv.DiaChi = txtDiachi.Text;
            if (xuly.tim(nv.MaNhanVien) == null)
            {
                xuly.them(nv);
                hienthi();
            }
            else
            {
                MessageBox.Show("Mã số nhân viên bị trùng! Vui lòng nhập lại ");
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            xuly.ghiFILE("dsNV.bin");
        }
    }
}
