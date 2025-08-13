using System.Data;
using System.Globalization;
using System.Windows.Forms;
using DuAn1_Nhom4.BLL;
using DuAn1_Nhom4.GUI.Hóa_đơn;
using DuAn1_Nhom4.Models;

namespace DuAn1_Nhom4.GUI
{
    public partial class PhieuXuatF : Form
    {
        private GenericBLL<ChiTietSanPham> _ctSanphamBLL = new GenericBLL<ChiTietSanPham>();
        private GenericBLL<PhieuXuat> _phieuXuatBLL = new GenericBLL<PhieuXuat>();
        private GenericBLL<PhieuXuatChiTiet> _ctPhieuXuatBLL = new GenericBLL<PhieuXuatChiTiet>();
        NhanVien _nhanVien;
        //KhachHang _khachHang;
        public PhieuXuatF(NhanVien nhanVien)
        {
            InitializeComponent();
            _nhanVien = nhanVien;
        }

        private void LoadSanPham()
        {
            var list = _ctSanphamBLL.GetAll(x => x.MaSpNavigation, x => x.MaMauNavigation, x => x.MaKichThuocNavigation);
            dtgDanhSachSP.DataSource = list.Select((sp, index) => new
            {
                STT = index + 1,
                MaSP = sp.MaCtsp,
                TenSP = sp.MaSpNavigation.TenSp,
                MauSac = sp.MaMauNavigation?.TenMau,
                KichThuoc = sp.MaKichThuocNavigation?.TenKichThuoc,
                SoLuong = sp.SoLuong,
                DonGiaNhap = sp.DonGiaNhap,
                DonGiaXuat = sp.DonGiaXuat

            }).ToList();

            dtgDanhSachSP.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgDanhSachSP.Columns["MaSP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgDanhSachSP.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgDanhSachSP.Columns["DonGiaNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgDanhSachSP.Columns["DonGiaXuat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }


        private void LoadPhieuXuat()
        {
            var list = _phieuXuatBLL.GetAll(x => x.MaKhNavigation, x => x.MaNvNavigation).Where(x => x.TrangThaiThanhToan == "Chưa thanh toán");
            dtgDanhSachHD.DataSource = list.Select((px, index) => new
            {
                STT = index + 1,
                MaPX = px.MaPhieuXuat,
                TenKH = px.MaKhNavigation.Ten,
                TenNV = px.MaNvNavigation.HoTen,
                NgayXuat = px.NgayXuat,
                TrangThai = px.TrangThaiThanhToan,
            }).ToList();
            dtgDanhSachHD.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgDanhSachHD.Columns["MaPX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgDanhSachHD.Columns["NgayXuat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dtgDanhSachHD_CellClick(null, new DataGridViewCellEventArgs(0, 0)); // Gọi hàm để load giỏ hàng cho phiếu xuất đầu tiên nếu có

<<<<<<< HEAD
            //dtgDanhSachHD_CellClick(null, new DataGridViewCellEventArgs(0, 0)); // Gọi sự kiện CellClick để cập nhật giỏ hàng và thông tin khách hàng khi load form lần đầu
=======
>>>>>>> main
        }


        private void LoadCTPX(int maPX)
        {
            var list = _ctPhieuXuatBLL.GetAll(
                x => x.MaCtspNavigation.MaSpNavigation,
                x => x.MaCtspNavigation.MaMauNavigation,
                x => x.MaCtspNavigation.MaKichThuocNavigation,
                x => x.MaPhieuXuatNavigation)
                .Where(x => x.MaPhieuXuat == maPX)
                .ToList();

            dtgGioHang.DataSource = list.Select((ct, index) => new
            {
                STT = index + 1,
                MaCT = ct.MaCt,
                TenSP = ct.MaCtspNavigation?.MaSpNavigation?.TenSp ?? "",
                MauSac = ct.MaCtspNavigation?.MaMauNavigation?.TenMau ?? "",
                KichThuoc = ct.MaCtspNavigation?.MaKichThuocNavigation?.TenKichThuoc ?? "",
                SoLuong = ct.SoLuong,
                DonGia = ct.MaCtspNavigation?.DonGiaXuat ?? 0,
                ThanhTien = ct.SoLuong * (ct.MaCtspNavigation?.DonGiaXuat ?? 0)
            }).ToList();

            lbTongtienhd.Text = "Tổng tiền: " + TinhTongTien().ToString("N0") + "VNĐ"; // Cập nhật tổng tiền của hóa đơn

            dtgGioHang.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgGioHang.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgGioHang.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgGioHang.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgGioHang.Columns["MaCT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            if (dtgGioHang.Rows.Count <= 0)
            {
                btnXoa.Enabled = false; // Vô hiệu hóa nút Xóa nếu giỏ hàng không có sản phẩm
                btnSua.Enabled = false; // Vô hiệu hóa nút Sửa nếu giỏ hàng không có sản phẩm
            }
            else
            {
                btnXoa.Enabled = true; // Kích hoạt nút Xóa nếu giỏ hàng có sản phẩm
                btnSua.Enabled = true; // Kích hoạt nút Sửa nếu giỏ hàng có sản phẩm

            }
        }

        private decimal TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dtgGioHang.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }

            return tongTien;
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dtgDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return; // Không có hàng nào được chọn
            }

            int maPx = Convert.ToInt32(dtgDanhSachHD.Rows[e.RowIndex].Cells[1].Value);
            var px = _phieuXuatBLL.GetById(maPx);
            
            LoadCTPX(maPx);
            LoadKhachHang(_phieuXuatBLL.GetById(maPx).MaKhNavigation); // Cập nhật thông tin khách hàng
            lbNV.Text = "Nhân viên: " + px.MaNvNavigation.HoTen;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var px = dtgDanhSachHD.CurrentRow.Cells["MaPX"].Value;
            var ctpx = dtgGioHang.CurrentRow?.Cells["MaCT"].Value;
            if(dtgGioHang.Rows.Count < 2)
            {
                MessageBox.Show("Không thể xóa sản phẩm vì giỏ hàng chỉ còn một sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thể xóa nếu giỏ hàng chỉ còn một sản phẩm
            }
            if (ctpx == null)
            {
                MessageBox.Show("Vui lòng chọn sản phầm trong giỏ để xóa"); return;
            }
            var ct = _ctPhieuXuatBLL.GetById((int)ctpx);
            var sp = _ctSanphamBLL.GetById(ct.MaCtsp);
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {sp.MaSpNavigation.TenSp} không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (sp != null)
                {
                    sp.SoLuong += ct.SoLuong;
                    _ctSanphamBLL.Update(sp);
                    _ctPhieuXuatBLL.Delete(ct.MaCt);
                    LoadSanPham();
                    LoadCTPX((int)px);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm");
                }
            }
            else
            {
                return;
            }


        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadPhieuXuat();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var list = _ctSanphamBLL.GetAll(x => x.MaSpNavigation, x => x.MaMauNavigation, x => x.MaKichThuocNavigation)
                .Where(x => x.MaSpNavigation.TenSp.Contains(textBox1.Text, StringComparison.OrdinalIgnoreCase));
            dtgDanhSachSP.DataSource = list.Select((sp, index) => new
            {
                STT = index + 1,
                MaSP = sp.MaCtsp,
                TenSP = sp.MaSpNavigation.TenSp,
                MauSac = sp.MaMauNavigation?.TenMau,
                KichThuoc = sp.MaKichThuocNavigation?.TenKichThuoc,
                SoLuong = sp.SoLuong,
                DonGiaNhap = sp.DonGiaNhap,
                DonGiaXuat = sp.DonGiaXuat

            }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var sp = dtgDanhSachSP.CurrentRow.Cells["MaSP"].Value;
            var px = dtgDanhSachHD.CurrentRow.Cells["MaPX"].Value;
            var donGia = dtgDanhSachSP.CurrentRow.Cells["DonGiaXuat"].Value;
            var soLuong = 0;
            if (_ctPhieuXuatBLL.GetAll().FirstOrDefault(x => x.MaPhieuXuat == (int)px && x.MaCtsp == (int)sp) != null)
            {
                MessageBox.Show("Sản phẩm đã có trong giỏ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thêm sản phẩm nếu đã có trong giỏ hàng
            }
            SoLuong soLuongForm = new SoLuong();
            soLuongForm.ShowDialog();            
            soLuong = soLuongForm.SoLuongSanPham;
            if(soLuong == 0)
            {
                return;
            }
            

            var ctpx = new PhieuXuatChiTiet
            {
                MaCtsp = (int)sp,
                GiaBan = (decimal)donGia,
                SoLuong = soLuong,
                MaPhieuXuat = (int)px // Chưa có mã phiếu xuất, sẽ cập nhật sau khi tạo phiếu xuất
            };

            // Kiểm tra số lượng sản phẩm có đủ không
            var ctSanPham = _ctSanphamBLL.GetById(ctpx.MaCtsp);
            if (ctSanPham.SoLuong < soLuong)
            {
                MessageBox.Show("Số lượng sản phẩm không đủ để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thêm vào giỏ hàng nếu số lượng không đủ
            }
            else
            {
                ctSanPham.SoLuong -= soLuong; // Giảm số lượng sản phẩm trong kho
                _ctSanphamBLL.Update(ctSanPham); // Cập nhật số lượng sản phẩm trong kho
                _ctPhieuXuatBLL.Add(ctpx);
                LoadSanPham();
                LoadCTPX((int)px); // Cập nhật giỏ hàng

            }


        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            KhachHangF khachHangForm = new KhachHangF();
            khachHangForm.ShowDialog();
            // Kiểm tra xem khách hàng đã được chọn hay chưa
            var kh = khachHangForm.Kh;
            if (kh == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước khi tạo phiếu xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thể tạo phiếu xuất nếu chưa chọn khách hàng
            }
            var nhanVien = _nhanVien;
            if (nhanVien == null)
            {
                MessageBox.Show("Vui lòng đăng nhập trước khi tạo phiếu xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thể tạo phiếu xuất nếu chưa đăng nhập
            }
            if (kh == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước khi tạo phiếu xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thể tạo phiếu xuất nếu chưa chọn khách hàng
            }

            var phieuXuat = new PhieuXuat()
            {
                MaKh = kh.MaKh, // Lấy mã khách hàng nếu đã chọn
                MaNv = nhanVien.Id,
                NgayXuat = DateOnly.FromDateTime(DateTime.Now),
                TrangThaiThanhToan = "Chưa thanh toán",
            };
            _phieuXuatBLL.Add(phieuXuat); // Thêm phiếu xuất mới vào cơ sở dữ liệu
            LoadPhieuXuat(); // Cập nhật danh sách phiếu xuất
            dtgDanhSachHD.ClearSelection(); // Xóa lựa chọn hiện tại trong DataGridView

            dtgDanhSachHD.Rows[dtgDanhSachHD.Rows.Count - 1].Selected = true; // Chọn phiếu xuất mới nhất
            dtgDanhSachHD.CurrentCell = dtgDanhSachHD.Rows[dtgDanhSachHD.Rows.Count - 1].Cells[0]; // Đặt con trỏ vào ô đầu tiên của phiếu xuất mới
            dtgDanhSachHD.FirstDisplayedScrollingRowIndex = dtgDanhSachHD.Rows.Count - 1;

            LoadCTPX(phieuXuat.MaPhieuXuat); // Tải giỏ hàng cho phiếu xuất mới


        }



        private void LoadKhachHang(KhachHang khachHang)
        {
            txtTen.Text = khachHang.Ten;
            txtsdt.Text = khachHang.Sdt;
        }

        
        private void ResetForm_XuatHang()
        {
            // Xóa text các ô bên phải
            txtsdt.Clear();
       
            txtTen.Clear();
      
            txtTienkhach.Clear();
            txtsdt.Clear();
            txtTen.Clear();


            lbNV.Text = "Nhân viên: ";


            // Label tổng tiền
            lbTongtienhd.Text = "Tổng tiền: 0";

            // Xóa giỏ hàng (DataGridView giỏ hàng)
            dtgGioHang.DataSource = null;

            // Load lại danh sách sản phẩm
            LoadSanPham();

            // Load lại danh sách hóa đơn (nếu muốn)
            LoadPhieuXuat();
            

        }
        bool isTyping = false;

        private void txtTienkhach_TextChanged(object sender, EventArgs e)
        {
            

            var px = dtgDanhSachHD.CurrentRow?.Cells["MaPX"].Value;
            if (px == null)
            {

                txtTienkhach.Clear(); // Xóa ô tiền khách nếu không có phiếu xuất
                return;
            }


            if (isTyping) return;

            isTyping = true;

            TextBox txt = sender as TextBox;
            string text = txt.Text;

            // Xóa các ký tự không phải số
            string clean = new string(text.Where(char.IsDigit).ToArray());

            if (decimal.TryParse(clean, out decimal value))
            {
                // Gán lại định dạng C0 (1.000.000 ₫)
                txt.Text = string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:N0}", value);
                txt.SelectionStart = txt.Text.Length; // Đặt con trỏ ở cuối

                // Tính tiền thừa
                var tongTien = TinhTongTien(); // → bạn phải có hàm này
                var tienKhach = value;
                var tienThua = tienKhach - tongTien;

                if (tienThua >= 0)
                    lbTienthua.Text = "Tiền thừa: " + tienThua.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));

                else
                    lbTienthua.Text = "Chưa đủ tiền!";
            }
            else
            {
                lbTienthua.Text = "Tiền thừa: 0 đ";
            }

            isTyping = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            var pxXoa = dtgDanhSachHD.CurrentRow?.Cells["MaPX"].Value;
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return; // Không thực hiện xóa nếu người dùng chọn No
            }
            if (pxXoa == null) return;
            var px = _phieuXuatBLL.GetById((int)pxXoa);
            var list = _ctPhieuXuatBLL.GetAll().Where(x => x.MaPhieuXuat == (int)pxXoa).ToList();
            foreach (var item in list)
            {
                var ctsp = _ctSanphamBLL.GetById(item.MaCtsp);
                if (ctsp != null)
                {
                    ctsp.SoLuong += item.SoLuong; // Trả lại số lượng sản phẩm vào kho
                    _ctSanphamBLL.Update(ctsp); // Cập nhật số lượng sản phẩm trong kho
                    
                }
            }

            px.TrangThaiThanhToan = "Đã hủy"; // Cập nhật trạng thái phiếu xuất

            _phieuXuatBLL.Update(px); // Xóa phiếu xuất
            LoadPhieuXuat(); // Cập nhật danh sách phiếu xuất
            ResetForm_XuatHang(); // Đặt lại form xuất hàng về trạng thái ban đầu
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var ctpx = dtgGioHang.CurrentRow?.Cells["MaCT"].Value;
            if (ctpx == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ hàng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ct = _ctPhieuXuatBLL.GetById((int)ctpx);
            var sp = _ctSanphamBLL.GetById(ct.MaCtsp);
            if (sp == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SoLuong soLuongForm = new SoLuong();

            soLuongForm.ShowDialog();
            int soLuong = soLuongForm.SoLuongSanPham;
            if(soLuong == 0)
            {
                return; // Không thể sửa nếu không có số lượng
            }

            if (soLuong > sp.SoLuong + ct.SoLuong)
            {
                MessageBox.Show("Số lượng sản phẩm không đủ để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thể sửa nếu số lượng không đủ
            }
            // Cập nhật số lượng sản phẩm trong kho

            sp.SoLuong += ct.SoLuong - soLuong; // Trả lại số lượng cũ vào kho và trừ đi số lượng mới
            _ctSanphamBLL.Update(sp); // Cập nhật số lượng sản phẩm trong kho
            ct.SoLuong = soLuong; // Cập nhật số lượng trong chi tiết phiếu xuất
            _ctPhieuXuatBLL.Update(ct); // Cập nhật chi tiết phiếu xuất
            LoadSanPham(); // Cập nhật danh sách sản phẩm
            LoadCTPX((int)dtgDanhSachHD.CurrentRow.Cells["MaPX"].Value); // Cập nhật giỏ hàng
            MessageBox.Show("Cập nhật số lượng sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var px = dtgDanhSachHD.CurrentRow?.Cells["MaPX"].Value;
            if (px == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var tienKhach = 0m;
            try
            {
                tienKhach = decimal.Parse(txtTienkhach.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Xin vui lòng nhập số tiền hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var tongTien = TinhTongTien();
            if (tienKhach < tongTien)
            {
                MessageBox.Show("Số tiền khách đưa không đủ để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thể thanh toán nếu số tiền không đủ
            }
            // Cập nhật trạng thái thanh toán của phiếu xuất
            var phieuXuat = _phieuXuatBLL.GetById((int)px);
            var list = _ctPhieuXuatBLL.GetAll().Where(x => x.MaPhieuXuat == (int)px).ToList();
            if (list.Count() == 0)
            {
                MessageBox.Show("Giỏ hàng không có sản phẩm nào để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không thể thanh toán nếu giỏ hàng không có sản phẩm
            }
            if (phieuXuat == null)
            {
                MessageBox.Show("Phiếu xuất không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            phieuXuat.TrangThaiThanhToan = "Đã thanh toán";
            _phieuXuatBLL.Update(phieuXuat); // Cập nhật phiếu xuất
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm_XuatHang(); // Đặt lại form xuất hàng về trạng thái ban đầu sau khi thanh toán thành công
            LoadPhieuXuat(); // Cập nhật danh sách phiếu xuất

        }
    }
}
