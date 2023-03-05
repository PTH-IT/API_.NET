using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class TtbaiTapTn
{
    public long Ma { get; set; }

    public long? MaCauHoi { get; set; }

    public long? MaDapAnluaChon { get; set; }

    public long? MaBaiNop { get; set; }

    public string? NguoiNop { get; set; }

    public virtual BaiTapTn? MaBaiNopNavigation { get; set; }

    public virtual CauHoi? MaCauHoiNavigation { get; set; }

    public virtual DapAn? MaDapAnluaChonNavigation { get; set; }

    public virtual TaiKhoan? NguoiNopNavigation { get; set; }
}
