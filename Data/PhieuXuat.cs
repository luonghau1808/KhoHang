using System;
using System.Collections.Generic;

namespace DuAn1_Nhom4.Data;

public partial class PhieuXuat
{
    public int MaPhieuXuat { get; set; }

    public int MaKh { get; set; }

    public int MaNv { get; set; }

    public DateOnly NgayXuat { get; set; }

    public bool TrangThaiThanhToan { get; set; }

    public string? MoTa { get; set; }

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;

    public virtual ICollection<PhieuXuatChiTiet> PhieuXuatChiTiets { get; set; } = new List<PhieuXuatChiTiet>();
}
