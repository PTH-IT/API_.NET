using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class Loimoi
{
    public long Ma { get; set; }

    public long MaLop { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public virtual LopHoc MaLopNavigation { get; set; } = null!;

    public virtual TaiKhoan TenDangNhapNavigation { get; set; } = null!;
}
