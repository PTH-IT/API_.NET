using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class BaiTapTn
{
    public long MaBaiNop { get; set; }

    public long MaBaiTap { get; set; }

    public DateTime? NgayNop { get; set; }

    public bool? Trangthai { get; set; }

    public string? NguoiNop { get; set; }

    public int? Diem { get; set; }

    public virtual BaiTap MaBaiTapNavigation { get; set; } = null!;

    public virtual TaiKhoan? NguoiNopNavigation { get; set; }

    public virtual ICollection<TtbaiTapTn> TtbaiTapTns { get; } = new List<TtbaiTapTn>();
}
