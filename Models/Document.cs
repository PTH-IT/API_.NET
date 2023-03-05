using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class Document
{
    public long Ma { get; set; }

    public string? Ten { get; set; }

    public string? Vitriluu { get; set; }

    public string? Noidung { get; set; }

    public string? Nguoisohuu { get; set; }

    public string? Image { get; set; }

    public long? MaLop { get; set; }

    public int? LuotTaiXuong { get; set; }

    public DateTime? Ngaydang { get; set; }

    public int? Luotxem { get; set; }

    public long? Machude { get; set; }

    public virtual LopHoc? MaLopNavigation { get; set; }

    public virtual Chudetailieu? MachudeNavigation { get; set; }

    public virtual TaiKhoan? NguoisohuuNavigation { get; set; }
}
