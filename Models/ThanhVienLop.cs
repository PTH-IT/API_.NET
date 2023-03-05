using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class ThanhVienLop
{
    public long MaLop { get; set; }

    public string Mathanhvien { get; set; } = null!;

    public DateTime? NgayThamGia { get; set; }

    public string? ChucVu { get; set; }

    public virtual LopHoc MaLopNavigation { get; set; } = null!;

    public virtual TaiKhoan MathanhvienNavigation { get; set; } = null!;
}
