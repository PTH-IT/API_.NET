using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class Mess
{
    public long Ma { get; set; }

    public string? NguoiGui { get; set; }

    public string? NguoiNhan { get; set; }

    public long? Malop { get; set; }

    public string? TinNhan { get; set; }

    public DateTime? Thoigiangui { get; set; }

    public virtual LopHoc? MalopNavigation { get; set; }

    public virtual TaiKhoan? NguoiGuiNavigation { get; set; }

    public virtual TaiKhoan? NguoiNhanNavigation { get; set; }
}
