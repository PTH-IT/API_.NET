using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class LopHoc
{
    public long MaLop { get; set; }

    public string? TenLop { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiTao { get; set; }

    public string ThongTinLopHoc { get; set; } = null!;

    public string? Hinhanh { get; set; }

    public virtual ICollection<BaiTap> BaiTaps { get; } = new List<BaiTap>();

    public virtual ICollection<Document> Documents { get; } = new List<Document>();

    public virtual ICollection<Loimoi> Loimois { get; } = new List<Loimoi>();

    public virtual ICollection<Mess> Messes { get; } = new List<Mess>();

    public virtual TaiKhoan? NguoiTaoNavigation { get; set; }

    public virtual ICollection<ThanhVienLop> ThanhVienLops { get; } = new List<ThanhVienLop>();

    public virtual ICollection<ThongBao> ThongBaos { get; } = new List<ThongBao>();
}
